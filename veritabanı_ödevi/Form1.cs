using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;


namespace veritabanı_ödevi
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User Id=postgres;Password=1234;Database=postgres");


        public void dersleri_goster(string txt)
        {

            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                veri_tabani_dataGridView.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }


        private void kayit_goster_btn_Click(object sender, EventArgs e)
        {
            dersleri_goster("select * from ders");

        }

        private void kayit_ekle_btn_Click(object sender, EventArgs e)
        {
            var frm_ekle = new kayit_ekle
            {
            ShowInTaskbar = false,
            MinimizeBox = false,
            MaximizeBox= false
            };
            frm_ekle.StartPosition= FormStartPosition.CenterParent;
            frm_ekle.ShowDialog(this);
        }

        private void kayit_guncelle_btn_Click(object sender, EventArgs e)
        {
            var frm_guncelle = new Kayit_güncelle
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            frm_guncelle.StartPosition = FormStartPosition.CenterParent;
            frm_guncelle.ShowDialog(this);
        }

        private void kayit_sil_btn_Click(object sender, EventArgs e)
        {
            var frm_sil = new Kayit_silme
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            frm_sil.StartPosition = FormStartPosition.CenterParent;
            frm_sil.ShowDialog(this);
        }

        private void transkript_btn_Click(object sender, EventArgs e)
        {
            var frm_transkript = new Transkript
            {
                ShowInTaskbar = false,
                MinimizeBox = false,
                MaximizeBox = false
            };
            frm_transkript.StartPosition = FormStartPosition.CenterParent;
            frm_transkript.ShowDialog(this);

        }
    }
}
