using AForge.Imaging;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBLReader
{
    public partial class Form1 : Form
    {
        private float HRes = 96.0f;
        private float VRes = 96.0f;
        private int RulerHeight;
        string dpmm = "8dpmm";
        private Font TheFont = new Font("Times New Roman", 10, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();

            VRes = (float)ppIn();
            HRes = VRes;
        }

        private void button1_Click(object sender, EventArgs ee)
        {
            string zpl_t = "";//richTextBox1.Text;
            byte[] zpl = Encoding.UTF8.GetBytes(zpl_t);
            var request = (HttpWebRequest)WebRequest.Create("http://api.labelary.com/v1/printers/8dpmm/labels/2x3/0/");
            request.Method = "POST";
            request.Accept = "application/png"; 
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = zpl.Length;

            var requestStream = request.GetRequestStream();
            requestStream.Write(zpl, 0, zpl.Length);
            requestStream.Close();

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                var image = System.Drawing.Image.FromStream(responseStream);
                var tmp = Process(image);

                Crop cropFilter = new Crop(new Rectangle(0, 0, tmp.X, tmp.Y));

                Bitmap image2 = new Bitmap(image);

                Bitmap croppedImage = cropFilter.Apply(image2);

               // pictureBox1.Image = croppedImage;
                responseStream.Close();
            }
            catch (WebException e)
            {
                Console.WriteLine("Error: {0}", e.Status);
            }
        }
        public Point Process(System.Drawing.Image image)
        {
            Bitmap b = new Bitmap(image);
           
            LockBitmap lockBitmap = new LockBitmap(b);
            lockBitmap.LockBits();
            int X = 0;
            int Y = 0;

            for (int y = 0; y < lockBitmap.Height; y++)
            {
                for (int x = 0; x < lockBitmap.Width; x++)
                {
                    Color color = lockBitmap.GetPixel(x, y);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;

                    double  lum = 0.2126 * R + 0.7152 * G + 0.0722 * B;

                    if (lum < 10)
                    {
                        if(X < x)
                        {
                            X = x;
                        }
                        if (Y < y)
                        {
                            Y = y;
                        }
                    }
                }
            }
            Point p = new Point(X,Y);
            return p;
        }
        public int ppIn()
        {
            string zpl_t = @"^XA
                ^FO0,0
                ^BQN,2,10
                ^FDMM,AAC-42^FS
                ^XZ";
            byte[] zpl = Encoding.UTF8.GetBytes(zpl_t);
            var request = (HttpWebRequest)WebRequest.Create(string.Format("http://api.labelary.com/v1/printers/{0}/labels/1x1/0/", dpmm));
            request.Method = "POST";
            //request.Accept = "application/png";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = zpl.Length;

            var requestStream = request.GetRequestStream();
            requestStream.Write(zpl, 0, zpl.Length);
            requestStream.Close();

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                var image = System.Drawing.Image.FromStream(responseStream);
                return Math.Max(image.Width, image.Height);               

            }
            catch (WebException e)
            {
                Console.WriteLine("Error: {0}", e.Status);
            }
            return 92;
        }
        public System.Drawing.Image getImage(string zpl_t)
        {
            string x = toolStripTextBox1.Text;
            string y = toolStripTextBox2.Text;
            byte[] zpl = Encoding.UTF8.GetBytes(zpl_t);
            var request = (HttpWebRequest)WebRequest.Create(string.Format("http://api.labelary.com/v1/printers/{0}/labels/{1}x{2}/0/", dpmm,x,y));
            request.Method = "POST";
            //request.Accept = "application/png";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = zpl.Length;

            var requestStream = request.GetRequestStream();
            requestStream.Write(zpl, 0, zpl.Length);
            requestStream.Close();

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseStream = response.GetResponseStream();
                var image = System.Drawing.Image.FromStream(responseStream);
                var tmp = Process(image);

                Crop cropFilter = new Crop(new Rectangle(0, 0, tmp.X, tmp.Y));

                Bitmap image2 = new Bitmap(image);

                Bitmap croppedImage = cropFilter.Apply(image2);
                responseStream.Close();
                // pictureBox1.Image = croppedImage;
                return croppedImage;
                
            }
            catch (WebException e)
            {
                Console.WriteLine("Error: {0}", e.Status);
            }
            return null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string zpl = @"^XA
                ^FO0,0
                ^BQN,2,10
                ^FDMM,AAC-42^FS
                ^XZ";
            System.Drawing.Image qrcode = getImage(zpl);
            if (qrcode != null)
            {
                LabelItem labelItem = new LabelItem(qrcode);
                labelItem.Visible = true;
                labelItem.Location = new Point(1, 1);
                labelItem.Height = qrcode.Height;
                labelItem.Width = qrcode.Width;
                labelItem.Show();

                LabelDesigner.Controls.Add(labelItem);
            }
        }

        
        private void DrawRuler(Graphics g)
        {
            g.DrawRectangle(Pens.White, ClientRectangle);
            g.FillRectangle(Brushes.Yellow, 0, 0, Width, Height);

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
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void DrawHRuler(Graphics g)
        {
            g.DrawRectangle(Pens.White, ClientRectangle);
            g.FillRectangle(Brushes.Yellow, 0, 0, Width, Height);

            float PixelsPerInch = VRes;

            int count = 1;
            for (float i = 1; i < (float)PixelsPerInch * RulerHeight + 10; i += 0.0625f) // mark every 1/8th inch
            {
                if ((i % (PixelsPerInch)) == 0)
                {
                    g.DrawLine(Pens.Black,i,0, i, 25);
                    g.DrawString(count.ToString(), TheFont, Brushes.Black, i, 15, new StringFormat());
                    count++;
                }
                else if (((i * 2) % ((PixelsPerInch))) == 0)
                {
                    g.DrawLine(Pens.Black, i, 0,  i, 20);
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
        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RulerHeight = 10;
            DrawRuler(g);
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RulerHeight = 10;
            DrawHRuler(g);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            var controles = LabelDesigner.Controls;
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            string value = toolStripComboBox1.Text;
            dpmm = "8dpmm";
            switch (value)
            {
                case "6 dpmm (152 dpi)":
                    dpmm = "6dpmm";
                    break;
                case "8 dpmm (203 dpi)":
                    dpmm = "8dpmm";
                    break;
                case "12 dpmm (300 dpi)":
                    dpmm = "12dpmm";
                    break;
                case "24 dpmm (600 dpi)":
                    dpmm = "24dpmm";
                    break;
            }

            
            VRes = (float)ppIn();
            HRes = VRes;
            splitContainer3.Panel1.Invalidate();
            splitContainer4.Panel2.Invalidate();
        }
    }
}
