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
    public partial class FacultyRegiUPDATE : Form
    {
        public FacultyRegiUPDATE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox3.Text == "" || textBox6.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || textBox7.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "")
            {
                MessageBox.Show("please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "update FacultyDetails set FacultyName='"+textBox2.Text+"',Deprt='"+comboBox1.Text+"',sub='"+comboBox2.Text+"',MobNum='"+textBox3.Text+"',PhoneNum='"+textBox4.Text+"',EmailId='"+textBox5.Text+"',RelationshipStatus='"+comboBox3.Text+"',AadhrNo='"+textBox6.Text+"',BloodGroup='"+comboBox4.Text+"',Datejoining='"+dateTimePicker1.Value.Date.ToString()+"',DOB='"+dateTimePicker2.Value.Date.ToString()+"',Qf='"+comboBox5.Text+"',Exprince='"+comboBox6.Text+"',age='"+textBox7.Text+"',persentCountry='"+comboBox7.Text+"',pesentState='"+comboBox8.Text+"',persentcity='"+textBox8.Text+"',prsentzipcode='"+textBox9.Text+"',persentlandmark='"+textBox10.Text+"', permaCountry='"+comboBox9.Text+"',permastate='"+comboBox10.Text+"',permacity='"+textBox11.Text+"',permazip='"+textBox12.Text+"',permalandmark='"+textBox13.Text+"' where  EmployeeID='" + textBox1.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            mycon ob = new mycon();                              //search facultydetails detail
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select *from FacultyDetails where EmployeeID='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {

                textBox2.Text = dr.GetString(1);
                comboBox1.Text = dr.GetString(2);
                comboBox2.Text = dr.GetString(3);
                textBox3.Text = dr.GetString(4);
                textBox4.Text = dr.GetString(5);
                textBox5.Text = dr.GetString(6);
                
                comboBox3.Text = dr.GetString(8);
                textBox6.Text = dr.GetString(9);
                comboBox4.Text = dr.GetString(10);
                dateTimePicker1.Text = dr.GetString(11);
                dateTimePicker2.Text = dr.GetString(12);
                comboBox5.Text = dr.GetString(13);
                comboBox6.Text = dr.GetString(14);
                textBox7.Text = dr.GetString(15);
                comboBox7.Text = dr.GetString(16);
                comboBox8.Text = dr.GetString(17);
                textBox8.Text = dr.GetString(18);
                textBox9.Text = dr.GetString(19);
                textBox10.Text = dr.GetString(20);
                comboBox9.Text = dr.GetString(21);
                comboBox10.Text = dr.GetString(22);
                textBox11.Text = dr.GetString(23);
                textBox12.Text = dr.GetString(24);
                textBox13.Text = dr.GetString(25);
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

