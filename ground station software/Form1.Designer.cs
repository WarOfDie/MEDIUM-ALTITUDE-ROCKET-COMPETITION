namespace yer_istasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textTakımID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textSayac = new System.Windows.Forms.Label();
            this.textIrtifa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textGpsIrtf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoylam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textJY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textJX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textDurum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textAçi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textIvmeZ = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textIvmeY = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textIvmeX = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textJZ = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.map2 = new GMap.NET.WindowsForms.GMapControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textGyBoylam = new System.Windows.Forms.TextBox();
            this.textGyEnlem = new System.Windows.Forms.TextBox();
            this.textGyIrtifa = new System.Windows.Forms.TextBox();
            this.textEnlem = new System.Windows.Forms.TextBox();
            this.textCrc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 40);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Port Ayarlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 194);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(115, 247);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alıcı Ayarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(16, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(115, 249);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gönderici Ayarları";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 194);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 44);
            this.button7.TabIndex = 9;
            this.button7.Text = "Göder";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 143);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 44);
            this.button6.TabIndex = 9;
            this.button6.Text = "Kapat";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 91);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 44);
            this.button5.TabIndex = 9;
            this.button5.Text = "Aç";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(7, 39);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Port Ayarlar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Takım ID:";
            // 
            // textTakımID
            // 
            this.textTakımID.BackColor = System.Drawing.SystemColors.Menu;
            this.textTakımID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTakımID.Location = new System.Drawing.Point(213, 69);
            this.textTakımID.Margin = new System.Windows.Forms.Padding(4);
            this.textTakımID.Name = "textTakımID";
            this.textTakımID.Size = new System.Drawing.Size(65, 15);
            this.textTakımID.TabIndex = 10;
            this.textTakımID.Text = "0";
            this.textTakımID.TextChanged += new System.EventHandler(this.textTakımID_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(213, 109);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(65, 15);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "0";
            // 
            // textSayac
            // 
            this.textSayac.AutoSize = true;
            this.textSayac.Location = new System.Drawing.Point(40, 108);
            this.textSayac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textSayac.Name = "textSayac";
            this.textSayac.Size = new System.Drawing.Size(49, 16);
            this.textSayac.TabIndex = 11;
            this.textSayac.Text = "Sayaç:";
            this.textSayac.Click += new System.EventHandler(this.textSayac_Click);
            // 
            // textIrtifa
            // 
            this.textIrtifa.BackColor = System.Drawing.SystemColors.Menu;
            this.textIrtifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIrtifa.Location = new System.Drawing.Point(213, 146);
            this.textIrtifa.Margin = new System.Windows.Forms.Padding(4);
            this.textIrtifa.Name = "textIrtifa";
            this.textIrtifa.Size = new System.Drawing.Size(65, 15);
            this.textIrtifa.TabIndex = 14;
            this.textIrtifa.Text = "0";
            this.textIrtifa.TextChanged += new System.EventHandler(this.textIrtifa_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "İrtifa:";
            // 
            // textGpsIrtf
            // 
            this.textGpsIrtf.BackColor = System.Drawing.SystemColors.Menu;
            this.textGpsIrtf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGpsIrtf.Location = new System.Drawing.Point(213, 223);
            this.textGpsIrtf.Margin = new System.Windows.Forms.Padding(4);
            this.textGpsIrtf.Name = "textGpsIrtf";
            this.textGpsIrtf.Size = new System.Drawing.Size(65, 15);
            this.textGpsIrtf.TabIndex = 16;
            this.textGpsIrtf.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Roket GPS İrtifa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Roket Enlem:";
            // 
            // textBoylam
            // 
            this.textBoylam.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoylam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoylam.Location = new System.Drawing.Point(213, 304);
            this.textBoylam.Margin = new System.Windows.Forms.Padding(4);
            this.textBoylam.Name = "textBoylam";
            this.textBoylam.Size = new System.Drawing.Size(65, 15);
            this.textBoylam.TabIndex = 20;
            this.textBoylam.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Roket Boylam:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 378);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Görev Yükü GPS İrtifa:";
            // 
            // textJY
            // 
            this.textJY.BackColor = System.Drawing.SystemColors.Menu;
            this.textJY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textJY.Location = new System.Drawing.Point(465, 109);
            this.textJY.Margin = new System.Windows.Forms.Padding(4);
            this.textJY.Name = "textJY";
            this.textJY.Size = new System.Drawing.Size(113, 15);
            this.textJY.TabIndex = 36;
            this.textJY.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Jiroskop Y:";
            // 
            // textJX
            // 
            this.textJX.BackColor = System.Drawing.SystemColors.Menu;
            this.textJX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textJX.Location = new System.Drawing.Point(465, 70);
            this.textJX.Margin = new System.Windows.Forms.Padding(4);
            this.textJX.Name = "textJX";
            this.textJX.Size = new System.Drawing.Size(113, 15);
            this.textJX.TabIndex = 34;
            this.textJX.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Jiroskop X:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 450);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Görev Yükü GPS Boylam";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 413);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Görev Yükü GPS Enlem:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(378, 450);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "CRC:";
            // 
            // textDurum
            // 
            this.textDurum.BackColor = System.Drawing.SystemColors.Menu;
            this.textDurum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDurum.Location = new System.Drawing.Point(465, 413);
            this.textDurum.Margin = new System.Windows.Forms.Padding(4);
            this.textDurum.Name = "textDurum";
            this.textDurum.Size = new System.Drawing.Size(113, 15);
            this.textDurum.TabIndex = 48;
            this.textDurum.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(378, 413);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "Durum:";
            // 
            // textAçi
            // 
            this.textAçi.BackColor = System.Drawing.SystemColors.Menu;
            this.textAçi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAçi.Location = new System.Drawing.Point(465, 378);
            this.textAçi.Margin = new System.Windows.Forms.Padding(4);
            this.textAçi.Name = "textAçi";
            this.textAçi.Size = new System.Drawing.Size(113, 15);
            this.textAçi.TabIndex = 46;
            this.textAçi.Text = "0";
            this.textAçi.TextChanged += new System.EventHandler(this.textAçi_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(378, 378);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "Açı:";
            // 
            // textIvmeZ
            // 
            this.textIvmeZ.BackColor = System.Drawing.SystemColors.Menu;
            this.textIvmeZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIvmeZ.Location = new System.Drawing.Point(465, 302);
            this.textIvmeZ.Margin = new System.Windows.Forms.Padding(4);
            this.textIvmeZ.Name = "textIvmeZ";
            this.textIvmeZ.Size = new System.Drawing.Size(113, 15);
            this.textIvmeZ.TabIndex = 44;
            this.textIvmeZ.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(377, 302);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 16);
            this.label18.TabIndex = 43;
            this.label18.Text = "İvme Z:";
            // 
            // textIvmeY
            // 
            this.textIvmeY.BackColor = System.Drawing.SystemColors.Menu;
            this.textIvmeY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIvmeY.Location = new System.Drawing.Point(465, 263);
            this.textIvmeY.Margin = new System.Windows.Forms.Padding(4);
            this.textIvmeY.Name = "textIvmeY";
            this.textIvmeY.Size = new System.Drawing.Size(113, 15);
            this.textIvmeY.TabIndex = 42;
            this.textIvmeY.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(378, 262);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 16);
            this.label19.TabIndex = 41;
            this.label19.Text = "İvme Y:";
            // 
            // textIvmeX
            // 
            this.textIvmeX.BackColor = System.Drawing.SystemColors.Menu;
            this.textIvmeX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIvmeX.Location = new System.Drawing.Point(465, 230);
            this.textIvmeX.Margin = new System.Windows.Forms.Padding(4);
            this.textIvmeX.Name = "textIvmeX";
            this.textIvmeX.Size = new System.Drawing.Size(113, 15);
            this.textIvmeX.TabIndex = 40;
            this.textIvmeX.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(377, 230);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "İvme X:";
            // 
            // textJZ
            // 
            this.textJZ.BackColor = System.Drawing.SystemColors.Menu;
            this.textJZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textJZ.Location = new System.Drawing.Point(465, 146);
            this.textJZ.Margin = new System.Windows.Forms.Padding(4);
            this.textJZ.Name = "textJZ";
            this.textJZ.Size = new System.Drawing.Size(113, 15);
            this.textJZ.TabIndex = 38;
            this.textJZ.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(379, 146);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 16);
            this.label21.TabIndex = 37;
            this.label21.Text = "Jiroskop Z:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Menu;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Menu;
            chartArea5.BackColor = System.Drawing.SystemColors.Menu;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(8, 22);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.BorderColor = System.Drawing.Color.White;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.LabelBackColor = System.Drawing.Color.White;
            series5.LabelBorderColor = System.Drawing.Color.White;
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1469, 182);
            this.chart1.TabIndex = 52;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(6, 21);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(446, 250);
            this.map.TabIndex = 53;
            this.map.Zoom = 0D;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.map);
            this.groupBox4.Location = new System.Drawing.Point(770, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(458, 277);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Roket Konum";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.map2);
            this.groupBox5.Location = new System.Drawing.Point(770, 298);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(458, 268);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Faydalı Yük Konum";
            // 
            // map2
            // 
            this.map2.Bearing = 0F;
            this.map2.CanDragMap = true;
            this.map2.EmptyTileColor = System.Drawing.Color.Navy;
            this.map2.GrayScaleMode = false;
            this.map2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map2.LevelsKeepInMemory = 5;
            this.map2.Location = new System.Drawing.Point(6, 21);
            this.map2.MarkersEnabled = true;
            this.map2.MaxZoom = 2;
            this.map2.MinZoom = 2;
            this.map2.MouseWheelZoomEnabled = true;
            this.map2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map2.Name = "map2";
            this.map2.NegativeMode = false;
            this.map2.PolygonsEnabled = true;
            this.map2.RetryLoadTile = 0;
            this.map2.RoutesEnabled = true;
            this.map2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map2.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map2.ShowTileGridLines = false;
            this.map2.Size = new System.Drawing.Size(446, 241);
            this.map2.TabIndex = 0;
            this.map2.Zoom = 0D;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart1);
            this.groupBox6.Location = new System.Drawing.Point(16, 572);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1494, 211);
            this.groupBox6.TabIndex = 56;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İrtifa";
            // 
            // textGyBoylam
            // 
            this.textGyBoylam.BackColor = System.Drawing.SystemColors.Menu;
            this.textGyBoylam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGyBoylam.Location = new System.Drawing.Point(213, 450);
            this.textGyBoylam.Margin = new System.Windows.Forms.Padding(4);
            this.textGyBoylam.Name = "textGyBoylam";
            this.textGyBoylam.Size = new System.Drawing.Size(65, 15);
            this.textGyBoylam.TabIndex = 26;
            this.textGyBoylam.Text = "0";
            // 
            // textGyEnlem
            // 
            this.textGyEnlem.BackColor = System.Drawing.SystemColors.Menu;
            this.textGyEnlem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGyEnlem.Location = new System.Drawing.Point(213, 413);
            this.textGyEnlem.Margin = new System.Windows.Forms.Padding(4);
            this.textGyEnlem.Name = "textGyEnlem";
            this.textGyEnlem.Size = new System.Drawing.Size(65, 15);
            this.textGyEnlem.TabIndex = 24;
            this.textGyEnlem.Text = "0";
            this.textGyEnlem.TextChanged += new System.EventHandler(this.textGyEnlem_TextChanged);
            // 
            // textGyIrtifa
            // 
            this.textGyIrtifa.BackColor = System.Drawing.SystemColors.Menu;
            this.textGyIrtifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textGyIrtifa.Location = new System.Drawing.Point(213, 380);
            this.textGyIrtifa.Margin = new System.Windows.Forms.Padding(4);
            this.textGyIrtifa.Name = "textGyIrtifa";
            this.textGyIrtifa.Size = new System.Drawing.Size(65, 15);
            this.textGyIrtifa.TabIndex = 22;
            this.textGyIrtifa.Text = "0";
            this.textGyIrtifa.TextChanged += new System.EventHandler(this.textGyIrtifa_TextChanged);
            // 
            // textEnlem
            // 
            this.textEnlem.BackColor = System.Drawing.SystemColors.Menu;
            this.textEnlem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEnlem.Location = new System.Drawing.Point(213, 263);
            this.textEnlem.Margin = new System.Windows.Forms.Padding(4);
            this.textEnlem.Name = "textEnlem";
            this.textEnlem.Size = new System.Drawing.Size(65, 15);
            this.textEnlem.TabIndex = 18;
            this.textEnlem.Text = "0";
            this.textEnlem.TextChanged += new System.EventHandler(this.textEnlem_TextChanged);
            // 
            // textCrc
            // 
            this.textCrc.BackColor = System.Drawing.SystemColors.Menu;
            this.textCrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCrc.Location = new System.Drawing.Point(465, 451);
            this.textCrc.Margin = new System.Windows.Forms.Padding(4);
            this.textCrc.Name = "textCrc";
            this.textCrc.Size = new System.Drawing.Size(102, 15);
            this.textCrc.TabIndex = 50;
            this.textCrc.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textCrc);
            this.groupBox3.Controls.Add(this.textEnlem);
            this.groupBox3.Controls.Add(this.textJX);
            this.groupBox3.Controls.Add(this.textJY);
            this.groupBox3.Controls.Add(this.textJZ);
            this.groupBox3.Controls.Add(this.textIvmeX);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textIvmeY);
            this.groupBox3.Controls.Add(this.textIvmeZ);
            this.groupBox3.Controls.Add(this.textAçi);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textTakımID);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textIrtifa);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textDurum);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.textSayac);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textGyIrtifa);
            this.groupBox3.Controls.Add(this.textGyEnlem);
            this.groupBox3.Controls.Add(this.textGyBoylam);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textGpsIrtf);
            this.groupBox3.Controls.Add(this.textBoylam);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(159, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(604, 551);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gelen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.button9);
            this.groupBox7.Controls.Add(this.button8);
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Location = new System.Drawing.Point(1234, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(276, 551);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Faydalı Yük";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Görev Yükü Nem:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Görev Yükü Sıcaklık:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Görev Yükü Basınç:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(176, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 15);
            this.textBox4.TabIndex = 62;
            this.textBox4.Text = "0";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(176, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 15);
            this.textBox3.TabIndex = 61;
            this.textBox3.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(176, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 15);
            this.textBox1.TabIndex = 60;
            this.textBox1.Text = "0";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(148, 56);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 44);
            this.button9.TabIndex = 59;
            this.button9.Text = "Fotoğraf Al";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_ClickAsync);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(19, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 44);
            this.button8.TabIndex = 58;
            this.button8.Text = "Port Ayarlar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 795);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTakımID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label textSayac;
        private System.Windows.Forms.TextBox textIrtifa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textGpsIrtf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoylam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textJY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textJX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textDurum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textAçi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textIvmeZ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textIvmeY;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textIvmeX;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textJZ;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private GMap.NET.WindowsForms.GMapControl map2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textGyBoylam;
        private System.Windows.Forms.TextBox textGyEnlem;
        private System.Windows.Forms.TextBox textGyIrtifa;
        private System.Windows.Forms.TextBox textEnlem;
        private System.Windows.Forms.TextBox textCrc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort3;
    }
}

