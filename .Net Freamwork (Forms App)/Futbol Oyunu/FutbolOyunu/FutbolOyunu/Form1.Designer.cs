namespace FutbolOyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pngkale = new System.Windows.Forms.PictureBox();
            this.pngtop = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pngbekci = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pngkale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngtop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngbekci)).BeginInit();
            this.SuspendLayout();
            // 
            // pngkale
            // 
            this.pngkale.Image = ((System.Drawing.Image)(resources.GetObject("pngkale.Image")));
            this.pngkale.Location = new System.Drawing.Point(114, 12);
            this.pngkale.Name = "pngkale";
            this.pngkale.Size = new System.Drawing.Size(890, 440);
            this.pngkale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngkale.TabIndex = 0;
            this.pngkale.TabStop = false;
            // 
            // pngtop
            // 
            this.pngtop.Image = ((System.Drawing.Image)(resources.GetObject("pngtop.Image")));
            this.pngtop.Location = new System.Drawing.Point(507, 634);
            this.pngtop.Name = "pngtop";
            this.pngtop.Size = new System.Drawing.Size(141, 106);
            this.pngtop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngtop.TabIndex = 2;
            this.pngtop.TabStop = false;
            this.pngtop.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 753);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pngbekci
            // 
            this.pngbekci.Image = ((System.Drawing.Image)(resources.GetObject("pngbekci.Image")));
            this.pngbekci.Location = new System.Drawing.Point(447, 37);
            this.pngbekci.Name = "pngbekci";
            this.pngbekci.Size = new System.Drawing.Size(257, 415);
            this.pngbekci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pngbekci.TabIndex = 1;
            this.pngbekci.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 750);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "ORTA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(789, 747);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 75);
            this.button5.TabIndex = 8;
            this.button5.Text = "Sağ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 903);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pngtop);
            this.Controls.Add(this.pngbekci);
            this.Controls.Add(this.pngkale);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pngkale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngtop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pngbekci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pngkale;
        private System.Windows.Forms.PictureBox pngtop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pngbekci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer4;
    }
}

