namespace FinalLinq
{
    partial class ShowProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowProfile));
            pictureBox1 = new PictureBox();
            btn_edit = new Button();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            NAME = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txt_password = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.MediumSlateBlue;
            resources.ApplyResources(btn_edit, "btn_edit");
            btn_edit.ForeColor = Color.White;
            btn_edit.Name = "btn_edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.images__5_;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.MediumSlateBlue;
            label4.Name = "label4";
            // 
            // NAME
            // 
            resources.ApplyResources(NAME, "NAME");
            NAME.ForeColor = Color.MediumSlateBlue;
            NAME.Name = "NAME";
            // 
            // txt_name
            // 
            resources.ApplyResources(txt_name, "txt_name");
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.MediumSlateBlue;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.MediumSlateBlue;
            label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.MediumSlateBlue;
            label5.Name = "label5";
            // 
            // txt_password
            // 
            resources.ApplyResources(txt_password, "txt_password");
            txt_password.Name = "txt_password";
            txt_password.ReadOnly = true;
            // 
            // txt_phone
            // 
            resources.ApplyResources(txt_phone, "txt_phone");
            txt_phone.Name = "txt_phone";
            txt_phone.ReadOnly = true;
            // 
            // txt_email
            // 
            resources.ApplyResources(txt_email, "txt_email");
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.download__6_;
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // ShowProfile
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox3);
            Controls.Add(txt_email);
            Controls.Add(txt_phone);
            Controls.Add(txt_password);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_name);
            Controls.Add(NAME);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(btn_edit);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowProfile";
            Load += ShowProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btn_edit;
        private PictureBox pictureBox2;
        private Label label4;
        private Label NAME;
        private TextBox txt_name;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txt_password;
        private TextBox txt_phone;
        private TextBox txt_email;
        private PictureBox pictureBox3;
    }
}