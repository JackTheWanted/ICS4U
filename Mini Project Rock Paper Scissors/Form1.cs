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
        Random generator = new Random();
        int playerState = 0;
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
            playerState = 1;
        }

        private void paperChoice(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.paper;
            playerState = 2;
        }

        private void scissorsChoice(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.scissors;
            playerState = 3;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void V_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.choosing;
            playerState = 0;

            imgOpponent.Image = Properties.Resources.loading;
            int randomCompChoice = generator.Next(1, 4);

            while (playerState == 0) ;
            if (randomCompChoice == 1)
            {
                imgOpponent.Image = Properties.Resources.rock;
            }

            else if (randomCompChoice == 2)
            {
                imgOpponent.Image = Properties.Resources.paper;
            }

            else if (randomCompChoice == 3)
            {
                imgOpponent.Image = Properties.Resources.scissors;
            }

        }
    }
}
