using System;
using System.Windows.Forms;

namespace TEST_FORM
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "Admin" && password == "1234")
            {
                MessageBox.Show("login successfull", "Login");
                Select_PLC f2 = new Select_PLC(username);
                this.Hide();
                f2.Show();
                f2.FormClosed += Select_plc_close;

            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Login");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void Select_plc_close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd/MMMM/yyyy");
            time.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
