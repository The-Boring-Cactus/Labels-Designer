namespace LabelDesigner.Parameters
{
    partial class BC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BC));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.orientation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printline = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bcheight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lineavobe = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ucc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mode = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cwidth = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bcR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orientation";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orientation
            // 
            this.orientation.FormattingEnabled = true;
            this.orientation.Items.AddRange(new object[] {
            "N",
            "R",
            "I",
            "B"});
            this.orientation.Location = new System.Drawing.Point(129, 137);
            this.orientation.Name = "orientation";
            this.orientation.Size = new System.Drawing.Size(121, 21);
            this.orientation.TabIndex = 1;
            this.orientation.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 65);
            this.label2.TabIndex = 2;
            this.label2.Text = "Values:\r\nN = normal\r\nR = rotated 90 degrees (clockwise)\r\nI = inverted 180 degrees" +
    "\r\nB = read from bottom up, 270 degrees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bar code height (dots)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Values: 1 to 32000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Values: \r\nY (yes) or N (no)\r\nDefault: Y";
            // 
            // printline
            // 
            this.printline.FormattingEnabled = true;
            this.printline.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.printline.Location = new System.Drawing.Point(129, 207);
            this.printline.Name = "printline";
            this.printline.Size = new System.Drawing.Size(121, 21);
            this.printline.TabIndex = 7;
            this.printline.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Print interpretation line";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(118, 439);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(258, 20);
            this.data.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bcheight
            // 
            this.bcheight.Location = new System.Drawing.Point(129, 99);
            this.bcheight.Name = "bcheight";
            this.bcheight.Size = new System.Drawing.Size(121, 20);
            this.bcheight.TabIndex = 12;
            this.bcheight.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 39);
            this.label8.TabIndex = 15;
            this.label8.Text = "Values: \r\nY (yes) or N (no)\r\nDefault: N";
            // 
            // lineavobe
            // 
            this.lineavobe.FormattingEnabled = true;
            this.lineavobe.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.lineavobe.Location = new System.Drawing.Point(129, 255);
            this.lineavobe.Name = "lineavobe";
            this.lineavobe.Size = new System.Drawing.Size(121, 21);
            this.lineavobe.TabIndex = 14;
            this.lineavobe.Text = "N";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Print interpretation line\r\nabove code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 39);
            this.label10.TabIndex = 18;
            this.label10.Text = "Values: \r\nY (yes) or N (no)\r\nDefault: N";
            // 
            // ucc
            // 
            this.ucc.FormattingEnabled = true;
            this.ucc.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.ucc.Location = new System.Drawing.Point(129, 303);
            this.ucc.Name = "ucc";
            this.ucc.Size = new System.Drawing.Size(121, 21);
            this.ucc.TabIndex = 17;
            this.ucc.Text = "N";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "UCC check digit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 78);
            this.label12.TabIndex = 21;
            this.label12.Text = "Values:\r\nN = no selected mode\r\nU = UCC Case Mode\r\nA = Automatic Mode\r\nD = UCC/EAN" +
    " Mode\r\nDefault: N";
            // 
            // mode
            // 
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "U",
            "N",
            "A",
            "D"});
            this.mode.Location = new System.Drawing.Point(129, 354);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(121, 21);
            this.mode.TabIndex = 20;
            this.mode.Text = "N";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Mode";
            // 
            // cwidth
            // 
            this.cwidth.Location = new System.Drawing.Point(129, 27);
            this.cwidth.Name = "cwidth";
            this.cwidth.Size = new System.Drawing.Size(121, 20);
            this.cwidth.TabIndex = 24;
            this.cwidth.Text = "2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(256, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 26);
            this.label14.TabIndex = 23;
            this.label14.Text = "Values: 1 to 10\r\nInitial Value at Power Up: 2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Bar code Width (dots)";
            // 
            // bcR
            // 
            this.bcR.Location = new System.Drawing.Point(128, 63);
            this.bcR.Name = "bcR";
            this.bcR.Size = new System.Drawing.Size(121, 20);
            this.bcR.TabIndex = 27;
            this.bcR.Text = "3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(255, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 26);
            this.label16.TabIndex = 26;
            this.label16.Text = "Values: 2.0 to 3.0, in 0.1 increments \r\nDefault: 3.0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 26);
            this.label17.TabIndex = 25;
            this.label17.Text = "Wide bar to narrow\r\nbar width ratio";
            // 
            // BC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 524);
            this.Controls.Add(this.bcR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cwidth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ucc);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lineavobe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bcheight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.printline);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orientation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BC";
            this.Text = "Code 128 Bar Code";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox orientation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox printline;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox data;
        public System.Windows.Forms.TextBox bcheight;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox lineavobe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox ucc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox cwidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox bcR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}