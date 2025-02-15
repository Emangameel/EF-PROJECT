namespace FinalLinq
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_cart = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_total = new Label();
            lbl_count = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_cart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgv_cart
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 128);
            dataGridViewCellStyle1.SelectionForeColor = Color.Purple;
            dgv_cart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_cart.BackgroundColor = Color.Indigo;
            dgv_cart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cart.Dock = DockStyle.Bottom;
            dgv_cart.Location = new Point(0, 286);
            dgv_cart.Name = "dgv_cart";
            dgv_cart.RowHeadersWidth = 51;
            dgv_cart.Size = new Size(769, 241);
            dgv_cart.TabIndex = 0;
            dgv_cart.RowHeaderMouseDoubleClick += dgv_cart_RowHeaderMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__8_;
            pictureBox1.Location = new Point(726, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(517, 114);
            button1.Name = "button1";
            button1.Size = new Size(121, 44);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(264, 25);
            label1.Name = "label1";
            label1.Size = new Size(185, 48);
            label1.TabIndex = 3;
            label1.Text = "My Cart";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__2_1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download__3_;
            pictureBox3.Location = new Point(629, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.BackColor = Color.Transparent;
            lbl_total.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_total.ForeColor = Color.Yellow;
            lbl_total.Location = new Point(12, 98);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(117, 37);
            lbl_total.TabIndex = 11;
            lbl_total.Text = "Total";
            // 
            // lbl_count
            // 
            lbl_count.AutoSize = true;
            lbl_count.BackColor = Color.Transparent;
            lbl_count.Font = new Font("Courier New", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_count.ForeColor = Color.Yellow;
            lbl_count.Location = new Point(12, 150);
            lbl_count.Name = "lbl_count";
            lbl_count.Size = new Size(99, 31);
            lbl_count.TabIndex = 12;
            lbl_count.Text = "Count";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(769, 527);
            Controls.Add(lbl_count);
            Controls.Add(lbl_total);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dgv_cart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_cart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_cart;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_total;
        private Label lbl_count;
    }
}