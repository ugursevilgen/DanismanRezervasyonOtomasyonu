using DanismanRezervasyonOtomasyonu.BLL;
using DanismanRezervasyonOtomasyonu.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanismanRezervasyonOtomasyonu
{
    public partial class DanisanEkle : Form
    {
        AdminManager adminManager;
        int result;
        public DanisanEkle()
        {
            InitializeComponent();
            adminManager = new AdminManager();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            result = adminManager.DanisanEkle(txt_danisanAdi.Text, txt_danisanSoyadi.Text,txt_yas.Text, txt_danisanAdres.Text, txt_danisanTelefon.Text, txt_danisanEmail.Text, txt_danisanPass.Text, txt_MoCA.Text, txt_MMSE.Text, txt_GDS.Text);


            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 300)
                {
                    txt_danisanAdi.Text = "";
                    txt_danisanSoyadi.Text = "";
                    txt_danisanAdres.Text = "";
                    txt_danisanTelefon.Text = "";
                    txt_danisanEmail.Text = "";
                    txt_MoCA.Text = "";
                    txt_MMSE.Text = "";
                    txt_GDS.Text = "";
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
