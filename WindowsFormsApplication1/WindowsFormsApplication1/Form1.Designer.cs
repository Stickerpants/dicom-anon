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
            this.port_value = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Submit = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.existingParameters = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.target_container = new System.Windows.Forms.GroupBox();
            this.target_port_textbox = new System.Windows.Forms.TextBox();
            this.target_ip_textbox = new System.Windows.Forms.TextBox();
            this.target_ae_label = new System.Windows.Forms.Label();
            this.target_ae_textbox = new System.Windows.Forms.TextBox();
            this.target_ae_text = new System.Windows.Forms.Label();
            this.target_ip_label = new System.Windows.Forms.Label();
            this.target_port_label = new System.Windows.Forms.Label();
            this.target_ip_text = new System.Windows.Forms.Label();
            this.target_port_combobox = new System.Windows.Forms.ComboBox();
            this.local_container = new System.Windows.Forms.GroupBox();
            this.local_port_textbox = new System.Windows.Forms.TextBox();
            this.local_ip_label = new System.Windows.Forms.Label();
            this.local_ae_textbox = new System.Windows.Forms.TextBox();
            this.local_ae_text = new System.Windows.Forms.Label();
            this.local_ip_text = new System.Windows.Forms.Label();
            this.local_port_label = new System.Windows.Forms.Label();
            this.local_ae_label = new System.Windows.Forms.Label();
            this.local_port_combobox = new System.Windows.Forms.ComboBox();
            this.help_container = new System.Windows.Forms.GroupBox();
            this.help_text = new System.Windows.Forms.Label();
            this.help_text2 = new System.Windows.Forms.Label();
            this.Listen = new System.Windows.Forms.Button();
            this.sendFile = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();

            this.directoryOpen = new System.Windows.Forms.Button();
            this.imageDisplay = new System.Windows.Forms.PictureBox();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goLeft = new System.Windows.Forms.Button();
            this.goRight = new System.Windows.Forms.Button();
            this.informationBox = new System.Windows.Forms.TextBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.currentFileLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Anonymize = new System.Windows.Forms.Button();
            this.OpenSingleFile = new System.Windows.Forms.Button();
            this.Filepath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.port_value.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.target_container.SuspendLayout();
            this.local_container.SuspendLayout();
            this.help_container.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 

            // 
            this.port_value.BackColor = System.Drawing.Color.Transparent;
            this.port_value.Controls.Add(this.sendButton);
            this.port_value.Controls.Add(this.sendFile);
            this.port_value.Controls.Add(this.Listen);
            this.port_value.Controls.Add(this.help_container);
            this.port_value.Controls.Add(this.local_container);
            this.port_value.Controls.Add(this.target_container);
            this.port_value.Controls.Add(this.groupBox1);
            this.port_value.Location = new System.Drawing.Point(4, 29);
            this.port_value.Name = "port_value";
            this.port_value.Padding = new System.Windows.Forms.Padding(3);
            this.port_value.Size = new System.Drawing.Size(1418, 731);
            this.port_value.TabIndex = 4;
            this.port_value.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Edit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.existingParameters);
            this.groupBox1.Controls.Add(this.New);
            this.groupBox1.Controls.Add(this.Submit);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 551);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(239, 373);
            this.Submit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(136, 45);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(77, 373);
            this.New.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(136, 45);
            this.New.TabIndex = 11;
            this.New.Text = "New";

            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // existingParameters
            // 
            this.existingParameters.FormattingEnabled = true;
            this.existingParameters.ItemHeight = 20;
            this.existingParameters.Location = new System.Drawing.Point(77, 99);
            this.existingParameters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.existingParameters.Name = "existingParameters";
            this.existingParameters.Size = new System.Drawing.Size(298, 264);
            this.existingParameters.TabIndex = 13;
            this.existingParameters.SelectedIndexChanged += new System.EventHandler(this.existingParameters_SelectedIndexChanged_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Existing Parameters";
            // 
            // Edit
            //
            this.Edit.Location = new System.Drawing.Point(239, 447);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(136, 44);
            this.Edit.TabIndex = 16;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(77, 447);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(136, 44);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
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
            this.target_container.Location = new System.Drawing.Point(947, 7);
            this.target_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.target_container.Name = "target_container";
            this.target_container.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.target_container.Size = new System.Drawing.Size(460, 460);
            this.target_container.TabIndex = 11;
            this.target_container.TabStop = false;
            this.target_container.Text = "Target";
            // 
            // target_port_textbox
            //
            this.target_port_textbox.Location = new System.Drawing.Point(273, 232);
            this.target_port_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.target_port_textbox.Name = "target_port_textbox";
            this.target_port_textbox.Size = new System.Drawing.Size(180, 26);
            this.target_port_textbox.TabIndex = 15;
            this.target_port_textbox.TextChanged += new System.EventHandler(this.target_port_textbox_TextChanged);
            this.target_port_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_port_textbox_KeyPress);
            this.target_port_textbox.Leave += new System.EventHandler(this.target_port_textbox_Leave);
            // 
            // target_ip_textbox
            //
            this.target_ip_textbox.Location = new System.Drawing.Point(273, 154);
            this.target_ip_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.target_ip_textbox.MaxLength = 15;
            this.target_ip_textbox.Name = "target_ip_textbox";
            this.target_ip_textbox.Size = new System.Drawing.Size(180, 26);
            this.target_ip_textbox.TabIndex = 13;
            this.target_ip_textbox.Visible = false;
            this.target_ip_textbox.TextChanged += new System.EventHandler(this.target_ip_textbox_TextChanged);
            this.target_ip_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_ip_textbox_KeyPress);
            this.target_ip_textbox.Leave += new System.EventHandler(this.target_ip_textbox_Leave);
            // 
            // target_ae_label
            // 
            this.target_ae_label.AutoSize = true;
            this.target_ae_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.target_ae_label.Location = new System.Drawing.Point(26, 72);
            this.target_ae_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.target_ae_label.Name = "target_ae_label";
            this.target_ae_label.Size = new System.Drawing.Size(205, 26);
            this.target_ae_label.TabIndex = 1;
            this.target_ae_label.Text = "Application Entity:";
            // 
            // target_ae_textbox
            // 
            this.target_ae_textbox.Location = new System.Drawing.Point(273, 71);
            this.target_ae_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.target_ae_textbox.Name = "target_ae_textbox";
            this.target_ae_textbox.Size = new System.Drawing.Size(180, 26);
            this.target_ae_textbox.TabIndex = 5;
            this.target_ae_textbox.Visible = false;
            this.target_ae_textbox.TextChanged += new System.EventHandler(this.target_ae_textbox_TextChanged);
            this.target_ae_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.target_ae_textbox_KeyPress);
            this.target_ae_textbox.Leave += new System.EventHandler(this.target_ae_textbox_Leave);
            // 
            // target_ae_text
            // 
            this.target_ae_text.AutoSize = true;
            this.target_ae_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.target_ae_text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.target_ae_text.Location = new System.Drawing.Point(268, 72);
            this.target_ae_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.target_ae_text.Name = "target_ae_text";
            this.target_ae_text.Size = new System.Drawing.Size(180, 26);
            this.target_ae_text.TabIndex = 10;
            this.target_ae_text.Text = "target_ae_default";
            this.target_ae_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.target_ae_text_MouseDoubleClick);
            // 
            // target_ip_label
            // 
            this.target_ip_label.AutoSize = true;
            this.target_ip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.target_ip_label.Location = new System.Drawing.Point(98, 154);
            this.target_ip_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.target_ip_label.Name = "target_ip_label";
            this.target_ip_label.Size = new System.Drawing.Size(136, 26);
            this.target_ip_label.TabIndex = 10;
            this.target_ip_label.Text = "IP Address:";
            // 
            // target_port_label
            // 
            this.target_port_label.AutoSize = true;
            this.target_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_port_label.Location = new System.Drawing.Point(171, 232);
            this.target_port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.target_port_label.Name = "target_port_label";
            this.target_port_label.Size = new System.Drawing.Size(68, 29);
            this.target_port_label.TabIndex = 11;
            this.target_port_label.Text = "Port:";
            // 
            // target_ip_text
            // 
            this.target_ip_text.AutoSize = true;
            this.target_ip_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.target_ip_text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.target_ip_text.Location = new System.Drawing.Point(268, 154);
            this.target_ip_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.target_ip_text.Name = "target_ip_text";
            this.target_ip_text.Size = new System.Drawing.Size(46, 26);
            this.target_ip_text.TabIndex = 12;
            this.target_ip_text.Text = "null";
            this.target_ip_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.target_ip_text_MouseDoubleClick);
            // 
            // target_port_combobox
            // 
            this.target_port_combobox.FormattingEnabled = true;
            this.target_port_combobox.Items.AddRange(new object[] {
            "104",
            "11112",
            "4242",
            "[Custom]"});
            this.target_port_combobox.Location = new System.Drawing.Point(273, 232);
            this.target_port_combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.target_port_combobox.Name = "target_port_combobox";
            this.target_port_combobox.Size = new System.Drawing.Size(180, 28);
            this.target_port_combobox.TabIndex = 14;
            this.target_port_combobox.Text = "104";
            this.target_port_combobox.TextChanged += new System.EventHandler(this.target_port_combobox_TextChanged);
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
            this.local_container.Location = new System.Drawing.Point(457, 8);
            this.local_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.local_container.Name = "local_container";
            this.local_container.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.local_container.Size = new System.Drawing.Size(482, 460);
            this.local_container.TabIndex = 1;
            this.local_container.TabStop = false;
            this.local_container.Text = "Local";
            // 
            // local_port_textbox
            //
            this.local_port_textbox.Location = new System.Drawing.Point(276, 235);
            this.local_port_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.local_port_textbox.Name = "local_port_textbox";
            this.local_port_textbox.Size = new System.Drawing.Size(178, 26);
            this.local_port_textbox.TabIndex = 10;
            this.local_port_textbox.Visible = false;
            this.local_port_textbox.TextChanged += new System.EventHandler(this.local_port_textbox_TextChanged);
            this.local_port_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.local_port_textbox_KeyPress);
            this.local_port_textbox.Leave += new System.EventHandler(this.local_port_textbox_Leave);
            // 
            // local_ip_label
            // 
            this.local_ip_label.AutoSize = true;
            this.local_ip_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.local_ip_label.Location = new System.Drawing.Point(81, 151);
            this.local_ip_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.local_ip_label.Name = "local_ip_label";
            this.local_ip_label.Size = new System.Drawing.Size(143, 26);
            this.local_ip_label.TabIndex = 2;
            this.local_ip_label.Text = "IP Address: ";
            // 
            // local_ae_textbox
            // 
            this.local_ae_textbox.Location = new System.Drawing.Point(276, 68);
            this.local_ae_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.local_ae_textbox.MaxLength = 16;
            this.local_ae_textbox.Name = "local_ae_textbox";
            this.local_ae_textbox.Size = new System.Drawing.Size(180, 26);
            this.local_ae_textbox.TabIndex = 4;
            this.local_ae_textbox.Visible = false;
            this.local_ae_textbox.TextChanged += new System.EventHandler(this.local_ae_textbox_TextChanged);
            this.local_ae_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.local_ae_textbox_KeyPress);
            this.local_ae_textbox.Leave += new System.EventHandler(this.local_ae_textbox_Leave);
            // 
            // local_ae_text
            // 
            this.local_ae_text.AutoSize = true;
            this.local_ae_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.local_ae_text.Location = new System.Drawing.Point(273, 69);
            this.local_ae_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.local_ae_text.Name = "local_ae_text";
            this.local_ae_text.Size = new System.Drawing.Size(170, 26);
            this.local_ae_text.TabIndex = 9;
            this.local_ae_text.Text = "local_ae_default";
            this.local_ae_text.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.local_ae_text_MouseDoubleClick);
            // 
            // local_ip_text
            // 
            this.local_ip_text.AutoSize = true;
            this.local_ip_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.local_ip_text.Location = new System.Drawing.Point(273, 154);
            this.local_ip_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.local_ip_text.Name = "local_ip_text";
            this.local_ip_text.Size = new System.Drawing.Size(46, 26);
            this.local_ip_text.TabIndex = 6;
            this.local_ip_text.Text = "null";
            // 
            // local_port_label
            // 
            this.local_port_label.AutoSize = true;
            this.local_port_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.local_port_label.Location = new System.Drawing.Point(46, 232);
            this.local_port_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.local_port_label.Name = "local_port_label";
            this.local_port_label.Size = new System.Drawing.Size(173, 26);
            this.local_port_label.TabIndex = 3;
            this.local_port_label.Text = "Listening Port: ";
            // 
            // local_ae_label
            // 
            this.local_ae_label.AutoSize = true;
            this.local_ae_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.local_ae_label.Location = new System.Drawing.Point(16, 69);
            this.local_ae_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.local_ae_label.Name = "local_ae_label";
            this.local_ae_label.Size = new System.Drawing.Size(205, 26);
            this.local_ae_label.TabIndex = 0;
            this.local_ae_label.Text = "Application Entity:";
            // 
            // local_port_combobox
            // 
            this.local_port_combobox.FormattingEnabled = true;
            this.local_port_combobox.Items.AddRange(new object[] {
            "104",
            "11112",
            "4242",
            "[Custom]"});
            this.local_port_combobox.Location = new System.Drawing.Point(276, 232);
            this.local_port_combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.local_port_combobox.Name = "local_port_combobox";
            this.local_port_combobox.Size = new System.Drawing.Size(180, 28);
            this.local_port_combobox.TabIndex = 8;
            this.local_port_combobox.Text = "104";
            this.local_port_combobox.TextChanged += new System.EventHandler(this.local_port_combobox_TextChanged);
            // 
            // help_container
            // 
            this.help_container.Controls.Add(this.help_text2);
            this.help_container.Controls.Add(this.help_text);
            this.help_container.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.help_container.Location = new System.Drawing.Point(457, 464);
            this.help_container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.help_container.Name = "help_container";
            this.help_container.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.help_container.Size = new System.Drawing.Size(963, 95);
            this.help_container.TabIndex = 11;
            this.help_container.TabStop = false;
            this.help_container.Text = "Help";
            // 
            // help_text
            // 
            this.help_text.AutoSize = true;
            this.help_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.help_text.Location = new System.Drawing.Point(9, 26);
            this.help_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.help_text.Name = "help_text";
            this.help_text.Size = new System.Drawing.Size(534, 20);
            this.help_text.TabIndex = 11;
            this.help_text.Text = "Double click the field values to change them, and hit \'Enter\' to confirm.";
            // 
            // help_text2
            // 
            this.help_text2.AutoSize = true;
            this.help_text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.help_text2.Location = new System.Drawing.Point(9, 46);
            this.help_text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.help_text2.Name = "help_text2";
            this.help_text2.Size = new System.Drawing.Size(421, 20);
            this.help_text2.TabIndex = 12;
            this.help_text2.Text = "Recommended DICOM ports are 104, 11112, and 4242.";
            // 
            // Listen
            // 
            this.Listen.Location = new System.Drawing.Point(457, 569);
            this.Listen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(482, 121);
            this.Listen.TabIndex = 12;
            this.Listen.Text = "Listen";
            this.Listen.UseVisualStyleBackColor = true;
            this.Listen.Click += new System.EventHandler(this.Listen_Click);
            // 
            // sendFile
            // 
            this.sendFile.Location = new System.Drawing.Point(7, 700);
            this.sendFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendFile.Name = "sendFile";
            this.sendFile.Size = new System.Drawing.Size(1400, 26);
            this.sendFile.TabIndex = 13;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(947, 569);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(460, 121);
            this.sendButton.TabIndex = 14;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.currentFileLabel);
            this.tabPage5.Controls.Add(this.informationLabel);
            this.tabPage5.Controls.Add(this.informationBox);
            this.tabPage5.Controls.Add(this.directoryBox);
            this.tabPage5.Controls.Add(this.goRight);
            this.tabPage5.Controls.Add(this.goLeft);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.imageDisplay);
            this.tabPage5.Controls.Add(this.directoryOpen);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1418, 731);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "View";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // directoryOpen
            //
            this.directoryOpen.Location = new System.Drawing.Point(460, 669);
            this.directoryOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directoryOpen.Name = "directoryOpen";
            this.directoryOpen.Size = new System.Drawing.Size(112, 35);
            this.directoryOpen.TabIndex = 0;
            this.directoryOpen.Text = "Open";
            this.directoryOpen.UseVisualStyleBackColor = true;
            this.directoryOpen.Click += new System.EventHandler(this.directoryOpen_Click);
            // 
            // imageDisplay
            // 
            this.imageDisplay.Location = new System.Drawing.Point(12, 48);
            this.imageDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageDisplay.Name = "imageDisplay";
            this.imageDisplay.Size = new System.Drawing.Size(699, 560);
            this.imageDisplay.TabIndex = 1;
            this.imageDisplay.TabStop = false;
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(94, 674);
            this.directoryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(355, 26);
            this.directoryBox.TabIndex = 2;
            this.directoryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.directoryBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 678);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Directory";
            // 
            // goLeft
            // 
            this.goLeft.Location = new System.Drawing.Point(218, 617);
            this.goLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goLeft.Name = "goLeft";
            this.goLeft.Size = new System.Drawing.Size(112, 35);
            this.goLeft.TabIndex = 4;
            this.goLeft.Text = "Left";
            this.goLeft.UseVisualStyleBackColor = true;
            this.goLeft.Click += new System.EventHandler(this.goLeft_Click);
            // 
            // goRight
            // 
            this.goRight.Location = new System.Drawing.Point(339, 617);
            this.goRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.goRight.Name = "goRight";
            this.goRight.Size = new System.Drawing.Size(112, 35);
            this.goRight.TabIndex = 5;
            this.goRight.Text = "Right";
            this.goRight.UseVisualStyleBackColor = true;
            this.goRight.Click += new System.EventHandler(this.goRight_Click);
            // 
            // informationBox
            // 
            this.informationBox.Location = new System.Drawing.Point(720, 48);
            this.informationBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.informationBox.Multiline = true;
            this.informationBox.Name = "informationBox";
            this.informationBox.ReadOnly = true;
            this.informationBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.informationBox.Size = new System.Drawing.Size(670, 602);
            this.informationBox.TabIndex = 6;
            this.informationBox.WordWrap = false;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(720, 18);
            this.informationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(90, 20);
            this.informationLabel.TabIndex = 7;
            this.informationLabel.Text = "Information";
            // 
            // currentFileLabel
            // 
            this.currentFileLabel.AutoSize = true;
            this.currentFileLabel.Location = new System.Drawing.Point(12, 18);
            this.currentFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentFileLabel.Name = "currentFileLabel";
            this.currentFileLabel.Size = new System.Drawing.Size(132, 20);
            this.currentFileLabel.TabIndex = 8;
            this.currentFileLabel.Text = "No input directory";
            // 
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.Filepath);
            this.tabPage2.Controls.Add(this.OpenSingleFile);
            this.tabPage2.Controls.Add(this.Anonymize);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1418, 731);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anonymize";
            this.tabPage2.UseVisualStyleBackColor = true;

            // 
            // Anonymize
            // 
            this.Anonymize.Location = new System.Drawing.Point(778, 254);
            this.Anonymize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Anonymize.Name = "Anonymize";
            this.Anonymize.Size = new System.Drawing.Size(380, 208);
            this.Anonymize.TabIndex = 0;
            this.Anonymize.Text = "Anonymize";
            this.Anonymize.UseVisualStyleBackColor = true;
            this.Anonymize.Click += new System.EventHandler(this.Anonymize_Click);
            // 
            // OpenSingleFile
            // 
            this.OpenSingleFile.Location = new System.Drawing.Point(218, 254);
            this.OpenSingleFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenSingleFile.Name = "OpenSingleFile";
            this.OpenSingleFile.Size = new System.Drawing.Size(380, 208);
            this.OpenSingleFile.TabIndex = 1;
            this.OpenSingleFile.Text = "Open Single Dicom File";
            this.OpenSingleFile.UseVisualStyleBackColor = true;
            this.OpenSingleFile.Click += new System.EventHandler(this.OpenSingleFile_Click);
            // 
            // Filepath
            // 
            this.Filepath.Location = new System.Drawing.Point(218, 554);
            this.Filepath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Filepath.Name = "Filepath";
            this.Filepath.Size = new System.Drawing.Size(940, 26);
            this.Filepath.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.port_value);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1426, 764);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 788);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.port_value.ResumeLayout(false);
            this.port_value.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.target_container.ResumeLayout(false);
            this.target_container.PerformLayout();
            this.local_container.ResumeLayout(false);
            this.local_container.PerformLayout();
            this.help_container.ResumeLayout(false);
            this.help_container.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDisplay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage port_value;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendFile;
        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.GroupBox help_container;
        private System.Windows.Forms.Label help_text2;
        private System.Windows.Forms.Label help_text;
        private System.Windows.Forms.GroupBox local_container;
        private System.Windows.Forms.ComboBox local_port_combobox;
        private System.Windows.Forms.Label local_ae_label;
        private System.Windows.Forms.Label local_port_label;
        private System.Windows.Forms.Label local_ip_text;
        private System.Windows.Forms.Label local_ae_text;
        private System.Windows.Forms.TextBox local_ae_textbox;
        private System.Windows.Forms.Label local_ip_label;
        private System.Windows.Forms.TextBox local_port_textbox;
        private System.Windows.Forms.GroupBox target_container;
        private System.Windows.Forms.ComboBox target_port_combobox;
        private System.Windows.Forms.Label target_ip_text;
        private System.Windows.Forms.Label target_port_label;
        private System.Windows.Forms.Label target_ip_label;
        private System.Windows.Forms.Label target_ae_text;
        private System.Windows.Forms.TextBox target_ae_textbox;
        private System.Windows.Forms.Label target_ae_label;
        private System.Windows.Forms.TextBox target_ip_textbox;
        private System.Windows.Forms.TextBox target_port_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox existingParameters;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label currentFileLabel;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.TextBox informationBox;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button goRight;
        private System.Windows.Forms.Button goLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imageDisplay;
        private System.Windows.Forms.Button directoryOpen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Filepath;
        private System.Windows.Forms.Button OpenSingleFile;
        private System.Windows.Forms.Button Anonymize;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

