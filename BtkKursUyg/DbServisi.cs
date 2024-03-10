using BtkKursUyg.Modeller;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace BtkKursUyg
{
    public class DbServisi
    {
        static SqlConnection connection =
            new SqlConnection("Server=.\\SQLEXPRESS;Database=btk_kurs_db;Trusted_Connection=True;");


        static bool Baglan()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection.State == ConnectionState.Open;
        }

        public static TblKullanicilar OturumAc(string eposta, string parola)
        {
            if(Baglan())
            {
                //Bağlantı var demektir
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Id, Ad, Soyad, EPosta FROM TblKullanicilar " +
                    "WHERE EPosta = @p1 and Parola = @p2";

                cmd.Parameters.AddWithValue("p1", eposta);
                cmd.Parameters.AddWithValue("p2", parola);
                
                //Sorguyu çalıştırında verileri okumak için reader döndü
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    TblKullanicilar k = new TblKullanicilar();
                    
                    k.Id = Convert.ToInt32(reader["Id"]);
                    k.Ad = reader["Ad"].ToString();
                    k.Soyad = reader["Soyad"].ToString();
                    k.EPosta = reader["EPosta"].ToString();

                    return k;
                }

            }
            else
            {
                MessageBox.Show("Bağlantı yok!");
                return null;
            }
            
            return null;
        }
    }
}
