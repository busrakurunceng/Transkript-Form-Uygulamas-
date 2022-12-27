using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritabanı_ödevi
{
    public partial class kayit_ekle : Form
    {
        public kayit_ekle()
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
                dataGridView2.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

            conn.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = conn;

            komut_ekle.Parameters.AddWithValue("@ders_kodu", ders_kodu_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@ders_adı", ders_adi_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToInt32(kredi_textbox.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(akts_textbox.Text));
            komut_ekle.Parameters.AddWithValue("@ogretim_uyesi", ogretim_uyesi_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@donem", donem_textbox.Text);
            komut_ekle.Parameters.AddWithValue("@harf_notu", harf_notu_textbox.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ders (ders_kodu , ders_adı, kredi, akts, ogretim_uyesi, donem, harf_notu) values (@ders_kodu, @ders_adı, @kredi, @akts, @ogretim_uyesi , @donem , @harf_notu)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
            komut_ekle.Dispose();
            conn.Close();

            dersleri_goster("select * from ders");
        }
    }
}
