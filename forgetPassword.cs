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
    public partial class forgetPassword : Form
    {
        public forgetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select sq from CreateAccount where Useid='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                label5.Text = dr.GetString(0);
            }
            else
            {
                MessageBox.Show("invalid");
            }
            dr.Close();
            con.Close();
        }





        private void button2_Click(object sender, EventArgs e)
        {
           
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Select psw from CreateAccount where useid='" + textBox1.Text + "' and ans='"+textBox2.Text+"'";
                OleDbDataReader dr = ob.getData(sqlcmd, con);
                if (dr.Read())
                {
                    label6.Text = dr.GetString(0);
                }
                else
                {
                    MessageBox.Show("invalid answer");
                }
                con.Close();
                dr.Close();
            }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

