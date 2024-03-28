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
    public partial class SarkiListesiUC : UserControl
    {
        public static List<string> Sarkilar = new List<string>();
        public static int Secili = -1;
        public int onceki = 1;
        public int sonraki = 1;
        public static string SarkiciAdi = "";
        public static string SarkiListesiAdi = "";

        public SarkiListesiUC()
        {
            InitializeComponent();
        }

        private void SarkiListesiUC_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                Sarkilar.Clear();
                Secili = -1;
                this.Size = new Size(AnaSayfa.Instance.PnlContainer.Width, AnaSayfa.Instance.PnlContainer.Height);
                this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            }
        }

        internal void SarkilariGetir(string SarkiListesiAdi)
        {
            pnl_Sarkilar.Location = new Point((this.Width / 10), 50 + this.Size.Height / 10 + 50);
            pnl_Sarkilar.Size = new Size(Convert.ToInt16(this.Size.Width / 1.2), (this.Height / 2) - 50);
            List<string> SarkiAdlari = new List<string>();
            CmdClass cmdc = new CmdClass();
            SarkiAdlari = cmdc.SarkilariGetir2(SarkiListesiAdi);
            for (int i = 0; i < SarkiAdlari.Count; i++)
            {
                Sarkilar.Add(SarkiAdlari[i]);
                Panel pnls = new Panel();
                pnls.Name = "pnl_" + (i + 1);
                pnls.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
                if (pnl_Sarkilar.VerticalScroll.Visible == true)
                {
                    pnls.Size = new Size(pnl_Sarkilar.Size.Width - SystemInformation.VerticalScrollBarWidth, 50);
                }
                else
                {
                    pnls.Size = new Size(pnl_Sarkilar.Size.Width, 50);
                }
                pnls.Location = new Point(0, pnls.Size.Height * i + (10 * i));
                pnls.Tag = SarkiAdlari[i];
                //pnls.BorderStyle = BorderStyle.Fixed3D;
                pnls.Cursor = Cursors.Hand;
                pnls.BackColor = Color.Transparent;
                pnl_Sarkilar.Controls.Add(pnls);
                pnls.Click += new EventHandler(pnls_Click);
                pnls.MouseEnter += new EventHandler(pnls_MouseEnter);
                pnls.MouseLeave += new EventHandler(pnls_MouseLeave);

                Label lbl = new Label();
                lbl.ForeColor = Color.White;
                lbl.Location = new Point(50, pnls.Height / 4);
                lbl.Text = SarkiAdlari[i];
                lbl.Name = "lbl_" + (i + 1);
                lbl.Font = new Font("Georgia", 14);
                lbl.AutoSize = true;
                pnls.Controls.Add(lbl);
                lbl.Click += new EventHandler(lbl_Click);
                lbl.MouseEnter += new EventHandler(lbl_MouseEnter);
                lbl.MouseLeave += new EventHandler(lbl_MouseLeave);

                Button btn = new Button();
                btn.Name = "btn_" + (i + 1);
                btn.Size = new Size(25, pnls.Size.Height / 2);
                btn.Location = new Point(20, pnls.Size.Height / 4);
                btn.BackgroundImage = Properties.Resources.playButton;
                btn.BackgroundImageLayout = ImageLayout.Stretch;
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Transparent;
                btn.FlatAppearance.BorderSize = 0;
                pnls.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
                btn.MouseEnter += new EventHandler(btn_MouseEnter);
                btn.MouseLeave += new EventHandler(btn_MouseLeave);

                Button btn2 = new Button();
                btn2.Name = "btn2_" + (i + 1);
                btn2.Size = new Size(25, pnls.Size.Height / 2);
                btn2.Location = new Point(pnls.Size.Width - 100, pnls.Size.Height / 4);
                btn2.BackgroundImage = Properties.Resources.deleteButton;
                btn2.BackgroundImageLayout = ImageLayout.Stretch;
                btn2.Anchor = AnchorStyles.Right;
                btn2.FlatStyle = FlatStyle.Flat;
                btn2.BackColor = Color.Transparent;
                btn2.FlatAppearance.BorderSize = 0;
                pnls.Controls.Add(btn2);
                btn2.Click += new EventHandler(btn2_Click);
                btn2.MouseEnter += new EventHandler(btn2_MouseEnter);
                btn2.MouseLeave += new EventHandler(btn2_MouseLeave);
            }
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            Button btn2 = sender as Button;
            btn2.BackColor = Color.FromArgb(60, 60, 60);
            int pnlC = Convert.ToInt16(btn2.Name.Substring(5, btn2.Name.Length - 5));
            this.Controls.Find("pnl_" + pnlC, true).FirstOrDefault().BackColor = Color.Transparent;
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            Button btn2 = sender as Button;
            btn2.BackColor = Color.FromArgb(80, 80, 80);
            int pnlC = Convert.ToInt16(btn2.Name.Substring(5, btn2.Name.Length - 5));
            this.Controls.Find("pnl_" + pnlC, true).FirstOrDefault().BackColor = Color.FromArgb(50, 50, 50);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn2 = sender as Button;
            try
            {
                CmdClass cmdc = new CmdClass();
                int seciliSarki = Convert.ToInt16(btn2.Name.Substring(5, btn2.Name.Length - 5)) - 1;
                cmdc.SarkiListesiSarkiSil(SarkiListesiAdi, Sarkilar[seciliSarki]);
                AnaSayfa.Instance.PnlContainer.Controls.RemoveByKey("SarkiListesiUC");
                if (Sarkilar.Count > 0)
                {
                    SarkiListesiUC slUC = new SarkiListesiUC();
                    slUC.Size = this.Size;
                    AnaSayfa.Instance.PnlContainer.Controls.Add(slUC);
                    SarkiListesiUC.SarkiListesiAdi = AnaSayfa.SeciliListe;
                    slUC.SarkilariGetir(AnaSayfa.SeciliListe);
                    AnaSayfa.Instance.PnlContainer.Controls["SarkiListesiUC"].BringToFront();
                    if (SarkilarUC.Secili == -1)
                    {
                        AnaSayfa.c = 0;
                        if (Sarkilar.Count > 0)
                        {
                            Secili = 0;
                            string ss = Sarkilar[Secili];
                            SarkiciAdi = ss.Substring(0, ss.IndexOf('-')).Trim();
                        }
                        else
                        {
                            Secili = -1;
                            AnaSayfa.Instance.pbSarkiciResmi.ImageLocation = "";
                            AnaSayfa.Instance.lblSarkiAdi.Text = "";
                            AnaSayfa.Instance.lblSarkiciAdi.Text = "";
                        }
                        AnaSayfa.Instance.BaslatButton.PerformClick();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Şarkı silinirken bir hata oluştu!");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Secili = Convert.ToInt16(btn.Name.Substring(4, btn.Name.Length - 4)) - 1;
            AnaSayfa.c = 0;
            SarkilarUC.Secili = -1;
            string ss = Sarkilar[Secili];
            SarkiciAdi = ss.Substring(0, ss.IndexOf('-')).Trim();
            AnaSayfa.Instance.BaslatButton.PerformClick();
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(80, 80, 80);
            int pnlC = Convert.ToInt16(btn.Name.Substring(4, btn.Name.Length - 4));
            this.Controls.Find("pnl_" + pnlC, true).FirstOrDefault().BackColor = Color.FromArgb(50, 50, 50);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(60, 60, 60);
            int pnlC = Convert.ToInt16(btn.Name.Substring(4, btn.Name.Length - 4));
            this.Controls.Find("pnl_" + pnlC, true).FirstOrDefault().BackColor = Color.Transparent;
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            if (AnaSayfa.c == 0)
            {
                Secili = Convert.ToInt16(lbl.Name.Substring(4, lbl.Name.Length - 4)) - 1;
                AnaSayfa.c = 0;
                string ss = Sarkilar[Secili];
                SarkiciAdi = ss.Substring(0, ss.IndexOf('-')).Trim();
            }
        }

        private void lbl_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            int pnlC = Convert.ToInt16(lbl.Name.Substring(4, lbl.Name.Length - 4));
            this.Controls.Find("pnl_" + pnlC, true).FirstOrDefault().BackColor = Color.FromArgb(50, 50, 50);
        }
        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            int pnlC = Convert.ToInt16(lbl.Name.Substring(4, lbl.Name.Length - 4));
            this.Controls.Find("pnl_" + pnlC, true).FirstOrDefault().BackColor = Color.Transparent;
        }

        private void pnls_Click(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            if (AnaSayfa.c == 0)
            {
                Secili = Convert.ToInt16(pnl.Name.Substring(4, pnl.Name.Length - 4)) - 1;
                AnaSayfa.c = 0;
                string ss = Sarkilar[Secili];
                SarkiciAdi = ss.Substring(0, ss.IndexOf('-')).Trim();
            }
        }

        private void pnls_MouseEnter(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            pnl.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void pnls_MouseLeave(object sender, EventArgs e)
        {
            Panel pnl = sender as Panel;
            pnl.BackColor = Color.Transparent;
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            AnaSayfa.Instance.PnlContainer.Controls.RemoveByKey("SarkiListesiUC");
        }
    }
}
