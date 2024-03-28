using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace JJ
{
    public class DbClass
    {
        string yol;
        public SqlConnection baglanti;
        public SqlCommand komut;
        public SqlDataReader okuyucu;
        public SqlDataAdapter adaptor;
        public DataTable tablo;

        public DbClass()
        {
            yol = ConfigurationManager.ConnectionStrings["VeriYolu"].ConnectionString;
        }

        public void Baglan()
        {
            try
            {
                baglanti = new SqlConnection(yol);
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata ile karşılaşıldı!");   
            }
        }

        public void Kes()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Dispose();
            }
        }
    }
}
