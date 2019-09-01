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
    public partial class AddnewSubject : Form
    {
        public AddnewSubject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert into Subject values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "')";

                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("Data save sucessfully");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
