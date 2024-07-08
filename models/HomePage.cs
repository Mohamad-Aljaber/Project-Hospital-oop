using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital1.models
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMamger formMamger = new FormMamger();
            formMamger.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FromDoctors fromDoctors = new FromDoctors();
            fromDoctors.Show();
        
    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormPatient patient = new FormPatient();
            patient.Show();
        
    }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormNurse formNurse = new FormNurse();
            formNurse.Show();
        }
    }
}
