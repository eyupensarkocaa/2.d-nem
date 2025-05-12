namespace indexOutOfRangeHatası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] dizi = { 1, 2, 3 };
                int eleman = dizi[5];
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Hata Oluştu!", ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);//
            }
        }
    }
}
