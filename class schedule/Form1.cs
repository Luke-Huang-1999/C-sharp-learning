namespace class_schedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

            dataGridView1.Columns.Add("colMonday", "星期一");
            dataGridView1.Columns.Add("colTuesday", "星期二");
            dataGridView1.Columns.Add("colWednesday", "星期三");
            dataGridView1.Columns.Add("colThursday", "星期四");
            dataGridView1.Columns.Add("colFriday", "星期五");

            // 禁止所有欄位自動排序
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 禁止使用者調整欄寬
            dataGridView1.AllowUserToResizeColumns = false;

            // 禁止使用者調整列高
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void GenerateSchedule()
        {


            //取得下拉式選單的結果
            int startIndex = comboBox1.SelectedIndex;

            //科目清單
            string[] subject = { "國文", "數學", "英文" };

            //清除舊的課表內容
            dataGridView1.Rows.Clear();

            for (int period = 0; period < 8; period++)
            {
                dataGridView1.Rows.Add();
            }

            //填入星期一到星期五的課表
            for (int day = 0; day < 5; day++)
            {
                for (int period = 0; period < 8; period++)
                {
                    int subjectIndex = startIndex % 3;//0國文, 1數學, 2英文
                    startIndex++;
                    dataGridView1.Rows[period].Cells[day].Value = subject[subjectIndex];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateSchedule();
        }
    }
}
