﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBLReader
{
    public partial class LabelItem : UserControl
    {
        private Image qrcode;

        //public LabelItem()
        //{
        //    InitializeComponent();
        //}

        bool selected = false;
        private Point MouseDownLocation;

        public string zpl = "";

        public LabelItem(Image qrcode)
        {
            InitializeComponent();
            this.qrcode = qrcode;
            this.itempic.Image = this.qrcode;
        }

        private void LabelItem_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void LabelItem_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

        private void itempic_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void itempic_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.None;
        }

       
        private void itempic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                selected = true;
            }
           

        }

        private void itempic_MouseUp(object sender, MouseEventArgs e)
        {

            selected = false;
        }

        private void itempic_MouseMove(object sender, MouseEventArgs e)
        {
            if (selected == true)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
            }
        }
    }
}
