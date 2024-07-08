namespace hospital1.models
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            pictureClose = new PictureBox();
            pictureManger = new PictureBox();
            label2 = new Label();
            pictureDoctors = new PictureBox();
            label1 = new Label();
            picturePatient = new PictureBox();
            label3 = new Label();
            pictureNures = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureManger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePatient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureNures).BeginInit();
            SuspendLayout();
            // 
            // pictureClose
            // 
            pictureClose.Image = (Image)resources.GetObject("pictureClose.Image");
            pictureClose.Location = new Point(290, 414);
            pictureClose.Name = "pictureClose";
            pictureClose.Size = new Size(309, 231);
            pictureClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureClose.TabIndex = 10;
            pictureClose.TabStop = false;
            pictureClose.Click += pictureBox2_Click;
            // 
            // pictureManger
            // 
            pictureManger.Image = (Image)resources.GetObject("pictureManger.Image");
            pictureManger.Location = new Point(12, 104);
            pictureManger.Name = "pictureManger";
            pictureManger.Size = new Size(268, 228);
            pictureManger.SizeMode = PictureBoxSizeMode.Zoom;
            pictureManger.TabIndex = 11;
            pictureManger.TabStop = false;
            pictureManger.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Traditional Arabic", 30F, FontStyle.Bold);
            label2.Location = new Point(346, 25);
            label2.Name = "label2";
            label2.Size = new Size(212, 76);
            label2.TabIndex = 12;
            label2.Text = "Doctors";
            label2.Click += label2_Click;
            // 
            // pictureDoctors
            // 
            pictureDoctors.Image = (Image)resources.GetObject("pictureDoctors.Image");
            pictureDoctors.Location = new Point(307, 104);
            pictureDoctors.Name = "pictureDoctors";
            pictureDoctors.Size = new Size(268, 228);
            pictureDoctors.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDoctors.TabIndex = 13;
            pictureDoctors.TabStop = false;
            pictureDoctors.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Traditional Arabic", 30F, FontStyle.Bold);
            label1.Location = new Point(622, 25);
            label1.Name = "label1";
            label1.Size = new Size(187, 76);
            label1.TabIndex = 14;
            label1.Text = "patient";
            // 
            // picturePatient
            // 
            picturePatient.Image = (Image)resources.GetObject("picturePatient.Image");
            picturePatient.Location = new Point(601, 104);
            picturePatient.Name = "picturePatient";
            picturePatient.Size = new Size(268, 228);
            picturePatient.SizeMode = PictureBoxSizeMode.Zoom;
            picturePatient.TabIndex = 15;
            picturePatient.TabStop = false;
            picturePatient.Click += pictureBox4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Traditional Arabic", 30F, FontStyle.Bold);
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(203, 76);
            label3.TabIndex = 16;
            label3.Text = "Manger";
            // 
            // pictureNures
            // 
            pictureNures.Image = (Image)resources.GetObject("pictureNures.Image");
            pictureNures.Location = new Point(-5, 414);
            pictureNures.Name = "pictureNures";
            pictureNures.Size = new Size(268, 228);
            pictureNures.SizeMode = PictureBoxSizeMode.Zoom;
            pictureNures.TabIndex = 17;
            pictureNures.TabStop = false;
            pictureNures.Click += pictureBox5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Traditional Arabic", 30F, FontStyle.Bold);
            label4.Location = new Point(50, 337);
            label4.Name = "label4";
            label4.Size = new Size(165, 76);
            label4.TabIndex = 18;
            label4.Text = "Nurse";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1022, 657);
            Controls.Add(label4);
            Controls.Add(pictureNures);
            Controls.Add(label3);
            Controls.Add(picturePatient);
            Controls.Add(label1);
            Controls.Add(pictureDoctors);
            Controls.Add(label2);
            Controls.Add(pictureManger);
            Controls.Add(pictureClose);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)pictureClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureManger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePatient).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureNures).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureClose;
        private PictureBox pictureManger;
        private Label label2;
        private PictureBox pictureDoctors;
        private Label label1;
        private PictureBox picturePatient;
        private Label label3;
        private PictureBox pictureNures;
        private Label label4;
    }
}