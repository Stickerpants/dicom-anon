namespace WindowsFormsApplication1
{
    partial class NewParameter
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
            this.label1 = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parameterInput = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(36, 48);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(208, 20);
            this.TitleInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parameters";
            // 
            // parameterInput
            // 
            this.parameterInput.Location = new System.Drawing.Point(36, 117);
            this.parameterInput.Multiline = true;
            this.parameterInput.Name = "parameterInput";
            this.parameterInput.Size = new System.Drawing.Size(208, 88);
            this.parameterInput.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(36, 212);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(169, 211);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.parameterInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.label1);
            this.Name = "NewParameter";
            this.Text = "NewParameter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox parameterInput;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancel;
    }
}