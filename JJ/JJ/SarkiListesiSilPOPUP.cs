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
    public partial class SarkiListesiSilPOPUP : Form
    {
        public SarkiListesiSilPOPUP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowInTaskbar = false;
            cb_SarkiListeleri.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SarkiListesiSilPOPUP_Load(object sender, EventArgs e)
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

        private void btn_SarkiListesiSil_Click(object sender, EventArgs e)
        {
            try
            {
                CmdClass cmdc = new CmdClass();
                cmdc.SarkiListesiSil(cb_SarkiListeleri.SelectedItem.ToString());
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("Şarkı listesi silinemedi!");
            }
        }

        private void SarkiListesiSilPOPUP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_SarkiListesiSil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
