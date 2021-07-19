using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelDesigner
{
    public partial class ImageResizer : Form
    {
        public float HRes = 96.0f;
        public float VRes = 96.0f;
        public int RulerHeight = 10;
        private Font TheFont = new Font("Times New Roman", 10, FontStyle.Bold);
        Bitmap theImage;
        public Bitmap resizeImage;
        private int rHeight;
        private int rWidth;
        public ImageResizer(string path)
        {
            InitializeComponent();

            theImage = new Bitmap(path);
            resizeImage = new Bitmap(path);
            rHeight = theImage.Height;
            rWidth = theImage.Width;
            pictureBox1.Height = rHeight;
            pictureBox1.Width = rWidth;
            pictureBox1.Image = theImage;

            iWidth.Text = rWidth.ToString();
            iHeight.Text = rHeight.ToString();
            percentaje.Text = string.Format("{0}%", trackBar1.Value);
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RulerHeight = 10;
            DrawHRuler(g);
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RulerHeight = 10;
            DrawRuler(g);
        }

        private void DrawRuler(Graphics g)
        {
            g.DrawRectangle(Pens.White, ClientRectangle);
            g.FillRectangle(Brushes.Yellow, 0, 0, splitContainer3.Panel1.Width, splitContainer3.Panel1.Height);

            float PixelsPerInch = VRes;

            int count = 1;
            for (float i = 1; i < (float)PixelsPerInch * RulerHeight + 10; i += 0.0625f) // mark every 1/8th inch
            {
                if ((i % (PixelsPerInch)) == 0)
                {
                    g.DrawLine(Pens.Black, 0, i, 25, i);
                    g.DrawString(count.ToString(), TheFont, Brushes.Black, 15, i, new StringFormat());
                    count++;
                }
                else if (((i * 2) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, 0, i, 20, i);
                }
                else if (((i * 4) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, 0, i, 15, i);
                }
                else if (((i * 8) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, 0, i, 10, i);
                }
                else if (((i * 16) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, 0, i, 5, i);
                }

            }
            g.Dispose();
        }
        private void DrawHRuler(Graphics g)
        {
            g.DrawRectangle(Pens.White, ClientRectangle);
            g.FillRectangle(Brushes.Yellow, 0, 0, 1900, 2000);

            float PixelsPerInch = VRes;

            int count = 1;
            for (float i = 1; i < (float)PixelsPerInch * RulerHeight + 10; i += 0.0625f) // mark every 1/8th inch
            {
                if ((i % (PixelsPerInch)) == 0)
                {
                    g.DrawLine(Pens.Black, i, 0, i, 25);
                    g.DrawString(count.ToString(), TheFont, Brushes.Black, i, 15, new StringFormat());
                    count++;
                }
                else if (((i * 2) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, i, 0, i, 20);
                }
                else if (((i * 4) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, i, 0, i, 15);
                }
                else if (((i * 8) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, i, 0, i, 10);
                }
                else if (((i * 16) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, i, 0, i, 5);
                }

            }
            g.Dispose();
        }

        

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            percentaje.Text = string.Format("{0}%",trackBar1.Value);

            float perc = (float)trackBar1.Value / 100;
            int tWidth = (int)(rWidth * perc);
            int tHeight = (int)(rHeight * perc);
            iWidth.Text = tWidth.ToString();
            iHeight.Text = tHeight.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 100;
            pictureBox1.Height = rHeight;
            pictureBox1.Width = rWidth;
            pictureBox1.Image = theImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tWidth = int.Parse(iWidth.Text);
            int tHeight =int.Parse(iHeight.Text);

            ResizeNearestNeighbor filter = new ResizeNearestNeighbor(tWidth, tHeight);
            resizeImage = filter.Apply(theImage);

            pictureBox1.Image = resizeImage;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
