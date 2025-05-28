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
    public partial class FormDetails : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormDetails()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 4;
            lblResult.Text = "";
        }

        private void FormDetails_Load(object sender, EventArgs e)
        {
            detailsDAO dDAO = new detailsDAO();

            bindingSource.DataSource = dDAO.getALLDetails();
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
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = new Menu();
            menu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["detail_id"].Value.ToString();
                txtName.Text = row.Cells["name"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details detail = new Details
            {
                name = txtName.Text,
                price = decimal.Parse(txtPrice.Text)
            };

            detailsDAO dDAO = new detailsDAO();
            int result = dDAO.addDetail(detail);

            bindingSource.DataSource = dDAO.getALLDetails();
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
            Details detail = new Details
            {
                detail_id = int.Parse(txtID.Text),
                name = txtName.Text,
                price = decimal.Parse(txtPrice.Text)
            };

            detailsDAO dDAO = new detailsDAO();
            int result = dDAO.updateDetail(detail);

            bindingSource.DataSource = dDAO.getALLDetails();
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
            Details detail = new Details
            {
                detail_id = int.Parse(txtID.Text)
            };

            detailsDAO dDAO = new detailsDAO();
            int result = dDAO.deleteDetail(detail);

            bindingSource.DataSource = dDAO.getALLDetails();
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
            detailsDAO dDAO = new detailsDAO();

            bindingSource.DataSource = dDAO.getALLDetails();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Details detail = new Details
            {
                name = txtSearch.Text
            };
            detailsDAO dDAO = new detailsDAO();

            bindingSource.DataSource = dDAO.getSearchDetails(detail);
            dataGridView1.DataSource = bindingSource;
        }

        private void попитТоварівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productDemand = new FormProductDemandView();
            productDemand.ShowDialog();
        }
    }
}
