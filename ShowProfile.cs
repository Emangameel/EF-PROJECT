using Dapper;
using FinalLinq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLinq
{
    public partial class ShowProfile : Form
    {
        int id;
        ToysContext context;

        private string userName;
        private string password;
        private string email;
        private string phone;
        SqlConnection con;
        public ShowProfile(int id, string userName, string password, string phone, string email)
        {
            con = new SqlConnection("Server = EMAN\\SQLEXPRESS; Database = ToysStore; Trusted_Connection = True; Trust Server Certificate = True");
            InitializeComponent();
            context = new ToysContext();
            this.id = id;
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.phone = phone;
            context.SaveChanges();
        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
            var q1 = con.Query($"select * from Users  where Id={id}").SingleOrDefault();
            txt_name.Text = userName;
            txt_password.Text = password;
            txt_phone.Text = phone;
            txt_email.Text = email;
            context.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile(id, userName, password, phone, email);
            editProfile.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Between b=new Between(UserManager.LoggedInUserId,userName,password,phone,email);
            b.Show();
            this.Hide();
        }
    }
}
