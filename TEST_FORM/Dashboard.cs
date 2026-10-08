using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_FORM
{
    public partial class Dashboard : Form
    {
        private Plc plc;
        private byte plc_status;
        private bool Q0_1_status;
        public Dashboard(string username, string plc_ip, string plc_type, string plc_rack, string plc_slot, Plc plc)
        {
            InitializeComponent();
            this.plc = plc;
            lbUsername.Text = "User: " + username;
            lbCPUtype.Text = "CPU Type: " + plc_type;
            lbPLCip.Text = "IP: " + plc_ip;
            lbPLCrack.Text = "Rack:" + plc_rack;
            lbPLCslot.Text = "Slot:" + plc_slot;

        }
        private void DashboardClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss tt");
            try
            {
                plc_status = plc.ReadStatus();
                if (plc_status == 0x08)
                {
                    lbPLCStatus.Text = "PLC Online";
                    lbPLCStatus.BackColor = Color.Green;
                }
            }
            catch
            {
                lbPLCStatus.Text = "PLC Offline";
                lbPLCStatus.BackColor = Color.Red;
                Controls_pannel.Enabled = false;
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            plc.Close();
            Application.Exit();
        }

        private void Outputs_Pooling_Tick(object sender, EventArgs e)
        {
            try
            {
                Q0_1_status = (bool)plc.Read("Q0.0");
                if (Q0_1_status)
                {
                    PIC_lamp_status.Image = Properties.Resources.lamp_green;
                    label6.Text = "Running";
                }
                else
                {
                    PIC_lamp_status.Image = Properties.Resources.lamp_red;
                    label6.Text = "Stopped";
                }
            }
            catch {
                PIC_lamp_status.Image = Properties.Resources.lamp_error;
                label6.Text = "Error";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plc.Write("M0.0", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            plc.Write("M0.0", false);
        }


        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                plc.ReadStatus();

                if (plc.IsConnected)
                {
                    plc.Close();
                }
            }
            catch
            {
                // PLC already offline
            }
        }
    }
}
