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
    public partial class SarkiListesiPOPUP : Form
    {
        public SarkiListesiPOPUP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            tb_SarkiListesiAdi.MaxLength = 50;
        }

        public static string slSecilenSarki = "";

        private void tb_SarkiListesiAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_SarkiListesiAdi.Text.Trim() != "")
                {
                    CmdClass cmdc = new CmdClass();
                    bool slKontrol = cmdc.SarkiListesiKontrol(tb_SarkiListesiAdi.Text);
                    if (slKontrol == false)
                    {
                        try
                        {
                            cmdc.SarkiListesiOlustur(tb_SarkiListesiAdi.Text);
                            MessageBox.Show("Şarkı listesi başarıyla oluşturuldu!");
                            this.Dispose();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Şarkı listesi oluşturulamadı!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu isimle şarkı listesi zaten mevcut!");
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir isim giriniz!");
                }
            }
        }
    }
}
