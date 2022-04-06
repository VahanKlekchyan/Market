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
    public partial class ProductGroup : Form
    {
        DBConect con = new DBConect();
        string bid;
        string bGroupName;

        public ProductGroup()
        {
            InitializeComponent();
        }

        public void ProductGroup_Load(object sender, EventArgs e)
        {
            var query = "select * from ProductGroup";
            var ds = con.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Խմբի համար";
            dataGridView1.Columns[1].HeaderText = "Խմբի անվանում";
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddProductGropupForm().Show();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editProdGroup = new AddProductGropupForm();

            editProdGroup.Show();
            editProdGroup.Text = "Խմբագրել";
            editProdGroup.Codetext.Text = bid;
            editProdGroup.GroupNametext.Text = bGroupName;
            editProdGroup.ADDbutton.Text = "Փոփոխել";
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bGroupName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dResult = MessageBox.Show("Դուք ցանկանում եք հեռացնել տվյալ խումբը?", " ", MessageBoxButtons.YesNo);

            if (dResult == DialogResult.Yes)
            {
                con.setData("delete from ProductGroup where GroupID = '" + bid + "'");
                MessageBox.Show("Տվյալները հաջողությամբ հեռացվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductGroup_Activated(object sender, EventArgs e)
        {
            var query = "select * from ProductGroup";
            var ds = con.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Խմբի համար";
            dataGridView1.Columns[1].HeaderText = "Խմբի անվանում";
            //  this.dataGridView1.Size = new System.Drawing.Size(781, 421);
        }
    }
}
