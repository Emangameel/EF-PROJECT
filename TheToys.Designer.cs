namespace FinalLinq
{
    partial class TheToys
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            dgv_toys = new DataGridView();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            txt_customername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_toys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__2_1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__8_;
            pictureBox2.Location = new Point(759, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dgv_toys
            // 
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = Color.Purple;
            dgv_toys.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_toys.BackgroundColor = Color.Indigo;
            dgv_toys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_toys.Dock = DockStyle.Bottom;
            dgv_toys.Location = new Point(0, 269);
            dgv_toys.Name = "dgv_toys";
            dgv_toys.RowHeadersWidth = 51;
            dgv_toys.Size = new Size(800, 238);
            dgv_toys.TabIndex = 3;
            dgv_toys.RowHeaderMouseDoubleClick += dgv_toys_RowHeaderMouseDoubleClick_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(497, 111);
            button1.Name = "button1";
            button1.Size = new Size(159, 44);
            button1.TabIndex = 8;
            button1.Text = "Add to cart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download__3_;
            pictureBox3.Location = new Point(648, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // txt_customername
            // 
            txt_customername.Location = new Point(46, 0);
            txt_customername.Name = "txt_customername";
            txt_customername.Size = new Size(10, 27);
            txt_customername.TabIndex = 10;
            // 
            // TheToys
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 507);
            Controls.Add(txt_customername);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(dgv_toys);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TheToys";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TheToys";
            Load += TheToys_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_toys).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private DataGridView dgv_toys;
        private Button button1;
        private PictureBox pictureBox3;
        private TextBox txt_customername;
    }
}