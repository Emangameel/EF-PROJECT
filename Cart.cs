using Castle.Components.DictionaryAdapter.Xml;
using FinalLinq.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLinq
{
    public partial class Cart : Form
    {
        int id;

        ToysContext context;
        public Cart(int id)
        {
            this.id = id;
            context = new ToysContext();
            InitializeComponent();
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            // Fetch orders and their details for the logged-in user
            var cartItems = context.Orders
                .Where(s => s.userId == UserManager.LoggedInUserId)  // Filter by user
                .SelectMany(o => o.orderDetails.Select(d => new
                {
                    d.ToyId,             // Toy ID
                    d.toys.ToyName,      // Toy Name
                    d.toys.Price,        // Toy Price
                    d.toys.Stock,        // Toy Stock
                    d.toys.Category,     // Toy Category
                    d.toys.categoryId    // Toy Category ID
                }))
                .ToList();

            // Set the DataSource for DataGridView
            dgv_cart.DataSource = cartItems;

            // Calculate total price and count of items in the cart
            var totalPrice = cartItems.Sum(s => s.Price);
            var totalCount = cartItems.Count();

          //  Optionally, update the UI elements like labels(total and count)
            lbl_total.Text = $"Total Cost : {totalPrice} $";
            lbl_count.Text = $"Num Of products In Cart : {totalCount}";

            // Optionally, hide the first column (ToyId) in the DataGridView
            dgv_cart.Columns[0].Visible = false;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private List<Toys> cartList = new List<Toys>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            // البحث عن العنصر في OrderDetails بناءً على ToyId و UserId
            var orderDetail = context.OrderDetails
                .FirstOrDefault(od => od.ToyId == id && od.orders.OrderId == context.Orders
                .Where(o => o.userId == UserManager.LoggedInUserId)
                .Select(o => o.OrderId)
                .FirstOrDefault());

            if (orderDetail != null)
            {
                context.OrderDetails.Remove(orderDetail); // حذف العنصر من OrderDetails
                context.SaveChanges(); // حفظ التغييرات

                MessageBox.Show("Item removed from cart.");

                LoadCart(); // تحديث الـ DataGridView بعد الحذف
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
                lbl_total.Text = $"Total Cost : {totalPrice} $";
                lbl_count.Text = $"Num Of Products In Cart : {totalCount}";
            }
            else
            {
                MessageBox.Show("Item not found in cart.");
            }

            id = 0; // إعادة تعيين ID بعد الحذف
        }

        private void LoadCart()
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

            dgv_cart.DataSource = cartItems;

            var totalPrice = cartItems.Sum(s => s.Price);
            var totalCount = cartItems.Count();

            // تحديث الـ Labels إذا كنت تستخدمها
            lbl_total.Text = $"Total Cost : {totalPrice} $";
            lbl_count.Text = $"Num Of products In Cart : {totalCount}";

            dgv_cart.Columns[0].Visible = false; // إخفاء عمود الـ ID
        }

        private void dgv_cart_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgv_cart.Rows[e.RowIndex].Cells["ToyId"].Value);

            // Optionally, get the other toy details if needed (though they might be added to cart directly)
            string toyName = dgv_cart.SelectedRows[0].Cells["ToyName"].Value.ToString();

            decimal price = Convert.ToDecimal(dgv_cart.SelectedRows[0].Cells["Price"].Value);
            //dgv_cart.Rows[1].Cells["ToyId"].Style.BackColor = Color.Yellow;
            //dgv_cart.Rows[1].Cells["ToyName"].Style.BackColor = Color.Yellow;
            //dgv_cart.Rows[1].Cells["Price"].Style.BackColor = Color.Yellow;
            //dgv_cart.Rows[1].Cells["Stock"].Style.BackColor = Color.Yellow;
            //dgv_cart.Rows[1].Cells["CategoryId"].Style.BackColor = Color.Yellow;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Store s=new Store();
            s.Show();
            this .Hide ();
        }
    }
}