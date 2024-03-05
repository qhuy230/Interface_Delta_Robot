
namespace Control_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Connect = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.x4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.TextBox();
            this.y4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.z4 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.x3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.z3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.z2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.current_x = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.current_y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.current_z = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.Parity = System.IO.Ports.Parity.Mark;
            this.serialPort1.PortName = "COM9";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Lime;
            this.Connect.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.Color.Black;
            this.Connect.Location = new System.Drawing.Point(19, 472);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(153, 59);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "CONNECT";
            this.Connect.UseMnemonic = false;
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_btn);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Yellow;
            this.submit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.Black;
            this.submit.Location = new System.Drawing.Point(188, 472);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(153, 59);
            this.submit.TabIndex = 0;
            this.submit.Text = "SEND";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.Submit_Btn);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PORTS";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(16, 552);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(64, 20);
            this.status.TabIndex = 9;
            this.status.Text = "Status: ";
            // 
            // z
            // 
            this.z.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z.Location = new System.Drawing.Point(275, 73);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(100, 21);
            this.z.TabIndex = 3;
            this.z.Text = "-240";
            this.z.TextChanged += new System.EventHandler(this.change_position);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // y
            // 
            this.y.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y.Location = new System.Drawing.Point(149, 73);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(100, 21);
            this.y.TabIndex = 2;
            this.y.Text = "1";
            this.y.TextChanged += new System.EventHandler(this.change_position);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // x
            // 
            this.x.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(23, 73);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 21);
            this.x.TabIndex = 1;
            this.x.Text = "100";
            this.x.TextChanged += new System.EventHandler(this.change_position);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.x4);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.a4);
            this.panel1.Controls.Add(this.y4);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.z4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.x3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.a3);
            this.panel1.Controls.Add(this.y3);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.z3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.x2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.a2);
            this.panel1.Controls.Add(this.y2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.z2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.x);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.a);
            this.panel1.Controls.Add(this.y);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.z);
            this.panel1.Location = new System.Drawing.Point(369, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 279);
            this.panel1.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(424, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 15);
            this.label20.TabIndex = 32;
            this.label20.Text = "A (Tốc độ)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(424, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "A (Tốc độ)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "A (Tốc độ)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(318, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 15);
            this.label19.TabIndex = 31;
            this.label19.Text = "Z";
            // 
            // x4
            // 
            this.x4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x4.Location = new System.Drawing.Point(23, 233);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(100, 21);
            this.x4.TabIndex = 24;
            this.x4.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(189, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 15);
            this.label21.TabIndex = 29;
            this.label21.Text = "Y";
            // 
            // a4
            // 
            this.a4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a4.Location = new System.Drawing.Point(400, 233);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(100, 21);
            this.a4.TabIndex = 30;
            this.a4.Text = "6";
            // 
            // y4
            // 
            this.y4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y4.Location = new System.Drawing.Point(149, 233);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(100, 21);
            this.y4.TabIndex = 25;
            this.y4.Text = "-100";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(59, 211);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "X";
            // 
            // z4
            // 
            this.z4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z4.Location = new System.Drawing.Point(275, 233);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(100, 21);
            this.z4.TabIndex = 27;
            this.z4.Text = "-240";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(318, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 15);
            this.label15.TabIndex = 23;
            this.label15.Text = "Z";
            // 
            // x3
            // 
            this.x3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x3.Location = new System.Drawing.Point(23, 185);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(100, 21);
            this.x3.TabIndex = 16;
            this.x3.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(189, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 15);
            this.label17.TabIndex = 21;
            this.label17.Text = "Y";
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(400, 185);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(100, 21);
            this.a3.TabIndex = 22;
            this.a3.Text = "6";
            // 
            // y3
            // 
            this.y3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y3.Location = new System.Drawing.Point(149, 185);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(100, 21);
            this.y3.TabIndex = 17;
            this.y3.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(59, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 15);
            this.label18.TabIndex = 18;
            this.label18.Text = "X";
            // 
            // z3
            // 
            this.z3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z3.Location = new System.Drawing.Point(275, 185);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(100, 21);
            this.z3.TabIndex = 19;
            this.z3.Text = "-240";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(318, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Z";
            // 
            // x2
            // 
            this.x2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x2.Location = new System.Drawing.Point(23, 129);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(100, 21);
            this.x2.TabIndex = 8;
            this.x2.Text = "-100";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Y";
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(400, 129);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(100, 21);
            this.a2.TabIndex = 14;
            this.a2.Text = "6";
            // 
            // y2
            // 
            this.y2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y2.Location = new System.Drawing.Point(149, 129);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(100, 21);
            this.y2.TabIndex = 9;
            this.y2.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(59, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "X";
            // 
            // z2
            // 
            this.z2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z2.Location = new System.Drawing.Point(275, 129);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(100, 21);
            this.z2.TabIndex = 11;
            this.z2.Text = "-240";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "GÁN TỌA ĐỘ ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(424, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 4;
            this.label10.Text = "A (Tốc độ)";
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(400, 73);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 21);
            this.a.TabIndex = 4;
            this.a.Text = "6";
            this.a.TextChanged += new System.EventHandler(this.change_position);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 50;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.current_x);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.current_y);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.current_z);
            this.panel2.Location = new System.Drawing.Point(369, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 110);
            this.panel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "VỊ TRÍ HIỆN TẠI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Z";
            // 
            // current_x
            // 
            this.current_x.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_x.Location = new System.Drawing.Point(46, 68);
            this.current_x.Name = "current_x";
            this.current_x.ReadOnly = true;
            this.current_x.Size = new System.Drawing.Size(100, 21);
            this.current_x.TabIndex = 5;
            this.current_x.Text = "-5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Y";
            // 
            // current_y
            // 
            this.current_y.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_y.Location = new System.Drawing.Point(201, 68);
            this.current_y.Name = "current_y";
            this.current_y.ReadOnly = true;
            this.current_y.Size = new System.Drawing.Size(100, 21);
            this.current_y.TabIndex = 3;
            this.current_y.Text = "-20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "X";
            // 
            // current_z
            // 
            this.current_z.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_z.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.current_z.Location = new System.Drawing.Point(358, 68);
            this.current_z.Name = "current_z";
            this.current_z.ReadOnly = true;
            this.current_z.Size = new System.Drawing.Size(100, 21);
            this.current_z.TabIndex = 1;
            this.current_z.Text = "-200";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.getPosition);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(137, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(662, 29);
            this.name.TabIndex = 13;
            this.name.Text = "GIAO DIỆN ĐIỀU KHIỂN VÀ GIÁM SÁT ROBOT DELTA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(823, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "9600"});
            this.comboBox2.DisplayMember = "9600";
            this.comboBox2.DropDownWidth = 50;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600"});
            this.comboBox2.Location = new System.Drawing.Point(108, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "9600";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(13, 126);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "BAUDRATE";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label41);
            this.panel4.Location = new System.Drawing.Point(42, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 162);
            this.panel4.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "9600"});
            this.comboBox3.DisplayMember = "9600";
            this.comboBox3.DropDownWidth = 50;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "9600"});
            this.comboBox3.Location = new System.Drawing.Point(-317, 128);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(119, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.ValueMember = "9600";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(14, 15);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(258, 24);
            this.label41.TabIndex = 7;
            this.label41.Text = "CÀI ĐẶT CỔNG NỐI TIẾP";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gray;
            this.label24.Location = new System.Drawing.Point(16, 579);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(196, 20);
            this.label24.TabIndex = 17;
            this.label24.Text = "Pham Quoc Huy Designed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 608);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label status;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox z;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox current_x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox current_y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox current_z;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox a4;
        private System.Windows.Forms.TextBox y4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox z4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox a3;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox z3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox a2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label24;
    }
}

