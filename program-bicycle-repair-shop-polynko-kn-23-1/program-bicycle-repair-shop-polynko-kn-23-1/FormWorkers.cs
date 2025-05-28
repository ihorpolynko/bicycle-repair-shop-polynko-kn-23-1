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
    public partial class FormWorkers : Form
    {
        BindingSource bindingSource = new BindingSource();
        public FormWorkers()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
            lblResult.Text = "";
        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            workersDAO wDAO = new workersDAO();

            bindingSource.DataSource = wDAO.getALLWorkers();
            dataGridView1.DataSource = bindingSource;

            lstPosition.SelectedIndex = 0;
        }

        private void change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void FormWorkers_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = new Menu();
            menu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["worker_id"].Value.ToString();
                txtPIB.Text = row.Cells["pib"].Value.ToString();
                lstPosition.SelectedItem = row.Cells["position"].Value.ToString();
                txtNumber.Text = row.Cells["phone_number"].Value.ToString();
                txtSalary.Text = row.Cells["salary"].Value.ToString();
            }
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPIB.Clear();
            txtNumber.Clear();
            txtSalary.Clear();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            workersDAO wDAO = new workersDAO();

            bindingSource.DataSource = wDAO.getALLWorkers();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Workers worker = new Workers
            {
                pib = txtPIB.Text,
                position = lstPosition.Text,
                phone_number = txtNumber.Text,
                salary = Decimal.Parse(txtSalary.Text)
            };

            workersDAO wDAO = new workersDAO();
            int result = wDAO.addWorker(worker);

            bindingSource.DataSource = wDAO.getALLWorkers();
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
            Workers worker = new Workers
            {
                worker_id = int.Parse(txtID.Text),
                pib = txtPIB.Text,
                position = lstPosition.Text,
                phone_number = txtNumber.Text,
                salary = Decimal.Parse(txtSalary.Text)
            };

            workersDAO wDAO = new workersDAO();
            int result = wDAO.updateWorker(worker);

            bindingSource.DataSource = wDAO.getALLWorkers();
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
            Workers worker = new Workers
            {
                worker_id = int.Parse(txtID.Text),
            };

            workersDAO wDAO = new workersDAO();
            int result = wDAO.deleteWorker(worker);

            bindingSource.DataSource = wDAO.getALLWorkers();
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
            Workers worker = new Workers
            {
                position = lstSearch.Text
            };
            workersDAO wDAO = new workersDAO();

            bindingSource.DataSource = wDAO.getSearchWorkers(worker);
            dataGridView1.DataSource = bindingSource;
        }
    }
}
