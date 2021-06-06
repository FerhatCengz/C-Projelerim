namespace ProjeBaslangıc
{
    partial class Dr_BilgiDuzenle
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
            this.btn_bilgiguncelle = new System.Windows.Forms.Button();
            this.text_tc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_brans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_bilgiguncelle
            // 
            this.btn_bilgiguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_bilgiguncelle.Location = new System.Drawing.Point(167, 371);
            this.btn_bilgiguncelle.Name = "btn_bilgiguncelle";
            this.btn_bilgiguncelle.Size = new System.Drawing.Size(192, 42);
            this.btn_bilgiguncelle.TabIndex = 47;
            this.btn_bilgiguncelle.Text = "Güncelle";
            this.btn_bilgiguncelle.UseVisualStyleBackColor = false;
            // 
            // text_tc
            // 
            this.text_tc.Location = new System.Drawing.Point(170, 152);
            this.text_tc.Mask = "00000000000";
            this.text_tc.Name = "text_tc";
            this.text_tc.Size = new System.Drawing.Size(192, 36);
            this.text_tc.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "T.C";
            // 
            // text_soyad
            // 
            this.text_soyad.Location = new System.Drawing.Point(170, 89);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.Size = new System.Drawing.Size(192, 36);
            this.text_soyad.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "SOYADI";
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(170, 29);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(192, 36);
            this.text_ad.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "ADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 41;
            this.label5.Text = "Parola";
            // 
            // text_parola
            // 
            this.text_parola.Location = new System.Drawing.Point(167, 261);
            this.text_parola.Name = "text_parola";
            this.text_parola.Size = new System.Drawing.Size(195, 36);
            this.text_parola.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Branş";
            // 
            // cmb_brans
            // 
            this.cmb_brans.FormattingEnabled = true;
            this.cmb_brans.Location = new System.Drawing.Point(170, 209);
            this.cmb_brans.Name = "cmb_brans";
            this.cmb_brans.Size = new System.Drawing.Size(192, 36);
            this.cmb_brans.TabIndex = 50;
            // 
            // Dr_BilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(463, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_brans);
            this.Controls.Add(this.btn_bilgiguncelle);
            this.Controls.Add(this.text_tc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_parola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dr_BilgiDuzenle";
            this.Text = "Dr_BilgiDuzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bilgiguncelle;
        private System.Windows.Forms.MaskedTextBox text_tc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_soyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_brans;
    }
}