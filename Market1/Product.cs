using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market1
{
    public partial class Product : Form
    {
        DBConect con = new DBConect();

        public Product()
        {
            InitializeComponent();
        }

        private void Registrbutton_Click(object sender, EventArgs e)
        {
            string query;
            if (RegistrProdbutton.Text == "Գրանցել")
            {
                query = "Insert into Product1 values ('" + ProductCode.Text + "',N'" + ProductGroup.Text + "',N'" + ProductName.Text + "') ";
                MessageBox.Show("Տվյալները հաջողությամբ ավելացվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                query = "UPDATE Product1 SET ProductGroup= N'" + ProductGroup.Text + "' , ProductName=N'" + ProductName.Text + "' WHERE ProductID = '" + ProductCode.Text + "' ";
                MessageBox.Show("Տվյալները հաջողությամբ խմբագրվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.setData(query);
            Close();
        }

        private void CloseProdbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            string query = "Select GroupID,GroupName From ProductGroup ";
            DataSet ds = con.getData(query);

            ProductGroup.DataSource = ds.Tables[0];
            ProductGroup.DisplayMember = "GroupName";
            ProductGroup.ValueMember = "GroupID";
        }

    }  
}
