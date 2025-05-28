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
    public partial class FormProductDemandView : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormProductDemandView()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
        }

        private void FormProductDemandView_Load(object sender, EventArgs e)
        {
            productDemandsViewDAO pdDAO = new productDemandsViewDAO();

            bindingSource.DataSource = pdDAO.getALLproductDemandsView();
            dataGridView1.DataSource = bindingSource;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;
            }
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            productDemandsViewDAO pdDAO = new productDemandsViewDAO();

            bindingSource.DataSource = pdDAO.getALLproductDemandsView();
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

                txtID.Text = row.Cells["detail_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
            }
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            ProductDemandView productDemandView = new ProductDemandView
            {
                detail_id = int.Parse(txtID.Text)
            };
            productDemandsViewDAO pdDAO = new productDemandsViewDAO();

            bindingSource.DataSource = pdDAO.getSearchByID(productDemandView);
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            ProductDemandView productDemandView = new ProductDemandView
            {
                name = txtName.Text,
            };
            productDemandsViewDAO pdDAO = new productDemandsViewDAO();

            bindingSource.DataSource = pdDAO.getSearchByName(productDemandView);
            dataGridView1.DataSource = bindingSource;
        }
    }
}
