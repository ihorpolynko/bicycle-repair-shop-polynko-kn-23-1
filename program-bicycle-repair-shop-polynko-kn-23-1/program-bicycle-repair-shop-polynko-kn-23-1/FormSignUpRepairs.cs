﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public partial class FormSignUpRepairs : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormSignUpRepairs()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 12;
            lblResult.Text = "";
            cbPayment.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void FormSignUpRepairs_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadWorkers();

            signuprepairsDAO surDAO = new signuprepairsDAO();

            bindingSource.DataSource = surDAO.getALLSignUpRepairs();
            dataGridView1.DataSource = bindingSource;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
        }

        private void change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void FormSignUpRepairs_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = new Menu();
            menu.Show();
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtRepairReason.Clear();
            txtPayAmo.Clear();
            dtpOrderDate.Value = DateTime.Now;
            cbPayment.Checked = false;
            cbPayment.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbPayment.Enabled = true;
            btnAdd.Enabled = false;
            if (e.RowIndex >= 0)
            {
                cbPayment.Enabled = true;
                btnAdd.Enabled = false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["sign_up_repairs_id"].Value.ToString();
                lstClientID.SelectedValue = Convert.ToInt32(row.Cells["client_id"].Value);
                lstWorkerID.SelectedValue = Convert.ToInt32(row.Cells["worker_id"].Value);
                txtRepairReason.Text = row.Cells["repair_reason"].Value.ToString();

                var paymentDateVal = row.Cells["payment_date"].Value;
                if (DateTime.TryParse(row.Cells["sign_up_date"].Value?.ToString(), out DateTime parsedSignUpDate))
                {
                    dtpOrderDate.Value = parsedSignUpDate;
                }
                else
                {
                    dtpOrderDate.Value = DateTime.Now;
                }

                var paymentAmountVal = row.Cells["payment_amount"].Value;
                if (paymentAmountVal != null && decimal.TryParse(paymentAmountVal.ToString(), out decimal parsedAmount))
                {
                    txtPayAmo.Text = parsedAmount.ToString();
                }
                else
                {
                    txtPayAmo.Clear();
                }

                cbPayment.Checked = paymentDateVal != null && !string.IsNullOrWhiteSpace(paymentDateVal.ToString());

                cbPayment.Enabled = paymentAmountVal != null &&
                                    decimal.TryParse(paymentAmountVal.ToString(), out decimal amount) &&
                                    amount > 0;
            }
        }

        private void детальнішеПроЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var expandedSignUpRepairsView = new FormExpandedSignUpRepairsView();
            expandedSignUpRepairsView.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SignUpRepairs signUpRepair = new SignUpRepairs
            {
                client_id = Convert.ToInt32(lstClientID.SelectedValue),
                worker_id = Convert.ToInt32(lstWorkerID.SelectedValue),
                repair_reason = txtRepairReason.Text,
                sign_up_date = dtpOrderDate.Value,
                payment_amount = string.IsNullOrWhiteSpace(txtPayAmo.Text) ? (decimal?)null : decimal.Parse(txtPayAmo.Text),
            };

            signuprepairsDAO supDAO = new signuprepairsDAO();
            int result = supDAO.addSignUpRepairs(signUpRepair);

            if (result != 1)
            {
                lblResult.Text = "Додавання: помилка!";
            }
            else
            {
                lblResult.Text = "Додавання: успіх!";
            }

            bindingSource.DataSource = supDAO.getALLSignUpRepairs();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SignUpRepairs signUpRepair = new SignUpRepairs
            {
                sign_up_repairs_id = int.Parse(txtID.Text),
                client_id = Convert.ToInt32(lstClientID.SelectedValue),
                worker_id = Convert.ToInt32(lstWorkerID.SelectedValue),
                repair_reason = txtRepairReason.Text,
                sign_up_date = dtpOrderDate.Value,
                payment_amount = string.IsNullOrWhiteSpace(txtPayAmo.Text) ? (decimal?)null : decimal.Parse(txtPayAmo.Text),
                payment_date = cbPayment.Checked ? DateTime.Now : (DateTime?)null
            };

            signuprepairsDAO supDAO = new signuprepairsDAO();
            int result = supDAO.updateSignUpRepairs(signUpRepair);

            bindingSource.DataSource = supDAO.getALLSignUpRepairs();
            dataGridView1.DataSource = bindingSource;

            if (result != 1)
            {
                lblResult.Text = "Оновлення: помилка!";
            }
            else
            {
                lblResult.Text = "Оновлення: успіх!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SignUpRepairs signUpRepair = new SignUpRepairs
            {
                sign_up_repairs_id = int.Parse(txtID.Text),
            };

            signuprepairsDAO supDAO = new signuprepairsDAO();
            int result = supDAO.deleteSignUpRepairs(signUpRepair);

            bindingSource.DataSource = supDAO.getALLSignUpRepairs();
            dataGridView1.DataSource = bindingSource;

            if (result != 1)
            {
                lblResult.Text = "Видалення: помилка!";
            }
            else
            {
                lblResult.Text = "Видалення: успіх!";
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            signuprepairsDAO supDAO = new signuprepairsDAO();

            bindingSource.DataSource = supDAO.getALLSignUpRepairs();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SignUpRepairs signUpRepair = new SignUpRepairs
            {
                client_id = Convert.ToInt32(lstClientID.SelectedValue),
            };

            signuprepairsDAO supDAO = new signuprepairsDAO();

            bindingSource.DataSource = supDAO.getSearchSignUpRepairs(signUpRepair);
            dataGridView1.DataSource = bindingSource;
        }
        private void LoadClients()
        {
            using (var conn = new MySqlConnection(DBConfig.LoadConfig()))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT client_id, pib FROM clients ORDER BY client_id DESC", conn);
                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                lstClientID.DataSource = table;
                lstClientID.DisplayMember = "pib";
                lstClientID.ValueMember = "client_id";
            }
        }

        private void LoadWorkers()
        {
            using (var conn = new MySqlConnection(DBConfig.LoadConfig()))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT worker_id, pib FROM workers ORDER BY worker_id DESC", conn);
                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                lstWorkerID.DataSource = table;
                lstWorkerID.DisplayMember = "pib";
                lstWorkerID.ValueMember = "worker_id";
            }
        }
    }
}
