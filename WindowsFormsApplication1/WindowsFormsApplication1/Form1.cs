using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*This button loops through the already created xml file filled with
        * the tags to be anonymized. The list is populated with these specific
        * tags to be anonymized, and we then search through the DICOM file
        * and "remove" any information that corresponds to the information in the
        * list. This "removed" patient information is passed to the crosswalk
        table for later reference */
        private void button1_Click(object sender, EventArgs e)
        {
            //this array is populated by going through
            List<string> tagList = new List<string>();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open XML File";
            ofd.Filter = "XML|*.xml";
            try { 
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    XmlDocument xDoc = new XmlDocument();
                    //Alternatively: xDoc.Load(textBox1.Text) when opening a single dicom file
                    xDoc.Load("\\WindowsFormApplication\\FileName");
                    /* The parameter in SelectNodes will change depending
                     on what the xml file's nodes are defined as */
                    while (xDoc.HasChildNodes)
                    {
                        foreach (XmlNode node in xDoc.SelectNodes("Root/File (Scenario) Type"))
                        {
                            tagList.Add(node.ChildNodes.ToString());
                        }
                        //send this tagList to the crosswalk table
                    }
                    for (int i = 0; i < tagList.Count-1; i++)
                    {
                        /*iterate through the DICOM file and when an element in
                        * the tagList matches the element in the DICOM file, 
                        "remove it". Send these values to the crosswalk table */
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
                MessageBox.Show(ex.GetType().Name);
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Text File";
            ofd.Filter = "Text|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }
    }
}
