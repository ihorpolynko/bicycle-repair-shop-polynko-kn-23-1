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
    public partial class FormUsers : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormUsers()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
            lblResult.Text = "";
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            usersDAO uDAO = new usersDAO();

            bindingSource.DataSource = uDAO.getALLUsers();
            dataGridView1.DataSource = bindingSource;

            lstRole.SelectedIndex = 0;
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
            var entermenu = new EnterMenu();
            entermenu.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                login = txtLogin.Text,
                password = txtPass.Text,
                role = lstRole.SelectedItem.ToString()
            };

            usersDAO uDAO = new usersDAO();
            int result = uDAO.addUser(user);

            bindingSource.DataSource = uDAO.getALLUsers();
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
            Users user = new Users
            {
                user_id = int.Parse(txtID.Text),
                login = txtLogin.Text,
                password = txtPass.Text,
                role = lstRole.SelectedItem.ToString()
            };

            usersDAO uDAO = new usersDAO();
            int result = uDAO.updateUser(user);

            bindingSource.DataSource = uDAO.getALLUsers();
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
            Users user = new Users
            {
                user_id = int.Parse(txtID.Text),
            };

            usersDAO uDAO = new usersDAO();
            int result = uDAO.deleteUser(user);

            bindingSource.DataSource = uDAO.getALLUsers();
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
            usersDAO uDAO = new usersDAO();

            bindingSource.DataSource = uDAO.getALLUsers();
            dataGridView1.DataSource = bindingSource;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Users user = new Users
            {
                role = lstSearch.SelectedItem.ToString()
            };

            usersDAO uDAO = new usersDAO();

            bindingSource.DataSource = uDAO.getSearchUsers(user);
            dataGridView1.DataSource = bindingSource;
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtLogin.Clear();
            txtPass.Clear();
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

                txtID.Text = row.Cells["user_id"].Value.ToString();
                txtLogin.Text = row.Cells["login"].Value.ToString();
                txtPass.Text = row.Cells["password"].Value.ToString();
                lstRole.SelectedItem = row.Cells["role"].Value.ToString();
            }
        }
    }
}
