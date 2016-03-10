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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.port_value = new System.Windows.Forms.TabPage();
            this.help_container = new System.Windows.Forms.GroupBox();
            this.help_text = new System.Windows.Forms.Label();
            this.local_container = new System.Windows.Forms.GroupBox();
            this.local_port_combobox = new System.Windows.Forms.ComboBox();
            this.local_ae_label = new System.Windows.Forms.Label();
            this.local_port_label = new System.Windows.Forms.Label();
            this.local_ip_text = new System.Windows.Forms.Label();
            this.local_ae_text = new System.Windows.Forms.Label();
            this.local_ae_textbox = new System.Windows.Forms.TextBox();
            this.local_ip_label = new System.Windows.Forms.Label();
            this.target_container = new System.Windows.Forms.GroupBox();
            this.target_port_label = new System.Windows.Forms.Label();
            this.target_ip_label = new System.Windows.Forms.Label();
            this.target_ae_text = new System.Windows.Forms.Label();
            this.target_ae_textbox = new System.Windows.Forms.TextBox();
            this.target_ae_label = new System.Windows.Forms.Label();
            this.target_ip_text = new System.Windows.Forms.Label();
            this.target_ip_textbox = new System.Windows.Forms.TextBox();
            this.help_text2 = new System.Windows.Forms.Label();
            this.local_port_textbox = new System.Windows.Forms.TextBox();
            this.target_port_combobox = new System.Windows.Forms.ComboBox();
            this.target_port_textbox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.port_value.SuspendLayout();
            this.help_container.SuspendLayout();
            this.local_container.SuspendLayout();
            this.target_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Input);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.port_value);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(709, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(4, 22);
            this.Input.Margin = new System.Windows.Forms.Padding(2);
            this.Input.Name = "Input";
            this.Input.Padding = new System.Windows.Forms.Padding(2);
            this.Input.Size = new System.Drawing.Size(701, 365);
            this.Input.TabIndex = 0;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(701, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anonymize";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // port_value
            // 
            this.port_value.BackColor = System.Drawing.Color.Transparent;
            this.port_value.Controls.Add(this.help_container);
            this.port_value.Controls.Add(this.local_container);
            this.port_value.Controls.Add(this.target_container);
            this.port_value.Location = new System.Drawing.Point(4, 22);
            this.port_value.Margin = new System.Windows.Forms.Padding(2);
            this.port_value.Name = "port_value";
            this.port_value.Padding = new System.Windows.Forms.Padding(2);
            this.port_value.Size = new System.Drawing.Size(701, 365);
            this.port_value.TabIndex = 4;
            this.port_value.Text = "View";
            // 
            // help_container
            // 
            this.help_container.Controls.Add(this.help_text2);
            this.help_container.Controls.Add(this.help_text);
            this.help_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.help_container.Location = new System.Drawing.Point(3, 310);
            this.help_container.Name = "help_container";
            this.help_container.Size = new System.Drawing.Size(693, 55);
            this.help_container.TabIndex = 11;
            this.help_container.TabStop = false;
            this.help_container.Text = "Help";
            // 
            // help_text
            // 
            this.help_text.AutoSize = true;
            this.help_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.help_text.Location = new System.Drawing.Point(6, 17);
            this.help_text.Name = "help_text";
            this.help_text.Size = new System.Drawing.Size(339, 13);
            this.help_text.TabIndex = 11;
            this.help_text.Text = "Double click the field values to change them, and hit \'Enter\' to confirm.";
            // 
            // local_container
            // 
            this.local_container.Controls.Add(this.local_port_combobox);
            this.local_container.Controls.Add(this.local_ae_label);
            this.local_container.Controls.Add(this.local_port_label);
            this.local_container.Controls.Add(this.local_ip_text);
            this.local_container.Controls.Add(this.local_ae_text);
            this.local_container.Controls.Add(this.local_ae_textbox);
            this.local_container.Controls.Add(this.local_ip_label);
            this.local_container.Controls.Add(this.local_port_textbox);
            this.local_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.local_container.Location = new System.Drawing.Point(5, 5);
            this.local_container.Name = "local_container";
            this.local_container.Size = new System.Drawing.Size(352, 299);
            this.local_container.TabIndex = 1;
            this.local_container.TabStop = false;
            this.local_container.Text = "Local";
            // 
            // local_port_combobox
            // 
            this.local_port_combobox.FormattingEnabled = true;
            this.local_port_combobox.Items.AddRange(new object[] {
            "104",
            "11112",
            "4242",
            "[Custom]"});
            this.local_port_combobox.Location = new System.Drawing.Point(184, 151);
            this.local_port_combobox.Name = "local_port_combobox";
            this.local_port_combobox.Size = new System.Drawing.Size(121, 21);
            this.local_port_combobox.TabIndex = 8;
            this.local_port_combobox.Text = "104";
            this.local_port_combobox.TextChanged += new System.EventHandler(this.local_port_combobox_TextChanged);
            // 
            // local_ae_label
            // 
            this.local_ae_label.AutoSize = true;
            this.local_ae_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.local_ae_label.Location = new System.Drawing.Point(11, 45);
            this.local_ae_label.Name = "local_ae_label";
            this.local_ae_label.Size = new System.Drawing.Size(142, 18);
            this.local_ae_label.TabIndex = 0;
            this.local_ae_label.Text = "Application Entity:";
            // 
            // local_port_label
            // 
            this.local_port_label.AutoSize = true;
            this.local_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.local_port_label.Location = new System.Drawing.Point(31, 151);
            this.local_port_label.Name = "local_port_label";
            this.local_port_label.Size = new System.Drawing.Size(122, 18);
            this.local_port_label.TabIndex = 3;
            this.local_port_label.Text = "Listening Port: ";
            // 
            // local_ip_text
            // 
            this.local_ip_text.AutoSize = true;
            this.local_ip_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.local_ip_text.Location = new System.Drawing.Point(182, 100);
            this.local_ip_text.Name = "local_ip_text";
            this.local_ip_text.Size = new System.Drawing.Size(30, 18);
            this.local_ip_text.TabIndex = 6;
            this.local_ip_text.Text = "null";
            // 
            // local_ae_text
            // 
            this.local_ae_text.AutoSize = true;
            this.local_ae_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.local_ae_text.Location = new System.Drawing.Point(182, 45);
            this.local_ae_text.Name = "local_ae_text";
            this.local_ae_text.Size = new System.Drawing.Size(114, 18);
            this.local_ae_text.TabIndex = 9;
            this.local_ae_text.Text = "local_ae_default";
            this.local_ae_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.local_ae_text_MouseDoubleClick);
            // 
            // local_ae_textbox
            // 
            this.local_ae_textbox.Location = new System.Drawing.Point(184, 44);
            this.local_ae_textbox.MaxLength = 16;
            this.local_ae_textbox.Name = "local_ae_textbox";
            this.local_ae_textbox.Size = new System.Drawing.Size(121, 20);
            this.local_ae_textbox.TabIndex = 4;
            this.local_ae_textbox.Visible = false;
            this.local_ae_textbox.TextChanged += new System.EventHandler(this.local_ae_textbox_TextChanged);
            this.local_ae_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.local_ae_textbox_KeyPress);
            this.local_ae_textbox.Leave += new System.EventHandler(this.local_ae_textbox_Leave);
            // 
            // local_ip_label
            // 
            this.local_ip_label.AutoSize = true;
            this.local_ip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.local_ip_label.Location = new System.Drawing.Point(54, 98);
            this.local_ip_label.Name = "local_ip_label";
            this.local_ip_label.Size = new System.Drawing.Size(99, 18);
            this.local_ip_label.TabIndex = 2;
            this.local_ip_label.Text = "IP Address: ";
            // 
            // target_container
            // 
            this.target_container.Controls.Add(this.target_port_combobox);
            this.target_container.Controls.Add(this.target_ip_text);
            this.target_container.Controls.Add(this.target_port_label);
            this.target_container.Controls.Add(this.target_ip_label);
            this.target_container.Controls.Add(this.target_ae_text);
            this.target_container.Controls.Add(this.target_ae_textbox);
            this.target_container.Controls.Add(this.target_ae_label);
            this.target_container.Controls.Add(this.target_ip_textbox);
            this.target_container.Controls.Add(this.target_port_textbox);
            this.target_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.target_container.Location = new System.Drawing.Point(363, 5);
            this.target_container.Name = "target_container";
            this.target_container.Size = new System.Drawing.Size(333, 299);
            this.target_container.TabIndex = 11;
            this.target_container.TabStop = false;
            this.target_container.Text = "Target";
            // 
            // target_port_label
            // 
            this.target_port_label.AutoSize = true;
            this.target_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_port_label.Location = new System.Drawing.Point(114, 151);
            this.target_port_label.Name = "target_port_label";
            this.target_port_label.Size = new System.Drawing.Size(45, 18);
            this.target_port_label.TabIndex = 11;
            this.target_port_label.Text = "Port:";
            // 
            // target_ip_label
            // 
            this.target_ip_label.AutoSize = true;
            this.target_ip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.target_ip_label.Location = new System.Drawing.Point(65, 100);
            this.target_ip_label.Name = "target_ip_label";
            this.target_ip_label.Size = new System.Drawing.Size(94, 18);
            this.target_ip_label.TabIndex = 10;
            this.target_ip_label.Text = "IP Address:";
            // 
            // target_ae_text
            // 
            this.target_ae_text.AutoSize = true;
            this.target_ae_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.target_ae_text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.target_ae_text.Location = new System.Drawing.Point(179, 47);
            this.target_ae_text.Name = "target_ae_text";
            this.target_ae_text.Size = new System.Drawing.Size(120, 18);
            this.target_ae_text.TabIndex = 10;
            this.target_ae_text.Text = "target_ae_default";
            this.target_ae_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.target_ae_text_MouseDoubleClick);
            // 
            // target_ae_textbox
            // 
            this.target_ae_textbox.Location = new System.Drawing.Point(182, 46);
            this.target_ae_textbox.Name = "target_ae_textbox";
            this.target_ae_textbox.Size = new System.Drawing.Size(121, 20);
            this.target_ae_textbox.TabIndex = 5;
            this.target_ae_textbox.Visible = false;
            this.target_ae_textbox.TextChanged += new System.EventHandler(this.target_ae_textbox_TextChanged);
            this.target_ae_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_ae_textbox_KeyPress);
            this.target_ae_textbox.Leave += new System.EventHandler(this.target_ae_textbox_Leave);
            // 
            // target_ae_label
            // 
            this.target_ae_label.AutoSize = true;
            this.target_ae_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.target_ae_label.Location = new System.Drawing.Point(17, 47);
            this.target_ae_label.Name = "target_ae_label";
            this.target_ae_label.Size = new System.Drawing.Size(142, 18);
            this.target_ae_label.TabIndex = 1;
            this.target_ae_label.Text = "Application Entity:";
            // 
            // target_ip_text
            // 
            this.target_ip_text.AutoSize = true;
            this.target_ip_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.target_ip_text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.target_ip_text.Location = new System.Drawing.Point(179, 100);
            this.target_ip_text.Name = "target_ip_text";
            this.target_ip_text.Size = new System.Drawing.Size(30, 18);
            this.target_ip_text.TabIndex = 12;
            this.target_ip_text.Text = "null";
            this.target_ip_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.target_ip_text_MouseDoubleClick);
            // 
            // target_ip_textbox
            // 
            this.target_ip_textbox.Location = new System.Drawing.Point(182, 100);
            this.target_ip_textbox.MaxLength = 15;
            this.target_ip_textbox.Name = "target_ip_textbox";
            this.target_ip_textbox.Size = new System.Drawing.Size(121, 20);
            this.target_ip_textbox.TabIndex = 13;
            this.target_ip_textbox.Visible = false;
            this.target_ip_textbox.TextChanged += new System.EventHandler(this.target_ip_textbox_TextChanged);
            this.target_ip_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_ip_textbox_KeyPress);
            this.target_ip_textbox.Leave += new System.EventHandler(this.target_ip_textbox_Leave);
            // 
            // help_text2
            // 
            this.help_text2.AutoSize = true;
            this.help_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.help_text2.Location = new System.Drawing.Point(6, 30);
            this.help_text2.Name = "help_text2";
            this.help_text2.Size = new System.Drawing.Size(272, 13);
            this.help_text2.TabIndex = 12;
            this.help_text2.Text = "Recommended DICOM ports are 104, 11112, and 4242.";
            // 
            // local_port_textbox
            // 
            this.local_port_textbox.Location = new System.Drawing.Point(184, 153);
            this.local_port_textbox.Name = "local_port_textbox";
            this.local_port_textbox.Size = new System.Drawing.Size(120, 20);
            this.local_port_textbox.TabIndex = 10;
            this.local_port_textbox.Visible = false;
            this.local_port_textbox.TextChanged += new System.EventHandler(this.local_port_textbox_TextChanged);
            this.local_port_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.local_port_textbox_KeyPress);
            this.local_port_textbox.Leave += new System.EventHandler(this.local_port_textbox_Leave);
            // 
            // target_port_combobox
            // 
            this.target_port_combobox.FormattingEnabled = true;
            this.target_port_combobox.Items.AddRange(new object[] {
            "104",
            "11112",
            "4242",
            "[Custom]"});
            this.target_port_combobox.Location = new System.Drawing.Point(182, 151);
            this.target_port_combobox.Name = "target_port_combobox";
            this.target_port_combobox.Size = new System.Drawing.Size(121, 21);
            this.target_port_combobox.TabIndex = 14;
            this.target_port_combobox.Text = "104";
            this.target_port_combobox.TextChanged += new System.EventHandler(this.target_port_combobox_TextChanged);
            // 
            // target_port_textbox
            // 
            this.target_port_textbox.Location = new System.Drawing.Point(182, 151);
            this.target_port_textbox.Name = "target_port_textbox";
            this.target_port_textbox.Size = new System.Drawing.Size(121, 20);
            this.target_port_textbox.TabIndex = 15;
            this.target_port_textbox.TextChanged += new System.EventHandler(this.target_port_textbox_TextChanged);
            this.target_port_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_port_textbox_KeyPress);
            this.target_port_textbox.Leave += new System.EventHandler(this.target_port_textbox_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 407);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.port_value.ResumeLayout(false);
            this.help_container.ResumeLayout(false);
            this.help_container.PerformLayout();
            this.local_container.ResumeLayout(false);
            this.local_container.PerformLayout();
            this.target_container.ResumeLayout(false);
            this.target_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Input;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage port_value;
        private System.Windows.Forms.Label local_ae_label;
        private System.Windows.Forms.Label local_port_label;
        private System.Windows.Forms.Label local_ip_label;
        private System.Windows.Forms.Label target_ae_label;
        private System.Windows.Forms.TextBox target_ae_textbox;
        private System.Windows.Forms.TextBox local_ae_textbox;
        private System.Windows.Forms.Label local_ip_text;
        private System.Windows.Forms.ComboBox local_port_combobox;
        private System.Windows.Forms.Label local_ae_text;
        private System.Windows.Forms.Label target_ae_text;
        private System.Windows.Forms.GroupBox local_container;
        private System.Windows.Forms.GroupBox target_container;
        private System.Windows.Forms.Label target_ip_label;
        private System.Windows.Forms.GroupBox help_container;
        private System.Windows.Forms.Label help_text;
        private System.Windows.Forms.Label target_port_label;
        private System.Windows.Forms.Label target_ip_text;
        private System.Windows.Forms.TextBox target_ip_textbox;
        private System.Windows.Forms.Label help_text2;
        private System.Windows.Forms.TextBox local_port_textbox;
        private System.Windows.Forms.TextBox target_port_textbox;
        private System.Windows.Forms.ComboBox target_port_combobox;
    }
}

