using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stari_dqdo
{
    public partial class Form2 : Form
    {
        public string name;
        public string email;
        public string city;

        public string passingvalue
        {
            get { return name; }
            set { name = value; }
        }
        public string passingvalue1
        {
            get { return email; }
            set { email = value; }
        }
        public string passingvalue2
        {
            get { return city; }
            set { city = value; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label4.Text = "" + name;
            label5.Text = "" + email;
            label6.Text = "" + city;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
