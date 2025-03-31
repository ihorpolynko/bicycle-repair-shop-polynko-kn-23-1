using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Crud;
using System.Diagnostics.Metrics;

namespace Kyrsova1PolynkoP_20
{
    public partial class Form1 : Form
    {
        private FormClient client;
        private FormMaster master;
        private FormProfit profit;
        private FormZapus_na_remont zapus_na_remont;
        private FormWorker worker;
        private FormSklad sklad;
        private FormTovar tovar;
        private FormZamov zamov;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client = new FormClient();
            client.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            master = new FormMaster();
            master.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            profit = new FormProfit();
            profit.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zapus_na_remont = new FormZapus_na_remont();
            zapus_na_remont.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            worker = new FormWorker();
            worker.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sklad = new FormSklad();
            sklad.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            tovar = new FormTovar();
            tovar.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            zamov = new FormZamov();
            zamov.Visible = true;
        }

        private void ‚Ëı≥‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}