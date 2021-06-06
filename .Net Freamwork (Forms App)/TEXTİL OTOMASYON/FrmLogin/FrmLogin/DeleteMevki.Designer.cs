namespace FrmLogin
{
    partial class DeleteMevki
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.data_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(23, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // data_grid
            // 
            this.data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_grid.Location = new System.Drawing.Point(0, 0);
            this.data_grid.Name = "data_grid";
            this.data_grid.RowTemplate.Height = 24;
            this.data_grid.Size = new System.Drawing.Size(632, 333);
            this.data_grid.TabIndex = 2;
            this.data_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellDoubleClick);
            // 
            // DeleteMevki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 333);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.textBox1);
            this.Name = "DeleteMevki";
            this.Text = "DeleteMevki";
            this.Load += new System.EventHandler(this.DeleteMevki_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView data_grid;
    }
}