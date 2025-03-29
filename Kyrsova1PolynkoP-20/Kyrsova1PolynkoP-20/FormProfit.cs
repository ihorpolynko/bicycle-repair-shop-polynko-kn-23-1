namespace Kyrsova1PolynkoP_20
{
    public partial class FormProfit : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormProfit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") // якщо в TextBox1 є текст
            {
                button2.Enabled = true; // розблокувати кнопку 1
                button3.Enabled = true; // розблокувати кнопку 2
                button4.Enabled = true; // розблокувати кнопку 3
            }
            else
            {
                button2.Enabled = false; // заблокувати кнопку 1
                button3.Enabled = false; // заблокувати кнопку 2
                button4.Enabled = false; // заблокувати кнопку 3
            }
        }

        private void FormProfit_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int period = int.Parse(textBox1.Text);
            int profit_kilkist = string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
            int vutraru = string.IsNullOrEmpty(textBox3.Text) ? 0 : int.Parse(textBox3.Text);

            profitDAO pDAO = new profitDAO();
            int result = pDAO.addProfit(period, profit_kilkist, vutraru);
            if (result != 1)
            {
                MessageBox.Show("Помилка!");
            }
            else
            {
                MessageBox.Show("Успіх!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int period = int.Parse(textBox1.Text);

            profitDAO pDAO = new profitDAO();
            int result = pDAO.deleteProfit(period);
            if (result != 1)
            {
                MessageBox.Show("Помилка!");
            }
            else
            {
                MessageBox.Show("Успіх!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profitDAO pDAO = new profitDAO();

            bindingSource.DataSource = pDAO.getALLProfits();
            dataGridView1.DataSource = bindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Profit profit = new Profit
            {
                period = int.Parse(textBox1.Text),
                profit_kilkist = int.Parse(textBox2.Text),
                vutraru = int.Parse(textBox3.Text)
            };

            profitDAO pDAO = new profitDAO();
            int result = pDAO.updateProfit(profit);
            if (result != 1)
            {
                MessageBox.Show("Помилка!");
            }
            else
            {
                MessageBox.Show("Успіх!");
            }
        }

        private void чистийПрибутокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profit_viewDAO p_vDAO = new profit_viewDAO();

            bindingSource.DataSource = p_vDAO.getProfits_view();
            dataGridView1.DataSource = bindingSource;
        }

        private void загальніВідомостіПроКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            biznesrozvProfitDAO brpDAO = new biznesrozvProfitDAO();

            bindingSource.DataSource = brpDAO.biznesrozvProfit();
            dataGridView1.DataSource = bindingSource;
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
