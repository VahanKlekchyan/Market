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
    public partial class Dzerqberum : Form
    {
        DBConect con = new DBConect();

        public Dzerqberum()
        {
            InitializeComponent();
        }

        int i = 0;
        int uPrice = 0;
        int pCount = 0;
        int totalSum = 0;
        int price = 0;
        int veradir = 0;
        int sPrice = 0;
        string exDate;

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            pCount = int.Parse(textBoxCount.Text);
            uPrice = int.Parse(textBoxUnitPrice.Text);
            price = pCount * uPrice;
            veradir = int.Parse(textBoxVeradir.Text);
            sPrice = (uPrice * veradir / 100 + uPrice);
            exDate = dateTimePicker1.Text;
            dataGridView1.Rows[i].Cells[0].Value = comboBoxProductName.Text;
            dataGridView1.Rows[i].Cells[1].Value = pCount.ToString();
            dataGridView1.Rows[i].Cells[2].Value = uPrice.ToString();
            dataGridView1.Rows[i].Cells[3].Value = price.ToString();
            dataGridView1.Rows[i].Cells[4].Value = veradir.ToString();
            dataGridView1.Rows[i].Cells[5].Value = sPrice.ToString();
            dataGridView1.Rows[i].Cells[6].Value = exDate.ToString();
            totalSum += price;
            textBox3TotalSum.Text = totalSum.ToString();
            i++;
        }

        private void textBoxUnitPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = (int.Parse(textBoxCount.Text) * int.Parse(textBoxUnitPrice.Text)).ToString();
        }

        private void textBoxVeradir_TextChanged(object sender, EventArgs e)
        {
            textBoxSalesPrice.Text = (int.Parse(textBoxUnitPrice.Text) * int.Parse(textBoxVeradir.Text) / 100 + int.Parse(textBoxUnitPrice.Text)).ToString();
        }

        private void Dzerqberum_Load(object sender, EventArgs e)
        {
            string query = "Select ProductName From Product1 ";
            var ds = con.getData(query);

            comboBoxProductName.DataSource = ds.Tables[0];
            comboBoxProductName.DisplayMember = "ProductName";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dataGridView1.ColumnCount = 7;
            dataGridView1.RowCount = 30;
            dataGridView1.Columns[0].HeaderText = "Ապրանքի անվանում";
            dataGridView1.Columns[1].HeaderText = "Քանակ";
            dataGridView1.Columns[2].HeaderText = "Գին";
            dataGridView1.Columns[3].HeaderText = "Գումար";
            dataGridView1.Columns[4].HeaderText = "Վերադիր %";
            dataGridView1.Columns[5].HeaderText = "Վաճառքի գին";
            dataGridView1.Columns[6].HeaderText = "Պիտ. ժամկետ";
        }

        private void buttonGrancel_Click(object sender, EventArgs e)
        {
            var docNum = textBox1DocNumber.Text;
            var partners = textBox2Partners.Text;
            for (int k = 0; k < i; k++)
            {
                string query = "INSERT INTO Invoice VALUES (N'" + docNum + "',N'" + partners + "','" + totalSum + "',N'" + dataGridView1.Rows[k].Cells[0].Value + "','" + dataGridView1.Rows[k].Cells[1].Value + "','" + dataGridView1.Rows[k].Cells[2].Value + "','" + dataGridView1.Rows[k].Cells[3].Value + "','" + dataGridView1.Rows[k].Cells[4].Value + "','" + dataGridView1.Rows[k].Cells[5].Value + "', '" + dataGridView1.Rows[k].Cells[6].Value + "')";
                con.setData(query);
            }

            MessageBox.Show("Տվյալները հաջողությամբ լրացվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();     
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStripEditDelete.Show(Cursor.Position);
        }

        private void buttonPakel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void հեռացնելToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStripEditDelete.Close();
        }

        private void ToolStripMenuItemdelete_Click(object sender, EventArgs e)
        {

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowindex);       
            i--;
        }

        private void խմբագրելToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            comboBoxProductName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxCount.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxUnitPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxVeradir.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxSalesPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
            i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
        }
    }
}
