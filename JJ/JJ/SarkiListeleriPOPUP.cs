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
    public partial class SarkiListeleriPOPUP : Form
    {
        public SarkiListeleriPOPUP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            cb_SarkiListeleri.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static string sarkiAdi = "";

        private void SarkiListeleriPOPUP_Load(object sender, EventArgs e)
        {
            cbDoldur();
        }

        private void cbDoldur()
        {
            List<string> liste = new List<string>();
            CmdClass cmdc = new CmdClass();
            liste = cmdc.SarkiListeleriDoldur();
            foreach (var item in liste)
            {
                cb_SarkiListeleri.Items.Add(item);
            }
            if (cb_SarkiListeleri.Items.Count > 0)
            {
                cb_SarkiListeleri.Text = cb_SarkiListeleri.Items[0].ToString();
            }
        }

        private void cb_SarkiListeleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_SarkiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                CmdClass cmdc = new CmdClass();
                bool sKontrol = cmdc.SarkiKontrol(cb_SarkiListeleri.SelectedItem.ToString(), sarkiAdi);
                if (sKontrol == false)
                {
                    cmdc.SarkiEkle(cb_SarkiListeleri.SelectedItem.ToString(), sarkiAdi);
                    MessageBox.Show(sarkiAdi + ", " + cb_SarkiListeleri.SelectedItem.ToString() + " isimli listeye başarıyla eklenmiştir!");
                }
                else
                {
                    MessageBox.Show(sarkiAdi + ", " + cb_SarkiListeleri.SelectedItem.ToString() + " isimli listede zaten bulunmaktadır!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Şarkı, seçilen şarkı listesine eklenemedi!");
            }
        }

        private void SarkiListeleriPOPUP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_SarkiEkle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
