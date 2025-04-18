﻿using MySqlX.XDevAPI;
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
    public partial class FormClient : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormClient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                client_id = int.Parse(textBox1.Text),
                client_pib = textBox2.Text,
                type_of_zamov = textBox3.Text
            };

            clientDAO cDAO = new clientDAO();
            int result = cDAO.addClient(client);
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
            Client client = new Client
            {
                client_id = int.Parse(textBox1.Text),
                client_pib = textBox2.Text,
                type_of_zamov = textBox3.Text
            };

            clientDAO cDAO = new clientDAO();
            int result = cDAO.deleteClient(client);
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
            clientDAO cDAO = new clientDAO();

            bindingSource.DataSource = cDAO.getALLClients();
            dataGridView1.DataSource = bindingSource;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.DefaultCellStyle.BackColor = Color.Gray;
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void загальніВідомостіПроКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generalClientInfoDAO gciDAO = new generalClientInfoDAO();

            bindingSource.DataSource = gciDAO.getMOREClients();
            dataGridView1.DataSource = bindingSource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client client = new Client
            {
                client_id = int.Parse(textBox1.Text),
                client_pib = textBox2.Text,
                type_of_zamov = textBox3.Text
            };

            clientDAO cDAO = new clientDAO();
            int result = cDAO.updateClient(client);
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
        }
    }
}
