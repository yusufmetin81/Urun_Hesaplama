namespace urun_kdv_taksit_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunAdi;
            double brmFiyat, adet, tplTutar = 0, tksTutar = 0, carpim;


            // TextBox2 için sayý kontrolü (brmFiyat)
            if (!double.TryParse(textBox2.Text, out brmFiyat))
            {
                MessageBox.Show("Hatalý Ürün Fiyatý Girdiniz Lütfen Düzeltin", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                textBox2.Clear();
                return;
            }

            // TextBox2 için sayý kontrolü (adet)
            if (!double.TryParse(textBox3.Text, out adet))
            {
                MessageBox.Show("Hatalý Adet Sayýsý Girdiniz Lütfen Düzeltin", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                textBox3.Clear();
                return;
            }

            brmFiyat = Convert.ToDouble(textBox2.Text);
            adet = Convert.ToDouble(textBox3.Text);

            // TOPLAM TUTARI HESAPLAMA
            carpim = brmFiyat * adet;

            // KDV ÝÞLEMLERÝ
            if (radioButton1.Checked)
            {
                tplTutar = carpim * 1.18;
            }
            else if (radioButton2.Checked)
            {
                tplTutar = carpim * 1.20;
            }
            else
            {
                MessageBox.Show("LÜTFEN BÝR KDV ORANI BELÝRLEYÝNÝZ!", "KDV SEÇÝNÝZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox1.Focus();
                return;
            }


            //TAKSÝTLENDÝRME ÝÞLEMLERÝ
            if (radioButton3.Checked)
            {
                //tksTutar = tplTutar;

            }
            else if (radioButton4.Checked)
            {
                tksTutar = tplTutar / 2;
            }
            else if (radioButton5.Checked)
            {
                tksTutar = tplTutar / 4;
            }
            else
            {
                MessageBox.Show("LÜTFEN BÝR ÖDEME YÖNTEMÝ SEÇÝNÝZ", "TAKSÝTLENDÝRME SEÇENEÐÝ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox2.Focus();
                return;

            }

            // SONUÇLARI TEXTBOX'A YAZDIRMA ÝÞLEMÝ
            textBox4.Text = tksTutar.ToString();
            textBox5.Text = tplTutar.ToString();

        }


    }
}