namespace FinalLinq
{
    partial class Store
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Indigo;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(251, 212);
            button1.Name = "button1";
            button1.Size = new Size(182, 37);
            button1.TabIndex = 1;
            button1.Text = "MY CART";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Indigo;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(251, 129);
            button2.Name = "button2";
            button2.Size = new Size(182, 35);
            button2.TabIndex = 2;
            button2.Text = "TOYS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Indigo;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Yellow;
            button4.Location = new Point(251, 298);
            button4.Name = "button4";
            button4.Size = new Size(182, 44);
            button4.TabIndex = 4;
            button4.Text = "Checkout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(207, 36);
            label1.Name = "label1";
            label1.Size = new Size(282, 41);
            label1.TabIndex = 5;
            label1.Text = "DISNEY STORE";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.download__8_;
            pictureBox2.Location = new Point(651, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Store
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images__8_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(689, 489);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Store";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Label label1;
        private PictureBox pictureBox2;
    }
}