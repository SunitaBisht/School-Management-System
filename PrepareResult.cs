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
    public partial class PrepareResult : Form
    {

        decimal sum = 0;
        decimal percentage = 0;
        decimal maxmarks = 1000;

        public void sumofmarks()                                                               //create function for marks                                                                                                                    
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "select * from prepareResult where ApplicationNo='" + textBox2.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            while (dr.Read())
            {
                sum = sum + decimal.Parse(dr.GetString(8));                                        //sum of total marks
                percentage = (sum * 100) / maxmarks;                                              //convert percentage

                if (percentage >= 80)
                {
                    textBox11.Text = "A+";
                }
                else if (percentage < 80 && percentage >= 60)
                {
                    textBox11.Text = "A";

                }                                                                      //show grad
                else if (percentage < 60 && percentage >= 50)
                {
                    textBox11.Text = "B";
                }
                else if (percentage < 50 && percentage >= 40)
                {
                    textBox11.Text = "C";
                }
                else if (percentage < 40 && percentage >= 33)
                {
                    textBox11.Text = "D";
                }
                else if (percentage < 33)
                {
                    textBox11.Text = "fail";
                }
            }
            textBox9.Text = sum.ToString();                                         //show total marks
            textBox10.Text = percentage.ToString();                                   //show percentage

            dr.Close();
            con.Close();
        }



        public void showgrid()                                                                               //show gridview
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "select * from prepareResult where ApplicationNo='" + textBox2.Text + "'";
            dataGridView1.DataSource = ob.getTable(sqlcmd, con);
            con.Close();
        }
        public void addsubject()                                              //create function  add subject in textbox
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "select subName from Subject where cls='" + textBox5.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));

            }
            dr.Close();
            con.Close();

        }
        public PrepareResult()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox5.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox5.Text = "";
                }
        }

        private void button1_Click(object sender, EventArgs e)                    //search button
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from PersonalDetail where ApplicationNo='" + textBox2.Text + "'";               //fetch table data
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox3.Text = dr.GetString(6);
                textBox5.Text = dr.GetString(3);
                textBox6.Text = dr.GetString(2);
                textBox7.Text = dr.GetString(4);

            }
            dr.Close();

            sqlcmd = "Select FatherName from FamilyDetails where ApplicationNo='" + textBox2.Text + "'";            //show another table datafetch           
            dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox4.Text = dr.GetString(0);
            }
            dr.Close();

            addsubject();                                                      //call addsubject function

            showgrid();                                                         //call gridview

            sumofmarks();                                                   //call function

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)                //save button
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = " Insert into prepareResult values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox8.Text + "')";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("save data sucessfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
                showgrid();                                                         //call gridview

                sumofmarks();                                                         //call sum
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox8.Text;
            foreach (char ch in s1)
                if ((ch <= '9' && ch >= '0') || ch == '.')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox8.Text = "";
                }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox9.Text;
            foreach (char ch in s1)
                if ((ch <= '9' && ch >= '0') || ch == '.')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox9.Text = "";
                }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox10.Text;
            foreach (char ch in s1)
                if ((ch <= '9' && ch >= '0') || ch == '.' || ch == '%')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox10.Text = "";
                }
        }
    }
}

 
