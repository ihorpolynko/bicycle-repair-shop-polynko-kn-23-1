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
    public partial class FormExpandedSignUpRepairsView : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormExpandedSignUpRepairsView()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 16;
        }

        private void FormExpandedSignUpRepairsView_Load(object sender, EventArgs e)
        {
            expandedSignUpRepairsViewDAO esurDAO = new expandedSignUpRepairsViewDAO();

            bindingSource.DataSource = esurDAO.getALLexpandedSignUpRepairsView();
            dataGridView1.DataSource = bindingSource;
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

                txtID.Text = row.Cells["sign_up_repairs_id"].Value.ToString();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            expandedSignUpRepairsViewDAO esurDAO = new expandedSignUpRepairsViewDAO();

            bindingSource.DataSource = esurDAO.getALLexpandedSignUpRepairsView();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            ExpandedSignUpRepairsView expandedSignUpRepairView = new ExpandedSignUpRepairsView
            {
                sign_up_repairs_id = int.Parse(txtID.Text)
            };
            expandedSignUpRepairsViewDAO esurDAO = new expandedSignUpRepairsViewDAO();

            bindingSource.DataSource = esurDAO.getSearchByID(expandedSignUpRepairView);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearchByWorkerPIB_Click(object sender, EventArgs e)
        {
            ExpandedSignUpRepairsView expandedSignUpRepairView = new ExpandedSignUpRepairsView
            {
                worker_pib = txtWorkerPIB.Text
            };
            expandedSignUpRepairsViewDAO esurDAO = new expandedSignUpRepairsViewDAO();

            bindingSource.DataSource = esurDAO.getSearchByWorkerPIB(expandedSignUpRepairView);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearchByClientPIB_Click(object sender, EventArgs e)
        {
            ExpandedSignUpRepairsView expandedSignUpRepairView = new ExpandedSignUpRepairsView
            {
                client_pib = txtClientPIB.Text
            };
            expandedSignUpRepairsViewDAO esurDAO = new expandedSignUpRepairsViewDAO();

            bindingSource.DataSource = esurDAO.getSearchByClientPIB(expandedSignUpRepairView);
            dataGridView1.DataSource = bindingSource;
        }
    }
}