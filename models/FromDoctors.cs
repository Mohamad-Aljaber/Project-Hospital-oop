using hospital1.classes;
using hospital1.connect;
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
    public partial class FromDoctors : Form
    {
        OpertionDoctor opertionDoctor = new OpertionDoctor();
        public FromDoctors()
        {
            InitializeComponent();
        }

        private void getDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FromDoctors_Load(object sender, EventArgs e)
        {
            try
            {


                dataGridView1.DataSource= opertionDoctor.GetDoctors();
                


            }
            catch (Exception ex)
            {


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void adddoctor_Click(object sender, EventArgs e)
        {
            string fname = first_Name.Text;
            string lname= last_Name.Text;
            int age = Convert.ToInt32(Age.Text);
            string adder = adders.Text;
            string ph = phon.Text;
            string emai = email.Text;
            string gende = gender.Text;
            string blood_grou = blood_group.Text;
            string nameDepartmen = nameDepartment.Text;
            int sall = Convert.ToInt32(sal.Text);
            string namejobb = namejob.Text;
            string specialt = specialty.Text;
            Doctor doctor=new Doctor(0, fname,lname,  adder,age,ph,emai,gende, blood_grou, sall,nameDepartmen,namejobb, specialt);
            opertionDoctor.AddDoctor(doctor);
            dataGridView1.DataSource = opertionDoctor.GetDoctors();
        }
    }
}
