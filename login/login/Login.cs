using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4POBKTS;Initial Catalog=LoginDb;Integrated Security=True");


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;

            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (u_name.Text != "" && password.Text != "")
            {
                string query = "select count(*) from RegistrationTbl where first_name ='" + u_name.Text + "'and password='" + password.Text + "'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                int v = (int)command.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("error username or password");
                }
                else
                {
                    MessageBox.Show("welcome to your profile");
                    u_name.Text = "";
                    password.Text = "";
                }
            }
            else
            {
                MessageBox.Show("fill in this blanks");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }
    }
}
