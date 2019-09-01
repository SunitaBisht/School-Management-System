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
    public partial class CreateAccountUpdate : Form
    {
        public CreateAccountUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)                // create update button
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Update CreateAccount set psw='" + textBox2.Text + "',cpsw='" + textBox3.Text + "',sq='" + comboBox1.Text + "',ans='" + textBox4.Text + "' where Useid='" + textBox1.Text + "'";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("data update sucessfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)                        //search button create
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd= "Select * from CreateAccount where useid='"+textBox1.Text+"'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);                          //fetch data from table to form
            if (dr.Read())                
            {
                textBox2.Text = dr.GetString(1);                          //dr me data ek ek krke store hoga
                textBox3.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                textBox4.Text = dr.GetString(4);
            }
            dr.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)                       //create clear
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
        }
    }
}

 