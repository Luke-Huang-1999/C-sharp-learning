namespace CH1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arr1 = "Hello, " + textBox1.Text;
            label1.Text = arr1;
        }
    }
}
