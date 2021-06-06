namespace ProjeBaslangıc
{
    partial class Hastakayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hastakayit));
            this.label7 = new System.Windows.Forms.Label();
            this.text_tel = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_parola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "Telefon No";
            // 
            // text_tel
            // 
            this.text_tel.Location = new System.Drawing.Point(147, 190);
            this.text_tel.Mask = "000-0000";
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(195, 34);
            this.text_tel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(147, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_cinsiyet
            // 
            this.text_cinsiyet.FormattingEnabled = true;
            this.text_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.text_cinsiyet.Location = new System.Drawing.Point(147, 295);
            this.text_cinsiyet.Name = "text_cinsiyet";
            this.text_cinsiyet.Size = new System.Drawing.Size(195, 34);
            this.text_cinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cinsiyet";
            // 
            // text_tc
            // 
            this.text_tc.Location = new System.Drawing.Point(150, 135);
            this.text_tc.Mask = "00000000000";
            this.text_tc.Name = "text_tc";
            this.text_tc.Size = new System.Drawing.Size(192, 34);
            this.text_tc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "T.C";
            // 
            // text_parola
            // 
            this.text_parola.Location = new System.Drawing.Point(147, 244);
            this.text_parola.Name = "text_parola";
            this.text_parola.Size = new System.Drawing.Size(195, 34);
            this.text_parola.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Parola";
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(150, 12);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(192, 34);
            this.text_ad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "SOYADI";
            // 
            // text_soyad
            // 
            this.text_soyad.Location = new System.Drawing.Point(150, 74);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.Size = new System.Drawing.Size(192, 34);
            this.text_soyad.TabIndex = 2;
            // 
            // Hastakayit
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(458, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_cinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_parola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Hastakayit";
            this.Text = "Hastakayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox text_tel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox text_cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox text_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_parola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_soyad;
    }
}