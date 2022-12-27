namespace veritabanı_ödevi
{
    partial class Transkript
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
            this.transkript_dataGridView = new System.Windows.Forms.DataGridView();
            this.transkript_listele_btn = new System.Windows.Forms.Button();
            this.transkript_hesapla_btn = new System.Windows.Forms.Button();
            this.gno_lbl = new System.Windows.Forms.Label();
            this.gno_txtbox = new System.Windows.Forms.TextBox();
            this.secilen_donem_txtbox = new System.Windows.Forms.TextBox();
            this.istenilen_donem_lbl = new System.Windows.Forms.Label();
            this.istenilen_donem_txt = new System.Windows.Forms.TextBox();
            this.secilen_donem_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transkript_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transkript_dataGridView
            // 
            this.transkript_dataGridView.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.transkript_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transkript_dataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.transkript_dataGridView.Location = new System.Drawing.Point(45, 12);
            this.transkript_dataGridView.Name = "transkript_dataGridView";
            this.transkript_dataGridView.RowHeadersWidth = 51;
            this.transkript_dataGridView.RowTemplate.Height = 24;
            this.transkript_dataGridView.Size = new System.Drawing.Size(876, 335);
            this.transkript_dataGridView.TabIndex = 48;
            // 
            // transkript_listele_btn
            // 
            this.transkript_listele_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.transkript_listele_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.transkript_listele_btn.Location = new System.Drawing.Point(60, 353);
            this.transkript_listele_btn.Name = "transkript_listele_btn";
            this.transkript_listele_btn.Size = new System.Drawing.Size(119, 48);
            this.transkript_listele_btn.TabIndex = 49;
            this.transkript_listele_btn.Text = "Sonuçlanmış Dersleri Listele";
            this.transkript_listele_btn.UseVisualStyleBackColor = false;
            this.transkript_listele_btn.Click += new System.EventHandler(this.transkript_listele_btn_Click);
            // 
            // transkript_hesapla_btn
            // 
            this.transkript_hesapla_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.transkript_hesapla_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.transkript_hesapla_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.transkript_hesapla_btn.Location = new System.Drawing.Point(674, 402);
            this.transkript_hesapla_btn.Name = "transkript_hesapla_btn";
            this.transkript_hesapla_btn.Size = new System.Drawing.Size(119, 48);
            this.transkript_hesapla_btn.TabIndex = 50;
            this.transkript_hesapla_btn.Text = "GANO Hesapla";
            this.transkript_hesapla_btn.UseVisualStyleBackColor = false;
            this.transkript_hesapla_btn.Click += new System.EventHandler(this.transkript_hesapla_btn_Click);
            // 
            // gno_lbl
            // 
            this.gno_lbl.AutoSize = true;
            this.gno_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gno_lbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gno_lbl.Location = new System.Drawing.Point(477, 481);
            this.gno_lbl.Name = "gno_lbl";
            this.gno_lbl.Size = new System.Drawing.Size(283, 20);
            this.gno_lbl.TabIndex = 51;
            this.gno_lbl.Text = "Genel Akademik Not Ortalaması:";
            // 
            // gno_txtbox
            // 
            this.gno_txtbox.Enabled = false;
            this.gno_txtbox.Location = new System.Drawing.Point(802, 479);
            this.gno_txtbox.Name = "gno_txtbox";
            this.gno_txtbox.Size = new System.Drawing.Size(119, 22);
            this.gno_txtbox.TabIndex = 52;
            // 
            // secilen_donem_txtbox
            // 
            this.secilen_donem_txtbox.Enabled = false;
            this.secilen_donem_txtbox.Location = new System.Drawing.Point(242, 481);
            this.secilen_donem_txtbox.Name = "secilen_donem_txtbox";
            this.secilen_donem_txtbox.Size = new System.Drawing.Size(119, 22);
            this.secilen_donem_txtbox.TabIndex = 53;
            // 
            // istenilen_donem_lbl
            // 
            this.istenilen_donem_lbl.AutoSize = true;
            this.istenilen_donem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.istenilen_donem_lbl.ForeColor = System.Drawing.Color.Navy;
            this.istenilen_donem_lbl.Location = new System.Drawing.Point(12, 418);
            this.istenilen_donem_lbl.Name = "istenilen_donem_lbl";
            this.istenilen_donem_lbl.Size = new System.Drawing.Size(222, 20);
            this.istenilen_donem_lbl.TabIndex = 55;
            this.istenilen_donem_lbl.Text = "Ortalaması İstenilen Dönem:";
            // 
            // istenilen_donem_txt
            // 
            this.istenilen_donem_txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.istenilen_donem_txt.Location = new System.Drawing.Point(261, 416);
            this.istenilen_donem_txt.Name = "istenilen_donem_txt";
            this.istenilen_donem_txt.Size = new System.Drawing.Size(100, 22);
            this.istenilen_donem_txt.TabIndex = 54;
            // 
            // secilen_donem_btn
            // 
            this.secilen_donem_btn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.secilen_donem_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.secilen_donem_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.secilen_donem_btn.Location = new System.Drawing.Point(393, 402);
            this.secilen_donem_btn.Name = "secilen_donem_btn";
            this.secilen_donem_btn.Size = new System.Drawing.Size(119, 48);
            this.secilen_donem_btn.TabIndex = 56;
            this.secilen_donem_btn.Text = "Seçilen Dönem İçin Hesapla";
            this.secilen_donem_btn.UseVisualStyleBackColor = false;
            this.secilen_donem_btn.Click += new System.EventHandler(this.secilen_donem_btn_Click);
            // 
            // Transkript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(968, 548);
            this.Controls.Add(this.secilen_donem_btn);
            this.Controls.Add(this.istenilen_donem_lbl);
            this.Controls.Add(this.istenilen_donem_txt);
            this.Controls.Add(this.secilen_donem_txtbox);
            this.Controls.Add(this.gno_txtbox);
            this.Controls.Add(this.gno_lbl);
            this.Controls.Add(this.transkript_hesapla_btn);
            this.Controls.Add(this.transkript_listele_btn);
            this.Controls.Add(this.transkript_dataGridView);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Transkript";
            this.Text = "Transkript Hesaplama";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            ((System.ComponentModel.ISupportInitialize)(this.transkript_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transkript_dataGridView;
        private System.Windows.Forms.Button transkript_listele_btn;
        private System.Windows.Forms.Button transkript_hesapla_btn;
        private System.Windows.Forms.Label gno_lbl;
        private System.Windows.Forms.TextBox gno_txtbox;
        private System.Windows.Forms.TextBox secilen_donem_txtbox;
        private System.Windows.Forms.Label istenilen_donem_lbl;
        public System.Windows.Forms.TextBox istenilen_donem_txt;
        private System.Windows.Forms.Button secilen_donem_btn;
    }
}