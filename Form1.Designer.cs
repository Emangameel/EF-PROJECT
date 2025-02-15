namespace FinalLinq
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label4 = new Label();
            txt_confirmpass = new TextBox();
            label5 = new Label();
            cb_checkpass = new CheckBox();
            txt_email = new TextBox();
            label6 = new Label();
            txt_phone = new TextBox();
            label3 = new Label();
            btn_register = new Button();
            btn_clear = new Button();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(101, 21);
            label1.Name = "label1";
            label1.Size = new Size(257, 54);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(101, 101);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.Gainsboro;
            txt_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.ForeColor = SystemColors.ControlText;
            txt_username.Location = new Point(101, 132);
            txt_username.MaxLength = 36767;
            txt_username.MinimumSize = new Size(50, 20);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(272, 30);
            txt_username.TabIndex = 2;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.Gainsboro;
            txt_password.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_password.ForeColor = SystemColors.ControlText;
            txt_password.Location = new Point(98, 207);
            txt_password.MaxLength = 36767;
            txt_password.MinimumSize = new Size(50, 20);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(275, 30);
            txt_password.TabIndex = 5;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(98, 176);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txt_confirmpass
            // 
            txt_confirmpass.BackColor = Color.Gainsboro;
            txt_confirmpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_confirmpass.ForeColor = SystemColors.ControlText;
            txt_confirmpass.Location = new Point(98, 281);
            txt_confirmpass.MaxLength = 36767;
            txt_confirmpass.MinimumSize = new Size(50, 20);
            txt_confirmpass.Name = "txt_confirmpass";
            txt_confirmpass.PasswordChar = '*';
            txt_confirmpass.Size = new Size(275, 30);
            txt_confirmpass.TabIndex = 7;
            txt_confirmpass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(98, 250);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 6;
            label5.Text = "Confirm Password";
            // 
            // cb_checkpass
            // 
            cb_checkpass.AutoSize = true;
            cb_checkpass.Cursor = Cursors.Hand;
            cb_checkpass.FlatStyle = FlatStyle.Flat;
            cb_checkpass.Location = new Point(243, 314);
            cb_checkpass.Name = "cb_checkpass";
            cb_checkpass.Size = new Size(130, 24);
            cb_checkpass.TabIndex = 8;
            cb_checkpass.Text = "Show password";
            cb_checkpass.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.Gainsboro;
            txt_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_email.ForeColor = SystemColors.ActiveCaptionText;
            txt_email.Location = new Point(101, 355);
            txt_email.MaxLength = 36767;
            txt_email.MinimumSize = new Size(50, 20);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(272, 30);
            txt_email.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.AppWorkspace;
            label6.Location = new Point(101, 324);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.Gainsboro;
            txt_phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_phone.ForeColor = SystemColors.ControlText;
            txt_phone.Location = new Point(101, 427);
            txt_phone.MaxLength = 36767;
            txt_phone.MinimumSize = new Size(50, 20);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(272, 30);
            txt_phone.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(101, 396);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 11;
            label3.Text = "Phone number";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Indigo;
            btn_register.FlatAppearance.BorderSize = 0;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = Color.GhostWhite;
            btn_register.Location = new Point(126, 485);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(232, 45);
            btn_register.TabIndex = 13;
            btn_register.Text = "REGISTER";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.BlueViolet;
            btn_clear.Location = new Point(126, 550);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(232, 43);
            btn_clear.TabIndex = 14;
            btn_clear.Text = "CLEAR";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(119, 614);
            label7.Name = "label7";
            label7.Size = new Size(254, 28);
            label7.TabIndex = 15;
            label7.Text = "Already have an account?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.MediumPurple;
            label8.Location = new Point(175, 652);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 16;
            label8.Text = "Back to login";
            label8.Click += label8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(494, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(532, 719);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_clear);
            Controls.Add(btn_register);
            Controls.Add(txt_phone);
            Controls.Add(label3);
            Controls.Add(txt_email);
            Controls.Add(label6);
            Controls.Add(cb_checkpass);
            Controls.Add(txt_confirmpass);
            Controls.Add(label5);
            Controls.Add(txt_password);
            Controls.Add(label4);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label4;
        private TextBox txt_confirmpass;
        private Label label5;
        private CheckBox cb_checkpass;
        private TextBox txt_email;
        private Label label6;
        private TextBox txt_phone;
        private Label label3;
        private Button btn_register;
        private Button btn_clear;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}
