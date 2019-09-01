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
    public partial class FacultyRegi : Form
    {
        public FacultyRegi()
        {
            InitializeComponent();
        }
        String Gender;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox3.Text == "" || textBox6.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || textBox7.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "")
            {
                MessageBox.Show("please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert into FacultyDetails values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+ Gender + "','" + comboBox3.Text + "','" + textBox6.Text + "','" + comboBox4.Text + "','"+dateTimePicker1.Value.Date.ToString()+"','"+dateTimePicker2.Value.Date.ToString()+"','" + comboBox5.Text + "','" + comboBox6.Text + "','" + textBox7.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + comboBox9.Text + "','" + comboBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "')";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("Data save sucessfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox3.Text = "";
            textBox6.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            radioButton1.Text = "";
            radioButton2.Text = "";
            comboBox6.Text = "";
            textBox7.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox3.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox3.Text = "";
                }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox4.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox4.Text = "";
                }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox6.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox6.Text = "";
                }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox9.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox9.Text = "";
                }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox12.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox12.Text = "";
                }
        }
    }
}

