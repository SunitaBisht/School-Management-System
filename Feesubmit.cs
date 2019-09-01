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
    public partial class Feesubmit : Form
    {
        decimal Adf, Latef, Devf, Comf, Abf, LAbf, DA, Readf, Tuf, AuVif, Scf, redf, Gamef, Mf, Exf, totalf;

        private void textBox16_TextChanged(object sender, EventArgs e)                     //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox16.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox16.Text = "";
                }
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)                        //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox17.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox17.Text = "";
                }
            }
        }
        private void textBox18_TextChanged(object sender, EventArgs e)                               //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox18.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox18.Text = "";
                }
            }
        }
        private void textBox19_TextChanged(object sender, EventArgs e)                     //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox19.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox19.Text = "";
                }
            }
        }
        private void textBox20_TextChanged(object sender, EventArgs e)                         //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox20.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox20.Text = "";
                }
            }
        }
        private void textBox21_TextChanged(object sender, EventArgs e)                         //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox21.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox21.Text = "";
                }
            }
        }
        private void textBox15_TextChanged(object sender, EventArgs e)                              //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox15.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox15.Text = "";
                }
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)                     //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox10.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox10.Text = "";
                }
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)                                 //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox9.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox9.Text = "";
                }
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)               //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox8.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox8.Text = "";
                }
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)                         //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox7.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox7.Text = "";
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)                                //condition for enter fee (only numbers not other char)
        {
            string s3 = textBox6.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox6.Text = "";
                }
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)                                //condition for enter fee (only numbers not other char)
        {
            string s2 = textBox4.Text;
            foreach (char ch in s2)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox4.Text = "";
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)                               //condition for enter fee (only numbers not other char)
        {

            string s2 = textBox5.Text;
            foreach (char ch in s2)
            {
                if ((ch >= '0' && ch <= '9') || (ch == '.'))
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox5.Text = "";
                }
            }
        }

        public void sum()                                      //create method  all fee for sum
        {
            if (textBox3.Text != "")
            {
                Adf = decimal.Parse(textBox3.Text);
            }
            else
            {
                Adf = 0;
            }

            if (textBox4.Text != "")
            {
                Latef = decimal.Parse(textBox4.Text);
            }
            else
            {
                Latef = 0;
            }
            if (textBox5.Text != "")
            {
                Devf = decimal.Parse(textBox5.Text);
            }
            else
            {
                Devf = 0;
            }
            if (textBox6.Text != "")
            {
                Comf = decimal.Parse(textBox6.Text);
            }
            else
            {
                Comf = 0;
            }
            if (textBox7.Text != "")
            {
                Abf = decimal.Parse(textBox7.Text);
            }
            else
            {
                Adf = 0;
            }
            if (textBox8.Text != "")
            {
                LAbf = decimal.Parse(textBox8.Text);
            }
            else
            {
                LAbf = 0;
            }
            if (textBox9.Text != "")
            {
                DA = decimal.Parse(textBox9.Text);
            }
            else
            {
                DA = 0;
            }
            if (textBox10.Text != "")
            {
                Readf = decimal.Parse(textBox10.Text);
            }
            else
            {
                Readf = 0;
            }
            if (textBox11.Text != "")
            {
                Tuf = decimal.Parse(textBox15.Text);
            }
            else
            {
                Tuf = 0;
            }
            if (textBox16.Text != "")
            {
                AuVif = decimal.Parse(textBox16.Text);
            }
            else
            {
                AuVif = 0;
            }
            if (textBox17.Text != "")
            {
                Scf = decimal.Parse(textBox17.Text);
            }
            else
            {
                Scf = 0;
            }
            if (textBox18.Text != "")
            {
                redf = decimal.Parse(textBox18.Text);
            }
            else
            {
                redf = 0;
            }
            if (textBox19.Text != "")
            {
                Gamef = decimal.Parse(textBox19.Text);
            }
            else
            {
                Gamef = 0;
            }
            if (textBox20.Text != "")
            {
                Mf = decimal.Parse(textBox20.Text);
            }
            else
            {
                Mf = 0;
            }
            if (textBox21.Text != "")
            {
                Exf = decimal.Parse(textBox21.Text);
            }
            else
            {
                Exf = 0;
            }

            totalf = Adf + Latef + Devf + Comf + Abf + LAbf + DA + Readf + Tuf + AuVif + Scf + redf + Gamef + Mf + Exf;
            textBox11.Text = totalf.ToString();
        }


        public Feesubmit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "" || textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "")
            //{
            //    MessageBox.Show("please fill all details");
            //}
            //else
            //{

            //}
        }

        private void button3_Click(object sender, EventArgs e)                 //search details
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "Select StudentName,Class,sion From PersonalDetail Where ApplicationNo='" + comboBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                textBox2.Text = dr.GetString(0);
                textBox13.Text = dr.GetString(1);
                textBox14.Text = dr.GetString(2);
            }
            dr.Close();
            con.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {                                                         //call sum method
            sum();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)                 //condition for enter fee (only numbers not other char)
        {
            String s1 = textBox3.Text;
            foreach (char ch in s1)
            {
                if ((ch >= '0' && ch <= '9') || ch == '.')
                {

                }
                else
                {
                    MessageBox.Show("inalid character");
                    textBox3.Text = "";
                }
            }
        }
    }
}

