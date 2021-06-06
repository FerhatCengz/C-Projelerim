namespace ProjeBaslangıc
{
    partial class FrmBilgiDuzenle
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
            this.label7 = new System.Windows.Forms.Label();
            this.text_tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.text_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_parola = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Telefon No";
            // 
            // text_tel
            // 
            this.text_tel.Location = new System.Drawing.Point(135, 179);
            this.text_tel.Mask = "000-0000";
            this.text_tel.Name = "text_tel";
            this.text_tel.Size = new System.Drawing.Size(195, 36);
            this.text_tel.TabIndex = 35;
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(135, 343);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(192, 42);
            this.btn_bilgiguncelle.TabIndex = 34;
            this.btn_bilgiguncelle.Text = "Güncelle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = false;
            this.btn_bilgiguncelle.Click += new System.EventHandler(this.btn_bilgiguncelle_Click);
            // 
            // text_cinsiyet
            // 
            this.text_cinsiyet.FormattingEnabled = true;
            this.text_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.text_cinsiyet.Location = new System.Drawing.Point(135, 284);
            this.text_cinsiyet.Name = "text_cinsiyet";
            this.text_cinsiyet.Size = new System.Drawing.Size(195, 36);
            this.text_cinsiyet.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cinsiyet";
            // 
            // text_tc
            // 
            this.text_tc.Enabled = false;
            this.text_tc.Location = new System.Drawing.Point(138, 124);
            this.text_tc.Mask = "00000000000";
            this.text_tc.Name = "text_tc";
            this.text_tc.Size = new System.Drawing.Size(192, 36);
            this.text_tc.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "T.C";
            // 
            // text_parola
            // 
            this.text_parola.Location = new System.Drawing.Point(135, 233);
            this.text_parola.Name = "text_parola";
            this.text_parola.Size = new System.Drawing.Size(195, 36);
            this.text_parola.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Parola";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "ADI";
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(138, 28);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(192, 36);
            this.text_ad.TabIndex = 25;
            // 
            // text_soyad
            // 
            this.text_soyad.Location = new System.Drawing.Point(138, 76);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.Size = new System.Drawing.Size(192, 36);
            this.text_soyad.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Soyad";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.btn_bilgiguncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(430, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_soyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_tel);
            this.Controls.Add(this.btn_bilgiguncelle);
            this.Controls.Add(this.text_cinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_parola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "FrmBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox text_tel;
        private System.Windows.Forms.Button btn_bilgiguncelle;
        private System.Windows.Forms.ComboBox text_cinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox text_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_parola;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.TextBox text_soyad;
        private System.Windows.Forms.Label label1;
    }
}