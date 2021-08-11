using AForge.Imaging;
using AForge.Imaging.Filters;
using ImageMagick;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelDesigner
{
    public partial class Form1 : Form
    {
        private float HRes = 96.0f;
        private float VRes = 96.0f;
        private int RulerHeight=10;
        string dpmm = "8dpmm";
        string currentFile = "";
        private Font TheFont = new Font("Times New Roman", 10, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();

            VRes = (float)ppIn();
            HRes = VRes;
            splitContainer2.Height = RulerHeight * (int)VRes;
            splitContainer2.Width = RulerHeight * (int)VRes;
            var pn1 = panel1;
        }

        
        public int[] Process(System.Drawing.Image image)
        {
            Bitmap b = new Bitmap(image);
           
            LockBitmap lockBitmap = new LockBitmap(b);
            lockBitmap.LockBits();
            
            List<Point> allBlack = new List<Point>();
            for (int y = 0; y < lockBitmap.Height; y++)
            {
                for (int x = 0; x < lockBitmap.Width; x++)
                {
                    Color color = lockBitmap.GetPixel(x, y);

                    int R = color.R;
                    int G = color.G;
                    int B = color.B;
                    int A = color.A;
                    if (A > 0)
                    {
                        double lum = 0.2126 * R + 0.7152 * G + 0.0722 * B;

                        if (lum < 10)
                        {
                            allBlack.Add(new Point(x, y));

                        }
                    }
                }
            }
            int minX = (from p in allBlack orderby p.X select p).First().X;
            int minY = (from p in allBlack orderby p.Y select p).First().Y;
            int maxX = (from p in allBlack orderby p.X select p).Last().X;
            int maxY = (from p in allBlack orderby p.Y select p).Last().Y; ;

            
            return new int[] {minX, minY, maxX,  maxY };
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
                //var image = System.Drawing.Image.FromStream(responseStream);

                MagickImage img = new MagickImage(responseStream);
                img.ColorFuzz = new Percentage(90);
                img.Transparent(MagickColors.White);
                var image = img.ToBitmap();

                var tmp = Process(image);

                Crop cropFilter = new Crop(new Rectangle(tmp[0], tmp[1], tmp[2]- tmp[0], tmp[3]- tmp[1]));

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

        public void CreateLabel(string zpl, string zpl_clean)
        {
            System.Drawing.Image qrcode = getImage(zpl);
            if (qrcode != null)
            {
                LabelItem labelItem = new LabelItem(qrcode);
                labelItem.Visible = true;
                labelItem.Location = new Point(100, 100);
                labelItem.zpl = zpl_clean;
                labelItem.zpl_gen = zpl;
                labelItem.Height = qrcode.Height;
                labelItem.Width = qrcode.Width;
                labelItem.Remove += LabelItem_Remove;
                labelItem.PositionUpdate += LabelItem_PositionUpdate;
                labelItem.Show();

                LabelDesigner.Controls.Add(labelItem);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Parameters.BQ bq = new Parameters.BQ();
            bq.ShowDialog();
            string zpl =string.Format(
                @"^XA
^FO0,0
^BQN,2,{0},{1},{2}
^FD{3}^FS
^XZ", bq.factor.Text, bq.correction.Text, bq.mask.Text,bq.data.Text);
            string zpl_clean = string.Format(
                @"^BQN,2,{0},{1},{2}
^FD{3}^FS", bq.factor.Text, bq.correction.Text, bq.mask.Text, bq.data.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void LabelItem_Remove(object sender, RemoveEvent e)
        {
            foreach (LabelItem item in LabelDesigner.Controls.OfType<LabelItem>())
            {
                if(item.uuid == e.id)
                {
                    LabelDesigner.Controls.Remove(item);
                }
            }
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
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
           
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
            StringBuilder code = new StringBuilder();
            code.Append("^XA\n");
            foreach (LabelItem item in LabelDesigner.Controls.OfType<LabelItem>())
            {
                code.Append(string.Format("\n^FO{0},{1}\n", item.Location.X, item.Location.Y));
                code.Append(item.zpl);
                code.Append("\n");
            }
            code.Append("\n^XZ\n");
            Viewer viewer = new Viewer();
            viewer.richTextBox1.Text = code.ToString();
            viewer.Colorize();
            viewer.ShowDialog();
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
            LabelDesigner.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Parameters.BC bq = new Parameters.BC();
            bq.ShowDialog();
            string zpl = string.Format(
                @"^XA
^FO5,60
^BY{7}
^BC{0},{1},{2},{3},{4},{5}
^FD{6}^FS
^XZ", bq.orientation.Text, bq.bcheight.Text, bq.printline.Text, bq.lineavobe.Text, bq.ucc.Text, bq.mode.Text, bq.data.Text, bq.cwidth.Text);
            string zpl_clean = string.Format(
                @"^BY{7}
^BC{0},{1},{2},{3},{4},{5}
^FD{6}^FS", bq.orientation.Text, bq.bcheight.Text, bq.printline.Text, bq.lineavobe.Text, bq.ucc.Text, bq.mode.Text, bq.data.Text, bq.cwidth.Text);
            CreateLabel(zpl, zpl_clean);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "QR CODE";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "CODE 128 BAR CODE";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (path != "")
            {
                ImageResizer imageResizer = new ImageResizer(path);
                imageResizer.HRes = HRes;
                imageResizer.VRes = VRes;
                imageResizer.RulerHeight = RulerHeight;
                imageResizer.ShowDialog();


                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.labelary.com/v1/graphics");
                string str1 = "----WebKitBoundaryString";

                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "multipart/form-data; boundary=" + str1;
                httpWebRequest.KeepAlive = true;
                httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
                MemoryStream memoryStream = new MemoryStream();
                StreamWriter streamWriter = new StreamWriter((Stream)memoryStream);
                streamWriter.Write("\r\n--" + str1 + "\r\n");
                streamWriter.Write("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: image/png\r\n\r\n", (object)"file", (object)Path.GetFileName(path), (object)Path.GetExtension(path));
                streamWriter.Flush();

                imageResizer.resizeImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);

                streamWriter.Write("\r\n--" + str1 + "--\r\n");
                streamWriter.Flush();
                httpWebRequest.ContentLength = memoryStream.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                    memoryStream.WriteTo(requestStream);
                memoryStream.Close();
                string str2 = "";
                try
                {
                    str2 = new StreamReader(httpWebRequest.GetResponse().GetResponseStream()).ReadToEnd();
                }
                catch
                {
                }

                string zpl_clean = str2.Replace("^XA^FO0,0", "").Replace("^XZ", "");

                CreateLabel(str2, zpl_clean);

            }
           
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Add Image";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Vertical Line";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Horizontal Line";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parameters.Line line = new Parameters.Line();
            line.Text = "Vertical Line";
            line.ShowDialog();
            string zpl = string.Format(
                @"^XA
^FO5,5
^GB1,{0},{1}^FS
^XZ", line.data.Text, line.thickness.Text);
            string zpl_clean = string.Format(
                @"^GB1,{0},{1}^FS", line.data.Text, line.thickness.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Parameters.Line line = new Parameters.Line();
            line.Text = "Horizontal Line";
            line.ShowDialog();
            string zpl = string.Format(
                @"^XA
^FO5,5
^GB{0},1,{1}^FS
^XZ", line.data.Text, line.thickness.Text);
            string zpl_clean = string.Format(
                @"^GB{0},1,{1}^FS", line.data.Text, line.thickness.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            //Alphanumeric
            statusLabel.Text = "Alphanumeric Data";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            //
            statusLabel.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Parameters.Alphanumeric alphanumeric = new Parameters.Alphanumeric();
            alphanumeric.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^CF{0},{1},{2}
^FD{3}^FS
^XZ", alphanumeric.font.Text, alphanumeric.cheight.Text, alphanumeric.cwidth.Text, alphanumeric.data.Text);
            string zpl_clean = string.Format(
                @"^CF{0},{1},{2}
^FD{3}^FS", alphanumeric.font.Text, alphanumeric.cheight.Text, alphanumeric.cwidth.Text, alphanumeric.data.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Bitmapped Font";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Parameters.Bitmapped alphanumeric = new Parameters.Bitmapped();
            alphanumeric.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^A{0}{1},{2},{3}
^FD{4}^FS
^XZ", alphanumeric.font.Text, alphanumeric.orientation.Text, alphanumeric.cheight.Text, alphanumeric.cwidth.Text, alphanumeric.data.Text);
            string zpl_clean = string.Format(
                @"^A{0}{1},{2},{3}
^FD{4}^FS", alphanumeric.font.Text, alphanumeric.orientation.Text, alphanumeric.cheight.Text, alphanumeric.cwidth.Text, alphanumeric.data.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            currentFile = "";
            saveFileDialog1.FileName = "";
            LabelDesigner.Controls.Clear();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(currentFile=="")
            {
                saveFileDialog1.ShowDialog();
                currentFile = saveFileDialog1.FileName;
            }
            if (currentFile !="") {
                List<Utils.LabelItem> items = new List<Utils.LabelItem>();
                foreach (LabelItem item in LabelDesigner.Controls.OfType<LabelItem>())
                {
                    var it = new Utils.LabelItem() { X = item.Location.X, Y = item.Location.Y, uuid = item.uuid, zpl = item.zpl, zpl_gen = item.zpl_gen };
                    items.Add(it);
                }

                Utils.WriteToJsonFile<List<Utils.LabelItem>>(currentFile, items);
            }

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.ShowDialog();
            currentFile = openFileDialog2.FileName;
            if(currentFile!="")
            {
                saveFileDialog1.FileName = "";
                LabelDesigner.Controls.Clear();

                List<Utils.LabelItem> items = Utils.ReadFromJsonFile<List<Utils.LabelItem>>(currentFile);
                foreach(Utils.LabelItem item in items)
                {
                    System.Drawing.Image qrcode = getImage(item.zpl_gen);
                    if (qrcode != null)
                    {
                        LabelItem labelItem = new LabelItem(qrcode);
                        labelItem.Visible = true;
                        labelItem.Location = new Point(item.X, item.Y);
                        labelItem.zpl = item.zpl;
                        labelItem.zpl_gen = item.zpl_gen;
                        labelItem.Height = qrcode.Height;
                        labelItem.Width = qrcode.Width;
                        labelItem.Remove += LabelItem_Remove;
                        labelItem.PositionUpdate += LabelItem_PositionUpdate;
                        labelItem.Show();

                        LabelDesigner.Controls.Add(labelItem);
                    }
                }
            }
           
        }

        private void LabelItem_PositionUpdate(object sender, PositionEvent e)
        {
            if(e.X=="")
            {
                statusLabel.Text = "";
            }
            else
            {
                statusLabel.Text = string.Format("X: {0}, Y: {1}", e.X, e.Y);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                statusLabel.Text = "Delete on click";
                foreach (LabelItem item in LabelDesigner.Controls.OfType<LabelItem>())
                {
                    item.remove = true;
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (!e.Control)
            {
                statusLabel.Text = "";
                foreach (LabelItem item in LabelDesigner.Controls.OfType<LabelItem>())
                {
                    item.remove = false;
                }
            }
        }

        private void printToolStripButton_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Generate ZPL";
        }

        private void printToolStripButton_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void LabelDesigner_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string x = toolStripTextBox1.Text;
            string y = toolStripTextBox2.Text;
            int w = int.Parse(x);
            int h = int.Parse(y);

            float H_pix = HRes * h;
            float W_pix = HRes * w;

            g.DrawLine(Pens.Red, 0, H_pix, W_pix, H_pix);

            g.DrawLine(Pens.Red, W_pix, 0, W_pix, H_pix);

            g.Dispose();

        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            LabelDesigner.Invalidate();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            LabelDesigner.Invalidate();
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Graphic Box";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Graphic Circle";
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Graphic Ellipse";
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Graphic Diagonal Line";
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "Graphic Symbol";
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            statusLabel.Text = "PDF417 Bar Code";
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Parameters.GraphicBox graphicBox = new Parameters.GraphicBox();
            graphicBox.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^GB{0},{1},{2},{3}{4}^FS
^XZ", graphicBox.cwidth.Text, graphicBox.cheight.Text, graphicBox.cborder.Text, graphicBox.ccolor.Text, graphicBox.cdegree.Text);
            string zpl_clean = string.Format(
                @"^GB{0},{1},{2},{3}{4}^FS", graphicBox.cwidth.Text, graphicBox.cheight.Text, graphicBox.cborder.Text, graphicBox.ccolor.Text, graphicBox.cdegree.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Parameters.GraphicCircle graphicCircle = new Parameters.GraphicCircle();
            graphicCircle.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^GC{0},{1},{2}^FS
^XZ", graphicCircle.cdiameter.Text, graphicCircle.cborder.Text, graphicCircle.ccolor.Text);
            string zpl_clean = string.Format(
                @"^GC{0},{1},{2}^FS", graphicCircle.cdiameter.Text, graphicCircle.cborder.Text, graphicCircle.ccolor.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Parameters.GraphicEllipse graphicEllipse = new Parameters.GraphicEllipse();
            graphicEllipse.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^GE{0},{1},{2},{3}^FS
^XZ", graphicEllipse.cwidth.Text, graphicEllipse.cheight.Text, graphicEllipse.cborder.Text,  graphicEllipse.ccolor.Text);
            string zpl_clean = string.Format(
                @"^GE{0},{1},{2},{3}^FS", graphicEllipse.cwidth.Text, graphicEllipse.cheight.Text, graphicEllipse.cborder.Text, graphicEllipse.ccolor.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Parameters.GraphicDiagonalLine graphicDiagonalLine = new Parameters.GraphicDiagonalLine();
            graphicDiagonalLine.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^GD{0},{1},{2},{3},{4}^FS
^XZ", graphicDiagonalLine.cwidth.Text, graphicDiagonalLine.cheight.Text, graphicDiagonalLine.cborder.Text, graphicDiagonalLine.ccolor.Text, graphicDiagonalLine.corientation.Text);
            string zpl_clean = string.Format(
                @"^GD{0},{1},{2},{3},{4}^FS", graphicDiagonalLine.cwidth.Text, graphicDiagonalLine.cheight.Text, graphicDiagonalLine.cborder.Text, graphicDiagonalLine.ccolor.Text, graphicDiagonalLine.corientation.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Parameters.GraphicSymbol graphicSymbol = new Parameters.GraphicSymbol();
            graphicSymbol.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^GS{0},{1},{2}^FD{3}^FS
^XZ", graphicSymbol.corientation.Text, graphicSymbol.cheight.Text, graphicSymbol.cwidth.Text, graphicSymbol.csymbol.Text);
            string zpl_clean = string.Format(
                @"^GS{0},{1},{2}^FD{3}^FS", graphicSymbol.corientation.Text, graphicSymbol.cheight.Text, graphicSymbol.cwidth.Text, graphicSymbol.csymbol.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Parameters.PDF417BarCode pdf417BarCode = new Parameters.PDF417BarCode();
            pdf417BarCode.ShowDialog();

            string zpl = string.Format(
                @"^XA
^FO5,5
^B7{0},{1},{2},{3},{4},{5}^FD{6}^FS
^XZ", pdf417BarCode.corientation.Text, pdf417BarCode.cheight.Text, pdf417BarCode.csecurity.Text, pdf417BarCode.ccolumns.Text, pdf417BarCode.crows.Text, pdf417BarCode.ctruncate.Text, pdf417BarCode.data.Text);
            string zpl_clean = string.Format(
                @"^B7{0},{1},{2},{3},{4},{5}^FD{6}^FS", pdf417BarCode.corientation.Text, pdf417BarCode.cheight.Text, pdf417BarCode.csecurity.Text, pdf417BarCode.ccolumns.Text, pdf417BarCode.crows.Text, pdf417BarCode.ctruncate.Text, pdf417BarCode.data.Text);

            CreateLabel(zpl, zpl_clean);
        }

        private void printToolStripButton1_Click(object sender, EventArgs e)
        {
            StringBuilder code = new StringBuilder();
            code.Append("^XA\n");
            foreach (LabelItem item in LabelDesigner.Controls.OfType<LabelItem>())
            {
                code.Append(string.Format("\n^FO{0},{1}\n", item.Location.X, item.Location.Y));
                code.Append(item.zpl);
                code.Append("\n");
            }
            code.Append("\n^XZ\n");
            string s = code.ToString();
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s);
            }
        }
    }
}
