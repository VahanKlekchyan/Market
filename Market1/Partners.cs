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
    public partial class Partners : Form
    {
        DBConect con = new DBConect();

        string bid;
        string bFirstName;
        string bLastName;
        string bTel;
        string bDiscount;
        public Partners()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Addpartners().Show();

        }

        private void Partners_Load(object sender, EventArgs e)
        {
            var query = "Select *From Partners";
            var ds = con.getData(query);

            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "Կոդ";
            dataGridView1.Columns[1].HeaderText = "Անուն";
            dataGridView1.Columns[2].HeaderText = "Ազգանուն";
            dataGridView1.Columns[3].HeaderText = "Հեռախոս";
            dataGridView1.Columns[4].HeaderText = "Զեղչ";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                bFirstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                bLastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                bTel = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                bDiscount = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Դուք ցանկանում եք հեռացնել տվյալ խումբը?", " ", MessageBoxButtons.YesNo);
            if (dResult == DialogResult.Yes)
            {
                con.setData("delete from Partners where PartnersCode = '" + bid + "'");
                MessageBox.Show("Տվյալները հաջողությամբ խմբագրվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Partners_Activated(object sender, EventArgs e)
        {
            string query = "select * from Partners";
            DataSet ds = con.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void խմբագրելToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addpartners edit = new Addpartners();
            edit.Show();
            edit.Text = "Խմբագրել";
            edit.button1Add.Text = "Փոփոխել";
            edit.textBoxCode.Text = bid;
            edit.textBoxName.Text = bFirstName;
            edit.textBoxLastname.Text = bLastName;
            edit.textBoxTel.Text = bTel;
            edit.textBoxDiscount.Text = bDiscount;


        }
    }
}

