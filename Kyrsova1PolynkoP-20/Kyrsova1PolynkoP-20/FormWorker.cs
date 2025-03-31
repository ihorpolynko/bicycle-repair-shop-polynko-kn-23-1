using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsova1PolynkoP_20
{
    public partial class FormWorker : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormWorker()
        {
            InitializeComponent();
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
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

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int worker_id = int.Parse(textBox1.Text);
            String worker_pib = textBox2.Text;
            String worker_posada = textBox3.Text;
            double zarplata_worker = string.IsNullOrEmpty(textBox4.Text) ? 0 : double.Parse(textBox4.Text);

            workerDAO wDAO = new workerDAO();
            int result = wDAO.addWorker(worker_id, worker_pib, worker_posada, zarplata_worker);
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
            workerDAO wDAO = new workerDAO();

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            bindingSource.DataSource = wDAO.getALLWorkers();
            dataGridView1.DataSource = bindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int worker = int.Parse(textBox1.Text);

            workerDAO wDAO = new workerDAO();
            int result = wDAO.deleteWorker(worker);
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
            Worker worker = new Worker
            {
                worker_id = int.Parse(textBox1.Text),
                worker_pib = textBox2.Text,
                worker_posada = textBox3.Text,
                zarplata_worker = double.Parse(textBox4.Text),
            };

            workerDAO wDAO = new workerDAO();
            int result = wDAO.updateWorker(worker);
            if (result != 1)
            {
                MessageBox.Show("Помилка!");
            }
            else
            {
                MessageBox.Show("Успіх!");
            }
        }

        private void загальніВідомостіПроКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            worker_tovarInfoDAO wtiDAO = new worker_tovarInfoDAO();

            bindingSource.DataSource = wtiDAO.worker_tovarInfo();
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
    }
}