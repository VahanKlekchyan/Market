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
    public partial class Sales : Form
    {
        DBConect con = new DBConect();
        string Docdate = DateTime.Today.ToString("yyyy-MM-dd");
        int i = 0;

        public Sales()
        {
            InitializeComponent();
        }


        private void Sales_Load(object sender, EventArgs e)
        {
            var query = "Select GroupName From ProductGroup";
            var ds = con.getData(query);

            comboBox1ProductGroup.DataSource = ds.Tables[0];
            comboBox1ProductGroup.DisplayMember = "GroupName";

            query = "Select FirstName,LastName From Partners";
            ds = con.getData(query);

            comboBox3Partners.DataSource = ds.Tables[0];
            comboBox3Partners.DisplayMember = "FirstName" ;
           
            dataGridView1Sales.ColumnCount = 6;
            dataGridView1Sales.RowCount = 30;
            dataGridView1Sales.Columns[0].HeaderText = "Ապրանքի անվանում";
            dataGridView1Sales.Columns[1].HeaderText = "Քանակ";
            dataGridView1Sales.Columns[2].HeaderText = "Վաճառքի Գին";
            dataGridView1Sales.Columns[3].HeaderText = "Զեղչ";
            dataGridView1Sales.Columns[4].HeaderText = "Զեղչ գին";
            dataGridView1Sales.Columns[5].HeaderText = "Գումար";
        }

        private void comboBox1ProductGroup_TextChanged(object sender, EventArgs e)
        {
            var query = "Select ProductName From Product1 where ProductGroup= N'" + comboBox1ProductGroup.Text + "' ";
            var ds = con.getData(query);

            comboBox2ProductName.DataSource = ds.Tables[0];
            comboBox2ProductName.DisplayMember = "ProductName";
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {

            dataGridView1Sales.Rows[i].Cells[0].Value = comboBox2ProductName.Text.ToString();
            dataGridView1Sales.Rows[i].Cells[1].Value = textBox2Count.Text.ToString();
            dataGridView1Sales.Rows[i].Cells[2].Value = textBox4Price.Text.ToString();
            dataGridView1Sales.Rows[i].Cells[3].Value = textBox6DCountpersent.Text.ToString();
            dataGridView1Sales.Rows[i].Cells[4].Value = (int.Parse(textBox4Price.Text) - int.Parse(textBox4Price.Text) * int.Parse(textBox6DCountpersent.Text) / 100).ToString();
            dataGridView1Sales.Rows[i].Cells[5].Value = (int.Parse(textBox2Count.Text) * (int.Parse(textBox4Price.Text) - int.Parse(textBox4Price.Text) * int.Parse(textBox6DCountpersent.Text) / 100)).ToString();

            i++;
        }

        private void textBox6DCountpersent_TextChanged(object sender, EventArgs e)
        {
            textBox3DiscountPrice.Text = (int.Parse(textBox4Price.Text) - int.Parse(textBox4Price.Text) * int.Parse(textBox6DCountpersent.Text) / 100).ToString();
            textBox5Sum.Text = (int.Parse(textBox2Count.Text) * (int.Parse(textBox4Price.Text) - int.Parse(textBox4Price.Text) * int.Parse(textBox6DCountpersent.Text) / 100)).ToString();
        }

        private void button2Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1Grancel_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < i; k++)
            {
                var docNum = textBox1Hdm.Text;
                var dartners = comboBox3Partners.Text;
                var query = "INSERT INTO Sales VALUES (N'" + docNum + "',N'" + dartners + "',N'" + comboBox1ProductGroup.Text + "',N'" + dataGridView1Sales.Rows[k].Cells[0].Value + "','" + dataGridView1Sales.Rows[k].Cells[1].Value + "','" + dataGridView1Sales.Rows[k].Cells[2].Value + "','" + dataGridView1Sales.Rows[k].Cells[3].Value + "','" + dataGridView1Sales.Rows[k].Cells[4].Value + "','" + dataGridView1Sales.Rows[k].Cells[5].Value + "', '" + Docdate + "')";
                con.setData(query);
            }

            MessageBox.Show("Տվյալները հաջողությամբ լրացվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void comboBox3Partners_TextChanged(object sender, EventArgs e)
        {
            var query = "Select FirstName From Partners";
            var ds = con.getData(query);

            comboBox3Partners.DataSource = ds.Tables[0];
            comboBox3Partners.DisplayMember = "FirstName";

        }
    }
}
