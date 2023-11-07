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


            // TextBox2 i�in say� kontrol� (brmFiyat)
            if (!double.TryParse(textBox2.Text, out brmFiyat))
            {
                MessageBox.Show("Hatal� �r�n Fiyat� Girdiniz L�tfen D�zeltin", "Hatal� Giri�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                textBox2.Clear();
                return;
            }

            // TextBox2 i�in say� kontrol� (adet)
            if (!double.TryParse(textBox3.Text, out adet))
            {
                MessageBox.Show("Hatal� Adet Say�s� Girdiniz L�tfen D�zeltin", "Hatal� Giri�", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                textBox3.Clear();
                return;
            }

            brmFiyat = Convert.ToDouble(textBox2.Text);
            adet = Convert.ToDouble(textBox3.Text);

            // TOPLAM TUTARI HESAPLAMA
            carpim = brmFiyat * adet;

            // KDV ��LEMLER�
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
                MessageBox.Show("L�TFEN B�R KDV ORANI BEL�RLEY�N�Z!", "KDV SE��N�Z", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox1.Focus();
                return;
            }


            //TAKS�TLEND�RME ��LEMLER�
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
                MessageBox.Show("L�TFEN B�R �DEME Y�NTEM� SE��N�Z", "TAKS�TLEND�RME SE�ENE��", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBox2.Focus();
                return;

            }

            // SONU�LARI TEXTBOX'A YAZDIRMA ��LEM�
            textBox4.Text = tksTutar.ToString();
            textBox5.Text = tplTutar.ToString();

        }


    }
}