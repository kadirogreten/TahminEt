namespace TahminEt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tutulan;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            tutulan = random.Next(0, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);

            if (sayi < tutulan)
            {
                label1.Text = "Daha büyük bir sayý girin";
            }
            else if (sayi > tutulan)
            {
                label1.Text = "Daha küçük bir sayý girin";
            }
            else
            {
                label1.Text = "Tebrikler!";
            }
            Console.ReadLine();
        }
    }
}



