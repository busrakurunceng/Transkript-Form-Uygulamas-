namespace veritabanı_ödevi
{
    partial class Kayit_silme
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
            this.sil_btn = new System.Windows.Forms.Button();
            this.silme_kod_lbl = new System.Windows.Forms.Label();
            this.sil_kod_txtbox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sil_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sil_btn.Location = new System.Drawing.Point(410, 400);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(100, 36);
            this.sil_btn.TabIndex = 54;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // silme_kod_lbl
            // 
            this.silme_kod_lbl.AutoSize = true;
            this.silme_kod_lbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.silme_kod_lbl.Location = new System.Drawing.Point(104, 410);
            this.silme_kod_lbl.Name = "silme_kod_lbl";
            this.silme_kod_lbl.Size = new System.Drawing.Size(141, 16);
            this.silme_kod_lbl.TabIndex = 53;
            this.silme_kod_lbl.Text = "Silinecek Dersin Kodu:";
            // 
            // sil_kod_txtbox
            // 
            this.sil_kod_txtbox.Location = new System.Drawing.Point(265, 407);
            this.sil_kod_txtbox.Name = "sil_kod_txtbox";
            this.sil_kod_txtbox.Size = new System.Drawing.Size(100, 22);
            this.sil_kod_txtbox.TabIndex = 52;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView2.Location = new System.Drawing.Point(23, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(575, 335);
            this.dataGridView2.TabIndex = 51;
            // 
            // Kayit_silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(623, 517);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.silme_kod_lbl);
            this.Controls.Add(this.sil_kod_txtbox);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Kayit_silme";
            this.Text = "Kayıt Sil";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Label silme_kod_lbl;
        private System.Windows.Forms.TextBox sil_kod_txtbox;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}