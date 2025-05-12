namespace string_dizi_oluşturm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[5];
            dizi[0] = "Eyüp";
            dizi[1] = "Arda";
            dizi[2] = "Berkay";
            dizi[3] = "Ahmet";

            foreach (string eleman in dizi)
            {
                listBox1.Items.Add(eleman);
            }
 

        }
    }
}
