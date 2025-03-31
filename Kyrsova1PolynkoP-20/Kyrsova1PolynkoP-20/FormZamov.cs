using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrsova1PolynkoP_20
{
    public partial class FormZamov : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormZamov()
        {
            InitializeComponent();
        }

        private void FormZamov_Load(object sender, EventArgs e)
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
            int zamov_id = int.Parse(textBox1.Text);
            int client_id = string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
            int worker_id = string.IsNullOrEmpty(textBox3.Text) ? 0 : int.Parse(textBox3.Text);
            int tovar_id = string.IsNullOrEmpty(textBox4.Text) ? 0 : int.Parse(textBox4.Text);
            int kilist_tovar = string.IsNullOrEmpty(textBox5.Text) ? 0 : int.Parse(textBox5.Text);
            DateTime date_of_zamov = DateTime.Parse(dateTimePicker1.Text);
            zamovDAO zDAO = new zamovDAO();
            int result = zDAO.addSklad(zamov_id, client_id, worker_id, tovar_id, kilist_tovar, date_of_zamov);
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
            int zamov = int.Parse(textBox1.Text);
            zamovDAO zDAO = new zamovDAO();
            int result = zDAO.deleteZamov(zamov);
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
            Zamov zamov = new Zamov
            {
                zamov_id = int.Parse(textBox1.Text),
                client_id = int.Parse(textBox2.Text),
                worker_id = int.Parse(textBox3.Text),
                tovar_id = int.Parse(textBox4.Text),
                kilkist_tovar = int.Parse(textBox5.Text),
                date_of_zamov = DateTime.Parse(dateTimePicker1.Text)
            };

            zamovDAO zDAO = new zamovDAO();
            int result = zDAO.updateZamov(zamov);
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
            zamovDAO zDAO = new zamovDAO();

            bindingSource.DataSource = zDAO.getALLZamovs();
            dataGridView1.DataSource = bindingSource;
        }

        private void загальніВідомостіПроКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detailInfoZamovClientDAO dizc = new detailInfoZamovClientDAO();

            bindingSource.DataSource = dizc.getdetailInfoZamovClient();
            dataGridView1.DataSource = bindingSource;
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void відомостіПроСумуУсіхЗамовленьВраховуючиКількістьЗамовляємогоТоваруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sumZamovDAO sz = new sumZamovDAO();

            bindingSource.DataSource = sz.getSumZamov();
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
