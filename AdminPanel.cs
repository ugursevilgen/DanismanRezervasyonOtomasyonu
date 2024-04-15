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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanisanEkle danisanEkle = new DanisanEkle();
            danisanEkle.Show();
        }

        private void btn_danisanListesi_Click(object sender, EventArgs e)
        {
            DanisanListesi danisanListesi = new DanisanListesi();
            danisanListesi.Show();
            this.Hide();
        }
    }
}
