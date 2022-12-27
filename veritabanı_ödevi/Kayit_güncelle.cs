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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace veritabanı_ödevi
{
    public partial class Kayit_güncelle : Form
    {
        public Kayit_güncelle()
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

        private void guncelle_btn_Click(object sender, EventArgs e)
        {

            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;

            komut_guncelle.Parameters.AddWithValue("@guncellenecek_kod", guncelle_kod_txt.Text); ;
            komut_guncelle.Parameters.AddWithValue("@ders_kodu", ders_kodu_textbox.Text);
            komut_guncelle.Parameters.AddWithValue("@ders_adı", ders_adi_textbox.Text);
            komut_guncelle.Parameters.AddWithValue("@kredi", Convert.ToInt32(kredi_textbox.Text));
            komut_guncelle.Parameters.AddWithValue("@akts", Convert.ToInt32(akts_textbox.Text));
            komut_guncelle.Parameters.AddWithValue("@ogretim_uyesi", (ogretim_uyesi_textbox.Text));
            komut_guncelle.Parameters.AddWithValue("@donem", donem_textbox.Text);
            komut_guncelle.Parameters.AddWithValue("@harf_notu", harf_notu_textbox.Text); ;

            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update ders set ders_kodu=@ders_kodu, ders_adı=@ders_adı, kredi=@kredi, akts= @akts, ogretim_uyesi=@ogretim_uyesi, donem=@donem, harf_notu=@harf_notu where ders_kodu = @guncellenecek_kod";

            NpgsqlDataReader dr = komut_guncelle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
            }
            komut_guncelle.Dispose();
            conn.Close();

            dersleri_goster("select * from ders ");
        }

        private void tıkla_btn_Click(object sender, EventArgs e)
        {
           dersleri_goster("select * from ders");
        }
    }
}
