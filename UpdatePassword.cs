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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "update CreateAccount set psw='" + textBox3.Text + "',cpsw='" + textBox4.Text + "' where Useid='" + textBox1.Text + "' and psw='" + textBox2.Text + "'";
            int n = ob.putData(sqlcmd, con);
            if (n >= 1)
            {
                MessageBox.Show("password update sucessfully");
            }
            else
            {
                MessageBox.Show("error");
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
