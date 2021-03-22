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
    public partial class frmElendin : Form
    {
        public frmElendin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oyunEkrani oyun = new oyunEkrani();
            Form1 fr = new Form1();
            fr.Show();
            oyun.Hide();
            this.Hide();
            
        }

        private void frmElendin_Load(object sender, EventArgs e)
        {
            lblskor0.Text = Properties.Settings.Default.skorum.ToString();
        }
    }
}
