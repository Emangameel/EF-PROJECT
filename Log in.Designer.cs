namespace FinalLinq
{
    partial class Log_in
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
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            btn_login = new Button();
            txt_password = new TextBox();
            label4 = new Label();
            txt_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumPurple;
            label8.Location = new Point(138, 441);
            label8.Name = "label8";
            label8.Size = new Size(154, 28);
            label8.TabIndex = 32;
            label8.Text = "Create account";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(96, 403);
            label7.Name = "label7";
            label7.Size = new Size(233, 28);
            label7.TabIndex = 31;
            label7.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(89, 339);
            button1.Name = "button1";
            button1.Size = new Size(232, 43);
            button1.TabIndex = 30;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Indigo;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.GhostWhite;
            btn_login.Location = new Point(89, 274);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(232, 45);
            btn_login.TabIndex = 29;
            btn_login.Text = "LOG IN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gainsboro;
            txt_password.ForeColor = SystemColors.Desktop;
            txt_password.Location = new Point(77, 211);
            txt_password.MaxLength = 36767;
            txt_password.MinimumSize = new Size(50, 20);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(275, 30);
            txt_password.TabIndex = 21;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(77, 180);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 20;
            label4.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.Gainsboro;
            txt_username.ForeColor = SystemColors.Desktop;
            txt_username.Location = new Point(80, 136);
            txt_username.MaxLength = 36767;
            txt_username.MinimumSize = new Size(50, 20);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(272, 30);
            txt_username.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(80, 105);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 18;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(80, 25);
            label1.Name = "label1";
            label1.Size = new Size(257, 54);
            label1.TabIndex = 17;
            label1.Text = "Get Started";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(404, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 603);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Log_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_in";
            Load += Log_in_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Button button1;
        private Button btn_login;
        private TextBox txt_password;
        private Label label4;
        private TextBox txt_username;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}