﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class NewParameter : Form
    {

        private Form1 mainForm = null;

        public NewParameter(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }

        private void NewParameter_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string title = TitleInput.Text;
            title = mainForm.RemoveWhiteSpace(title);

            if (title.Equals("")) { title = "noNameGiven"; }

            TextReader parameterReader = new System.IO.StringReader(parameterInput.Text);
            int lns = parameterInput.Lines.Length;

            string[] parameters = new string[lns];

            for (int k = 0; k < lns; k++)
            {
                parameters[k] = parameterReader.ReadLine();
            }

            XDocument xmlDoc = mainForm.xDoc;

            xmlDoc.Root.Add(new XElement(title));
            XElement element = xmlDoc.Root.Element(title);

            for (int i = 0; i < lns; i++)
            {
                if (!parameters[i].Equals(""))
                {
                    element.Add(new XElement(mainForm.RemoveWhiteSpace(parameters[i])));
                }
            }

            xmlDoc.Save("parameters.xml");

            mainForm.ePlistBox();

            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void parameterInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
