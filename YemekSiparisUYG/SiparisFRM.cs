using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisUYG
{
	public partial class SiparisFRM : Form
	{

		Iiskenderler FRMiskender;
		Icecekler FRMicecekler;
		Tatlilar FRMTatlilar;
		Sepet sepetForm;
		DonerlerFRM FRMDoner;

		Listeleler siparislerListesiFRM;

		public SiparisFRM()
		{
			InitializeComponent();
		}


		/*
		 * VT DEKİ TABLOLAR  
		 * D_urunler döner
		 * I_urunler iskennder 
		 * Ii_urunler içecek
		 * T_urunler tatlılar 
		 */

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (FRMDoner == null || FRMDoner.IsDisposed)
			{
				FRMDoner = new DonerlerFRM();
				FRMDoner.FormClosed += (s, args) => { FRMDoner = null; }; // Form kapatıldığında, sepetForm değişkenini null olarak ayarla.
				FRMDoner.Show();
                LogTut.LogKaydet("Personel", "ID li personel dönerler sayfasını görüntüledi");
            }
			else
			{
				FRMDoner.Activate(); // Sepet formu zaten açıksa, onu ön plana getir.
                LogTut.LogKaydet("Personel", "ID li personel dönerler sayfasını görüntüledi");
            }
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (FRMiskender == null || FRMiskender.IsDisposed)
			{
				FRMiskender = new Iiskenderler();
				FRMiskender.FormClosed += (s, args) => { FRMiskender = null; }; // Form kapatıldığında, sepetForm değişkenini null olarak ayarla.
				FRMiskender.Show();
                LogTut.LogKaydet("Personel", "ID li personel İskenderler sayfasını görüntüledi");
            }
			else
			{
				FRMiskender.Activate(); // Sepet formu zaten açıksa, onu ön plana getir.
                LogTut.LogKaydet("Personel", "ID li personel İskenderler sayfasını görüntüledi");
            }
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{//frm tatllılar
			if (FRMTatlilar == null || FRMTatlilar.IsDisposed)
			{
				FRMTatlilar = new Tatlilar();
				FRMTatlilar.FormClosed += (s, args) => { FRMTatlilar = null; }; // Form kapatıldığında, sepetForm değişkenini null olarak ayarla.
				FRMTatlilar.Show();
                LogTut.LogKaydet("Personel", "ID li personel içecekler sayfasını görüntüledi");
            }
			else
			{
				FRMTatlilar.Activate(); // Sepet formu zaten açıksa, onu ön plana getir.
                LogTut.LogKaydet("Personel", "ID li personel tatlılar sayfasını görüntüledi");
            }

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{//içecekler
			if (FRMicecekler == null || FRMicecekler.IsDisposed)
			{
				FRMicecekler = new Icecekler();
				FRMicecekler.FormClosed += (s, args) => { FRMicecekler = null; }; // Form kapatıldığında, sepetForm değişkenini null olarak ayarla.
				FRMicecekler.Show();
                LogTut.LogKaydet("Personel", "ID li personel içecekler sayfasını görüntüledi");
            }
			else
			{
				FRMicecekler.Activate(); // Sepet formu zaten açıksa, onu ön plana getir.
                LogTut.LogKaydet("Personel", "ID li personel içecekler sayfasını görüntüledi");
            }
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			if (sepetForm == null || sepetForm.IsDisposed)
			{
				sepetForm = new Sepet();
				sepetForm.FormClosed += (s, args) => { sepetForm = null; }; // Form kapatıldığında, sepetForm değişkenini null olarak ayarla.
				sepetForm.Show();
                LogTut.LogKaydet("Personel", "ID li personel sepet sayfasını görüntüledi");
            }
			else
			{
				sepetForm.Activate(); // Sepet formu zaten açıksa, onu ön plana getir.
                LogTut.LogKaydet("Personel", "ID li personel sepet sayfasını görüntüledi");
            }

		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			if (siparislerListesiFRM == null || siparislerListesiFRM.IsDisposed)
			{
				siparislerListesiFRM = new Listeleler();
				siparislerListesiFRM.FormClosed += (s, args) => { siparislerListesiFRM = null; }; // Form kapatıldığında, sepetForm değişkenini null olarak ayarla.
				siparislerListesiFRM.Show();
                LogTut.LogKaydet("Personel", "ID li personel sipariş listesini görüntüledi");
            }
			else
			{
				siparislerListesiFRM.Activate(); // Sepet formu zaten açıksa, onu ön plana getir.
                LogTut.LogKaydet("Personel", "ID li personel sipariş listesini görüntüledi");
            }
		}

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GirisFRM openForm = Application.OpenForms.OfType<GirisFRM>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.BringToFront();
                openForm.Focus();
                openForm.Show();
                this.Close();
				LogTut.LogKaydet("Personel","ID li personel giriş sayfasına geri döndü");
            }
            else
            {
                openForm = new GirisFRM();
                openForm.Show();
                this.Close();
                LogTut.LogKaydet("Personel", "ID li personel giriş sayfasına geri döndü");
            }
        }
    }
}
	

