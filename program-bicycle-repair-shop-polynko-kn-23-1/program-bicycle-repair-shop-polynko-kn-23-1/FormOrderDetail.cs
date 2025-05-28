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
    public partial class FormOrderDetail : Form
    {
        BindingSource bindingSource = new BindingSource();
        private int orderId;

        public FormOrderDetail(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
            lblResult.Text = "";

            txtID.Text = orderId.ToString();
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            LoadDetails();

            ordersDetailDAO odDAO = new ordersDetailDAO();

            bindingSource.DataSource = odDAO.getALLOrdersDetail();
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

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDetailQuantity.Clear();
        }

        private void повернутисяуменюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrdersDetail ordersDetail = new OrdersDetail
            {
                order_id = int.Parse(txtID.Text),
                detail_id = Convert.ToInt32(lstDetailID.SelectedValue),
                quantity_details = int.Parse(txtDetailQuantity.Text)
            };

            ordersDetailDAO odDAO = new ordersDetailDAO();
            int result = odDAO.addOrdersDetail(ordersDetail);

            bindingSource.DataSource = odDAO.getALLOrdersDetail();
            dataGridView1.DataSource = bindingSource;

            if (result != 1)
            {
                lblResult.Text = "Додавання: помилка!";
            }
            else
            {
                lblResult.Text = "Додавання: успіх!";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrdersDetail ordersDetail = new OrdersDetail
            {
                order_id = int.Parse(txtID.Text),
                detail_id = Convert.ToInt32(lstDetailID.SelectedValue),
                quantity_details = int.Parse(txtDetailQuantity.Text)
            };

            ordersDetailDAO odDAO = new ordersDetailDAO();
            int result = odDAO.updateOrdersDetail(ordersDetail);

            bindingSource.DataSource = odDAO.getALLOrdersDetail();
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
            OrdersDetail ordersDetail = new OrdersDetail
            {
                order_id = int.Parse(txtID.Text),
                detail_id = Convert.ToInt32(lstDetailID.SelectedValue),
            };

            ordersDetailDAO odDAO = new ordersDetailDAO();
            int result = odDAO.deleteOrdersDetail(ordersDetail);

            bindingSource.DataSource = odDAO.getALLOrdersDetail();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                lstDetailID.SelectedValue = Convert.ToInt32(row.Cells["detail_id"].Value);
                txtDetailQuantity.Text = row.Cells["quantity_details"].Value.ToString();
            }
        }

        private void LoadDetails()
        {
            using (var conn = new MySqlConnection(DBConfig.LoadConfig()))
            {
                conn.Open();
                var cmd = new MySqlCommand("SELECT detail_id, name FROM details ORDER BY detail_id DESC", conn);
                var adapter = new MySqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                lstDetailID.DataSource = table;
                lstDetailID.DisplayMember = "name";
                lstDetailID.ValueMember = "detail_id";
            }
        }
    }
}
