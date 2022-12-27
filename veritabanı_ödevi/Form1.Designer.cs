namespace veritabanı_ödevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.veri_tabani_dataGridView = new System.Windows.Forms.DataGridView();
            this.veri_tabani_groupbox = new System.Windows.Forms.GroupBox();
            this.kayit_goster_btn = new System.Windows.Forms.Button();
            this.fonksiyonlar_groupBox = new System.Windows.Forms.GroupBox();
            this.transkript_btn = new System.Windows.Forms.Button();
            this.kayit_guncelle_btn = new System.Windows.Forms.Button();
            this.kayit_sil_btn = new System.Windows.Forms.Button();
            this.kayit_ekle_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veri_tabani_dataGridView)).BeginInit();
            this.veri_tabani_groupbox.SuspendLayout();
            this.fonksiyonlar_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // veri_tabani_dataGridView
            // 
            this.veri_tabani_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.veri_tabani_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.veri_tabani_dataGridView.Location = new System.Drawing.Point(54, 66);
            this.veri_tabani_dataGridView.Name = "veri_tabani_dataGridView";
            this.veri_tabani_dataGridView.RowHeadersWidth = 51;
            this.veri_tabani_dataGridView.RowTemplate.Height = 24;
            this.veri_tabani_dataGridView.Size = new System.Drawing.Size(631, 257);
            this.veri_tabani_dataGridView.TabIndex = 0;
            // 
            // veri_tabani_groupbox
            // 
            this.veri_tabani_groupbox.BackColor = System.Drawing.Color.MistyRose;
            this.veri_tabani_groupbox.Controls.Add(this.kayit_goster_btn);
            this.veri_tabani_groupbox.Location = new System.Drawing.Point(32, 34);
            this.veri_tabani_groupbox.Name = "veri_tabani_groupbox";
            this.veri_tabani_groupbox.Size = new System.Drawing.Size(688, 349);
            this.veri_tabani_groupbox.TabIndex = 1;
            this.veri_tabani_groupbox.TabStop = false;
            this.veri_tabani_groupbox.Text = "Kayıt Gösterme Ekranı";
            // 
            // kayit_goster_btn
            // 
            this.kayit_goster_btn.BackColor = System.Drawing.Color.Yellow;
            this.kayit_goster_btn.Location = new System.Drawing.Point(534, 295);
            this.kayit_goster_btn.Name = "kayit_goster_btn";
            this.kayit_goster_btn.Size = new System.Drawing.Size(119, 48);
            this.kayit_goster_btn.TabIndex = 4;
            this.kayit_goster_btn.Text = "Kayıt Göster";
            this.kayit_goster_btn.UseVisualStyleBackColor = false;
            this.kayit_goster_btn.Click += new System.EventHandler(this.kayit_goster_btn_Click);
            // 
            // fonksiyonlar_groupBox
            // 
            this.fonksiyonlar_groupBox.Controls.Add(this.transkript_btn);
            this.fonksiyonlar_groupBox.Controls.Add(this.kayit_guncelle_btn);
            this.fonksiyonlar_groupBox.Controls.Add(this.kayit_sil_btn);
            this.fonksiyonlar_groupBox.Controls.Add(this.kayit_ekle_btn);
            this.fonksiyonlar_groupBox.ForeColor = System.Drawing.Color.Maroon;
            this.fonksiyonlar_groupBox.Location = new System.Drawing.Point(813, 34);
            this.fonksiyonlar_groupBox.Name = "fonksiyonlar_groupBox";
            this.fonksiyonlar_groupBox.Size = new System.Drawing.Size(465, 349);
            this.fonksiyonlar_groupBox.TabIndex = 2;
            this.fonksiyonlar_groupBox.TabStop = false;
            this.fonksiyonlar_groupBox.Text = "Fonksiyonlar";
            // 
            // transkript_btn
            // 
            this.transkript_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.transkript_btn.Location = new System.Drawing.Point(273, 241);
            this.transkript_btn.Name = "transkript_btn";
            this.transkript_btn.Size = new System.Drawing.Size(119, 48);
            this.transkript_btn.TabIndex = 3;
            this.transkript_btn.Text = "TRANSKRİPT HESAPLA";
            this.transkript_btn.UseVisualStyleBackColor = false;
            this.transkript_btn.Click += new System.EventHandler(this.transkript_btn_Click);
            // 
            // kayit_guncelle_btn
            // 
            this.kayit_guncelle_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kayit_guncelle_btn.Location = new System.Drawing.Point(88, 241);
            this.kayit_guncelle_btn.Name = "kayit_guncelle_btn";
            this.kayit_guncelle_btn.Size = new System.Drawing.Size(119, 48);
            this.kayit_guncelle_btn.TabIndex = 2;
            this.kayit_guncelle_btn.Text = "KAYIT GÜNCELLE";
            this.kayit_guncelle_btn.UseVisualStyleBackColor = false;
            this.kayit_guncelle_btn.Click += new System.EventHandler(this.kayit_guncelle_btn_Click);
            // 
            // kayit_sil_btn
            // 
            this.kayit_sil_btn.BackColor = System.Drawing.Color.Peru;
            this.kayit_sil_btn.Location = new System.Drawing.Point(273, 87);
            this.kayit_sil_btn.Name = "kayit_sil_btn";
            this.kayit_sil_btn.Size = new System.Drawing.Size(119, 48);
            this.kayit_sil_btn.TabIndex = 1;
            this.kayit_sil_btn.Text = "KAYIT SİL";
            this.kayit_sil_btn.UseVisualStyleBackColor = false;
            this.kayit_sil_btn.Click += new System.EventHandler(this.kayit_sil_btn_Click);
            // 
            // kayit_ekle_btn
            // 
            this.kayit_ekle_btn.BackColor = System.Drawing.Color.LightCoral;
            this.kayit_ekle_btn.Location = new System.Drawing.Point(88, 87);
            this.kayit_ekle_btn.Name = "kayit_ekle_btn";
            this.kayit_ekle_btn.Size = new System.Drawing.Size(119, 48);
            this.kayit_ekle_btn.TabIndex = 0;
            this.kayit_ekle_btn.Text = "KAYIT EKLE";
            this.kayit_ekle_btn.UseVisualStyleBackColor = false;
            this.kayit_ekle_btn.Click += new System.EventHandler(this.kayit_ekle_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1332, 428);
            this.Controls.Add(this.fonksiyonlar_groupBox);
            this.Controls.Add(this.veri_tabani_dataGridView);
            this.Controls.Add(this.veri_tabani_groupbox);
            this.Name = "Form1";
            this.Text = "Transkript Hesaplama Programı";
            ((System.ComponentModel.ISupportInitialize)(this.veri_tabani_dataGridView)).EndInit();
            this.veri_tabani_groupbox.ResumeLayout(false);
            this.fonksiyonlar_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView veri_tabani_dataGridView;
        private System.Windows.Forms.GroupBox veri_tabani_groupbox;
        private System.Windows.Forms.GroupBox fonksiyonlar_groupBox;
        private System.Windows.Forms.Button kayit_sil_btn;
        private System.Windows.Forms.Button kayit_ekle_btn;
        private System.Windows.Forms.Button kayit_goster_btn;
        private System.Windows.Forms.Button transkript_btn;
        private System.Windows.Forms.Button kayit_guncelle_btn;
    }
}

