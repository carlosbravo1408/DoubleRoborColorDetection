namespace VideoCapture
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videoSourceB = new System.Windows.Forms.PictureBox();
            this.videoSourceG = new System.Windows.Forms.PictureBox();
            this.videoSourceR = new System.Windows.Forms.PictureBox();
            this.videoSourceBlob = new AForge.Controls.PictureBox();
            this.rtx_indicativo = new System.Windows.Forms.RichTextBox();
            this.videoSourceCaptura = new AForge.Controls.VideoSourcePlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_resolucion = new System.Windows.Forms.ComboBox();
            this.btn_puerto = new System.Windows.Forms.Button();
            this.btn_camara = new System.Windows.Forms.Button();
            this.cbx_Puerto = new System.Windows.Forms.ComboBox();
            this.cbx_camaras = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudBb = new System.Windows.Forms.NumericUpDown();
            this.nudBg = new System.Windows.Forms.NumericUpDown();
            this.nudBr = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nudGb = new System.Windows.Forms.NumericUpDown();
            this.nudGg = new System.Windows.Forms.NumericUpDown();
            this.nudGr = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudRb = new System.Windows.Forms.NumericUpDown();
            this.nudRg = new System.Windows.Forms.NumericUpDown();
            this.nudRr = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceBlob)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBr)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGr)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRr)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.videoSourceB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceG, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceBlob, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtx_indicativo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.videoSourceCaptura, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 491);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // videoSourceB
            // 
            this.videoSourceB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceB.Location = new System.Drawing.Point(605, 248);
            this.videoSourceB.Name = "videoSourceB";
            this.videoSourceB.Size = new System.Drawing.Size(296, 240);
            this.videoSourceB.TabIndex = 14;
            this.videoSourceB.TabStop = false;
            this.toolTip1.SetToolTip(this.videoSourceB, "Viewer Blue");
            this.videoSourceB.DoubleClick += new System.EventHandler(this.videoSourceB_DoubleClick);
            // 
            // videoSourceG
            // 
            this.videoSourceG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceG.Location = new System.Drawing.Point(605, 3);
            this.videoSourceG.Name = "videoSourceG";
            this.videoSourceG.Size = new System.Drawing.Size(296, 239);
            this.videoSourceG.TabIndex = 13;
            this.videoSourceG.TabStop = false;
            this.toolTip1.SetToolTip(this.videoSourceG, "View Green Color");
            this.videoSourceG.DoubleClick += new System.EventHandler(this.videoSourceG_DoubleClick);
            // 
            // videoSourceR
            // 
            this.videoSourceR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceR.Location = new System.Drawing.Point(304, 3);
            this.videoSourceR.Name = "videoSourceR";
            this.videoSourceR.Size = new System.Drawing.Size(295, 239);
            this.videoSourceR.TabIndex = 2;
            this.videoSourceR.TabStop = false;
            this.toolTip1.SetToolTip(this.videoSourceR, "View Red Color");
            this.videoSourceR.DoubleClick += new System.EventHandler(this.videoSourceR_DoubleClick);
            // 
            // videoSourceBlob
            // 
            this.videoSourceBlob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceBlob.Image = null;
            this.videoSourceBlob.Location = new System.Drawing.Point(304, 248);
            this.videoSourceBlob.Name = "videoSourceBlob";
            this.videoSourceBlob.Size = new System.Drawing.Size(295, 240);
            this.videoSourceBlob.TabIndex = 10;
            this.videoSourceBlob.TabStop = false;
            this.toolTip1.SetToolTip(this.videoSourceBlob, "Blob, Shaper recognition");
            // 
            // rtx_indicativo
            // 
            this.rtx_indicativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtx_indicativo.Location = new System.Drawing.Point(3, 248);
            this.rtx_indicativo.Name = "rtx_indicativo";
            this.rtx_indicativo.Size = new System.Drawing.Size(295, 240);
            this.rtx_indicativo.TabIndex = 6;
            this.rtx_indicativo.Text = "";
            // 
            // videoSourceCaptura
            // 
            this.videoSourceCaptura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourceCaptura.Location = new System.Drawing.Point(3, 3);
            this.videoSourceCaptura.Name = "videoSourceCaptura";
            this.videoSourceCaptura.Size = new System.Drawing.Size(295, 239);
            this.videoSourceCaptura.TabIndex = 12;
            this.toolTip1.SetToolTip(this.videoSourceCaptura, "Image Source");
            this.videoSourceCaptura.VideoSource = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbx_resolucion);
            this.groupBox1.Controls.Add(this.btn_puerto);
            this.groupBox1.Controls.Add(this.btn_camara);
            this.groupBox1.Controls.Add(this.cbx_Puerto);
            this.groupBox1.Controls.Add(this.cbx_camaras);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dispositivos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(469, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(104, 62);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Condicional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "label7";
            this.label13.TextChanged += new System.EventHandler(this.label13_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "label9";
            this.label14.TextChanged += new System.EventHandler(this.label14_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "label8";
            this.label15.TextChanged += new System.EventHandler(this.label15_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(333, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 62);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.label1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // cbx_resolucion
            // 
            this.cbx_resolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_resolucion.FormattingEnabled = true;
            this.cbx_resolucion.Location = new System.Drawing.Point(201, 18);
            this.cbx_resolucion.Name = "cbx_resolucion";
            this.cbx_resolucion.Size = new System.Drawing.Size(127, 21);
            this.cbx_resolucion.TabIndex = 4;
            this.cbx_resolucion.SelectedIndexChanged += new System.EventHandler(this.cbx_resolucion_SelectedIndexChanged);
            // 
            // btn_puerto
            // 
            this.btn_puerto.Location = new System.Drawing.Point(201, 40);
            this.btn_puerto.Name = "btn_puerto";
            this.btn_puerto.Size = new System.Drawing.Size(126, 23);
            this.btn_puerto.TabIndex = 3;
            this.btn_puerto.Text = "Conectar Dispositivo";
            this.btn_puerto.UseVisualStyleBackColor = true;
            this.btn_puerto.Click += new System.EventHandler(this.btn_puerto_Click);
            // 
            // btn_camara
            // 
            this.btn_camara.Location = new System.Drawing.Point(8, 65);
            this.btn_camara.Name = "btn_camara";
            this.btn_camara.Size = new System.Drawing.Size(127, 23);
            this.btn_camara.TabIndex = 2;
            this.btn_camara.Text = "Conectar Cámara";
            this.btn_camara.UseVisualStyleBackColor = true;
            this.btn_camara.Click += new System.EventHandler(this.btn_camara_Click);
            // 
            // cbx_Puerto
            // 
            this.cbx_Puerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Puerto.FormattingEnabled = true;
            this.cbx_Puerto.Location = new System.Drawing.Point(8, 42);
            this.cbx_Puerto.Name = "cbx_Puerto";
            this.cbx_Puerto.Size = new System.Drawing.Size(188, 21);
            this.cbx_Puerto.TabIndex = 1;
            this.cbx_Puerto.SelectedIndexChanged += new System.EventHandler(this.cbx_Puerto_SelectedIndexChanged);
            // 
            // cbx_camaras
            // 
            this.cbx_camaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_camaras.FormattingEnabled = true;
            this.cbx_camaras.Location = new System.Drawing.Point(7, 19);
            this.cbx_camaras.Name = "cbx_camaras";
            this.cbx_camaras.Size = new System.Drawing.Size(188, 21);
            this.cbx_camaras.TabIndex = 0;
            this.cbx_camaras.SelectedIndexChanged += new System.EventHandler(this.cbx_camaras_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(591, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 110);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calibración";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudBb);
            this.groupBox7.Controls.Add(this.nudBg);
            this.groupBox7.Controls.Add(this.nudBr);
            this.groupBox7.Enabled = false;
            this.groupBox7.Location = new System.Drawing.Point(224, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(91, 92);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Blue";
            // 
            // nudBb
            // 
            this.nudBb.Location = new System.Drawing.Point(6, 66);
            this.nudBb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBb.Name = "nudBb";
            this.nudBb.Size = new System.Drawing.Size(78, 20);
            this.nudBb.TabIndex = 5;
            this.nudBb.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nudBg
            // 
            this.nudBg.Location = new System.Drawing.Point(6, 41);
            this.nudBg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBg.Name = "nudBg";
            this.nudBg.Size = new System.Drawing.Size(78, 20);
            this.nudBg.TabIndex = 4;
            this.nudBg.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudBr
            // 
            this.nudBr.Location = new System.Drawing.Point(6, 17);
            this.nudBr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBr.Name = "nudBr";
            this.nudBr.Size = new System.Drawing.Size(78, 20);
            this.nudBr.TabIndex = 3;
            this.nudBr.Value = new decimal(new int[] {
            27,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nudGb);
            this.groupBox6.Controls.Add(this.nudGg);
            this.groupBox6.Controls.Add(this.nudGr);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(118, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(91, 92);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Green";
            // 
            // nudGb
            // 
            this.nudGb.Location = new System.Drawing.Point(6, 66);
            this.nudGb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGb.Name = "nudGb";
            this.nudGb.Size = new System.Drawing.Size(78, 20);
            this.nudGb.TabIndex = 5;
            this.nudGb.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudGg
            // 
            this.nudGg.Location = new System.Drawing.Point(6, 41);
            this.nudGg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGg.Name = "nudGg";
            this.nudGg.Size = new System.Drawing.Size(78, 20);
            this.nudGg.TabIndex = 4;
            this.nudGg.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nudGr
            // 
            this.nudGr.Location = new System.Drawing.Point(6, 17);
            this.nudGr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGr.Name = "nudGr";
            this.nudGr.Size = new System.Drawing.Size(78, 20);
            this.nudGr.TabIndex = 3;
            this.nudGr.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudRb);
            this.groupBox5.Controls.Add(this.nudRg);
            this.groupBox5.Controls.Add(this.nudRr);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(6, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(91, 92);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Red";
            // 
            // nudRb
            // 
            this.nudRb.Location = new System.Drawing.Point(6, 66);
            this.nudRb.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRb.Name = "nudRb";
            this.nudRb.Size = new System.Drawing.Size(78, 20);
            this.nudRb.TabIndex = 5;
            this.nudRb.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudRg
            // 
            this.nudRg.Location = new System.Drawing.Point(6, 41);
            this.nudRg.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRg.Name = "nudRg";
            this.nudRg.Size = new System.Drawing.Size(78, 20);
            this.nudRg.TabIndex = 4;
            this.nudRg.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudRr
            // 
            this.nudRr.Location = new System.Drawing.Point(6, 17);
            this.nudRr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRr.Name = "nudRr";
            this.nudRr.Size = new System.Drawing.Size(78, 20);
            this.nudRr.TabIndex = 3;
            this.nudRr.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(904, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enviar :v";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 638);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoSourceBlob)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBr)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGr)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_puerto;
        private System.Windows.Forms.Button btn_camara;
        private System.Windows.Forms.ComboBox cbx_Puerto;
        private System.Windows.Forms.ComboBox cbx_camaras;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cbx_resolucion;
        private System.Windows.Forms.RichTextBox rtx_indicativo;
        private AForge.Controls.VideoSourcePlayer videoSourceCaptura;
        private AForge.Controls.PictureBox videoSourceBlob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox videoSourceR;
        private System.Windows.Forms.PictureBox videoSourceB;
        private System.Windows.Forms.PictureBox videoSourceG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudBb;
        private System.Windows.Forms.NumericUpDown nudBg;
        private System.Windows.Forms.NumericUpDown nudBr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nudGb;
        private System.Windows.Forms.NumericUpDown nudGg;
        private System.Windows.Forms.NumericUpDown nudGr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown nudRb;
        private System.Windows.Forms.NumericUpDown nudRg;
        private System.Windows.Forms.NumericUpDown nudRr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;


    }
}

