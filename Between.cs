using FinalLinq.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalLinq
{
    public partial class Between : Form
    {    
        ToysContext context;
        private int id;
        private string username;
        private string password;
        private string email;
        private string phone;
        public Between(int id, string username, string password, string phone, string email)
        {
            context=new ToysContext();
            InitializeComponent();
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.phone = phone;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowProfile showProfile = new ShowProfile(id, username, password, phone, email);
            showProfile.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Log_in log= new Log_in();
            log.Show();
            this.Hide();
        }
    }
}
