using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisUYG
{
    internal static class LogTut
    {
        public static string ID { get; set; }

        public static void LogKaydet(string yetki,string mesaj)
        {
            try
            {
                mesaj = ID + mesaj;
                DateTime now = DateTime.Now;
                string IPAdres = IPAdressAl();
                SqlConnection con = new SqlConnection(Connection1.ConnectionString1);
                string query = "INSERT INTO [dbo].[L_Log] " +
                    "([Zaman]," +
                    "[Yetki]," +
                    "[IP_Adres]," +
                    "[Olay]) " +
                    "VALUES (@zaman," +
                    "@yetki," +
                    "@ipadres, " +
                    "@olay)";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@zaman",now);
                command.Parameters.AddWithValue("@yetki", yetki);
                command.Parameters.AddWithValue("@ipadres", IPAdres);
                command.Parameters.AddWithValue("@olay", mesaj);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch(Exception ex) { MessageBox.Show("Log tutulamadı"+ex); }
        }
        static string IPAdressAl()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Yerel IP Adresi bulunamadı!");
        }
        static string a { get; set; }
        public static string Kullanici_ID_Bilgisini_Al(string sifre)
        {
            GirisFRM girisFRM = new GirisFRM();
            try
            {
               SqlConnection con = new SqlConnection(Connection1.ConnectionString1);
               string query = "SELECT kullanici_id FROM Y_yetkiler WHERE sifre=@sifre";
               SqlCommand command = new SqlCommand(query, con);
               string hash= girisFRM.sifrele256Bit(sifre);
               command.Parameters.AddWithValue("@sifre", hash);
                command.Connection.Open();
                SqlDataReader read = command.ExecuteReader();
                if (read.Read()) 
                {
                     string v = read[0].ToString();
                     ID = v;
                     return v;
                }
                return a;
                command.Connection.Close();
            }
            catch (Exception ex) { return MessageBox.Show("kullanıcı ID bilgi alınamadı " + ex).ToString();  }
        }


    }
}
