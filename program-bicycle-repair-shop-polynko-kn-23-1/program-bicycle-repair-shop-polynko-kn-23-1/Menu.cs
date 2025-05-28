using System;
using System.Windows.Forms;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void підключенняДоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вийтиЗМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            var enterMenu = new EnterMenu();
            enterMenu.Show();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            var formClients = new FormClients();
            formClients.Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var formOrders = new FormOrders();
            formOrders.Show();
            this.Hide();
        }

        private void btnSignUpRepairs_Click(object sender, EventArgs e)
        {
            var formSignUpRepairs = new FormSignUpRepairs();
            formSignUpRepairs.Show();
            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            var formDetails = new FormDetails();
            formDetails.Show();
            this.Hide();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            var formWorkers = new FormWorkers();
            formWorkers.Show();
            this.Hide();
        }
    }
}
