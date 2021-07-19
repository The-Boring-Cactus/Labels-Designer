namespace LabelDesigner.Parameters
{
    partial class GraphicDiagonalLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicDiagonalLine));
            this.cwidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.corientation = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cwidth
            // 
            this.cwidth.Location = new System.Drawing.Point(129, 15);
            this.cwidth.Name = "cwidth";
            this.cwidth.Size = new System.Drawing.Size(121, 20);
            this.cwidth.TabIndex = 77;
            this.cwidth.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 76;
            this.label2.Text = "Values: 3 to 32000\r\nDefault: value of t (thickness) or 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Box width (in dots)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 74;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 52);
            this.label5.TabIndex = 73;
            this.label5.Text = "Values:\r\nB = black\r\nW = white\r\nDefault: B";
            // 
            // ccolor
            // 
            this.ccolor.FormattingEnabled = true;
            this.ccolor.Items.AddRange(new object[] {
            "B",
            "W"});
            this.ccolor.Location = new System.Drawing.Point(129, 161);
            this.ccolor.Name = "ccolor";
            this.ccolor.Size = new System.Drawing.Size(121, 21);
            this.ccolor.TabIndex = 72;
            this.ccolor.Text = "B";
            // 
            // lcolor
            // 
            this.lcolor.AutoSize = true;
            this.lcolor.Location = new System.Drawing.Point(12, 161);
            this.lcolor.Name = "lcolor";
            this.lcolor.Size = new System.Drawing.Size(53, 13);
            this.lcolor.TabIndex = 71;
            this.lcolor.Text = "Line color";
            // 
            // cborder
            // 
            this.cborder.Location = new System.Drawing.Point(129, 117);
            this.cborder.Name = "cborder";
            this.cborder.Size = new System.Drawing.Size(121, 20);
            this.cborder.TabIndex = 70;
            this.cborder.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 69;
            this.label3.Text = "Values: 1 to 32000\r\nDefault: 1";
            // 
            // lthickness
            // 
            this.lthickness.AutoSize = true;
            this.lthickness.Location = new System.Drawing.Point(12, 120);
            this.lthickness.Name = "lthickness";
            this.lthickness.Size = new System.Drawing.Size(89, 26);
            this.lthickness.TabIndex = 68;
            this.lthickness.Text = "Border thickness \r\n(in dots)";
            // 
            // cheight
            // 
            this.cheight.Location = new System.Drawing.Point(129, 69);
            this.cheight.Name = "cheight";
            this.cheight.Size = new System.Drawing.Size(121, 20);
            this.cheight.TabIndex = 67;
            this.cheight.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 66;
            this.label1.Text = "Values: 3 to 32000\r\nDefault: value of t (thickness) or 3";
            // 
            // lcheight
            // 
            this.lcheight.AutoSize = true;
            this.lcheight.Location = new System.Drawing.Point(12, 72);
            this.lcheight.Name = "lcheight";
            this.lcheight.Size = new System.Drawing.Size(71, 26);
            this.lcheight.TabIndex = 65;
            this.lcheight.Text = "Box height (in\r\ndots)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 52);
            this.label6.TabIndex = 80;
            this.label6.Text = "Values:\r\nR (or /) = right-leaning diagonal\r\nL (or \\) = left-leaning diagonal\r\nDef" +
    "ault: R";
            // 
            // corientation
            // 
            this.corientation.FormattingEnabled = true;
            this.corientation.Items.AddRange(new object[] {
            "R",
            "L"});
            this.corientation.Location = new System.Drawing.Point(129, 222);
            this.corientation.Name = "corientation";
            this.corientation.Size = new System.Drawing.Size(121, 21);
            this.corientation.TabIndex = 79;
            this.corientation.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Orientation";
            // 
            // GraphicDiagonalLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 357);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.corientation);
            this.Controls.Add(this.label7);
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
            this.Name = "GraphicDiagonalLine";
            this.Text = "Graphic Diagonal Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox cwidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox corientation;
        private System.Windows.Forms.Label label7;
    }
}