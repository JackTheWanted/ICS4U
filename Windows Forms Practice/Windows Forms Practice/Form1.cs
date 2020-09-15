using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int averageLife = 82;
        double tallestMan = 2.72;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            nameMessage.Text = "Greetings " + name;


            txtHeight.Text = double.Parse(txtHeight.Text).ToString("F2");
            heightMessage.Text = ($"You are {txtHeight.Text}m shorter than the tallest man in the world.");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
