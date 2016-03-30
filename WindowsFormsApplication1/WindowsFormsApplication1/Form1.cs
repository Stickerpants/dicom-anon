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
//using Dicom;
//using Dicom.Imaging;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string[] fileEntries;
        int index;
        public Form1()
        {
            InitializeComponent();
            index = 0;
        }
        /**
       *Loads DICOM file into form to manipulate
       */
        private void button1_Click(object sender, EventArgs e)
        {
            //fileEntries = Directory.GetFiles(this.result.Text);
           // var image = new Image(@"" + fileEntries.GetValue(0).ToString());
          //  index = 0;
            button1.Text = "Upload Successful";
            Label namelabel = new Label();
            namelabel.Location = new Point(13, 13);
            namelabel.Text = "Upload Successful";
            this.Controls.Add(namelabel);
          //  this.pictureBox1.Image = image.RenderImage().AsBitmap();
          //  string result = "Upload Successful";
          //  Label.Text = result.ToString();
        }
        /**
        *method used to browse for DICOM files to load
        */
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Load";
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.SelectedPath;
                this.textBox1.Text = file;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            fileEntries = Directory.GetFiles(@"" + this.textBox1.Text);
           // var image = new DicomImage(@"" + fileEntries.GetValue(index).ToString());
           // this.pictureBox1.Image = image.RenderImage().AsBitmap();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            index--;
            fileEntries = Directory.GetFiles(@"" + this.textBox1.Text);
          //  var image = new DicomImage(@"" + fileEntries.GetValue(index).ToString());
           // this.pictureBox1.Image = image.RenderImage().AsBitmap();
        }
    }
}