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
    public partial class FormReport : Form
    {
        BindingSource bindingSource = new BindingSource();

        public FormReport()
        {
            InitializeComponent();
            ThemeStyles.ApplyTheme(this);
            ThemeStyles.Change_theme_img(change_theme);
            dataGridView1.Left = (dataGridView1.Width) / 5;
            dataGridView2.Left = (dataGridView1.Width) / 4;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            reportsDAO rDAO = new reportsDAO();

            bindingSource.DataSource = rDAO.getALLmonthlyWorkerProfit();
            dataGridView1.DataSource = bindingSource;

            bindingSource.DataSource = rDAO.getALLmonthlyDetailsSales();
            dataGridView2.DataSource = bindingSource;

            var workersProfit = rDAO.getALLmonthlyWorkerProfit();
            dataGridView1.DataSource = workersProfit;
            decimal totalProfit = workersProfit.Sum(w => w.profit);
            txtSumProfit.Text = totalProfit.ToString("0.00");

            var detailsSales = rDAO.getALLmonthlyDetailsSales();
            dataGridView2.DataSource = detailsSales;
            decimal totalSumDetails = detailsSales.Sum(d => d.price * d.total_sold);
            txtSumDetails.Text = totalSumDetails.ToString("0.00");
        }

        private void change_theme_Click(object sender, EventArgs e)
        {
            change_theme.Image = ThemeStyles.isDarkTheme
                ? Properties.Resources.to_dark_theme
                : Properties.Resources.to_white_theme;

            ThemeStyles.ToggleTheme(this);
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menu = new Menu();
            menu.Show();
        }
    }
}
