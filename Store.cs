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
    public partial class Store : Form
    {
        int id;
        public Store()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheToys toys = new TheToys();
            toys.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart(id);
            cart.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details
                .Show();
            this.Hide();
        }
    }
}
