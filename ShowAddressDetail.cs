using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SchoolManagement
{
    public partial class ShowAddressDetail : Form
    {
        public ShowAddressDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from AddressDetails";
            dataGridView1.DataSource = ob.getTable(sqlcmd, con);
            con.Close();

        }
    }
}
