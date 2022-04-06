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
    public partial class Report : Form
    {
        DBConect con = new DBConect();

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dateTimePicker1ST.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1ST.Format = DateTimePickerFormat.Custom;

            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;


        }

        private void button1ShowReport_Click(object sender, EventArgs e)
        {
            var query = "Select * From Invoice where IExdate between '" + dateTimePicker1ST.Text + "'   and '" + dateTimePickerEnd.Text + "'";
            var ds = con.getData(query);
            dataGridView1Rep.DataSource = ds.Tables[0];
        }
    }
}
