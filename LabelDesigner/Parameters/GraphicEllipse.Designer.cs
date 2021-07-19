namespace LabelDesigner.Parameters
{
    partial class GraphicEllipse
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicEllipse));
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ccolor = new System.Windows.Forms.ComboBox();
            this.lcolor = new System.Windows.Forms.Label();
            this.cborder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lthickness = new System.Windows.Forms.Label();
            this.cheight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lcheight = new System.Windows.Forms.Label();
            this.cwidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 61;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 52);
            this.label5.TabIndex = 60;
            this.label5.Text = "Values:\r\nB = black\r\nW = white\r\nDefault: B";
            // 
            // ccolor
            // 
            this.ccolor.FormattingEnabled = true;
            this.ccolor.Items.AddRange(new object[] {
            "B",
            "W"});
            this.ccolor.Location = new System.Drawing.Point(129, 156);
            this.ccolor.Name = "ccolor";
            this.ccolor.Size = new System.Drawing.Size(121, 21);
            this.ccolor.TabIndex = 59;
            this.ccolor.Text = "B";
            // 
            // lcolor
            // 
            this.lcolor.AutoSize = true;
            this.lcolor.Location = new System.Drawing.Point(12, 156);
            this.lcolor.Name = "lcolor";
            this.lcolor.Size = new System.Drawing.Size(53, 13);
            this.lcolor.TabIndex = 58;
            this.lcolor.Text = "Line color";
            // 
            // cborder
            // 
            this.cborder.Location = new System.Drawing.Point(129, 112);
            this.cborder.Name = "cborder";
            this.cborder.Size = new System.Drawing.Size(121, 20);
            this.cborder.TabIndex = 57;
            this.cborder.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 56;
            this.label3.Text = "Values: 2 to 4095\r\nDefault: 1";
            // 
            // lthickness
            // 
            this.lthickness.AutoSize = true;
            this.lthickness.Location = new System.Drawing.Point(12, 115);
            this.lthickness.Name = "lthickness";
            this.lthickness.Size = new System.Drawing.Size(89, 26);
            this.lthickness.TabIndex = 55;
            this.lthickness.Text = "Border thickness \r\n(in dots)";
            // 
            // cheight
            // 
            this.cheight.Location = new System.Drawing.Point(129, 64);
            this.cheight.Name = "cheight";
            this.cheight.Size = new System.Drawing.Size(121, 20);
            this.cheight.TabIndex = 54;
            this.cheight.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 26);
            this.label1.TabIndex = 53;
            this.label1.Text = "Values: 3 to 4095\r\nDefault: value used for thickness (t) or 1";
            // 
            // lcheight
            // 
            this.lcheight.AutoSize = true;
            this.lcheight.Location = new System.Drawing.Point(12, 67);
            this.lcheight.Name = "lcheight";
            this.lcheight.Size = new System.Drawing.Size(83, 26);
            this.lcheight.TabIndex = 52;
            this.lcheight.Text = "Ellipse height (in\r\ndots)";
            // 
            // cwidth
            // 
            this.cwidth.Location = new System.Drawing.Point(129, 10);
            this.cwidth.Name = "cwidth";
            this.cwidth.Size = new System.Drawing.Size(121, 20);
            this.cwidth.TabIndex = 64;
            this.cwidth.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 26);
            this.label2.TabIndex = 63;
            this.label2.Text = "Values: 3 to 4095 (larger values are replaced with 4095)\r\nDefault: value used for" +
    " thickness (t) or 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Ellipse width (in dots)";
            // 
            // GraphicEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 288);
            this.Controls.Add(this.cwidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccolor);
            this.Controls.Add(this.lcolor);
            this.Controls.Add(this.cborder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lthickness);
            this.Controls.Add(this.cheight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lcheight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicEllipse";
            this.Text = "Graphic Ellipse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox ccolor;
        private System.Windows.Forms.Label lcolor;
        public System.Windows.Forms.TextBox cborder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lthickness;
        public System.Windows.Forms.TextBox cheight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lcheight;
        public System.Windows.Forms.TextBox cwidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}