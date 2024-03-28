using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JJ
{
    public partial class AnaSayfa : Form
    {
        static AnaSayfa _obj;
        public static int c = 0;
        private string wUrl = Path.GetFullPath(@"..\..\sarkilar\");
        public int vol = 100;
        public bool isMute = false;
        public static string CalanSarki = "";
        public static string SeciliListe = "";

        public static AnaSayfa Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new AnaSayfa();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return pnl_AnaSayfa_Orta;
            }
            set
            {
                pnl_AnaSayfa_Orta = value;
            }
        }

        public Button BaslatButton
        {
            get
            {
                return btn_Baslat;
            }
            set
            {
                btn_Baslat = value;
            }
        }

        public PictureBox pbSarkiciResmi
        {
            get
            {
                return pb_CalanSarki;
            }
            set
            {
                pb_CalanSarki = value;
            }
        }

        public Label lblSarkiAdi
        {
            get
            {
                return lbl_CalanSarki;
            }
            set
            {
                lbl_CalanSarki = value;
            }
        }

        public Label lblSarkiciAdi
        {
            get
            {
                return lbl_CalanSarkici;
            }
            set
            {
                lbl_CalanSarkici = value;
            }
        }

        public AnaSayfa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(Convert.ToInt16(Screen.PrimaryScreen.Bounds.Width / 1.2), Convert.ToInt16(Screen.PrimaryScreen.Bounds.Height / 1.2));
            this.Icon = Properties.Resources.JJ_Logo_i;
        }

        CmdClass cmdc = new CmdClass();

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            lbl_Kullanici.Text = CmdClass.ad + " " + CmdClass.soyad;
            _obj = this;
            SarkicilarUC sarkicilarUC = new SarkicilarUC();
            sarkicilarUC.Size = pnl_AnaSayfa_Orta.Size;
            pnl_AnaSayfa_Orta.Controls.Add(sarkicilarUC);
            tb_Sure.Enabled = false;
            WMediaPlayer.settings.volume = vol;
            lbl_Ses.Text = vol.ToString();
            pb_CalanSarki.SizeMode = PictureBoxSizeMode.StretchImage;

            KullaniciUC kullaniciUC = new KullaniciUC();
            kullaniciUC.Size = pnl_AnaSayfa_Orta.Size;
            pnl_AnaSayfa_Orta.Controls.Add(kullaniciUC);
            pnl_AnaSayfa_Orta.Controls["kullaniciUC"].SendToBack();

            try
            {
                List<string> SarkiListeleri = new List<string>();
                SarkiListeleri = cmdc.SarkiListeleriGetir();
                foreach (var item in SarkiListeleri)
                {
                    lb_SarkiListeleri.Items.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Baslat_Click(object sender, EventArgs e)
        {
            SarkiBaslat();
        }

        public void SarkiBaslat()
        {
            if (SarkilarUC.Secili != -1)
            {
                if (c == 0)
                {
                    WMediaPlayer.URL = wUrl + SarkilarUC.Sarkilar[SarkilarUC.Secili] + ".wav";
                    WMediaPlayer.Ctlcontrols.play();
                    timer_GecenSure.Enabled = true;
                    tb_Sure.Enabled = true;
                    btn_Baslat.BackgroundImage = Properties.Resources.pauseButton;
                    c++;
                    pb_CalanSarki.ImageLocation = @"..\..\resimler\sarkicilar\" + SarkicilarUC.SarkiciAdi + ".jpg";
                    CalanSarki = WMediaPlayer.currentMedia.name.ToString();
                    lbl_CalanSarki.Text = CalanSarki.Substring(CalanSarki.IndexOf('-') + 1, (CalanSarki.Length - CalanSarki.IndexOf('-') - 1)).Trim();
                    lbl_CalanSarkici.Text = CalanSarki.Substring(0, CalanSarki.IndexOf('-')).Trim();
                }
                else if (c % 2 == 0 && c != 0)
                {
                    WMediaPlayer.Ctlcontrols.currentPosition = tb_Sure.Value;
                    WMediaPlayer.Ctlcontrols.play();
                    timer_GecenSure.Enabled = true;
                    c++;
                    btn_Baslat.BackgroundImage = Properties.Resources.pauseButton;
                }
                else if (c % 2 == 1 && c != 0)
                {
                    WMediaPlayer.Ctlcontrols.pause();
                    tb_Sure.Value = Convert.ToInt16(WMediaPlayer.Ctlcontrols.currentPosition);
                    timer_GecenSure.Enabled = false;
                    c++;
                    btn_Baslat.BackgroundImage = Properties.Resources.playButton;
                }
            }
            else if (SarkiListesiUC.Secili != -1)
            {
                if (c == 0)
                {
                    WMediaPlayer.URL = wUrl + SarkiListesiUC.Sarkilar[SarkiListesiUC.Secili] + ".wav";
                    WMediaPlayer.Ctlcontrols.play();
                    timer_GecenSure.Enabled = true;
                    tb_Sure.Enabled = true;
                    btn_Baslat.BackgroundImage = Properties.Resources.pauseButton;
                    c++;
                    pb_CalanSarki.ImageLocation = @"..\..\resimler\sarkicilar\" + SarkiListesiUC.SarkiciAdi + ".jpg";
                    CalanSarki = WMediaPlayer.currentMedia.name.ToString();
                    lbl_CalanSarki.Text = CalanSarki.Substring(CalanSarki.IndexOf('-') + 1, (CalanSarki.Length - CalanSarki.IndexOf('-') - 1)).Trim();
                    lbl_CalanSarkici.Text = CalanSarki.Substring(0, CalanSarki.IndexOf('-')).Trim();
                }
                else if (c % 2 == 0 && c != 0)
                {
                    WMediaPlayer.Ctlcontrols.currentPosition = tb_Sure.Value;
                    WMediaPlayer.Ctlcontrols.play();
                    timer_GecenSure.Enabled = true;
                    c++;
                    btn_Baslat.BackgroundImage = Properties.Resources.pauseButton;
                }
                else if (c % 2 == 1 && c != 0)
                {
                    WMediaPlayer.Ctlcontrols.pause();
                    tb_Sure.Value = Convert.ToInt16(WMediaPlayer.Ctlcontrols.currentPosition);
                    timer_GecenSure.Enabled = false;
                    c++;
                    btn_Baslat.BackgroundImage = Properties.Resources.playButton;
                }
            }
            else if (SarkilarUC.Secili == -1 && SarkiListesiUC.Secili == -1)
            {
                WMediaPlayer.URL = "";
            }
        }

        private void btn_Sonraki_Click(object sender, EventArgs e)
        {
            if (SarkilarUC.Secili != -1)
            {
                tb_Sure.Value = 0;
                c = 0;
                if (SarkilarUC.Secili < SarkilarUC.Sarkilar.Count - 1)
                {
                    SarkilarUC.Secili++;
                }
                else
                {
                    SarkilarUC.Secili = 0;
                }
                SarkiBaslat();
            }
            if (SarkiListesiUC.Secili != -1)
            {
                tb_Sure.Value = 0;
                c = 0;
                if (SarkiListesiUC.Secili < SarkiListesiUC.Sarkilar.Count - 1)
                {
                    SarkiListesiUC.Secili++;
                }
                else
                {
                    SarkiListesiUC.Secili = 0;
                }
                string ss = SarkiListesiUC.Sarkilar[SarkiListesiUC.Secili];
                SarkiListesiUC.SarkiciAdi = ss.Substring(0, ss.IndexOf('-')).Trim();
                SarkiBaslat();
            }
        }

        private void btn_Onceki_Click(object sender, EventArgs e)
        {
            if (SarkilarUC.Secili != -1)
            {
                c = 0;
                tb_Sure.Value = Convert.ToInt16(WMediaPlayer.Ctlcontrols.currentPosition);
                if (tb_Sure.Value < 10)
                {
                    tb_Sure.Value = 0;
                    if (SarkilarUC.Secili > 0)
                    {
                        SarkilarUC.Secili--;
                    }
                    else
                    {
                        SarkilarUC.Secili = 0;
                    }
                }
                else
                {
                    tb_Sure.Value = 0;
                    WMediaPlayer.Ctlcontrols.stop();
                }
                SarkiBaslat();
            }
            if (SarkiListesiUC.Secili != -1)
            {
                c = 0;
                tb_Sure.Value = Convert.ToInt16(WMediaPlayer.Ctlcontrols.currentPosition);
                if (tb_Sure.Value < 10)
                {
                    tb_Sure.Value = 0;
                    if (SarkiListesiUC.Secili > 0)
                    {
                        SarkiListesiUC.Secili--;
                    }
                    else
                    {
                        SarkiListesiUC.Secili = 0;
                    }
                }
                else
                {
                    tb_Sure.Value = 0;
                    WMediaPlayer.Ctlcontrols.stop();
                }
                string ss = SarkiListesiUC.Sarkilar[SarkiListesiUC.Secili];
                SarkiListesiUC.SarkiciAdi = ss.Substring(0, ss.IndexOf('-')).Trim();
                SarkiBaslat();
            }
        }

        private void tb_Sure_Scroll(object sender, EventArgs e)
        {
            WMediaPlayer.Ctlcontrols.currentPosition = tb_Sure.Value;
        }

        private void timer_GecenSure_Tick(object sender, EventArgs e)
        {
            tb_Sure.Maximum = Convert.ToInt16(WMediaPlayer.currentMedia.duration);
            lbl_ToplamSure.Text = WMediaPlayer.currentMedia.durationString;
            if (tb_Sure.Value < tb_Sure.Maximum)
            {
                tb_Sure.Value = Convert.ToInt16(WMediaPlayer.Ctlcontrols.currentPosition);
                lbl_GecenSure.Text = WMediaPlayer.Ctlcontrols.currentPositionString;
            }
            if (WMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {

                lbl_GecenSure.Text = "00:00";
                tb_Sure.Maximum = 0;
                tb_Sure.Value = 0;
                btn_Sonraki.PerformClick();
            }
        }

        private void tb_Ses_Scroll(object sender, EventArgs e)
        {
            vol = tb_Ses.Value;
            WMediaPlayer.settings.volume = vol;
            lbl_Ses.Text = vol.ToString();
            isMute = false;
        }

        private void lbl_Ses_Click(object sender, EventArgs e)
        {
            if (!isMute)
            {
                WMediaPlayer.settings.mute = true;
                isMute = true;
                lbl_Ses.Text = "X";
            }
            else
            {
                WMediaPlayer.settings.mute = false;
                isMute = false;
                lbl_Ses.Text = vol.ToString();
            }
        }

        private void tb_Sure_MouseDown(object sender, MouseEventArgs e)
        {
            tb_Sure.Value = Convert.ToInt32(((double)e.X / (double)tb_Sure.Width) * (tb_Sure.Maximum - tb_Sure.Minimum));
            WMediaPlayer.Ctlcontrols.currentPosition = tb_Sure.Value;
        }

        private void tb_Ses_MouseDown(object sender, MouseEventArgs e)
        {
            tb_Ses.Value = Convert.ToInt32(((double)e.X / (double)tb_Ses.Width) * (tb_Ses.Maximum - tb_Ses.Minimum));
            vol = tb_Ses.Value;
            WMediaPlayer.settings.volume = vol;
            lbl_Ses.Text = vol.ToString();
            isMute = false;
        }

        private void tb_Sure_ValueChanged(object sender, EventArgs e)
        {
            string mn = (tb_Sure.Value / 60).ToString();
            string sn = (tb_Sure.Value % 60).ToString();
            if (Convert.ToInt16(mn) < 10)
            {
                mn = "0" + mn;
            }
            if (Convert.ToInt16(sn) < 10)
            {
                sn = "0" + sn;
            }
            lbl_GecenSure.Text = mn + ":" + sn;
        }

        private void lb_SarkiListeleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_SarkiListeleri.SelectedItem != null)
            {
                AnaSayfa.Instance.PnlContainer.Controls.RemoveByKey("SarkiListesiUC");
                if (!AnaSayfa.Instance.PnlContainer.Controls.ContainsKey("SarkiListesiUC"))
                {
                    SarkiListesiUC slUC = new SarkiListesiUC();
                    slUC.Size = this.Size;
                    AnaSayfa.Instance.PnlContainer.Controls.Add(slUC);
                    SeciliListe = lb_SarkiListeleri.SelectedItem.ToString();
                    SarkiListesiUC.SarkiListesiAdi = SeciliListe;
                    slUC.SarkilariGetir(SeciliListe);
                }
                AnaSayfa.Instance.PnlContainer.Controls["SarkiListesiUC"].BringToFront();
            }
        }

        private void btn_SarkiListesiEkle_Click(object sender, EventArgs e)
        {
            SarkiListesiPOPUP slpopup = new SarkiListesiPOPUP();
            slpopup.ShowDialog();
            try
            {
                List<string> SarkiListeleri = new List<string>();
                SarkiListeleri = cmdc.SarkiListeleriGetir();
                lb_SarkiListeleri.Items.Clear();
                foreach (var item in SarkiListeleri)
                {
                    lb_SarkiListeleri.Items.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_SarkiListesiSil_Click(object sender, EventArgs e)
        {
            SarkiListesiSilPOPUP slspopup = new SarkiListesiSilPOPUP();
            slspopup.ShowDialog();
            try
            {
                List<string> SarkiListeleri = new List<string>();
                SarkiListeleri = cmdc.SarkiListeleriGetir();
                lb_SarkiListeleri.Items.Clear();
                foreach (var item in SarkiListeleri)
                {
                    lb_SarkiListeleri.Items.Add(item);
                }
            }
            catch (Exception)
            {

            }
        }

        private void lbl_Kullanici_Click(object sender, EventArgs e)
        {
            pnl_AnaSayfa_Orta.Controls["kullaniciUC"].BringToFront();
            pnl_AnaSayfa_Orta.Controls["kullaniciUC"].Visible = true;
        }
    }
}
