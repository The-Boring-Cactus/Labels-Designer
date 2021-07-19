namespace LabelDesigner.Parameters
{
    partial class GraphicCircle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicCircle));
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ccolor = new System.Windows.Forms.ComboBox();
            this.lcolor = new System.Windows.Forms.Label();
            this.cborder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lthickness = new System.Windows.Forms.Label();
            this.cdiameter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lcheight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 51;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 52);
            this.label5.TabIndex = 50;
            this.label5.Text = "Values:\r\nB = black\r\nW = white\r\nDefault: B";
            // 
            // ccolor
            // 
            this.ccolor.FormattingEnabled = true;
            this.ccolor.Items.AddRange(new object[] {
            "B",
            "W"});
            this.ccolor.Location = new System.Drawing.Point(129, 113);
            this.ccolor.Name = "ccolor";
            this.ccolor.Size = new System.Drawing.Size(121, 21);
            this.ccolor.TabIndex = 49;
            this.ccolor.Text = "B";
            // 
            // lcolor
            // 
            this.lcolor.AutoSize = true;
            this.lcolor.Location = new System.Drawing.Point(12, 113);
            this.lcolor.Name = "lcolor";
            this.lcolor.Size = new System.Drawing.Size(53, 13);
            this.lcolor.TabIndex = 48;
            this.lcolor.Text = "Line color";
            // 
            // cborder
            // 
            this.cborder.Location = new System.Drawing.Point(129, 69);
            this.cborder.Name = "cborder";
            this.cborder.Size = new System.Drawing.Size(121, 20);
            this.cborder.TabIndex = 47;
            this.cborder.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 46;
            this.label3.Text = "Values: 2 to 4095\r\nDefault: 1";
            // 
            // lthickness
            // 
            this.lthickness.AutoSize = true;
            this.lthickness.Location = new System.Drawing.Point(12, 72);
            this.lthickness.Name = "lthickness";
            this.lthickness.Size = new System.Drawing.Size(89, 26);
            this.lthickness.TabIndex = 45;
            this.lthickness.Text = "Border thickness \r\n(in dots)";
            // 
            // cdiameter
            // 
            this.cdiameter.Location = new System.Drawing.Point(129, 21);
            this.cdiameter.Name = "cdiameter";
            this.cdiameter.Size = new System.Drawing.Size(121, 20);
            this.cdiameter.TabIndex = 44;
            this.cdiameter.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 43;
            this.label1.Text = "Values: 3 to 4095 (larger values\r\n are replaced with 4095)\r\nDefault: 3";
            // 
            // lcheight
            // 
            this.lcheight.AutoSize = true;
            this.lcheight.Location = new System.Drawing.Point(12, 24);
            this.lcheight.Name = "lcheight";
            this.lcheight.Size = new System.Drawing.Size(90, 26);
            this.lcheight.TabIndex = 42;
            this.lcheight.Text = "Circle diameter (in\r\ndots)";
            // 
            // GraphicCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccolor);
            this.Controls.Add(this.lcolor);
            this.Controls.Add(this.cborder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lthickness);
            this.Controls.Add(this.cdiameter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lcheight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphicCircle";
            this.Text = "Graphic Circle";
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
        public System.Windows.Forms.TextBox cdiameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lcheight;
    }
}