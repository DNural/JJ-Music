using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JJ
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.JJ_Logo_i;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = new Size(Convert.ToInt16(Screen.PrimaryScreen.Bounds.Width / 1.2), Convert.ToInt16(Screen.PrimaryScreen.Bounds.Height / 1.2));
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(pnl_Giris.Width + 200, pnl_Giris.Height + 200);
            lbl_HesapOlustur.Cursor = Cursors.Hand;
            lbl_SifremiUnuttum.Cursor = Cursors.Hand;
            btn_Giris.Cursor = Cursors.Hand;
            txt_Eposta.MaxLength = 40;
            txt_Sifre.MaxLength = 18;
            txt_Sifre.PasswordChar = '*';
            txt_Eposta.Focus();
        }

        CmdClass cmdc = new CmdClass();

        private void lbl_HesapOlustur_Click(object sender, EventArgs e)
        {
            Kayit kayitfrm = new Kayit();
            kayitfrm.Show();
            this.Hide();
        }

        private void lbl_SifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sufrm = new SifremiUnuttum();
            sufrm.Show();
            this.Hide();
        }

        private void lbl_HesapOlustur_MouseEnter(object sender, EventArgs e)
        {
            lbl_HesapOlustur.ForeColor = Color.LightBlue;
        }

        private void lbl_HesapOlustur_MouseLeave(object sender, EventArgs e)
        {
            lbl_HesapOlustur.ForeColor = Color.LightCoral;
        }

        private void lbl_SifremiUnuttum_MouseEnter(object sender, EventArgs e)
        {
            lbl_SifremiUnuttum.ForeColor = Color.LightBlue;
        }

        private void lbl_SifremiUnuttum_MouseLeave(object sender, EventArgs e)
        {
            lbl_SifremiUnuttum.ForeColor = Color.LightCoral;
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            errorP_Giris.Clear();
            errorP_Giris.SetIconPadding(btn_Giris, txt_Eposta.Width / 6);
            try
            {
                bool GirisBasarili = cmdc.GirisYap(txt_Eposta.Text, txt_Sifre.Text);
                if (GirisBasarili == true)
                {
                    MessageBox.Show("Hoşgeldin " + CmdClass.ad + " " + CmdClass.soyad);
                    AnaSayfa anasayfafrm = new AnaSayfa();
                    anasayfafrm.Show();
                    this.Hide();
                }
                else
                {
                    errorP_Giris.SetError(btn_Giris, "Geçerli e-Posta ve Şifre giriniz!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Giriş yapılamadı!");
            }
        }

        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txt_Eposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Giris_Click(this, new EventArgs());
            }
        }

        private void txt_Sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Giris_Click(this, new EventArgs());
            }
        }

        private void btn_Giris_MouseEnter(object sender, EventArgs e)
        {
            btn_Giris.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void btn_Giris_MouseLeave(object sender, EventArgs e)
        {
            btn_Giris.ForeColor = Color.White;
        }

        private void Giris_Activated(object sender, EventArgs e)
        {
            txt_Eposta.Focus();
        }
    }
}
