using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace JJ
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.JJ_Logo_i;
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = new Size(Convert.ToInt16(Screen.PrimaryScreen.Bounds.Width / 1.2), Convert.ToInt16(Screen.PrimaryScreen.Bounds.Height / 1.2));
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(pnl_SifremiUnuttum.Width + 200, pnl_SifremiUnuttum.Height + 200);
            btn_SifremiUnuttum.Cursor = Cursors.Hand;
            txt_Eposta.MaxLength = 40;
        }

        CmdClass cmdc = new CmdClass();

        private void SifremiUnuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giris girisfrm = new Giris();
            girisfrm.Show();
            this.Hide();
        }

        private void btn_SifremiUnuttum_MouseEnter(object sender, EventArgs e)
        {
            btn_SifremiUnuttum.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void btn_SifremiUnuttum_MouseLeave(object sender, EventArgs e)
        {
            btn_SifremiUnuttum.ForeColor = Color.White;
        }

        private void btn_SifremiUnuttum_Click(object sender, EventArgs e)
        {
            errorP_SifremiUnuttum.Clear();
            errorP_SifremiUnuttum.SetIconPadding(btn_SifremiUnuttum, txt_Eposta.Width / 6);
            if (txt_Eposta.Text.Contains("@beykent.edu.tr") || txt_Eposta.Text.Contains("@student.beykent.edu.tr") || txt_Eposta.Text.Contains("@hotmail.com") || txt_Eposta.Text.Contains("@outlook.com") || txt_Eposta.Text.Contains("@gmail.com") || txt_Eposta.Text.Contains("@windowslive.com"))
            {
                SendMail();
            }
            else
            {
                errorP_SifremiUnuttum.SetError(btn_SifremiUnuttum, "Geçerli e-Posta giriniz!");
            }
        }

        private void SendMail()
        {
            try
            {
                string mailfrom = "dogukannurallog@gmail.com";
                string mailto = txt_Eposta.Text;
                string mailpassword = "dogukannural123";
                string subject = txt_Eposta.Text + " e-Posta hesabının şifresi.";
                string mailbody = "Şifreniz: " + cmdc.SifreBul(mailto);
                string smtpmail = "smtp.gmail.com";


                MailMessage mail = new MailMessage(mailfrom, mailto, subject, mailbody);
                SmtpClient client = new SmtpClient(smtpmail);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(mailfrom, mailpassword);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Şifreniz girilen e-Posta hesabına gönderilmiştir!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Eposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_SifremiUnuttum_Click(this, new EventArgs());
            }
        }

        private void SifremiUnuttum_Activated(object sender, EventArgs e)
        {
            txt_Eposta.Focus();
        }
    }
}
