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
    public partial class ProductList : Form
    {
        DBConect con = new DBConect();

        public ProductList()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Product().Show();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            var query = "Select *From Product1";
            var ds = con.getData(query);

            dataGridView1Prd.DataSource = ds.Tables[0];
            dataGridView1Prd.Columns[0].HeaderText = "Կոդ";
            dataGridView1Prd.Columns[1].HeaderText = "Խմբի անվանում";
            dataGridView1Prd.Columns[0].HeaderText = "Ապրանքի անվանում";

        }

        string bid;
        string bGroupName;
        string bProductName;

        private void dataGridView1Prd_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1Prd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = dataGridView1Prd.Rows[e.RowIndex].Cells[0].Value.ToString();
                bGroupName = dataGridView1Prd.Rows[e.RowIndex].Cells[1].Value.ToString();
                bProductName = dataGridView1Prd.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Դուք ցանկանում եք հեռացնել տվյալ խումբը?", " ", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                con.setData("delete from Product1 where ProductID = '" + bid + "'");
                MessageBox.Show("Տվյալները հաջողությամբ խմբագրվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductList_Activated(object sender, EventArgs e)
        {
            string query = "select * from Product1";
            DataSet ds = con.getData(query);
            dataGridView1Prd.DataSource = ds.Tables[0];
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product Prd = new Product();
            Prd.Show();
            Prd.Text = "Խմբագրել";
            Prd.ProductCode.Text = bid;
            Prd.ProductName.Text = bProductName;
            Prd.RegistrProdbutton.Text = "Փոփոխել";
        }
    }
}
