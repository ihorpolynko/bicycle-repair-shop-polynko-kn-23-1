namespace Kyrsova1PolynkoP_20
{
    public partial class FormZapus_na_remont : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormZapus_na_remont()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormZapus_na_remont_Load(object sender, EventArgs e)
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int zapus_na_remont_id = int.Parse(textBox1.Text);
            int client_id = string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
            int master_id = string.IsNullOrEmpty(textBox3.Text) ? 0 : int.Parse(textBox3.Text);
            String reason_of_remont = textBox4.Text;
            DateTime remont_date = DateTime.Parse(dateTimePicker1.Text);
            double oplata = string.IsNullOrEmpty(textBox5.Text) ? 0 : int.Parse(textBox5.Text);

            zapus_na_remontDAO zDAO = new zapus_na_remontDAO();
            int result = zDAO.addZapus_na_remont(zapus_na_remont_id, client_id, master_id, reason_of_remont, remont_date, oplata);
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
            int zapus_na_remont = int.Parse(textBox1.Text);
            zapus_na_remontDAO zDAO = new zapus_na_remontDAO();
            int result = zDAO.deleteZapus_na_remont(zapus_na_remont);
            if (result != 1)
            {
                MessageBox.Show("Помилка!");
            }
            else
            {
                MessageBox.Show("Успіх!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zapus_na_remont zapus_na_remont = new Zapus_na_remont
            {
                zapus_na_remont_id = int.Parse(textBox1.Text),
                client_id = int.Parse(textBox2.Text),
                master_id = int.Parse(textBox3.Text),
                reason_of_remont = textBox4.Text,
                remont_date = DateTime.Parse(dateTimePicker1.Text),
                oplata = int.Parse(textBox5.Text)
            };

            zapus_na_remontDAO zDAO = new zapus_na_remontDAO();
            int result = zDAO.updateZapus_na_remont(zapus_na_remont);
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
            zapus_na_remontDAO zDAO = new zapus_na_remontDAO();

            bindingSource.DataSource = zDAO.getALLZapus_na_remonts();
            dataGridView1.DataSource = bindingSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}