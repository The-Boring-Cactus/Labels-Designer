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
    [Serializable]
    public partial class LabelItem : UserControl
    {
        private Image qrcode;
        public Boolean remove = false;
        public Boolean toselect = false;
        public event EventHandler<RemoveEvent> Remove;

        public event EventHandler<PositionEvent> PositionUpdate;
        public event EventHandler<SelectEvent> WasSelected;
        public bool isSelected = false;

        bool selected = false;
        private Point MouseDownLocation;
        public string uuid = "";
        public string zpl = "";

        public string zpl_gen = "";

        public LabelItem(Image qrcode)
        {
            InitializeComponent();
            this.qrcode = qrcode;
            this.itempic.Image = this.qrcode;

            Guid g = Guid.NewGuid();
            uuid = g.ToString();
        }
        
        
        private void LabelItem_MouseEnter(object sender, EventArgs e)
        {
            //this.BorderStyle = BorderStyle.FixedSingle;
            if (!isSelected)
                this.BackColor = Color.Orange;
        }

        private void LabelItem_MouseLeave(object sender, EventArgs e)
        {
            //this.BorderStyle = BorderStyle.None;
            if (!isSelected)
                this.BackColor = Color.Transparent;
        }

        private void itempic_MouseEnter(object sender, EventArgs e)
        {
            //this.BorderStyle = BorderStyle.FixedSingle;
            if (!isSelected)
                this.BackColor = Color.Orange;
        }

        private void itempic_MouseLeave(object sender, EventArgs e)
        {
            //this.BorderStyle = BorderStyle.None;
            if(!isSelected)
                this.BackColor = Color.Transparent;
        }

        public void resetSelect()
        {
            this.isSelected = false;
            this.toselect = false;
            this.BackColor = Color.Transparent;
        }
       
        private void itempic_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
                selected = true;
                if(PositionUpdate!=null)
                {
                    PositionUpdate.Invoke(this, new PositionEvent(this.Left.ToString(), this.Top.ToString()));
                }
                if(toselect)
                {
                    if (!this.isSelected)
                    {
                        this.isSelected = true;
                        this.BackColor = Color.GreenYellow;
                        if (WasSelected != null)
                        {
                            WasSelected.Invoke(this, new SelectEvent(uuid, SelAction.Add));
                        }
                    }
                    else
                    {
                        this.isSelected = false;
                        this.BackColor = Color.Transparent;
                        if (WasSelected != null)
                        {
                            WasSelected.Invoke(this, new SelectEvent(uuid, SelAction.Remove));
                        }
                    }
                }
                if(remove)
                {
                    if (Remove != null)
                    {
                        Remove.Invoke(this, new RemoveEvent(uuid));
                    }
                }
            }
           
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.BringToFront();
            }

            

        }

        private void itempic_MouseUp(object sender, MouseEventArgs e)
        {

            selected = false;
            if (PositionUpdate != null)
            {
                PositionUpdate.Invoke(this, new PositionEvent("", ""));
            }
        }

        private void itempic_MouseMove(object sender, MouseEventArgs e)
        {
            if (selected == true)
            {
                this.Left = e.X + this.Left - MouseDownLocation.X;
                this.Top = e.Y + this.Top - MouseDownLocation.Y;
                if (PositionUpdate != null)
                {
                    PositionUpdate.Invoke(this, new PositionEvent(this.Left.ToString(), this.Top.ToString()));
                }
            }
        }
    }
}
