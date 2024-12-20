﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4POBKTS;Initial Catalog=LoginDb;Integrated Security=True");
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (first_name.Text != "" && l_name.Text != "" && date.Text != "" &&
                    gender.Text != "" && address.Text != "" && email.Text != "" &&
                    password.Text != "" && con_password.Text != "")
                {
                    if (password.Text == con_password.Text)
                    {
                        int v = check(email.Text);
                        if (v != 1)
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(
                                "INSERT INTO RegistrationTbl (first_name, l_name, b_date, gender, address, email, password) " +
                                "VALUES (@first_name, @l_name, @b_date, @gender, @address, @email, @Password)",
                                connection);

                            command.Parameters.AddWithValue("first_name", first_name.Text);
                            command.Parameters.AddWithValue("@l_name", l_name.Text);
                            command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(date.Text));
                            command.Parameters.AddWithValue("@gender", gender.Text);
                            command.Parameters.AddWithValue("@address", address.Text);
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@Password", password.Text);

                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("You have successfully registered!");
                            first_name.Text = "";
                            l_name.Text = "";
                            gender.Text = "";
                            email.Text = "";
                            password.Text = "";
                            con_password.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You have already registered!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match.");
                    }
                }
                else
                {
                    MessageBox.Show("Fill in all the blanks.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int check(string email)
        {
            connection.Open();
            string query = "select count(*) from RegistrationTbl where email ='" + email + "'";
            SqlCommand command = new SqlCommand(query, connection); 
            int v = (int)command.ExecuteScalar();
            connection.Close();
            return v;



        }

        private void check_pass_CheckedChanged(object sender, EventArgs e)
        {
            if(check_pass.Checked)
            {
                password.UseSystemPasswordChar = false;
                con_password.UseSystemPasswordChar=false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                con_password.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void con_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void first_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
