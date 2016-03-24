using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dicom;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DicomSender send = new DicomSender();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.textBox3.Text = openFileDialog1.FileName;
                send.sendDicom(DicomFile.Open(@""+this.textBox3.Text));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listener list = new Listener();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DicomSender send = new DicomSender();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                this.textBox3.Text = openFileDialog1.FileName;
                send.sendDicom(DicomFile.Open(@"" + this.textBox3.Text));

            }
        }
    }
}
