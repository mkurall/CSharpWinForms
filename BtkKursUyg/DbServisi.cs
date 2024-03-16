using BtkKursUyg.Modeller;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace BtkKursUyg
{
    public class DbServisi
    {
        static SqlConnection connection =
            new SqlConnection("Server=.\\SQLEXPRESS;Database=btk_kurs_db;Trusted_Connection=True;");


        static bool Baglan()
        {
            //zaten bağlı isen tekrar bağlanma
            if (connection.State == ConnectionState.Closed)
            { 
                connection.Open();
            }

            if (connection.State == ConnectionState.Open)
                return true;//bağlantı var ise true dön
            else 
                return false;
        }

        public static TblKullanicilar OturumAc(string eposta, string parola)
        {
            if(Baglan()) //Önce bağlan ve garanti olsun
            {
                //Bağlantı var demektir sql sorgusunu oluştur
                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT Id, Ad, Soyad, EPosta FROM TblKullanicilar " +
                    "WHERE EPosta = @p1 and Parola = @p2";

                //paramettreleri gir
                cmd.Parameters.AddWithValue("p1", eposta);
                cmd.Parameters.AddWithValue("p2", parola);

                //Sorguyu çalıştırında verileri okumak için reader döndü
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())//okumaya başla
                    {
                        TblKullanicilar k = new TblKullanicilar();

                        k.Id = Convert.ToInt32(reader["Id"]);
                        k.Ad = reader["Ad"].ToString();
                        k.Soyad = reader["Soyad"].ToString();
                        k.EPosta = reader["EPosta"].ToString();

                        return k;
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Bağlantı yok!");
                return null;
            }
            
            return null;//kullanıcı bulunamadı
        }
    
        public static List<TblKurslar> KursListesiniGetir()
        {
            if(Baglan())
            {
                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "SELECT * FROM TblKurslar";

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<TblKurslar> liste = new List<TblKurslar>();

                    while(reader.Read())
                    {
                        TblKurslar k = new TblKurslar();

                        k.Id = Convert.ToInt32(reader["Id"]);
                        k.KursAdi = reader["KursAdi"].ToString();
                        k.KursTarihi = DateTime.Parse(reader["KursTarihi"].ToString());
                        k.EgitmenBilgisi = reader["EgitmenBilgisi"].ToString();

                        liste.Add(k);//Her çektiğim satırı listeye ekledim
                    }

                    return liste;
                }
            }
            else
            {
                MessageBox.Show("Bağlantı yok!");
            }

            return new List<TblKurslar>();
        }
    

        public static TblKurslar KursEkle(TblKurslar yeni)
        {
            if(Baglan() )
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO TblKurslar (KursAdi, KursTarihi,EgitmenBilgisi)" +
     " VALUES (@p1, @p2, @p3); SELECT @@IDENTITY";

                cmd.Parameters.AddWithValue("p1", yeni.KursAdi);
                cmd.Parameters.AddWithValue("p2", yeni.KursTarihi);
                cmd.Parameters.AddWithValue("p3", yeni.EgitmenBilgisi);

                int id =  Convert.ToInt32(cmd.ExecuteScalar());

                yeni.Id = id; 

                return yeni;
            }
            else
            {
                MessageBox.Show("Bağlantı yok");
            }

            return null;
        }
    
    }
}
