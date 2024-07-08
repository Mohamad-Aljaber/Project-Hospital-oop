namespace Hospital
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            user = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pass = new TextBox();
            butn_login = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Traditional Arabic", 15F, FontStyle.Bold);
            label1.Location = new Point(49, 37);
            label1.Name = "label1";
            label1.Size = new Size(347, 39);
            label1.TabIndex = 0;
            label1.Text = "System management Hospital";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Traditional Arabic", 20F, FontStyle.Bold);
            label2.Location = new Point(176, 62);
            label2.Name = "label2";
            label2.Size = new Size(99, 53);
            label2.TabIndex = 1;
            label2.Text = "login";
            label2.Click += label2_Click;
            // 
            // user
            // 
            user.BackColor = Color.DodgerBlue;
            user.Location = new Point(86, 247);
            user.Multiline = true;
            user.Name = "user";
            user.Size = new Size(284, 34);
            user.TabIndex = 2;
            user.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(127, 33);
            label3.TabIndex = 3;
            label3.Text = "username :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(145, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 15F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 300);
            label4.Name = "label4";
            label4.Size = new Size(115, 33);
            label4.TabIndex = 6;
            label4.Text = "pasword :";
            // 
            // pass
            // 
            pass.BackColor = Color.DodgerBlue;
            pass.Location = new Point(86, 336);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(284, 34);
            pass.TabIndex = 5;
            // 
            // butn_login
            // 
            butn_login.BackColor = Color.DodgerBlue;
            butn_login.FlatAppearance.BorderColor = Color.White;
            butn_login.FlatAppearance.MouseDownBackColor = Color.Gray;
            butn_login.FlatAppearance.MouseOverBackColor = Color.DodgerBlue;
            butn_login.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butn_login.Location = new Point(145, 414);
            butn_login.Name = "butn_login";
            butn_login.Size = new Size(150, 57);
            butn_login.TabIndex = 7;
            butn_login.Text = "login";
            butn_login.UseVisualStyleBackColor = false;
            butn_login.Click += butn_login_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(401, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(429, 573);
            Controls.Add(pictureBox2);
            Controls.Add(butn_login);
            Controls.Add(label4);
            Controls.Add(pass);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(user);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox user;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox pass;
        private Button butn_login;
        private PictureBox pictureBox2;
    }
}
