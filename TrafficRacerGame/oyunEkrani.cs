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
    public partial class oyunEkrani : Form
    {
        public oyunEkrani()
        {
            InitializeComponent();
        }

        private void oyunEkrani_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.ferrariDb==1)
            {
                pictureAraba.Image = Properties.Resources._2dFerrari;
            }

            else if (Properties.Settings.Default.lamboDb == 1)
            {
                pictureAraba.Image = Properties.Resources._2dLamboRed;
            }

            else if (Properties.Settings.Default.mustangDb == 1)
            {
                pictureAraba.Image = Properties.Resources._2dMustang;
            }
            
            timer1.Start();
        }

        // her çağırıldığında skor +1 olacak.
        void skorArtır()
        {
            int sk = int.Parse(lblSkor.Text);
            sk++;
            lblSkor.Text = sk.ToString();
            Properties.Settings.Default.skorum = sk;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.hızlıDb==1)
            {
                kırmızı1.Top += 10;
                kırmızı2.Top += 10;
                mavi1.Top += 10;
                mavi2.Top += 10;

                timer1.Interval = 15;
            }
            else if (Properties.Settings.Default.ortaDb == 1)
            {
                kırmızı1.Top += 10;
                kırmızı2.Top += 10;
                mavi1.Top += 10;
                mavi2.Top += 10;

                timer1.Interval = 22;
            }
            else if (Properties.Settings.Default.yavasDb == 1)
            {
                kırmızı1.Top += 10;
                kırmızı2.Top += 10;
                mavi1.Top += 10;
                mavi2.Top += 10;

                timer1.Interval = 35;
            }

            frmElendin loser = new frmElendin();

            Point k1 = new Point();
            Point k2 = new Point();
            Point m1 = new Point();
            Point m2 = new Point();
            Point araba = new Point();

            k1.X = kırmızı1.Left;
            k1.Y = kırmızı1.Bottom;

            k2.X = kırmızı2.Left;
            k2.Y = kırmızı2.Bottom;

            m1.X=mavi1.Left;
            m1.Y=mavi1.Bottom;

            m2.X = mavi2.Left;
            m2.Y = mavi2.Bottom;

            araba.X=pictureAraba.Left;
            araba.Y=pictureAraba.Top;
                   
            ///////////////////////////////
            // oyunda elenme işlemi :
            if (kırmızı1.Bottom >= pictureAraba.Top  && (kırmızı1.Left - pictureAraba.Left)==10)
            {                              
                kırmızı1.Visible = false;
                loser.Show();
                timer1.Stop();                              
            }
            if (kırmızı2.Bottom >= pictureAraba.Top && (kırmızı2.Left - pictureAraba.Left) == 10)
            {               
                kırmızı2.Visible = false;
                loser.Show();
                timer1.Stop();                
            }
    
            //////////////////////////////////////////////
            // puan alma işlemi :

            if (mavi1.Bottom == pictureAraba.Top && (mavi1.Left - pictureAraba.Left) == 10)
            {               
                    int sk = int.Parse(lblSkor.Text);
                    sk++;
                    lblSkor.Text = sk.ToString();
                    Properties.Settings.Default.skorum = sk;                                               
            }
            if (mavi2.Bottom == pictureAraba.Top && (mavi2.Left - pictureAraba.Left) == 10)
            { 
                    int sk = int.Parse(lblSkor.Text);
                    sk++;
                    lblSkor.Text = sk.ToString();
                    Properties.Settings.Default.skorum = sk;               
            }
            
            Point p = new Point();
            Point p2 = new Point();
            Point p3 = new Point();

            p.X = 66;
            p.Y = 30;

            p2.X =66;
            p2.Y =160;

            p3.X =66;
            p3.Y =290;

            // kırmızı ve mavi topların random şekilde üst kısımdan tekrar gelmesi işlemi :
            if (kırmızı1.Top==596 || kırmızı2.Top == 596 || mavi1.Top == 596 || mavi2.Top == 596)
            {
                Random rnd = new Random();
                if (kırmızı1.Top == 596)
                {
                    var deger = rnd.Next(1,4);
                    if (deger ==1)
                    {
                        kırmızı1.Top = 66;
                        kırmızı1.Left = 30;
                    }
                    else if (deger == 2)
                    {
                        kırmızı1.Top = 66;
                        kırmızı1.Left = 160;
                    }
                    else if (deger == 3)
                    {
                        kırmızı1.Top = 66;
                        kırmızı1.Left = 290;
                    }
                }
                else if (kırmızı2.Top == 596)
                { 
                    var deger2 = rnd.Next(1, 4);
                    if (deger2 == 1)
                    {
                        kırmızı2.Top = 66;
                        kırmızı2.Left = 30;
                    }
                    else if (deger2 == 2)
                    {
                        kırmızı2.Top = 66;
                        kırmızı2.Left = 160;
                    }
                    else if (deger2 == 3)
                    {
                        kırmızı2.Top = 66;
                        kırmızı2.Left = 290;
                    }
                }
                else if (mavi1.Top == 596)
                {
                    var deger3 = rnd.Next(1, 4);
                    if (deger3 == 1)
                    {
                        mavi1.Top = 66;
                        mavi1.Left = 30;
                    }
                    else if (deger3 == 2)
                    {
                        mavi1.Top = 66;
                        mavi1.Left = 160;
                    }
                    else if (deger3 == 3)
                    {
                        mavi1.Top = 66;
                        mavi1.Left = 290;
                    }
                }
                else if (mavi2.Top == 596)
                {
                    var deger4 = rnd.Next(1, 4);
                    if (deger4 == 1)
                    {
                        mavi2.Top = 66;
                        mavi2.Left = 30;
                    }
                    else if (deger4 == 2)
                    {
                        mavi2.Top = 66;
                        mavi2.Left = 160;
                    }
                    else if (deger4 == 3)
                    {
                        mavi2.Top = 66;
                        mavi2.Left = 290;
                    }
                }
            }
        }
        private void kırmızı2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void oyunEkrani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left) // klavyeden sola basıldığında arabayı sola hareket ettir.
            {
                if (pictureAraba.Left>20)
                {
                    pictureAraba.Left -= 130;
                }
            }
           if (e.KeyCode == Keys.Right) // klavyeden sağa basıldığında arabayı sağa hareket ettir.
            {
                if (pictureAraba.Left<280)
                {
                    pictureAraba.Left += 130;
                }
            }
        }
    }
}
