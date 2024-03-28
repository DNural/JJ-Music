using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJ
{
    public partial class KullaniciUC : UserControl
    {
        public KullaniciUC()
        {
            InitializeComponent();
            this.Visible = false;
            this.Anchor = AnchorStyles.None;
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
            txt_Sifre.MaxLength = 18;
            txt_Sifre.PasswordChar = '*';
        }

        public static string eposta = "";
        public static string telefon = "";
        public static string dogumTarihi = "";
        public static string cinsiyet = "";

        private void KullaniciUC_Load(object sender, EventArgs e)
        {
            try
            {
                CmdClass cmdc = new CmdClass();
                cmdc.KullaniciGetir();
                lbl_Eposta.Text = eposta;
                lbl_Telefon.Text = telefon;
                lbl_DogumTarihi.Text = dogumTarihi;
                lbl_Cinsiyet.Text = cinsiyet;
            }
            catch (Exception)
            {
            }
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Şifrenizi değiştirmek ister misiniz?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (txt_Sifre.Text.Trim() != "")
                {
                    if (txt_Sifre.Text.Length > 8)
                    {
                        try
                        {
                            CmdClass cmdc = new CmdClass();
                            cmdc.SifreDegistir(txt_Sifre.Text);
                            MessageBox.Show("Şifreniz başarıyla değiştirilmiştir!");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Şifre değiştirilemedi!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz 8-16 arası karakter içermelidir!");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir şifre giriniz!");
                }
            }
        }

        private void txt_Sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_SifreDegistir.PerformClick();
            }
        }
    }
}
