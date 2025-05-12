namespace BirBoyutluDiziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string[] isimler = new string[3];
        int[] notlar = new int[3];
        int index = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                Convert.ToInt32(txtDersNotu.Text);
                index++;
                txtAdSoyad.Text = "";
                txtDersNotu.Text = "";
            }
        }

        private void btndusuk_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[5];
            for (int i = 0; i < notlar.Length; i++)
            {
                if (notlar[i] < endusuk)
                    endusuk = notlar[i];
                {
                    txtEnDusuk.Text = endusuk.ToString();
                }
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lbListe.Items.Add(isimler[i] + ">" + notlar[i]);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnYüksek_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[3];
            for (int i = 0; i < isimler.Length; i++)
            {
                if (notlar[i] != enyuksek)
                {
                    enyuksek += 1;
                }
                txtEnYuksek.Text = enyuksek.ToString();
            }
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            txtOrtalama.Text = ortalama.ToString();
        }
    }
}









