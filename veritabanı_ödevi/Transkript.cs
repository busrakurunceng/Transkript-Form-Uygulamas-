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
    public partial class Transkript : Form
    {
        public Transkript()
        {
            InitializeComponent();
        }

        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=ders;User Id=postgres;Password=1234;Database=postgres");

        private void transkript_listele_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ders WHERE harf_notu IS NOT NULL";
            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            DataTable dataTable = new DataTable();

            conn.Open();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
            dataAdapter.Fill(dataTable);
            conn.Close();

            transkript_dataGridView.DataSource = dataTable;
        }

        private double GetGradePoint(string grade)
        {
            switch (grade)
            {
                case "AA":
                    return 4.0;
                case "BA":
                    return 3.5;
                case "BB":
                    return 3.0;
                case "CB":
                    return 2.5;
                case "CC":
                    return 2;
                case "DC":
                    return 1.5;
                case "DD":
                    return 1.0;
                case "FF":
                    return 0.0;
                default:
                    throw new ArgumentException("Geçersiz harf notu!");
            }
        }


        private void transkript_hesapla_btn_Click(object sender, EventArgs e)
        {
           
            string query = "SELECT kredi, harf_notu FROM ders WHERE harf_notu IS NOT NULL";
            NpgsqlCommand command = new NpgsqlCommand(query, conn);

            conn.Open();
            NpgsqlDataReader reader = command.ExecuteReader();


            double totalCredits = 0;
            double totalGradePoints = 0;
            while (reader.Read())
            {
                int credit = Convert.ToInt32(reader["kredi"]);
                string grade = (reader["harf_notu"]).ToString();
                double gradePoint = GetGradePoint(grade);

                totalCredits += credit;
                totalGradePoints += gradePoint * credit;
            }

            double gano = totalGradePoints / totalCredits;

            double yuvarlanmis_gno = Math.Round(gano, 2);

            gno_txtbox.Text = yuvarlanmis_gno.ToString();

            conn.Close();

        }

        private void secilen_donem_btn_Click(object sender, EventArgs e)
        {

            string secilen_donem = istenilen_donem_txt.Text;


            string ilk_donem = "SELECT kredi, harf_notu FROM ders WHERE donem=@secilen_donem AND harf_notu IS NOT NULL ";
            NpgsqlCommand comm = new NpgsqlCommand(ilk_donem, conn);

            comm.Parameters.AddWithValue("@secilen_donem", secilen_donem);
            conn.Open();
            NpgsqlDataReader reader_1 = comm.ExecuteReader();


            double secilen_donem_totalCredits = 0;
            double secilen_donem_totalGradePoints = 0;

            while (reader_1.Read())
            {
                int credit_secilen = Convert.ToInt32(reader_1["kredi"]);
                string grade_secilen = (reader_1["harf_notu"]).ToString();
                double gradePoint_secilen = GetGradePoint(grade_secilen);

                secilen_donem_totalCredits += credit_secilen;
                secilen_donem_totalGradePoints += gradePoint_secilen * credit_secilen;
            }

            double secilen_donem_ort = secilen_donem_totalGradePoints / secilen_donem_totalCredits;

            double yuvarlanmis_secilen_donem = Math.Round(secilen_donem_ort, 2);

            secilen_donem_txtbox.Text = yuvarlanmis_secilen_donem.ToString();

            conn.Close();
        }
    }
    }

