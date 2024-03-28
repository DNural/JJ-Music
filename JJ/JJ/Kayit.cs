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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.JJ_Logo_i;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = new Size(Convert.ToInt16(Screen.PrimaryScreen.Bounds.Width / 1.2), Convert.ToInt16(Screen.PrimaryScreen.Bounds.Height / 1.2));
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(pnl_Kayit.Width + 200, pnl_Kayit.Height + 200);
            btn_Kayit.Cursor = Cursors.Hand;
            txt_Ad.MaxLength = 30;
            txt_Soyad.MaxLength = 30;
            txt_Eposta.MaxLength = 40;
            txt_Sifre.MaxLength = 18;
            txt_Sifre.PasswordChar = '*';
            txt_SifreTekrar.MaxLength = 18;
            txt_SifreTekrar.PasswordChar = '*';
            txt_Telefon.MaxLength = 11;
            rb_Erkek.Checked = true;
        }

        public bool cinsiyet = false;
        CmdClass cmdc = new CmdClass();

        private void rb_Erkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Erkek.Checked)
            {
                rb_Kadin.Checked = false;
                cinsiyet = false;
            }
        }

        private void rb_Kadin_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Kadin.Checked)
            {
                rb_Erkek.Checked = false;
                cinsiyet = true;
            }
        }

        private void Kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris girisfrm = new Giris();
            girisfrm.Show();
            this.Hide();
        }

        private void btn_Kayit_Click(object sender, EventArgs e)
        {
            errorP_Kayit.Clear();
            errorP_Kayit.SetIconPadding(btn_Kayit, txt_Ad.Width / 4);
            KayitYap();
        }

        private void KayitYap()
        {
            try
            {
                if (txt_Ad.Text.Trim() != "" && txt_Soyad.Text.Trim() != "" && txt_Eposta.Text.Trim() != "" && txt_Sifre.Text.Trim() != "" && txt_SifreTekrar.Text.Trim() != "" && txt_Telefon.Text.Trim() != "")
                {
                    if (txt_Eposta.Text.Contains("@beykent.edu.tr") || txt_Eposta.Text.Contains("@student.beykent.edu.tr") || txt_Eposta.Text.Contains("@hotmail.com") || txt_Eposta.Text.Contains("@outlook.com") || txt_Eposta.Text.Contains("@gmail.com") || txt_Eposta.Text.Contains("@windowslive.com"))
                    {
                        if (txt_Sifre.Text.Length > 8)
                        {
                            if (txt_Sifre.Text == txt_SifreTekrar.Text)
                            {
                                if (txt_Telefon.Text.Length == 11)
                                {
                                    if ((Math.Floor(Convert.ToInt16(DateTime.Today.Subtract(dtp_DogumTarihi.Value).Days) / 365.25)) > 9) //365.25; 1 yıl = 365 gün 6 saat
                                    {
                                        bool kayitliEposta = cmdc.Kontrol(txt_Eposta.Text);
                                        if (kayitliEposta == false)
                                        {
                                            cmdc.HesapOlustur(txt_Ad.Text, txt_Soyad.Text, txt_Eposta.Text, txt_Sifre.Text, dtp_DogumTarihi.Value, cinsiyet, txt_Telefon.Text);
                                            MessageBox.Show("Hesap oluşturma başarılı!");
                                            this.Close();
                                        }
                                        else
                                        {
                                            errorP_Kayit.SetError(txt_Eposta, txt_Eposta.Text + " e-Posta adresi zaten kayıtlı!");
                                        }
                                    }
                                    else
                                    {
                                        errorP_Kayit.SetError(dtp_DogumTarihi, "Hesap oluşturmak için 9 yaşından büyük olmalısınız!");
                                    }
                                }
                                else
                                {
                                    errorP_Kayit.SetError(txt_Telefon, "Geçerli bir telefon numarası giriniz!");
                                }
                            }
                            else
                            {
                                errorP_Kayit.SetError(txt_Sifre, "Şifreler aynı olmalıdır!");
                                errorP_Kayit.SetError(txt_SifreTekrar, "Şifreler aynı olmalıdır!");
                            }
                        }
                        else
                        {
                            errorP_Kayit.SetError(txt_Sifre, "Şifreniz 8-16 arası karakter içermelidir!");
                        }
                    }
                    else
                    {
                        errorP_Kayit.SetError(txt_Eposta, "Geçerli bir e-Posta giriniz!");
                    }
                }
                else
                {
                    errorP_Kayit.SetError(btn_Kayit, "Bilgileri eksiksiz giriniz!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt oluşturulamadı!");
            }
        }

        private void txt_Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Kayit_Click(this, new EventArgs());
            }
        }

        private void txt_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Kayit_Click(this, new EventArgs());
            }
        }

        private void txt_Soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Kayit_Click(this, new EventArgs());
            }
        }

        private void txt_Eposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Kayit_Click(this, new EventArgs());
            }
        }

        private void txt_Sifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Kayit_Click(this, new EventArgs());
            }
        }

        private void txt_SifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_Kayit_Click(this, new EventArgs());
            }
        }

        private void btn_Kayit_MouseEnter(object sender, EventArgs e)
        {
            btn_Kayit.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void btn_Kayit_MouseLeave(object sender, EventArgs e)
        {
            btn_Kayit.ForeColor = Color.White;
        }

        private void Kayit_Activated(object sender, EventArgs e)
        {
            txt_Ad.Focus();
        }
    }
}
