using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Register : Form
    {

        Dictionary<string, List<string>> provinceDistrictMap = new Dictionary<string, List<string>>()
        {
            { "Bagmati", new List<string> { "Bhaktapur", "Kathmandu", "Lalitpur" } },
            { "Koshi", new List<string> { "Sunsari", "Morang" } },
            { "Lumbini", new List<string> { "Parasi","Palpa", "Gulmi", "Arghakhanchi", "Rupandehi" } },
            { "Sudurpaschim", new List<string> { "Aarcham", "Bajura", " Baitadi" } },
            { "Gandaki", new List<string> { "Gorkha", "Lamjung", "Tanahun" } },
            { "Madhesh", new List<string> { "Parsa", "Bara", "Rautahat", "Sarlahi", "Mahottari"}},
            { "Karnali", new List<string> { "Dolpa", "Mugu", "Humla", "Jumla", "Western Rukum" }}
        };

        public Register()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.AddRange(provinceDistrictMap.Keys.ToArray());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedProvince = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedProvince) && provinceDistrictMap.ContainsKey(selectedProvince))
            {
                comboBox2.Items.Clear(); 
                comboBox2.Items.AddRange(provinceDistrictMap[selectedProvince].ToArray());
                comboBox2.SelectedIndex = 0; 
            }
        }
    }
}
