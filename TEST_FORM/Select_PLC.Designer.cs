namespace TEST_FORM
{
    partial class Select_PLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_PLC));
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.ip = new System.Windows.Forms.TextBox();
            this.conn_plc = new System.Windows.Forms.Button();
            this.tbSlot = new System.Windows.Forms.TextBox();
            this.tbRack = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cheak_ip = new System.Windows.Forms.Button();
            this.cmbCpuType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME ";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(659, 31);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 16);
            this.time.TabIndex = 14;
            this.time.Text = "current time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(659, 4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(73, 16);
            this.date.TabIndex = 13;
            this.date.Text = "curent date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(2, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 1);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "PLC Connection form";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ip);
            this.panel2.Controls.Add(this.conn_plc);
            this.panel2.Controls.Add(this.tbSlot);
            this.panel2.Controls.Add(this.tbRack);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cheak_ip);
            this.panel2.Controls.Add(this.cmbCpuType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 301);
            this.panel2.TabIndex = 15;
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(142, 44);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(190, 22);
            this.ip.TabIndex = 0;
            // 
            // conn_plc
            // 
            this.conn_plc.Location = new System.Drawing.Point(62, 232);
            this.conn_plc.Name = "conn_plc";
            this.conn_plc.Size = new System.Drawing.Size(271, 37);
            this.conn_plc.TabIndex = 2;
            this.conn_plc.Text = "Connect to PLC";
            this.conn_plc.UseVisualStyleBackColor = true;
            this.conn_plc.Visible = false;
            this.conn_plc.Click += new System.EventHandler(this.conn_plc_Click);
            // 
            // tbSlot
            // 
            this.tbSlot.Location = new System.Drawing.Point(142, 199);
            this.tbSlot.Name = "tbSlot";
            this.tbSlot.Size = new System.Drawing.Size(191, 22);
            this.tbSlot.TabIndex = 5;
            this.tbSlot.Visible = false;
            // 
            // tbRack
            // 
            this.tbRack.Location = new System.Drawing.Point(142, 164);
            this.tbRack.Name = "tbRack";
            this.tbRack.Size = new System.Drawing.Size(191, 22);
            this.tbRack.TabIndex = 4;
            this.tbRack.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "IP STATUS";
            this.label8.Visible = false;
            // 
            // cheak_ip
            // 
            this.cheak_ip.Location = new System.Drawing.Point(62, 76);
            this.cheak_ip.Name = "cheak_ip";
            this.cheak_ip.Size = new System.Drawing.Size(271, 31);
            this.cheak_ip.TabIndex = 1;
            this.cheak_ip.Text = "Cheak IP Connection";
            this.cheak_ip.UseVisualStyleBackColor = true;
            this.cheak_ip.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCpuType
            // 
            this.cmbCpuType.BackColor = System.Drawing.Color.White;
            this.cmbCpuType.FormattingEnabled = true;
            this.cmbCpuType.Location = new System.Drawing.Point(142, 131);
            this.cmbCpuType.Name = "cmbCpuType";
            this.cmbCpuType.Size = new System.Drawing.Size(191, 24);
            this.cmbCpuType.TabIndex = 3;
            this.cmbCpuType.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Slot:";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rack:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "IP Address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cpu Type:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Seimens PLC Details:";
            // 
            // Select_PLC
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Select_PLC";
            this.Text = "Select PLC";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCpuType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cheak_ip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbRack;
        private System.Windows.Forms.Button conn_plc;
        private System.Windows.Forms.TextBox tbSlot;
        private System.Windows.Forms.TextBox ip;
    }
}