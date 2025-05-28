using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public partial class EnterMenu: Form
    {
        public EnterMenu()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            lblError.Text = "";
        }

        private void EnterMenu_Load(object sender, EventArgs e)
        {

        }
        private void Change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            UserAuth.ConnectionString = DBConfig.LoadConfig();

            var user = UserAuth.Authenticate(username, password);

            if (user != null)
            {
                if (user.role == "Admin")
                {
                    bool admin = true;
                    var connection = new Connection(admin);
                    connection.Show();
                    this.Hide();
                }
                else if (user.role == "Manager" || user.role == "Master")
                {
                    var menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                lblError.Text = "Неправильний логін або пароль!";
            }
        }


        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void підключенняДоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool admin = false;
            var connection = new Connection(admin);
            connection.Show();
            this.Hide();
        }
    }
}