namespace FinalLinq
{
    partial class Details
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
            lbl_num = new Label();
            lbl_price = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbl_num
            // 
            lbl_num.AutoSize = true;
            lbl_num.BackColor = Color.Transparent;
            lbl_num.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_num.ForeColor = Color.Yellow;
            lbl_num.Location = new Point(27, 88);
            lbl_num.Name = "lbl_num";
            lbl_num.Size = new Size(357, 37);
            lbl_num.TabIndex = 0;
            lbl_num.Text = "Number or items :";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.BackColor = Color.Transparent;
            lbl_price.Font = new Font("Courier New", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_price.ForeColor = Color.Yellow;
            lbl_price.Location = new Point(21, 161);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(157, 37);
            lbl_price.TabIndex = 1;
            lbl_price.Text = "Price :";
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(245, 304);
            button1.Name = "button1";
            button1.Size = new Size(139, 45);
            button1.TabIndex = 2;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__8_;
            pictureBox1.Location = new Point(635, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__7_;
            pictureBox2.Location = new Point(-1, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(669, 435);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lbl_price);
            Controls.Add(lbl_num);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details";
            Load += Details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_num;
        private Label lbl_price;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}