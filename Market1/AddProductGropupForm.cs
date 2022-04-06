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
    public partial class AddProductGropupForm : Form
    {
        DBConect con = new DBConect();

        public AddProductGropupForm()
        {
            InitializeComponent();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            string query;
            if (ADDbutton.Text == "Գրանցել")
            {
                query = "Insert into ProductGroup values ('" + Codetext.Text + "',N'" + GroupNametext.Text + "') ";
                MessageBox.Show("Տվյալները հաջողությամբ լրացվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                query = "UPDATE ProductGroup SET GroupName= (N'" + GroupNametext.Text + "') WHERE GroupID = ('" + Codetext.Text + "') ";
                MessageBox.Show("Տվյալները հաջողությամբ խմբագրվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.setData(query);
            Close();
        }
    }
}
