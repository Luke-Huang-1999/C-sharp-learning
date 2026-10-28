namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            label3.Text = sum.ToString();
        }
    }
}
