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
    public partial class EditProfile : Form
    {
        int id;
        ToysContext ToysContext;
        private string userName;
        private string password;
        private string email;
        private string phone;
        public EditProfile(int idd, string username, string pass, string phone, string email)
        {
            InitializeComponent();
            ToysContext = new ToysContext();
            this.id = idd;
            this.userName = username;
            this.password = pass;
            this.email = email;
            this.phone = phone;

        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            txt_name.Text = userName;
            txt_password.Text = password;
            txt_phone.Text = phone;
            txt_email.Text = email;
            ToysContext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var db = new ToysContext()) // Ensure proper context usage
                {
                    var s = db.Users.SingleOrDefault(n => n.Id == id); // Find user by ID
                    // Update user information
                    s.Name = txt_name.Text.Trim();
                    s.PhoneNumber = txt_phone.Text.Trim();
                    s.Email = email;
                    s.Password = password;
                    db.SaveChanges(); // Save changes to the database

                    MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Between b=new Between(UserManager.LoggedInUserId, userName, password, phone, email);
            b.Show();
            this.Hide();
        }
    }
}