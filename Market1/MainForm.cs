using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market1
{
    public partial class MainForm : Form
    {
        DBConect con = new DBConect();
        public MainForm()
        {
            InitializeComponent();
        }
        private void ProducGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductGroup().Show();
        }

        private void ProductNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ProductList().Show();
        }

        private void IncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dzerqberum().Show();
        }
        private void SalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Sales().Show();

        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Report().Show();
        }

        private void BuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Partners().Show();
        }
    }
      
}
