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

        public Form1()
        {
            xmlDoc = XDocument.Load("Patient1.xml");
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
            //this list is populated with tags from xml file
            List<string> tagList = new List<string>();

            //DicomFileReader dfr;
            //DicomFileWriter dfw;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open XML File";
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();

                try
                {
                    xDoc.Load(ofd.FileName);
                }
                catch (XmlException g)
                {
                    MessageBox.Show("XML error");
                }
                /* The parameter in SelectNodes will change depending
                 on what the xml file's nodes are defined as */

                foreach (XmlNode node in xDoc.SelectNodes("/Root"))
                {
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        foreach (XmlNode node3 in node2.ChildNodes)
                        {
                            tagList.Add(node3.Name);
                        }
                    }
                }
                foreach (string item in tagList)
                {
                    MessageBox.Show(item);
                }
                //send this tagList to the crosswalk table


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
                        dataSet.Add<string>(tag, "PLACEHOLDER");
                                //string info = dataSet.Get<string>(tag, "not contained");
                                //tag.ToString().Replace(info, "placeholder");
                                //dfw.Write(target, fileMeta, dataSet);
                    }
                }
            }
            ofd.Dispose();
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
            NewParameter form = new NewParameter(this);
            form.Show();
        }

        private void Submit_Click_1(object sender, EventArgs e)
        {

        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            string y = this.existingParameters.SelectedItem.ToString();
            XNode x = xmlDoc.Root.Element(y);
            x.Remove();

            xmlDoc.Save("Patient1.xml");

            ePlistBox();
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {

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

    }
}
