using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisUYG
{
    public partial class YoneticiUrunEkle : Form
    {
        public YoneticiUrunEkle()
        {
            InitializeComponent();

            UrunAdetCombo1.SelectedIndex = 0;
            UrunAdetCombo2.Text = "1";
        }

        private void GeriGitBTN_Click(object sender, EventArgs e)
        {

            // Açık olan formu bul ve öne getir
            YoneticiUrunDuzenleFRM openForm = Application.OpenForms.OfType<YoneticiUrunDuzenleFRM>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.Activate(); // Formu öne getir
                this.Hide();
            }
            else
            {
                // Eğer form kapalıysa, yeni bir örnek oluştur ve göster
                openForm = new YoneticiUrunDuzenleFRM();
                openForm.Show();
                this.Hide();
            }
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle() 
        {
            FotografYoluTXT.Text = "";
            UrunAdetCombo1.SelectedIndex = 0;
            UrunAdiTXT.Text = "";
            UrunAciklamaTXT.Text = "";
            UrunFiyatTXT.Text = "";
            LogTut.LogKaydet("Yönetici", "ID li yönetici urun düzenleme sayfasında textbaxları temizledi");
        }
        string degerTablo,degerColumn;
        private void EkleBtn_Click(object sender, EventArgs e)
        {

            if (UrunAdetCombo1.SelectedIndex == 0)
            {//Dönerler
                MessageBox.Show("Değer Giriniz");
            }

            else if (UrunAdetCombo1.SelectedIndex==1) 
            {//Dönerler
               degerTablo = "D_urunler";
                degerColumn = "D_";
            }

            else if (UrunAdetCombo1.SelectedIndex == 2)
            {//İskenderler
                degerTablo = "Ii_urunler";
                degerColumn = "li_";
            }

            else if (UrunAdetCombo1.SelectedIndex == 3)
            {//İçecekler
                degerTablo = "I_urunler";
                degerColumn = "I_";
            }

            else if (UrunAdetCombo1.SelectedIndex == 4)
            {//Tatlılar
               degerTablo = "T_urunler";
               degerColumn = "T_";
            }
            if (FotografYoluTXT.Text == "" ||
            UrunAdetCombo1.SelectedIndex == 0 ||
            UrunAdiTXT.Text == "" ||
            UrunAciklamaTXT.Text == "")
            {
                MessageBox.Show("Lütfen geçerli alanları doldurun");
                LogTut.LogKaydet("Yönetici", "ID li yönetici Veri Ekleme İşlemi yapamadı , boş alanlar mevcut");
            }
            else {
                try
                {
                    SqlConnection con = new SqlConnection(Connection1.ConnectionString1);
                    string query = $"INSERT INTO {degerTablo}" +
                    $" ({degerColumn}urun_image," +
                    $"{degerColumn}urun_adi, " +
                    $"{degerColumn}urun_aciklama," +
                    $" {degerColumn}Urun_Fiyat," +
                    $" {degerColumn}urun_adet)" +
                        " VALUES (@UYolu, @UAdi, @UAciklama,@UFiyat, @UAdet)";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Connection.Open();

                    command.Parameters.AddWithValue("@UYolu", FotografYoluTXT.Text);//U=ürün
                    command.Parameters.AddWithValue("@UAdi", UrunAdiTXT.Text);
                    command.Parameters.AddWithValue("@UAciklama", UrunAciklamaTXT.Text);
                    command.Parameters.AddWithValue("@UFiyat", UrunFiyatTXT.Text);
                    command.Parameters.AddWithValue("@UAdet", UrunAdetCombo2.Text);
                    MessageBox.Show("Ürün Ekleme Başarılı");
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    LogTut.LogKaydet("Yönetici", $"ID li yönetici Veri ekleme işlemi yaptı: Eklenen satırlar " +
                        $"tablo:{degerTablo} ," +
                        $"fotoğraf yolu{FotografYoluTXT.Text} ," +
                        $"Urun Adı {UrunAdiTXT.Text} ," +
                        $"Urun Açıklama{UrunAciklamaTXT.Text} ," +
                        $"Urun Fiyay:{UrunFiyatTXT.Text}" +
                        $"Urun Adet{UrunAdetCombo2.Text} ");
                }
                catch(Exception ex)
                {
                    LogTut.LogKaydet("Yönetici", "ID li yönetici Veri Ekleme İşlemi yapamadı Hata" + ex);
                    MessageBox.Show("EKLEME İŞLEMİ YAPILAMADI" + ex);
                }

            }

        }


    }
}
