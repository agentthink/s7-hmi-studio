namespace TEST_FORM
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Date_N_Time = new System.Windows.Forms.Timer(this.components);
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbCPUtype = new System.Windows.Forms.Label();
            this.lbPLCip = new System.Windows.Forms.Label();
            this.lbPLCrack = new System.Windows.Forms.Label();
            this.lbPLCslot = new System.Windows.Forms.Label();
            this.lbPLCStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.Controls_pannel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PIC_lamp_status = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblOutputs = new System.Windows.Forms.Label();
            this.lblCommands = new System.Windows.Forms.Label();
            this.Outputs_Pooling = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Controls_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_lamp_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.time.Location = new System.Drawing.Point(657, 33);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 16);
            this.time.TabIndex = 20;
            this.time.Text = "current time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(657, 6);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(73, 16);
            this.date.TabIndex = 19;
            this.date.Text = "curent date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 1);
            this.panel1.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(-1, 63);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(783, 1);
            this.panel5.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(-1, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(783, 1);
            this.panel7.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-1, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 1);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 46);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dashboard";
            // 
            // Date_N_Time
            // 
            this.Date_N_Time.Enabled = true;
            this.Date_N_Time.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(12, 96);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 22);
            this.lbUsername.TabIndex = 21;
            this.lbUsername.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "PLC Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Welcome";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuText;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(-1, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(783, 1);
            this.panel4.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(0, 125);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(782, 1);
            this.panel8.TabIndex = 24;
            // 
            // lbCPUtype
            // 
            this.lbCPUtype.AutoSize = true;
            this.lbCPUtype.Location = new System.Drawing.Point(169, 85);
            this.lbCPUtype.Name = "lbCPUtype";
            this.lbCPUtype.Size = new System.Drawing.Size(73, 16);
            this.lbCPUtype.TabIndex = 25;
            this.lbCPUtype.Text = "CPU Type:";
            // 
            // lbPLCip
            // 
            this.lbPLCip.AutoSize = true;
            this.lbPLCip.Location = new System.Drawing.Point(169, 105);
            this.lbPLCip.Name = "lbPLCip";
            this.lbPLCip.Size = new System.Drawing.Size(50, 16);
            this.lbPLCip.TabIndex = 26;
            this.lbPLCip.Text = "PLC IP:";
            // 
            // lbPLCrack
            // 
            this.lbPLCrack.AutoSize = true;
            this.lbPLCrack.Location = new System.Drawing.Point(401, 85);
            this.lbPLCrack.Name = "lbPLCrack";
            this.lbPLCrack.Size = new System.Drawing.Size(70, 16);
            this.lbPLCrack.TabIndex = 27;
            this.lbPLCrack.Text = "PLC Rack:";
            // 
            // lbPLCslot
            // 
            this.lbPLCslot.AutoSize = true;
            this.lbPLCslot.Location = new System.Drawing.Point(401, 105);
            this.lbPLCslot.Name = "lbPLCslot";
            this.lbPLCslot.Size = new System.Drawing.Size(61, 16);
            this.lbPLCslot.TabIndex = 28;
            this.lbPLCslot.Text = "PLC Slot:";
            // 
            // lbPLCStatus
            // 
            this.lbPLCStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPLCStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPLCStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbPLCStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPLCStatus.Location = new System.Drawing.Point(508, 66);
            this.lbPLCStatus.Name = "lbPLCStatus";
            this.lbPLCStatus.Size = new System.Drawing.Size(146, 50);
            this.lbPLCStatus.TabIndex = 29;
            this.lbPLCStatus.Text = "Status";
            this.lbPLCStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Controls:";
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnShutdown.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShutdown.Location = new System.Drawing.Point(660, 63);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(110, 55);
            this.btnShutdown.TabIndex = 35;
            this.btnShutdown.Text = "Shutdown system";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // Controls_pannel
            // 
            this.Controls_pannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls_pannel.Controls.Add(this.label6);
            this.Controls_pannel.Controls.Add(this.label5);
            this.Controls_pannel.Controls.Add(this.PIC_lamp_status);
            this.Controls_pannel.Controls.Add(this.button2);
            this.Controls_pannel.Controls.Add(this.button1);
            this.Controls_pannel.Controls.Add(this.panel9);
            this.Controls_pannel.Controls.Add(this.lblOutputs);
            this.Controls_pannel.Controls.Add(this.lblCommands);
            this.Controls_pannel.Location = new System.Drawing.Point(26, 157);
            this.Controls_pannel.Name = "Controls_pannel";
            this.Controls_pannel.Size = new System.Drawing.Size(743, 256);
            this.Controls_pannel.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "running_sts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lamp status (%Q0.0)";
            // 
            // PIC_lamp_status
            // 
            this.PIC_lamp_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PIC_lamp_status.ErrorImage = global::TEST_FORM.Properties.Resources.lamp_error;
            this.PIC_lamp_status.Location = new System.Drawing.Point(174, 119);
            this.PIC_lamp_status.Name = "PIC_lamp_status";
            this.PIC_lamp_status.Size = new System.Drawing.Size(130, 130);
            this.PIC_lamp_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_lamp_status.TabIndex = 5;
            this.PIC_lamp_status.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "%M0.1 OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(172, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "%M0.1 ON";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel9.Location = new System.Drawing.Point(10, 112);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(719, 1);
            this.panel9.TabIndex = 2;
            // 
            // lblOutputs
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.Location = new System.Drawing.Point(12, 132);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(67, 16);
            this.lblOutputs.TabIndex = 1;
            this.lblOutputs.Text = "OUTPUT:";
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.Location = new System.Drawing.Point(12, 12);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(89, 16);
            this.lblCommands.TabIndex = 0;
            this.lblCommands.Text = "COMMANDS:";
            // 
            // Outputs_Pooling
            // 
            this.Outputs_Pooling.Enabled = true;
            this.Outputs_Pooling.Interval = 500;
            this.Outputs_Pooling.Tick += new System.EventHandler(this.Outputs_Pooling_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(498, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1, 59);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.btnShutdown;
            this.ClientSize = new System.Drawing.Size(782, 433);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Controls_pannel);
            this.Controls.Add(this.btnShutdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPLCStatus);
            this.Controls.Add(this.lbPLCslot);
            this.Controls.Add(this.lbPLCrack);
            this.Controls.Add(this.lbPLCip);
            this.Controls.Add(this.lbCPUtype);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.Controls_pannel.ResumeLayout(false);
            this.Controls_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_lamp_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer Date_N_Time;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbCPUtype;
        private System.Windows.Forms.Label lbPLCip;
        private System.Windows.Forms.Label lbPLCrack;
        private System.Windows.Forms.Label lbPLCslot;
        private System.Windows.Forms.Label lbPLCStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Panel Controls_pannel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblOutputs;
        private System.Windows.Forms.Label lblCommands;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PIC_lamp_status;
        private System.Windows.Forms.Timer Outputs_Pooling;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}