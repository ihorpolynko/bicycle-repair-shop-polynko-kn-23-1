using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace program_bicycle_repair_shop_polynko_kn_23_1
{
    public partial class Connection : Form
    {
        public Connection(bool admin)
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            lblConfig.Text = "";
            if(admin)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }

            tbDataSource.TextChanged += CheckIfAllDBConfigFieldsFilled;
            tbUsername.TextChanged += CheckIfAllDBConfigFieldsFilled;
            tbPassword.TextChanged += CheckIfAllDBConfigFieldsFilled;
            tbDatabase.TextChanged += CheckIfAllDBConfigFieldsFilled;

            CheckIfAllDBConfigFieldsFilled(null, null);
        }

        private void CheckIfAllDBConfigFieldsFilled(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(tbDataSource.Text)
                          && !string.IsNullOrWhiteSpace(tbUsername.Text)
                          && !string.IsNullOrWhiteSpace(tbPassword.Text)
                          && !string.IsNullOrWhiteSpace(tbDatabase.Text);

            btnSave.Enabled = allFilled;
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            if (File.Exists("dbconfig.json"))
            {
                string json = File.ReadAllText("dbconfig.json");
                var config = JsonSerializer.Deserialize<DBConfig>(json);

                if (config != null)
                {
                    tbDataSource.Text = config.DataSource;
                    tbUsername.Text = config.Username;
                    tbPassword.Text = config.Password;
                    tbDatabase.Text = config.Database;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var config = new DBConfig
            {
                DataSource = tbDataSource.Text,
                Username = tbUsername.Text,
                Password = tbPassword.Text,
                Database = tbDatabase.Text
            };

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("dbconfig.json", json);

            UserAuth.ConnectionString = config.GetConnectionString();
            lblConfig.Text = "Конфігурацію збережено!";
        }

        private void вийтиЗМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbDataSource.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
            tbDatabase.Clear();
        }

        public void Сhange_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void Connection_FormClosed(object sender, FormClosedEventArgs e)
        {
            var enterMenu = new EnterMenu();
            enterMenu.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var users = new FormUsers();
            users.Show();
            this.Hide();
        }
    }
}