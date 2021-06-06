namespace Acsses_Kitaplik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.text_yazar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_sayfa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tur = new System.Windows.Forms.ComboBox();
            this.radio_k = new System.Windows.Forms.RadioButton();
            this.radio_s = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(5, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap ID";
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(146, 80);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(209, 28);
            this.text_ad.TabIndex = 2;
            // 
            // text_yazar
            // 
            this.text_yazar.Location = new System.Drawing.Point(146, 114);
            this.text_yazar.Name = "text_yazar";
            this.text_yazar.Size = new System.Drawing.Size(209, 28);
            this.text_yazar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap ADI";
            // 
            // text_sayfa
            // 
            this.text_sayfa.Location = new System.Drawing.Point(146, 148);
            this.text_sayfa.Name = "text_sayfa";
            this.text_sayfa.Size = new System.Drawing.Size(209, 28);
            this.text_sayfa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yazar";
            // 
            // cmb_tur
            // 
            this.cmb_tur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tur.FormattingEnabled = true;
            this.cmb_tur.Location = new System.Drawing.Point(146, 185);
            this.cmb_tur.Name = "cmb_tur";
            this.cmb_tur.Size = new System.Drawing.Size(209, 29);
            this.cmb_tur.TabIndex = 7;
            this.cmb_tur.SelectedIndexChanged += new System.EventHandler(this.cmb_tur_SelectedIndexChanged);
            // 
            // radio_k
            // 
            this.radio_k.AutoSize = true;
            this.radio_k.Location = new System.Drawing.Point(146, 231);
            this.radio_k.Name = "radio_k";
            this.radio_k.Size = new System.Drawing.Size(88, 25);
            this.radio_k.TabIndex = 8;
            this.radio_k.TabStop = true;
            this.radio_k.Text = "İkinci El";
            this.radio_k.UseVisualStyleBackColor = true;
            this.radio_k.CheckedChanged += new System.EventHandler(this.radio_k_CheckedChanged);
            // 
            // radio_s
            // 
            this.radio_s.AutoSize = true;
            this.radio_s.Location = new System.Drawing.Point(277, 231);
            this.radio_s.Name = "radio_s";
            this.radio_s.Size = new System.Drawing.Size(61, 25);
            this.radio_s.TabIndex = 9;
            this.radio_s.TabStop = true;
            this.radio_s.Text = "Sıfır";
            this.radio_s.UseVisualStyleBackColor = true;
            this.radio_s.CheckedChanged += new System.EventHandler(this.radio_s_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // text_id
            // 
            this.text_id.Enabled = false;
            this.text_id.Location = new System.Drawing.Point(146, 46);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(209, 28);
            this.text_id.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tür";
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(442, 33);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(139, 51);
            this.btn_listele.TabIndex = 13;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(442, 97);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(139, 51);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(442, 161);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(139, 51);
            this.btn_sil.TabIndex = 15;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(442, 218);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(139, 51);
            this.btn_guncelle.TabIndex = 16;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(648, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(648, 241);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(159, 28);
            this.text_search.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(931, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radio_s);
            this.Controls.Add(this.radio_k);
            this.Controls.Add(this.cmb_tur);
            this.Controls.Add(this.text_sayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_yazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.TextBox text_yazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_sayfa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tur;
        private System.Windows.Forms.RadioButton radio_k;
        private System.Windows.Forms.RadioButton radio_s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Button button1;
    }
}

