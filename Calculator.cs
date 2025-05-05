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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var x = int.Parse(e.KeyChar.ToString());

            }
            catch(Exception xe)
            {
                MessageBox.Show("This is string");
                textBox1.Clear();
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var x = int.Parse(e.KeyChar.ToString());

            }
            catch (Exception xe)
            {
                MessageBox.Show("This is string");
                textBox2.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 + num2;
            textBox3.Text = result.ToString();

        }
        private void button2_Click(object sender, EventArgs e)
        {


            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 - num2;
            textBox3.Text = result.ToString();
        }




        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 * num2;
            textBox3.Text = result.ToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="0" || textBox2.Text =="0")   
            {
                MessageBox.Show("Attempted to divide by zero");

            }
            else
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                int result = num1 / num2;
                textBox3.Text = result.ToString();

            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }

}