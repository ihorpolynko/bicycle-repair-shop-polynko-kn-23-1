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
    public partial class FormSklad : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormSklad()
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

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSklad_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            skladDAO sDAO = new skladDAO();

            bindingSource.DataSource = sDAO.getALLSklads();
            dataGridView1.DataSource = bindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int place_id = int.Parse(textBox1.Text);
            int sklad_id = string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
            int tovar_id = string.IsNullOrEmpty(textBox3.Text) ? 0 : int.Parse(textBox3.Text);
            String type_of_tovar = textBox4.Text;
            String nayavnist = textBox5.Text;
            int kilkist_tovar = string.IsNullOrEmpty(textBox6.Text) ? 0 : int.Parse(textBox6.Text);
            skladDAO sDAO = new skladDAO();
            int result = sDAO.addSklad(place_id, sklad_id, tovar_id, type_of_tovar, nayavnist, kilkist_tovar);
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
            int sklad = int.Parse(textBox1.Text);
            skladDAO sDAO = new skladDAO();
            int result = sDAO.deleteSklad(sklad);
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
            Sklad sklad = new Sklad
            {
                place_id = int.Parse(textBox1.Text),
                sklad_id = int.Parse(textBox2.Text),
                tovar_id = int.Parse(textBox3.Text),
                type_of_tovar = textBox4.Text,
                nayavnist = textBox5.Text,
                kilkist_tovar = int.Parse(textBox6.Text)
            };

            skladDAO sDAO = new skladDAO();
            int result = sDAO.updateSklad(sklad);
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
            textBox6.Clear();
        }
    }
}
