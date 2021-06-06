namespace E_Okul
{
    partial class FrmOgrenci_islem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.text_kulup = new System.Windows.Forms.ComboBox();
            this.text_cinsiyet = new System.Windows.Forms.ComboBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.text_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 482);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(125, 32);
            this.text_ad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_ad.Name = "text_ad";
            this.text_ad.Size = new System.Drawing.Size(143, 39);
            this.text_ad.TabIndex = 2;
            // 
            // text_soyad
            // 
            this.text_soyad.Location = new System.Drawing.Point(125, 88);
            this.text_soyad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.Size = new System.Drawing.Size(143, 39);
            this.text_soyad.TabIndex = 3;
            // 
            // text_kulup
            // 
            this.text_kulup.Font = new System.Drawing.Font("Arial", 10.2F);
            this.text_kulup.FormattingEnabled = true;
            this.text_kulup.Location = new System.Drawing.Point(125, 158);
            this.text_kulup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_kulup.Name = "text_kulup";
            this.text_kulup.Size = new System.Drawing.Size(143, 27);
            this.text_kulup.TabIndex = 8;
            // 
            // text_cinsiyet
            // 
            this.text_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_cinsiyet.FormattingEnabled = true;
            this.text_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.text_cinsiyet.Location = new System.Drawing.Point(125, 209);
            this.text_cinsiyet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_cinsiyet.Name = "text_cinsiyet";
            this.text_cinsiyet.Size = new System.Drawing.Size(143, 40);
            this.text_cinsiyet.TabIndex = 9;
            // 
            // text_id
            // 
            this.text_id.Font = new System.Drawing.Font("Arial", 1.2F);
            this.text_id.Location = new System.Drawing.Point(16, 12);
            this.text_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(23, 10);
            this.text_id.TabIndex = 10;
            this.text_id.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.2F);
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.2F);
            this.label3.Location = new System.Drawing.Point(11, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kulup :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.2F);
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soy Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.2F);
            this.label5.Location = new System.Drawing.Point(11, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cinsiyet :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 288);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 346);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 47);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 288);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 52);
            this.button3.TabIndex = 18;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // text_search
            // 
            this.text_search.Location = new System.Drawing.Point(62, 426);
            this.text_search.Name = "text_search";
            this.text_search.Size = new System.Drawing.Size(184, 39);
            this.text_search.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.2F);
            this.label1.Location = new System.Drawing.Point(1, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ara :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 421);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 39);
            this.button4.TabIndex = 21;
            this.button4.Text = ">";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmOgrenci_islem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 487);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.text_cinsiyet);
            this.Controls.Add(this.text_kulup);
            this.Controls.Add(this.text_soyad);
            this.Controls.Add(this.text_ad);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "FrmOgrenci_islem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenci_islem";
            this.Load += new System.EventHandler(this.FrmOgrenci_islem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_ad;
        private System.Windows.Forms.TextBox text_soyad;
        private System.Windows.Forms.ComboBox text_kulup;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox text_cinsiyet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox text_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}