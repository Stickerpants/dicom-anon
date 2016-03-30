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
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.button1 = new System.Windows.Forms.Button();
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                this.button2 = new System.Windows.Forms.Button();
                this.button3 = new System.Windows.Forms.Button();
                this.button4 = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                this.SuspendLayout();
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(200, 599);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(612, 26);
                this.textBox1.TabIndex = 0;
                // 
                // button1
                // 
                this.button1.Location = new System.Drawing.Point(912, 594);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(175, 37);
                this.button1.TabIndex = 1;
                this.button1.Text = "Load";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                //this.button1.Label namelabel = new Label();
                //namelabel.Location = new Point(13, 13);
               // this.button1.Click += new System.Windows.Forms.TextBox(); ;
                //this.Controls.Add(namelabel);
                // 
                // pictureBox1
                // 
                this.pictureBox1.Location = new System.Drawing.Point(12, 12);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(1002, 576);
                this.pictureBox1.TabIndex = 2;
                this.pictureBox1.TabStop = false;
                // 
                // button2
                // 
                this.button2.Location = new System.Drawing.Point(818, 594);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(88, 37);
                this.button2.TabIndex = 3;
                this.button2.Text = "Browse";
                this.button2.UseVisualStyleBackColor = true;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // button3
                // 
                this.button3.Location = new System.Drawing.Point(106, 594);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(88, 37);
                this.button3.TabIndex = 4;
                this.button3.Text = "Next";
                this.button3.UseVisualStyleBackColor = true;
                this.button3.Click += new System.EventHandler(this.button3_Click);
                // 
                // button4
                // 
                this.button4.Location = new System.Drawing.Point(12, 594);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(88, 37);
                this.button4.TabIndex = 5;
                this.button4.Text = "Previous";
                this.button4.UseVisualStyleBackColor = true;
                this.button4.Click += new System.EventHandler(this.button4_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1026, 643);
                this.Controls.Add(this.button4);
                this.Controls.Add(this.button3);
                this.Controls.Add(this.button2);
                this.Controls.Add(this.pictureBox1);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.textBox1);
                this.Name = "Form1";
                this.Text = "Form1";
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
            #endregion
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.PictureBox pictureBox1;
            private System.Windows.Forms.Button button2;
            private System.Windows.Forms.Button button3;
            private System.Windows.Forms.Button button4;
        }
}