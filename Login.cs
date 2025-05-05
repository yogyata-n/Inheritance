
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            
            textBox2.PasswordChar = '*';

     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            
            Regex regex = new Regex(@"^[a-zA-Z0-9_.]+$");
            if (!regex.IsMatch(username))
            {
                MessageBox.Show("Invalid username. Only letters, numbers, underscore (_) and dot (.) are allowed.");
                return;
            }

            

            MessageBox.Show("Logged In Successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optional: live validation or placeholder functionality
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

