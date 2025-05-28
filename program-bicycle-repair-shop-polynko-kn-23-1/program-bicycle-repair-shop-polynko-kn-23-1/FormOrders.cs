using MySql.Data.MySqlClient;
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
    public partial class FormOrders : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormOrders()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 8;
            lblResult.Text = "";
            cbPayment.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadWorkers();

            ordersDAO oDAO = new ordersDAO();

            bindingSource.DataSource = oDAO.getALLOrders();
            dataGridView1.DataSource = bindingSource;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cbPayment.Enabled = true;
                btnAdd.Enabled = false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["order_id"].Value.ToString();
                lstClientID.SelectedValue = Convert.ToInt32(row.Cells["client_id"].Value);
                lstWorkerID.SelectedValue = Convert.ToInt32(row.Cells["worker_id"].Value);
                dtpOrderDate.Text = row.Cells["order_date"].Value.ToString();

                var paymentValue = row.Cells["payment_date"].Value;
                cbPayment.Checked = paymentValue != null && !string.IsNullOrWhiteSpace(paymentValue.ToString());

                var paymentAmountValue = row.Cells["payment_amount"].Value;
                bool hasPaymentAmount = paymentAmountValue != null &&
                                        decimal.TryParse(paymentAmountValue.ToString(), out decimal amount) &&
                                        amount > 0;

                cbPayment.Enabled = hasPaymentAmount;
            }
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            cbPayment.Checked = false;
            cbPayment.Enabled = false;
            btnAdd.Enabled = true;
            dtpOrderDate.Value = DateTime.Now;
        }

        private void повернутисядоменюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = new Menu();
            menu.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ordersDAO oDAO = new ordersDAO();

            bindingSource.DataSource = oDAO.getALLOrders();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Orders order = new Orders
            {
                client_id = Convert.ToInt32(lstClientID.SelectedValue),
                worker_id = Convert.ToInt32(lstWorkerID.SelectedValue),
                order_date = dtpOrderDate.Value,
            };

            ordersDAO oDAO = new ordersDAO();
            int result = oDAO.addOrder(order);

            if (result != 1)
            {
                lblResult.Text = "Додавання: помилка!";
            }
            else
            {
                lblResult.Text = "Додавання: успіх!";
                int newOrderId = oDAO.getLastOrderId();

                var order_detail = new FormOrderDetail(newOrderId);
                order_detail.ShowDialog();
            }

            bindingSource.DataSource = oDAO.getALLOrders();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Orders order = new Orders
            {
                order_id = int.Parse(txtID.Text),
                client_id = Convert.ToInt32(lstClientID.SelectedValue),
                worker_id = Convert.ToInt32(lstWorkerID.SelectedValue),
                payment_date = cbPayment.Checked ? DateTime.Now : (DateTime?)null
            };

            int currentOrderId = int.Parse(txtID.Text);

            ordersDAO oDAO = new ordersDAO();
            int result = oDAO.updateOrder(order);

            var order_detail = new FormOrderDetail(currentOrderId);
            order_detail.ShowDialog();

            bindingSource.DataSource = oDAO.getALLOrders();
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
            Orders order = new Orders
            {
                order_id = int.Parse(txtID.Text),
            };

            ordersDAO oDAO = new ordersDAO();
            int result = oDAO.deleteOrder(order);

            bindingSource.DataSource = oDAO.getALLOrders();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Orders order = new Orders
            {
                client_id = Convert.ToInt32(lstClientID.SelectedValue)
            };
            ordersDAO oDAO = new ordersDAO();

            bindingSource.DataSource = oDAO.getSearchOrders(order);
            dataGridView1.DataSource = bindingSource;
        }

        private void детальнішеПроЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var expandedOrderDetailView = new FormExpandedOrderDetailView();
            expandedOrderDetailView.ShowDialog();
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
