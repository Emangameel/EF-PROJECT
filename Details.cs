using FinalLinq.Models;
using Microsoft.Data.SqlClient;
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
    public partial class Details : Form
    {
        ToysContext context;
        public Details()
        {
            InitializeComponent();
            context = new ToysContext();
        }

        private void Details_Load(object sender, EventArgs e)
        {

            var cartItems = context.Orders
.Where(s => s.userId == UserManager.LoggedInUserId)
.SelectMany(o => o.orderDetails.Select(d => new
{
    d.ToyId,
    d.toys.ToyName,
    d.toys.Price,
    d.toys.Stock,
    d.toys.Category,
    d.toys.categoryId
}))
.ToList();

            var totalPrice = cartItems.Any() ? cartItems.Sum(s => s.Price) : 0;
            var totalCount = cartItems.Count();

            // تحديث الـ Labels
            lbl_price.Text = $"Price : {totalPrice} $";
            lbl_num.Text = $"Num Of items: {totalCount}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been placed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store s=new Store();
            s.Show();
            this.Hide();
        }
    }
}
