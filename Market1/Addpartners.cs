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
    public partial class Addpartners : Form
    {
        DBConect con = new DBConect();
        public Addpartners()
        {
            InitializeComponent();
        }

        public void button1Add_Click(object sender, EventArgs e)
        {
            string query;
            if (button1Add.Text == "Գրանցել")
            {
                query = "Insert into Partners values ('" + textBoxCode.Text + "',N'" + textBoxName.Text + "',N'" + textBoxLastname.Text + "',N'" + textBoxTel.Text + "',N'" + textBoxDiscount.Text + "') ";
                MessageBox.Show("Տվյալները հաջողությամբ ավելացվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                query = "UPDATE Partners SET FirstName= N'" + textBoxName.Text + "' , LastName=N'" + textBoxLastname.Text + "', Telephone='" + textBoxTel.Text + "',Discount='" + textBoxDiscount.Text + "'  WHERE PartnersCode = '" + textBoxCode.Text + "' ";
                MessageBox.Show("Տվյալները հաջողությամբ խմբագրվել են", "Sucsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.setData(query);
            Close();
        }

        private void button2Close_Click(object sender, EventArgs e)
        {
            Close();
        }

             
    }
}
