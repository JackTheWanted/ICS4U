using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project_Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void rockChoice(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.rock;

        }

        private void paperChoice(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
        }

        private void scissorsChoice(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors;
        }
    }
}
