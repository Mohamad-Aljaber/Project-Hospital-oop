

using hospital1.models;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butn_login_Click(object sender, EventArgs e)
        {

            string username = "Admin";
            string pas = "123";


            if (username == user.Text.Trim() && pas == pass.Text.Trim())
            {
                

              HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
              
                



            }
            else
            {

                MessageBox.Show("EROOR IN PASSORD or username");



            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
