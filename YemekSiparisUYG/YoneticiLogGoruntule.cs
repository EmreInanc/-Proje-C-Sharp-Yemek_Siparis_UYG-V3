using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekSiparisUYG
{
    public partial class YoneticiLogGoruntule : Form
    {
        public YoneticiLogGoruntule()
        {
            InitializeComponent();
            SqlCommand com1 = new SqlCommand();
            datagridView_Data_yenile();
            LogDataGridView1.ScrollBars = ScrollBars.Both;
        }
        public void datagridView_Data_yenile() 
        {
            LogDataGridView1.DataSource = null;
            DataTable dataTable1 = TabloVerisiniAl("L_Log");
            LogDataGridView1.DataSource = dataTable1;
            LogDataGridView1.Update();
        }
        private DataTable TabloVerisiniAl(string table)
        {

            string query = "SELECT * FROM " + table;

            using (SqlConnection connection = new SqlConnection(Connection1.ConnectionString1))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {//geri dön button
            YoneticiUrunDuzenleFRM openForm = Application.OpenForms.OfType<YoneticiUrunDuzenleFRM>().FirstOrDefault();
            if (openForm != null)
            {
                openForm.BringToFront();
                openForm.Focus();
                openForm.Show();
                this.Close();
                LogTut.LogKaydet("Yönetici", "ID li yönetici Urun düzenleme sayfasına geri döndü  ");
            }
            else
            {
                openForm = new YoneticiUrunDuzenleFRM();
                openForm.Show();
                this.Close();
                LogTut.LogKaydet("Yönetici", "ID li yönetici Urun düzenleme sayfasına geri döndü  ");
            }
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            datagridView_Data_yenile();
            LogTut.LogKaydet("Yönetici", "ID li yönetici LOG sayfasını yeniledi");
        }
    }
}
