using S7.Net;
using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace TEST_FORM
{

    public partial class Select_PLC : Form
    {
        private string login_username;
        private string PLC_IP;
        private short rack;
        private short slot;
        private string plc_type;
        public Select_PLC(string username)
        {
            InitializeComponent();
            login_username = username;
            ip.Text = "192.168.10.1"; //default value

            cmbCpuType.DisplayMember = "Name";
            cmbCpuType.ValueMember = "Value";

            cmbCpuType.Items.Add(new CpuItem()
            {
                Name = "Siemens S7-200",
                Value = CpuType.S7200
            });

            cmbCpuType.Items.Add(new CpuItem()
            {
                Name = "Siemens S7-300",
                Value = CpuType.S7300
            });

            cmbCpuType.Items.Add(new CpuItem()
            {
                Name = "Siemens S7-400",
                Value = CpuType.S7400
            });

            cmbCpuType.Items.Add(new CpuItem()
            {
                Name = "Siemens S7-1200",
                Value = CpuType.S71200
            });

            cmbCpuType.Items.Add(new CpuItem()
            {
                Name = "Siemens S7-1500",
                Value = CpuType.S71500
            });

            cmbCpuType.SelectedIndex = 4;
            tbRack.Text = "0";
            tbSlot.Text = "1";

        }
        public class CpuItem
        {
            public string Name { get; set; }
            public CpuType Value { get; set; }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            label1.Text = "welcome Mr: " + login_username;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PLC_IP = ip.Text;

            if (!IPAddress.TryParse(PLC_IP, out _))
            {
                MessageBox.Show("Invalid IP Address.");
                ip.Text = "";
                ip.Focus();
                label8.Text = "Entered IP Adress isnt valid";
                label8.ForeColor = Color.Red;
                label8.Visible = true;
                return;
            }

            Ping ping = new Ping();

            try
            {
                PingReply reply = ping.Send(PLC_IP, 1000);

                if (reply.Status == IPStatus.Success)
                {
                    MessageBox.Show(
                        $"PLC Reachable!\nLatency: {reply.RoundtripTime} ms", "PLC PING INFO");

                    label8.Text = "PLC IP TEST PASS";
                    label8.ForeColor = Color.Green;
                    label8.Visible = true;

                    ip.Enabled = false;
                    cheak_ip.Enabled = false;

                    label3.Visible = true;
                    cmbCpuType.Visible = true;

                    label6.Visible = true;
                    tbRack.Visible = true;

                    label7.Visible = true;
                    tbSlot.Visible = true;

                    conn_plc.Visible = true;

                }
                else
                {
                    MessageBox.Show("PLC IP is not reachable.", "PLC PING INFO");
                    label8.Text = "PLC IP TEST FAIL";
                    label8.ForeColor = Color.Red;
                    label8.Visible = true;
                    ip.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void conn_plc_Click(object sender, EventArgs e)
        {
            rack = short.Parse(tbRack.Text);
            slot = short.Parse(tbSlot.Text);
            CpuType cpu = ((CpuItem)cmbCpuType.SelectedItem).Value;
            plc_type = ((CpuItem)cmbCpuType.SelectedItem).Name;

            try
            {
                Plc plc = new Plc(cpu, PLC_IP, rack, slot);
                plc.Open();

                if (plc.IsConnected)
                {
                    MessageBox.Show("Connection Successsful to plc at:" + PLC_IP, "Connection Status");
                    Dashboard f3 = new Dashboard(login_username, PLC_IP, plc_type, rack.ToString(), slot.ToString(), plc);
                    this.Hide();
                    f3.Show();
                    f3.FormClosed += DashboardClosed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CONNECTING PLC: " + ex, "Critical Error");
            }
        }
        private void DashboardClosed(object sender, EventArgs e)
        {
            this.Close();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }

}
