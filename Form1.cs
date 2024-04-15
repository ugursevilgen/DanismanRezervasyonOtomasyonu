using DanismanRezervasyonOtomasyonu.BLL;
using DanismanRezervasyonOtomasyonu.Entities;

namespace DanismanRezervasyonOtomasyonu
{
    public partial class Form1 : Form
    {
        UserManager userManager;
        int result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            result = userManager.GirisKontrol(txt_user.Text,txt_pass.Text);

            if (Hata.Hatalar.ContainsKey(result))
            {
                MessageBox.Show(Hata.Hatalar[result]);

                if (result == 100)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                else if (result == 200)
                {
                   //Rezervasyon Ekraný
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
