using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficRacerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioOrta.Checked = true;
        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            lblFerrari.Visible = true;
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            lblFerrari.Visible = false;
        }

        private void bunifuImageButton2_MouseHover(object sender, EventArgs e)
        {
            lblLambo.Visible = true;
        }

        private void bunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            lblLambo.Visible = false;
        }

        private void bunifuImageButton3_MouseHover(object sender, EventArgs e)
        {
            lblMustang.Visible = true;
        }

        private void bunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            lblMustang.Visible = false;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioHızlı.Checked)
            {
                Properties.Settings.Default.hızlıDb = 1;
                Properties.Settings.Default.ortaDb = 0;
                Properties.Settings.Default.yavasDb = 0;
            }

            else if(radioOrta.Checked)
            {
                Properties.Settings.Default.hızlıDb = 0;
                Properties.Settings.Default.ortaDb = 1;
                Properties.Settings.Default.yavasDb = 0;
            }

            else if(radioYavas.Checked)
            {
                Properties.Settings.Default.hızlıDb = 0;
                Properties.Settings.Default.ortaDb = 0;
                Properties.Settings.Default.yavasDb = 1;
            }


            oyunEkrani oyunE = new oyunEkrani();
            
            oyunE.Show();
            this.Hide();
            
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // ferrari
            Properties.Settings.Default.ferrariDb = 1;
            Properties.Settings.Default.lamboDb = 0;
            Properties.Settings.Default.mustangDb = 0;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // lambo
            Properties.Settings.Default.ferrariDb = 0;
            Properties.Settings.Default.lamboDb =1;
            Properties.Settings.Default.mustangDb = 0;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            // mustang
            Properties.Settings.Default.ferrariDb = 0;
            Properties.Settings.Default.lamboDb = 0;
            Properties.Settings.Default.mustangDb = 1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
