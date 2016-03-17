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
using Dicom;
using Dicom.IO;
using Dicom.IO.Reader;
using Dicom.IO.Writer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open DICOM File";
            ofd.Filter = "DICOM|*.DICOM";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
            ofd.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
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

            DicomFileReader dfr;
            DicomFileWriter dfw;

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
                //send this tagList to the crosswalk table


                //read through the DICOM file
                DicomReaderResult result;
                string filename = textBox1.Text;


                //using the validsource_returnsuccess example
                using (var Stream = File.OpenRead(filename))
                {
                    DicomFile dicomfile = new DicomFile();
                    dfr = new DicomFileReader();
                    var source = new StreamByteSource(Stream);

                    var fileMeta = dicomfile.FileMetaInfo;
                    var dataSet = dicomfile.Dataset;

                    var dataSetReader1 = new DicomDatasetReaderObserver(fileMeta);
                    var dataSetReader2 = new DicomDatasetReaderObserver(dataSet);

                    result = dfr.Read(source, dataSetReader1, dataSetReader2);

                    if (result == DicomReaderResult.Success)
                    {
                        //var file = IOManager.CreateFileReference(filename);
                        //var target = new FileByteTarget(file);
                        //dfw = new DicomFileWriter(new DicomWriteOptions());


                        /*when an element in the taglist matches a tag in the
                        dicom file, replace the information with "placeholder".
                        QUESTIONS: is a dicomfilewriter necessary?*/


                        foreach (string element in tagList)
                        {
                            //gets rid of spaces in user input
                            //also need to make case insensitive
                            string spaceless = element.Replace(" ", string.Empty);
                            DicomTag tag = DicomTag.Parse(spaceless);

                            if (dataSet.Contains(tag))
                            {
                                string info = dataSet.Get<string>(tag, "not contained");
                                tag.ToString().Replace(info, "placeholder");
                                //dfw.Write(target, fileMeta, dataSet);
                            }
                        }
                    }
                }
            }
            ofd.Dispose();
        }
    }
}
