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
        }

        private void FormOrderDetail_Load(object sender, EventArgs e)
        {
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
            lblResult.Text = "";

            txtID.Text = orderId.ToString();
            ordersDetailDAO odDAO = new ordersDetailDAO();

            bindingSource.DataSource = odDAO.getALLOrdersDetail();
            dataGridView1.DataSource = bindingSource;
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
            txtDetailID.Clear();
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
                detail_id = int.Parse(txtDetailID.Text),
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
                detail_id = int.Parse(txtDetailID.Text),
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
                detail_id = int.Parse(txtDetailID.Text)
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

                txtDetailID.Text = row.Cells["detail_id"].Value.ToString();
                txtDetailQuantity.Text = row.Cells["quantity_details"].Value.ToString();
            }
        }
    }
}
