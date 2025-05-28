using System;
using System.Windows.Forms;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public partial class FormClients : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormClients()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
            lblResult.Text = "";
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            clientsDAO cDAO = new clientsDAO();

            bindingSource.DataSource = cDAO.getALLClients();
            dataGridView1.DataSource = bindingSource;
        }

        private void change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void FormClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = new Menu();
            menu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clients client = new Clients
            {
                pib = txtPIB.Text,
                phone_number = txtNumber.Text
            };

            clientsDAO cDAO = new clientsDAO();
            int result = cDAO.addClient(client);

            bindingSource.DataSource = cDAO.getALLClients();
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
            Clients client = new Clients
            {
                client_id = int.Parse(txtID.Text),
                pib = txtPIB.Text,
                phone_number = txtNumber.Text
            };

            clientsDAO cDAO = new clientsDAO();
            int result = cDAO.updateClient(client);

            bindingSource.DataSource = cDAO.getALLClients();
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
            Clients client = new Clients
            {
                client_id = int.Parse(txtID.Text),
            };

            clientsDAO cDAO = new clientsDAO();
            int result = cDAO.deleteClient(client);

            bindingSource.DataSource = cDAO.getALLClients();
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
            clientsDAO cDAO = new clientsDAO();

            bindingSource.DataSource = cDAO.getALLClients();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clients client = new Clients
            {
                pib = txtSearch.Text
            };
            clientsDAO cDAO = new clientsDAO();

            bindingSource.DataSource = cDAO.getSearchClients(client);
            dataGridView1.DataSource = bindingSource;
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtPIB.Clear();
            txtNumber.Clear();
            txtSearch.Clear();
        }

        private void повернутисядоменюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["client_id"].Value.ToString();
                txtPIB.Text = row.Cells["pib"].Value.ToString();
                txtNumber.Text = row.Cells["phone_number"].Value.ToString();
            }
        }
    }
}
