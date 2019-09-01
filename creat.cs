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
    public partial class creat : Form
    {
        public creat()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox4.Text == "")      //show msg when not fill all textboxes

            {
                label6.Text = "Please fill all details";
            }

            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "insert into CreateAccount values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("Data save");
                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

  
