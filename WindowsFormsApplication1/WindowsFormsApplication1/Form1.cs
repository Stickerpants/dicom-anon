using System;
using System.Collections.Generic;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Dicom;
using Dicom.IO;
using Dicom.IO.Reader;
using Dicom.IO.Writer;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private XDocument xmlDoc = null;
        StreamWriter sw = null;
        private List<string> tagList = new List<string>();

        public Form1()
        {
            try
            {
                xmlDoc = XDocument.Load("parameters.xml");
            }
            catch (FileNotFoundException g)
            {
                MessageBox.Show("File not found");
            }
            InitializeComponent();
            ePlistBox();
        }

        /*This button loops through the already created xml file filled with
        * the tags to be anonymized. The list is populated with these specific
        * tags to be anonymized, and we then search through the DICOM file
        * and "remove" any information that corresponds to the information in the
        * list. This "removed" patient information is passed to the crosswalk
        table for later reference */
        private void Anonymize_Click(object sender, EventArgs e)
        {

            /*when an element in the taglist matches a tag in the
            dicom file, replace the information with "placeholder"*/
            string filename = Filepath.Text;
            DicomFile file = DicomFile.Open(filename);
            DicomDataset dataSet = file.Dataset;
            DicomTag tag = null;
            var ravioli = new List<dictItem>();

            foreach (string input in tagList)
            {
                ravioli = Lookup(input);
                foreach (dictItem entry in ravioli)
                {
                    tag = entry.tag;
                }
                    //need to make case insensitive
                    
                    //DicomTag tag = DicomTag.Parse(input);

                if (dataSet.Contains(tag))
                {
                    addToCrosswalk(tag.Element);
                    dataSet.Add<string>(tag, "PLACEHOLDER");
                    //string info = dataSet.Get<string>(tag, "not contained");
                    //tag.ToString().Replace(info, "placeholder");
                    //dfw.Write(target, fileMeta, dataSet);
                }
            }
        }

        //Allows the user to open a Dicom File from their computer
        private void OpenSingleFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open DICOM File";
            ofd.Filter = "DICOM|*.dcm";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Filepath.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void existingParameters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Input_Click(object sender, EventArgs e)
        {

        }

        public XDocument xDoc
        {
            get { return this.xmlDoc; }
        }

        public void ePlistBox()
        {
            this.existingParameters.Items.Clear();

            IEnumerable<XElement> elementos = xmlDoc.Root.Elements();

            foreach (XElement xelem in elementos)
            {
                this.existingParameters.Items.Add(xelem.Name);
            }
        }

        public string RemoveWhiteSpace(string str)
        {
            return new string(str.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }

        private void New_Click_1(object sender, EventArgs e)
        {
            NewParameter form = new NewParameter(this, null, null);
            form.Show();
        }

        //sets title to the selected string from the existing parameters box
        private void Submit_Click_1(object sender, EventArgs e)
        {
            string title = this.existingParameters.SelectedItem.ToString();
            addToList(title);
            MessageBox.Show("The selected parameters have been added!");
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            string y = this.existingParameters.SelectedItem.ToString();
            XNode x = xmlDoc.Root.Element(y);
            x.Remove();

            xmlDoc.Save("parameters.xml");

            ePlistBox();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            string y = this.existingParameters.SelectedItem.ToString();
            XElement x = xmlDoc.Root.Element(y);
            IEnumerable<XElement> elementos = x.Descendants();

            x.Remove();

            NewParameter form = new NewParameter(this, elementos, y);
            form.Show();
        }

        public List<dictItem> Lookup(String term)
        {
            var results = new List<dictItem>();

            DicomDictionary dd = DicomDictionary.Default;
            IEnumerator<DicomDictionaryEntry> de = dd.GetEnumerator();

            term = term.ToLower().Replace(",", "").Replace("(", "").Replace(")", "").Replace(" ", "");
            term = term.Replace("'s", "");
            term = term.Replace("’s", "");
            term = term.Replace("patients", "patient");

            var tagFormatFull = new Regex("^[0-9a-f]{8}$");
            var tagFormatGroup = new Regex("^[0-9a-f]{4}$");

            var mode = Mode.desc;
            if (tagFormatFull.Match(term).Success) mode = Mode.tag;
            else if (tagFormatGroup.Match(term).Success) mode = Mode.group;
            else if (term == "everything") mode = Mode.all;

            while (de.MoveNext())
            {
                DicomDictionaryEntry ent = de.Current;

                string comp = "";

                switch (mode)
                {
                    case Mode.tag:
                        comp = ent.Tag.ToString("J", null);
                        break;

                    case Mode.group:
                        comp = ent.Tag.ToString("J", null).Substring(0, 4);
                        break;

                    case Mode.desc:
                        comp = ent.Name.ToLower();
                        comp = comp.Replace("'s", "");
                        comp = comp.Replace("’s", "");
                        comp = comp.Replace(" ", "");
                        break;
                }

                comp = comp.ToLower();

                if (comp.Contains(term) || mode == Mode.all)
                {
                    var vm1 = "1";

                    if (ent.ValueMultiplicity.Maximum == int.MaxValue)
                        vm1 = String.Format("{0} or more", ent.ValueMultiplicity.Minimum);
                    else if (ent.ValueMultiplicity.Maximum == 1)
                    {
                        vm1 = String.Format("{0}", ent.ValueMultiplicity.Maximum);
                    }
                    else if (ent.ValueMultiplicity.Maximum == ent.ValueMultiplicity.Minimum)
                    {
                        vm1 = String.Format("{0} exatly", ent.ValueMultiplicity.Minimum);
                    }
                    else if (ent.ValueMultiplicity.Maximum > 1)
                        vm1 = String.Format("{0}-{1}", ent.ValueMultiplicity.Minimum, ent.ValueMultiplicity.Maximum);

                    results.Add(new dictItem
                    {
                        //tag = ent.Tag.ToString().ToUpper(),
                        tag = ent.Tag,
                        description = ent.Name,
                        vm = vm1,
                        vr = ent.ValueRepresentations[0].ToString()
                    });
                }
            }

            return results;
        }

        private enum Mode
        {
            tag,
            desc,
            group,
            all
        };

        public void addToCrosswalk(List<string> tagList)
        {
            sw = new StreamWriter(File.OpenWrite("C:\\Users\\Tyler\\Documents\\Schoolwork\\Third Year\\COSC 310\\CrosswalkTable.txt"));
            foreach (string item in tagList)
            {
                sw.Write(item + "    |    ");
            }
            sw.Dispose();
        }

        public void addToCrosswalk(ushort el)
        {
            sw = new StreamWriter(File.OpenWrite("C:\\Users\\Tyler\\Documents\\Schoolwork\\Third Year\\COSC 310\\CrosswalkTable.txt"));
            sw.Write(el);
            sw.Dispose();
        }

        //Searches through the xml file for the specified title and adds all child nodes to the tagList
        public void addToList(string title)
        {
            XElement titleSearch = xmlDoc.Root.Element(title);
            IEnumerable<XElement> children = titleSearch.Descendants();
            foreach (XElement child in children)
            {
                tagList.Add(child.Name.ToString());
            }

            addToCrosswalk(tagList);
        }

        List<string> getList()
        {
            return tagList;
        }

    }
}
