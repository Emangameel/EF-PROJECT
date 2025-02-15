using FinalLinq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLinq
{
    public partial class Log_in : Form
    {
       
        public Log_in()
        {
            InitializeComponent();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new ToysContext()) 
            {
               
                var user = db.Users.FirstOrDefault(u => u.Name == name && u.Password == password);
                if (user != null)
                {
                   UserManager.LoggedInUserId = user.Id;
                  //  MessageBox.Show("Log in successful"," ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Between betweenForm = new Between(user.Id, user.Name, user.Password, user.PhoneNumber, user.Email);
                    betweenForm.Show();
                    this.Hide();
                }
                
                else
                {
                    MessageBox.Show("Passowrd or email is not right ","try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_password.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
