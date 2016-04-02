namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Input = new System.Windows.Forms.TabPage();
            this.Edit = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.existingParameters = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Filepath = new System.Windows.Forms.TextBox();
            this.OpenSingleFile = new System.Windows.Forms.Button();
            this.Anonymize = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.informationBox = new System.Windows.Forms.TextBox();
            this.goRight = new System.Windows.Forms.Button();
            this.goLeft = new System.Windows.Forms.Button();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.directoryOpen = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.Input.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Input);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(948, 493);

            this.tabControl1.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.Controls.Add(this.Edit);
            this.Input.Controls.Add(this.Submit);
            this.Input.Controls.Add(this.Delete);
            this.Input.Controls.Add(this.New);
            this.Input.Controls.Add(this.existingParameters);
            this.Input.Controls.Add(this.label2);
            this.Input.Location = new System.Drawing.Point(4, 22);
            this.Input.Margin = new System.Windows.Forms.Padding(2);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(2);
            this.Input.Size = new System.Drawing.Size(701, 365);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(136, 223);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit...";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click_1);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(136, 193);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(47, 223);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete...";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(47, 193);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 2;
            this.New.Text = "New...";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click_1);
            // 
            // existingParameters
            // 
            this.existingParameters.FormattingEnabled = true;
            this.existingParameters.Location = new System.Drawing.Point(47, 52);
            this.existingParameters.Name = "existingParameters";
            this.existingParameters.Size = new System.Drawing.Size(165, 134);
            this.existingParameters.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Existing Parameters...";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Filepath);
            this.tabPage2.Controls.Add(this.OpenSingleFile);
            this.tabPage2.Controls.Add(this.Anonymize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(701, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anonymize";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Path:";
            // 
            // Filepath
            // 
            this.Filepath.Location = new System.Drawing.Point(81, 103);
            this.Filepath.Name = "Filepath";
            this.Filepath.Size = new System.Drawing.Size(150, 20);
            this.Filepath.TabIndex = 3;
            // 
            // OpenSingleFile
            // 
            this.OpenSingleFile.Location = new System.Drawing.Point(105, 46);
            this.OpenSingleFile.Name = "OpenSingleFile";
            this.OpenSingleFile.Size = new System.Drawing.Size(76, 35);
            this.OpenSingleFile.TabIndex = 1;
            this.OpenSingleFile.Text = "Open Single Dicom File";
            this.OpenSingleFile.UseVisualStyleBackColor = true;
            this.OpenSingleFile.Click += new System.EventHandler(this.OpenSingleFile_Click);
            // 
            // Anonymize
            // 
            this.Anonymize.Location = new System.Drawing.Point(312, 52);
            this.Anonymize.Name = "Anonymize";
            this.Anonymize.Size = new System.Drawing.Size(75, 23);
            this.Anonymize.TabIndex = 0;
            this.Anonymize.Text = "Anonymize";
            this.Anonymize.UseVisualStyleBackColor = true;
            this.Anonymize.Click += new System.EventHandler(this.Anonymize_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(701, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Listen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(701, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Send";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.currentFileLabel);
            this.tabPage5.Controls.Add(this.informationLabel);
            this.tabPage5.Controls.Add(this.informationBox);
            this.tabPage5.Controls.Add(this.goRight);
            this.tabPage5.Controls.Add(this.goLeft);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.directoryBox);
            this.tabPage5.Controls.Add(this.imageDisplay);
            this.tabPage5.Controls.Add(this.directoryOpen);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(940, 467);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "View";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(8, 12);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(90, 13);
            this.currentFileLabel.TabIndex = 8;
            this.currentFileLabel.Text = "No input directory";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(480, 12);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(59, 13);
            this.informationLabel.TabIndex = 7;
            this.informationLabel.Text = "Information";
            // 
            // informationBox
            // 
            this.informationBox.Location = new System.Drawing.Point(480, 31);
            this.informationBox.Multiline = true;
            this.informationBox.Name = "informationBox";
            this.informationBox.ReadOnly = true;
            this.informationBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.informationBox.Size = new System.Drawing.Size(448, 393);
            this.informationBox.TabIndex = 6;
            this.informationBox.WordWrap = false;
            // 
            // goRight
            // 
            this.goRight.Location = new System.Drawing.Point(226, 401);
            this.goRight.Name = "goRight";
            this.goRight.Size = new System.Drawing.Size(75, 23);
            this.goRight.TabIndex = 5;
            this.goRight.Text = "Right";
            this.goRight.UseVisualStyleBackColor = true;
            this.goRight.Click += new System.EventHandler(this.goRight_Click);
            // 
            // goLeft
            // 
            this.goLeft.Location = new System.Drawing.Point(145, 401);
            this.goLeft.Name = "goLeft";
            this.goLeft.Size = new System.Drawing.Size(75, 23);
            this.goLeft.TabIndex = 4;
            this.goLeft.Text = "Left";
            this.goLeft.UseVisualStyleBackColor = true;
            this.goLeft.Click += new System.EventHandler(this.goLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory";
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(63, 438);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(238, 20);
            this.directoryBox.TabIndex = 2;
            this.directoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.directoryBox_KeyPress);
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(8, 31);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(466, 364);
            this.imageDisplay.TabIndex = 1;
            this.imageDisplay.TabStop = false;
            // 
            // directoryOpen
            // 
            this.directoryOpen.Location = new System.Drawing.Point(307, 435);
            this.directoryOpen.Name = "directoryOpen";
            this.directoryOpen.Size = new System.Drawing.Size(75, 23);
            this.directoryOpen.TabIndex = 0;
            this.directoryOpen.Text = "Open";
            this.directoryOpen.UseVisualStyleBackColor = true;
            this.directoryOpen.Click += new System.EventHandler(this.directoryOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 512);

            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button directoryOpen;
        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button goRight;
        private System.Windows.Forms.Button goLeft;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.TextBox informationBox;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Button Anonymize;
        private System.Windows.Forms.TextBox Filepath;
        private System.Windows.Forms.Button OpenSingleFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.ListBox existingParameters;
        private System.Windows.Forms.Label label2;
    }
}

