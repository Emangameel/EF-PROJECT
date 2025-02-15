namespace FinalLinq
{
    partial class Between
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
            pictureBox2 = new PictureBox();
            btn_store = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSlateBlue;
            button1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(218, 185);
            button1.Name = "button1";
            button1.Size = new Size(179, 42);
            button1.TabIndex = 0;
            button1.Text = "About me";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.close;
            pictureBox2.Location = new Point(613, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btn_store
            // 
            btn_store.BackColor = Color.MediumSlateBlue;
            btn_store.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_store.ForeColor = Color.AliceBlue;
            btn_store.Location = new Point(218, 254);
            btn_store.Name = "btn_store";
            btn_store.Size = new Size(179, 45);
            btn_store.TabIndex = 3;
            btn_store.Text = "Store";
            btn_store.UseVisualStyleBackColor = false;
            btn_store.Click += btn_store_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download__6_;
            pictureBox3.Location = new Point(-32, 352);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(108, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images__5_;
            pictureBox1.Location = new Point(233, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Between
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(654, 394);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_store);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Between";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Between";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox2;
        private Button btn_store;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}