namespace Prime_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isprime;    //0為不是質數，1反之。
            for (int i = 2; i <= 100; i++)
            {
                isprime = 1;
                for (int j = i - 1; j > 1; j--)
                {
                    if (i % j == 0)
                    { 
                        isprime = 0;
                        break;
                    }
                }
                if (isprime == 1)
                    textBox1.Text += $"{i}是質數\r\n";
            }
        }
    }
}
