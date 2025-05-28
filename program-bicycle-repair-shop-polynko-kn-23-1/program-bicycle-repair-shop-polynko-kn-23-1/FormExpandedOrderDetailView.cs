using MySqlX.XDevAPI.Relational;
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
    public partial class FormExpandedOrderDetailView : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormExpandedOrderDetailView()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 16;
        }

        private void FormExpandedOrderDetailView_Load(object sender, EventArgs e)
        {
            expandedOrderDetailViewDAO eodDAO = new expandedOrderDetailViewDAO();

            bindingSource.DataSource = eodDAO.getALLexpandedOrderDetailView();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["order_id"].Value.ToString();
                txtWorkerPIB.Text = row.Cells["worker_pib"].Value.ToString();
                txtClientPIB.Text = row.Cells["client_pib"].Value.ToString();
            }
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtWorkerPIB.Clear();
            txtClientPIB.Clear();
        }

        private void повернутисяНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            ExpandedOrderDetailView expandedOrderDetailView = new ExpandedOrderDetailView
            {
                order_id = int.Parse(txtID.Text)
            };
            expandedOrderDetailViewDAO eodDAO = new expandedOrderDetailViewDAO();

            bindingSource.DataSource = eodDAO.getSearchByID(expandedOrderDetailView);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearchByWorkerPIB_Click(object sender, EventArgs e)
        {
            ExpandedOrderDetailView expandedOrderDetailView = new ExpandedOrderDetailView
            {
                worker_pib = txtWorkerPIB.Text
            };
            expandedOrderDetailViewDAO eodDAO = new expandedOrderDetailViewDAO();

            bindingSource.DataSource = eodDAO.getSearchByWorkerPIB(expandedOrderDetailView);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearchByClientPIB_Click(object sender, EventArgs e)
        {
            ExpandedOrderDetailView expandedOrderDetailView = new ExpandedOrderDetailView
            {
                client_pib = txtClientPIB.Text
            };
            expandedOrderDetailViewDAO eodDAO = new expandedOrderDetailViewDAO();

            bindingSource.DataSource = eodDAO.getSearchByClientPIB(expandedOrderDetailView);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            expandedOrderDetailViewDAO eodDAO = new expandedOrderDetailViewDAO();

            bindingSource.DataSource = eodDAO.getALLexpandedOrderDetailView();
            dataGridView1.DataSource = bindingSource;
        }
    }
}
