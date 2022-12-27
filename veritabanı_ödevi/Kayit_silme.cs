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
    public partial class Kayit_silme : Form
    {
        public Kayit_silme()
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
       
        private void sil_btn_Click(object sender, EventArgs e)
        {
            string silinecek_kod = sil_kod_txtbox.Text;

            string query = "DELETE FROM ders WHERE ders_kodu = @silinecek_kod";
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@silinecek_kod", silinecek_kod);


            conn.Open();
            int rowsAffected = command.ExecuteNonQuery();
            conn.Close();

            dersleri_goster("select * from ders");

        }
    }
}
