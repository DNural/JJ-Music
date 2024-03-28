using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace JJ
{
    public class CmdClass : DbClass
    {
        public static string ad = "";
        public static string soyad = "";
        public static int id;
        public bool GirisYap(string eposta, string sifre)
        {
            Baglan();
            komut = new SqlCommand("select * from tbl_Kullanicilar where kullaniciEposta = @eposta and kullaniciSifre = @sifre", baglanti);
            komut.Parameters.AddWithValue("@eposta", eposta);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            Giris girisfrm = new Giris();
            while (okuyucu.Read())
            {
                ad = okuyucu["kullaniciAdi"].ToString();
                soyad = okuyucu["kullaniciSoyadi"].ToString();
                id = Convert.ToInt16(okuyucu["kullaniciID"].ToString());
            }
            Kes();
            if (ad != "" && soyad != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void KullaniciGetir()
        {
            Baglan();
            komut = new SqlCommand("select * from tbl_Kullanicilar where kullaniciID = @kID", baglanti);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                KullaniciUC.eposta = okuyucu["kullaniciEposta"].ToString();
                KullaniciUC.telefon = okuyucu["kullaniciTelefon"].ToString();
                KullaniciUC.dogumTarihi = Convert.ToDateTime(okuyucu["kullaniciDogumTarihi"]).ToShortDateString().ToString();
                if (okuyucu["kullaniciCinsiyet"].ToString() == "False")
                {
                    KullaniciUC.cinsiyet = "Erkek";
                }
                else if (okuyucu["kullaniciCinsiyet"].ToString() == "True")
                {
                    KullaniciUC.cinsiyet = "Kadın";
                }
            }
            Kes();
        }

        internal void SifreDegistir(string kullaniciSifre)
        {
            Baglan();
            komut = new SqlCommand("update tbl_Kullanicilar set kullaniciSifre = @kSifre where kullaniciID = @kID", baglanti);
            komut.Parameters.AddWithValue("@kSifre", kullaniciSifre);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            Kes();
        }

        internal List<string> SarkiciAdlari()
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("Select sarkiciAdi from tbl_Sarkicilar", baglanti);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["sarkiciAdi"].ToString());
            }
            Kes();
            return dizi;
        }

        internal List<string> SarkiciResimleri()
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("Select sarkiciResim from tbl_Sarkicilar", baglanti);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["sarkiciResim"].ToString());
            }
            Kes();
            return dizi;
        }
        internal List<string> SarkilariGetir(string SarkiciAdi)
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("Select sarkiAdi from tbl_Sarkilar where sarkiciIDFK in (select sarkiciID from tbl_Sarkicilar where sarkiciAdi = @sarkiciAdi)", baglanti);
            komut.Parameters.AddWithValue("@sarkiciAdi", SarkiciAdi);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["sarkiAdi"].ToString());
            }
            Kes();
            return dizi;
        }

        public void HesapOlustur(string ad, string soyad, string eposta, string sifre, DateTime dogumTarihi, bool cinsiyet, string telefonNumarasi)
        {
            Baglan();
            komut = new SqlCommand("insert into tbl_Kullanicilar values(@ad, @soyad, @eposta, @sifre, @dogumTarihi, @cinsiyet, @telefonNumarasi)", baglanti);
            komut.Parameters.AddWithValue("@ad", ad);
            komut.Parameters.AddWithValue("@soyad", soyad);
            komut.Parameters.AddWithValue("@eposta", eposta);
            komut.Parameters.AddWithValue("@sifre", sifre);
            komut.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            komut.Parameters.AddWithValue("@telefonNumarasi", telefonNumarasi);
            komut.ExecuteNonQuery();
            Kes();
        }

        public bool Kontrol(string eposta)
        {
            Baglan();
            komut = new SqlCommand("select count(*) from tbl_Kullanicilar where kullaniciEposta = @eposta", baglanti);
            komut.Parameters.AddWithValue("@eposta", eposta);
            int c = (int)komut.ExecuteScalar();
            Kes();
            if (c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SifreBul(string eposta)
        {
            Baglan();
            komut = new SqlCommand("select kullaniciSifre from tbl_Kullanicilar where kullaniciEposta = @eposta", baglanti);
            komut.Parameters.AddWithValue("@eposta", eposta);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            string sifre = "";
            while (okuyucu.Read())
            {
                sifre = okuyucu["kullaniciSifre"].ToString();
            }
            Kes();
            return sifre;
        }

        public bool SarkiListesiKontrol(string sarkiListesiAdi)
        {
            Baglan();
            komut = new SqlCommand("select count(*) from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            int c = (int)komut.ExecuteScalar();
            Kes();
            if (c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal void SarkiListesiOlustur(string sarkiListesiAdi)
        {
            Baglan();
            komut = new SqlCommand("insert into tbl_SarkiListeleri values(@slAdi, @kID)", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            Kes();
        }

        internal List<string> SarkiListeleriDoldur()
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("select sarkiListesiAdi from tbl_SarkiListeleri where kullaniciIDFK = @kID", baglanti);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["sarkiListesiAdi"].ToString());
            }
            Kes();
            return dizi;
        }

        internal void SarkiEkle(string sarkiListesiAdi, string sarkiAdi)
        {
            Baglan();
            komut = new SqlCommand("insert into tbl_SarkiListesiSarkilar values((select sarkiListesiID from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID), (select sarkiID from tbl_Sarkilar where sarkiAdi like @sAdi))", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            komut.Parameters.AddWithValue("@sAdi", sarkiAdi);
            komut.ExecuteNonQuery();
            Kes();
        }

        internal bool SarkiKontrol(string sarkiListesiAdi, string sarkiAdi)
        {
            Baglan();
            komut = new SqlCommand("select count(*) from tbl_SarkiListesiSarkilar where sarkiListesiIDFK in (select sarkiListesiID from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID) and sarkiIDFK in (select sarkiID from tbl_Sarkilar where sarkiAdi like @sAdi)", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            komut.Parameters.AddWithValue("@sAdi", sarkiAdi);
            int c = (int)komut.ExecuteScalar();
            Kes();
            if (c > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal List<string> SarkiListeleriGetir()
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("select sarkiListesiAdi from tbl_SarkiListeleri where kullaniciIDFK = @kID", baglanti);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["sarkiListesiAdi"].ToString());
            }
            Kes();
            return dizi;
        }

        internal List<string> SarkilariGetir2(string sarkiListesiAdi)
        {
            List<string> dizi = new List<string>();
            Baglan();
            komut = new SqlCommand("select sarkiAdi from tbl_Sarkilar where sarkiID in (select sarkiIDFK from tbl_SarkiListesiSarkilar where sarkiListesiIDFK in (select sarkiListesiID from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID))", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                dizi.Add(okuyucu["sarkiAdi"].ToString());
            }
            Kes();
            return dizi;
        }

        internal void SarkiListesiSarkiSil(string sarkiListesiAdi, string sarkiAdi)
        {
            Baglan();
            komut = new SqlCommand("delete from tbl_SarkiListesiSarkilar where sarkiListesiIDFK in (select sarkiListesiID from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID) and sarkiIDFK in (select sarkiID from tbl_Sarkilar where sarkiAdi like @sAdi)", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            komut.Parameters.AddWithValue("@sAdi", sarkiAdi);
            komut.ExecuteNonQuery();
            Kes();
        }

        internal void SarkiListesiSil(string sarkiListesiAdi)
        {
            Baglan();
            komut = new SqlCommand("delete from tbl_SarkiListesiSarkilar where sarkiListesiIDFK in (select sarkiListesiID from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID) \n delete from tbl_SarkiListeleri where sarkiListesiAdi = @slAdi and kullaniciIDFK = @kID", baglanti);
            komut.Parameters.AddWithValue("@slAdi", sarkiListesiAdi);
            komut.Parameters.AddWithValue("@kID", id);
            komut.ExecuteNonQuery();
            Kes();
        }
    }
}
