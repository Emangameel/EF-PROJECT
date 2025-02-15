using FinalLinq.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace FinalLinq
{
    public partial class Form1 : Form
    {
        ToysContext toysContext;
        //string pattern = @"^(010|011|012|015)\d{8}$";
        //string Emailpattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        public Form1()
        {
            InitializeComponent();
            toysContext = new ToysContext();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            string confirmPassword = txt_confirmpass.Text.Trim();
            string email = txt_email.Text.Trim();
            string phone = txt_phone.Text.Trim();

            UserManager userService = new UserManager(); // Create an instance of UserService

            if (userService.RegisterUser(username, password, confirmPassword, email, phone))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log_in log=new Log_in();
                log.Show();
                this.Hide();
            }
            //else
            //{
            //    MessageBox.Show("Registration failed. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Log_in log = new Log_in();
            log.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_confirmpass.Text = "";
            txt_email.Text = "";
            txt_password.Text = "";
            txt_phone.Text = "";
            txt_username.Text = "";
        }
    }
}
