using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear any existing controls
            panel1.Controls.Clear();

            // Create a new instance of Form2
            Register registerForm = new Register();

            // Configure it to act as a child control
            registerForm.TopLevel = false;
            registerForm.FormBorderStyle = FormBorderStyle.None;
            registerForm.Dock = DockStyle.Fill;

            // Add to panel and show
            panel1.Controls.Add(registerForm);
            registerForm.Show();

        }
      
    

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear any existing controls
            panel1.Controls.Clear();

            // Create a new instance of Form2
            Login loginForm = new Login();

            // Configure it to act as a child control
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;

            // Add to panel and show

            panel1.Controls.Add(loginForm);
            loginForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            // Create a new instance of Form2
            Calculator calculator = new Calculator();

            // Configure it to act as a child control
            calculator.TopLevel = false;
            calculator.FormBorderStyle = FormBorderStyle.None;
            calculator.Dock = DockStyle.Fill;

            // Add to panel and show

            panel1.Controls.Add(calculator);
            calculator.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            label5.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //label5.Text = DateTime.Now.ToString("HH:MM:SS");
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
