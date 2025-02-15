using FinalLinq.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinalLinq
{
    public partial class TheToys : Form
    {
        int id;
        ToysContext context;
        private Cart cart;
        public TheToys()
        {
            context = new ToysContext();
            InitializeComponent();
        }

        private void TheToys_Load(object sender, EventArgs e)
        {
            dgv_toys.DataSource = context.Toys
        .Select(t => new
        {
            t.ToyId,  
            t.ToyName,
            t.Price,
            t.Category,
            t.Stock
        }).ToList();
        }

        private void dgv_toys_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Store st = new Store();
            st.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgv_toys_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgv_toys.SelectedRows[0].Cells["ToyId"].Value);
            string toyName = dgv_toys.SelectedRows[0].Cells["ToyName"].Value.ToString();
            decimal price = Convert.ToDecimal(dgv_toys.SelectedRows[0].Cells["Price"].Value);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                // Get the Toy details from the context using the selected ToyId
                Toys toy = context.Toys.Where(n => n.ToyId == id).SingleOrDefault();
                if (toy != null)
                {
                    // Check if an order already exists for the logged-in user
                    var existingOrder = context.Orders
                        .FirstOrDefault(o => o.userId == UserManager.LoggedInUserId ); // Assuming "Pending" means active

                    if (existingOrder == null)
                    {
                        // Create a new order if no active order exists
                        existingOrder = new Orders
                        {
                            userId = UserManager.LoggedInUserId,
                            CustomerName = txt_customername.Text,
                            orderDetails = new List<OrderDetails>()
                        };

                        context.Orders.Add(existingOrder);
                    }

                    // Add the toy to the order's order details
                    OrderDetails newOrderDetail = new OrderDetails()
                    {
                        ToyId = toy.ToyId,
                        OrderId = existingOrder.OrderId
                    };

                    existingOrder.orderDetails.Add(newOrderDetail);
                    context.SaveChanges();
                    MessageBox.Show("Toy added to the cart!");
                }
                else
                {
                    MessageBox.Show("Toy not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a toy first.");
            }
        }
        
        private void dgv_cart_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dgv_toys.Rows[e.RowIndex].Cells["ToyId"].Value);
            }

        }
             
    
    }

}

    
