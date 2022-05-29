using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Arsivi
{
    public class DatabaseOperation
    {
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PBUC8F9\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");

        public static DataGridView dg1;

        public void filmleriListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,KATEGORİ, LINK from TBL_FILMLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dg1.DataSource = dt;
            baglanti.Close();
          
        }

        public void filmiKaydet(Film film)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBL_FILMLER (AD,KATEGORİ,LINK) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", film.FilmName);
            komut.Parameters.AddWithValue("@P2", film.Category);
            komut.Parameters.AddWithValue("@P3", film.Link);
            komut.ExecuteNonQuery();
            baglanti.Close();
            filmleriListele();
            MessageBox.Show("film listeye eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmleriListele();
        }

        public void deleteFromTable(object idValue)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TBL_FILMLER WHERE AD = @uid", baglanti);
            komut.Parameters.AddWithValue("@uid", idValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            filmleriListele();
            MessageBox.Show("Başarı ile silindi");


        }



    }
}
