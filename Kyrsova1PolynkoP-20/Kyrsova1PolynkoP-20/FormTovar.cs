namespace Kyrsova1PolynkoP_20
{
    public partial class FormTovar : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormTovar()
        {
            InitializeComponent();
        }

        private void FormTovar_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ReadOnly = false;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.DefaultCellStyle.NullValue = DBNull.Value;
            dataGridView1.DefaultCellStyle.NullValue = "";
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovarDAO tDAO = new tovarDAO();

            bindingSource.DataSource = tDAO.getALLTovars();
            dataGridView1.DataSource = bindingSource;
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

        private void button2_Click(object sender, EventArgs e)
        {
            int tovar_id = int.Parse(textBox1.Text);
            int place_id = string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
            String type_of_tovar = textBox4.Text;
            int prise_of_tovar = string.IsNullOrEmpty(textBox5.Text) ? 0 : int.Parse(textBox5.Text);
            tovarDAO tDAO = new tovarDAO();
            int result = tDAO.addTovar(tovar_id, place_id, type_of_tovar, prise_of_tovar);
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
            int tovar_id = int.Parse(textBox1.Text);
            tovarDAO tDAO = new tovarDAO();
            int result = tDAO.deleteTovar(tovar_id);
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
            Tovar tovar = new Tovar
            {
                tovar_id = int.Parse(textBox1.Text),
                place_id = int.Parse(textBox2.Text),
                type_of_tovar = textBox4.Text,
                prise_of_tovar = int.Parse(textBox5.Text)
            };

            tovarDAO tDAO = new tovarDAO();
            int result = tDAO.updateTovar(tovar);
            if (result != 1)
            {
                MessageBox.Show("Помилка!");
            }
            else
            {
                MessageBox.Show("Успіх!");
            }
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
