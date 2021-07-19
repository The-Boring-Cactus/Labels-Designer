namespace LabelDesigner.Parameters
{
    partial class PDF417BarCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF417BarCode));
            this.label1 = new System.Windows.Forms.Label();
            this.corientation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cheight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.csecurity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ccolumns = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.crows = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ctruncate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 78);
            this.label1.TabIndex = 90;
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
            this.corientation.Location = new System.Drawing.Point(122, 18);
            this.corientation.Name = "corientation";
            this.corientation.Size = new System.Drawing.Size(121, 21);
            this.corientation.TabIndex = 89;
            this.corientation.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Orientation";
            // 
            // cheight
            // 
            this.cheight.Location = new System.Drawing.Point(122, 105);
            this.cheight.Name = "cheight";
            this.cheight.Size = new System.Drawing.Size(121, 20);
            this.cheight.TabIndex = 93;
            this.cheight.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 52);
            this.label4.TabIndex = 92;
            this.label4.Text = "Values: 1 to height of label\r\nDefault: value set by ^BY\r\nThis number multiplied b" +
    "y the module equals the height of the individual\r\nrows in dots.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 91;
            this.label3.Text = "Bar code height for\r\nindividual rows (in dots)";
            // 
            // csecurity
            // 
            this.csecurity.Location = new System.Drawing.Point(122, 163);
            this.csecurity.Name = "csecurity";
            this.csecurity.Size = new System.Drawing.Size(121, 20);
            this.csecurity.TabIndex = 96;
            this.csecurity.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 65);
            this.label5.TabIndex = 95;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "Security level";
            // 
            // ccolumns
            // 
            this.ccolumns.Location = new System.Drawing.Point(122, 241);
            this.ccolumns.Name = "ccolumns";
            this.ccolumns.Size = new System.Drawing.Size(121, 20);
            this.ccolumns.TabIndex = 99;
            this.ccolumns.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 52);
            this.label7.TabIndex = 98;
            this.label7.Text = "Values: 1 to 30\r\nDefault: 1:2 (row-to-column aspect ratio)\r\nYou can specify the n" +
    "umber of code-word columns giving control over the\r\nwidth of the symbol.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 26);
            this.label8.TabIndex = 97;
            this.label8.Text = "Number of data\r\ncolumns to encode";
            // 
            // crows
            // 
            this.crows.Location = new System.Drawing.Point(122, 315);
            this.crows.Name = "crows";
            this.crows.Size = new System.Drawing.Size(121, 20);
            this.crows.TabIndex = 102;
            this.crows.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(354, 52);
            this.label9.TabIndex = 101;
            this.label9.Text = "Values: 1 to 30\r\nDefault: 1:2 (row-to-column aspect ratio)\r\nYou can specify the n" +
    "umber of code-word columns giving control over the\r\nwidth of the symbol.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 26);
            this.label10.TabIndex = 100;
            this.label10.Text = "Number of rows to\r\nencode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 52);
            this.label11.TabIndex = 105;
            this.label11.Text = "Values:\r\nN = no truncation\r\nY = perform truncation\r\nDefault: N";
            // 
            // ctruncate
            // 
            this.ctruncate.FormattingEnabled = true;
            this.ctruncate.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ctruncate.Location = new System.Drawing.Point(122, 382);
            this.ctruncate.Name = "ctruncate";
            this.ctruncate.Size = new System.Drawing.Size(121, 21);
            this.ctruncate.TabIndex = 104;
            this.ctruncate.Text = "N";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 39);
            this.label12.TabIndex = 103;
            this.label12.Text = "Truncate right row\r\nindicators and stop\r\npattern";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 445);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 106;
            this.label13.Text = "Data";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(122, 445);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(488, 20);
            this.data.TabIndex = 107;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 108;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PDF417BarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ctruncate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.crows);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ccolumns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.csecurity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cheight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.corientation);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PDF417BarCode";
            this.Text = "PDF417 Bar Code ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox corientation;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox cheight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox csecurity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox ccolumns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox crows;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox ctruncate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Button button1;
    }
}