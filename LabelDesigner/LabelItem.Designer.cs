
namespace LabelDesigner
{
    partial class LabelItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itempic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).BeginInit();
            this.SuspendLayout();
            // 
            // itempic
            // 
            this.itempic.BackColor = System.Drawing.Color.Transparent;
            this.itempic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itempic.Location = new System.Drawing.Point(0, 0);
            this.itempic.Name = "itempic";
            this.itempic.Size = new System.Drawing.Size(240, 162);
            this.itempic.TabIndex = 0;
            this.itempic.TabStop = false;
            this.itempic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.itempic_MouseDown);
            this.itempic.MouseEnter += new System.EventHandler(this.itempic_MouseEnter);
            this.itempic.MouseLeave += new System.EventHandler(this.itempic_MouseLeave);
            this.itempic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.itempic_MouseMove);
            this.itempic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.itempic_MouseUp);
            // 
            // LabelItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.itempic);
            this.Name = "LabelItem";
            this.Size = new System.Drawing.Size(240, 162);
            ((System.ComponentModel.ISupportInitialize)(this.itempic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox itempic;
    }
}
