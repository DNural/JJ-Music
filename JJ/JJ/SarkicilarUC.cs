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
    public partial class SarkicilarUC : UserControl
    {
        public static string SarkiciAdi = "";
        public SarkicilarUC()
        {
            InitializeComponent();
        }

        private void SarkicilarUC_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                SarkicilariGetir();
                this.Size = new Size(AnaSayfa.Instance.PnlContainer.Width, AnaSayfa.Instance.PnlContainer.Height);
                this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            }
        }

        private void SarkicilariGetir()
        {
            List<string> SarkiciAdi = new List<string>();
            List<string> SarkiciResmi = new List<string>();
            CmdClass cmdc = new CmdClass();
            SarkiciAdi = cmdc.SarkiciAdlari();
            SarkiciResmi = cmdc.SarkiciResimleri();
            int cSarkicilar = 0;
            foreach (var item in SarkiciAdi)
            {
                cSarkicilar++;
            }
            SarkicilariYazdir(cSarkicilar, SarkiciAdi, SarkiciResmi);
        }

        private void SarkicilariYazdir(int cSarkicilar, List<string> sarkiciAdi, List<string> sarkiciResmi)
        {
            int lastX = 50;
            int lastY = 50;
            for (int i = 0; i < cSarkicilar; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(lastX, lastY);
                pb.Size = new Size(200, 200);
                pb.Name = "pb_" + sarkiciAdi[i];
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.ImageLocation = sarkiciResmi[i];
                this.Controls.Add(pb);
                pb.Click += new EventHandler(pb_Click);
                lastX = pb.Location.X + (pb.Size.Width + 50);
                if (lastX + (pb.Size.Width + 50) > this.Width)
                {
                    lastX = 50;
                    lastY += pb.Size.Height + 50;
                }

                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.ForeColor = Color.White;
                lbl.Text = sarkiciAdi[i];
                lbl.Name = "lbl_" + lbl.Text;
                lbl.Font = new Font("Georgia", 12);
                this.Controls.Add(lbl);
                lbl.Location = new Point(pb.Location.X + ((pb.Size.Width - lbl.Size.Width) / 2), pb.Location.Y + pb.Size.Height + (pb.Size.Height / 20));
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (!AnaSayfa.Instance.PnlContainer.Controls.ContainsKey("SarkilarUC"))
            {
                SarkilarUC sarkilarUC = new SarkilarUC();
                sarkilarUC.Size = this.Size;
                AnaSayfa.Instance.PnlContainer.Controls.Add(sarkilarUC);
                SarkiciAdi = pb.Name.Substring(3, pb.Name.Length - 3);
                sarkilarUC.SarkiciAdiGir(SarkiciAdi);
                sarkilarUC.SarkilariGetir();
            }
            AnaSayfa.Instance.PnlContainer.Controls["SarkilarUC"].BringToFront();
        }
    }
}
