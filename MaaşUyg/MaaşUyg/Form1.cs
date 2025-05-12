namespace Maaşuyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[4];
        int[] maaş = new int[4];
        int index = 0;
        private void btndusuk_Click(object sender, EventArgs e)
        {
            int endusuk = maaş[0];
            for (int i = 0; i < maaş.Length; i++)
            {
                if (maaş[i] < endusuk)
                {
                    endusuk = maaş[i];
                }
                textBox3.Text = endusuk.ToString();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtisim.Text;
                maaş[index] = int.Parse(txtmaas.Text);
                index++;
                txtisim.Text = "";
                txtmaas.Text = "";
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < isimler.Length; i++)
            {
                if (isimler[i] != null)
                {
                    lsbox1.Items.Add(isimler[i] + ">" + maaş[i]);

                }
            }
        }

        private void btntemizle2_Click(object sender, EventArgs e)
        {
            lsbox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnyuksek_Click(object sender, EventArgs e)
        {
            int enyuksek = maaş[0];
            for (int i = 0; i <= maaş.Length; i++)
            {
                if (maaş[i] > enyuksek)
                {
                    enyuksek = maaş[i];
                }
                textBox4.Text = enyuksek.ToString();
            }
        }

        private void tbntoplam_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < maaş.Length; i++)
            {
                toplam += maaş[i];
            }
            textBox5.Text = toplam.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
