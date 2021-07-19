namespace LabelDesigner.Parameters
{
    partial class GraphicSymbol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicSymbol));
            this.label6 = new System.Windows.Forms.Label();
            this.csymbol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.corientation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cwidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cheight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lcheight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 78);
            this.label6.TabIndex = 84;
            this.label6.Text = "Values\r\nA = Registered Trade Mark\r\nB = Copyright\r\nC = Trade Mark\r\nD = Underwriter" +
    "s Laboratories approval\r\nE = Canadian Standards Association approval";
            // 
            // csymbol
            // 
            this.csymbol.FormattingEnabled = true;
            this.csymbol.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.csymbol.Location = new System.Drawing.Point(126, 24);
            this.csymbol.Name = "csymbol";
            this.csymbol.Size = new System.Drawing.Size(121, 21);
            this.csymbol.TabIndex = 83;
            this.csymbol.Text = "A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Line color";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 81;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 78);
            this.label1.TabIndex = 87;
            this.label1.Text = "Values:\r\nN = normal\r\nR = rotate 90 degrees clockwise\r\nI = inverted 180 degrees\r\nB" +
    " = bottom-up, 270 degrees\r\nDefault: N or last";
            // 
            // corientation
            // 
            this.corientation.FormattingEnabled = true;
            this.corientation.Items.AddRange(new object[] {
            "N",
            "R",
            "I",
            "B"});
            this.corientation.Location = new System.Drawing.Point(126, 117);
            this.corientation.Name = "corientation";
            this.corientation.Size = new System.Drawing.Size(121, 21);
            this.corientation.TabIndex = 86;
            this.corientation.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Orientation";
            // 
            // cwidth
            // 
            this.cwidth.Location = new System.Drawing.Point(126, 207);
            this.cwidth.Name = "cwidth";
            this.cwidth.Size = new System.Drawing.Size(121, 20);
            this.cwidth.TabIndex = 93;
            this.cwidth.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 92;
            this.label3.Text = "Values: 0 to 32000\r\nDefault: last ^CF value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 39);
            this.label4.TabIndex = 91;
            this.label4.Text = "Character height\r\nproportional to width (in\r\ndots)";
            // 
            // cheight
            // 
            this.cheight.Location = new System.Drawing.Point(126, 261);
            this.cheight.Name = "cheight";
            this.cheight.Size = new System.Drawing.Size(121, 20);
            this.cheight.TabIndex = 90;
            this.cheight.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 89;
            this.label5.Text = "Values: 0 to 32000\r\nDefault: last ^CF value\r\n";
            // 
            // lcheight
            // 
            this.lcheight.AutoSize = true;
            this.lcheight.Location = new System.Drawing.Point(0, 210);
            this.lcheight.Name = "lcheight";
            this.lcheight.Size = new System.Drawing.Size(120, 39);
            this.lcheight.TabIndex = 88;
            this.lcheight.Text = "Character width\r\nproportional to height (in\r\ndots)";
            // 
            // GraphicSymbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 389);
            this.Controls.Add(this.cwidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cheight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lcheight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.corientation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.csymbol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicSymbol";
            this.Text = "Graphic Symbol ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox csymbol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox corientation;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox cwidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox cheight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lcheight;
    }
}