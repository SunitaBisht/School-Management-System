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
    public partial class Form1Updates : Form
    {
        public Form1Updates()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {                                                                               //update personal detail

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "")

            {
                MessageBox.Show("Please fill all details ");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = " Update PersonalDetail set AddDate='" + dateTimePicker1.Value.Date.ToString() + "',RollNO='" + textBox2.Text + "',Class='" + comboBox1.Text + "',sion='" + comboBox2.Text + "',sson='" + comboBox3.Text + "',StudentName='" + textBox3.Text + "',Gender='" + comboBox4.Text + "',DOB='" + dateTimePicker2.Value.Date.ToString() + "',BithPlace='" + comboBox5.Text + "',AadharNo='" + textBox4.Text + "',BloodGroup='" + comboBox6.Text + "',Nationality='" + comboBox7.Text + "',Religion='" + comboBox8.Text + "',Category='" + comboBox9.Text + "',cst='" + comboBox10.Text + "',PhysicallyChallanged='" + comboBox11.Text + "',Medium='" + comboBox12.Text + "',Board='" + comboBox13.Text + "',Behaviour='" + comboBox14.Text + "',Remark='" + textBox5.Text + "' where ApplicationNo= '" + textBox1.Text + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            mycon ob = new mycon();                              //search personal detail
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select *from PersonalDetail where ApplicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox3.Text = dr.GetString(6);
                comboBox4.Text = dr.GetString(7);
                dateTimePicker2.Text = dr.GetString(8);
                comboBox5.Text = dr.GetString(9);
                textBox4.Text = dr.GetString(10);
                comboBox6.Text = dr.GetString(11);
                comboBox7.Text = dr.GetString(12);
                comboBox8.Text = dr.GetString(13);
                comboBox9.Text = dr.GetString(14);
                comboBox10.Text = dr.GetString(15);
                comboBox11.Text = dr.GetString(16);
                comboBox12.Text = dr.GetString(17);
                comboBox13.Text = dr.GetString(18);
                comboBox14.Text = dr.GetString(19);
                textBox5.Text = dr.GetString(20);

            }
            dr.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)                              //clear personal detail
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            comboBox13.Text = "";
            comboBox14.Text = "";


        }

        private void button7_Click(object sender, EventArgs e)                              //update address detail
        {
            if (comboBox15.Text == "" || comboBox16.Text == "" || comboBox17.Text == "" || comboBox18.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Please fill All Details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Update AddressDetails set AddDate='" + dateTimePicker1.Value.Date.ToString() + "',RollNo='" + textBox2.Text + "',Class='" + comboBox1.Text + "',sion='" + comboBox2.Text + "',sson='" + comboBox3.Text + "',PresentCountry='" + comboBox15.Text + "',PresentState='" + comboBox16.Text + "',PresentCity='" + textBox6.Text + "',PresentZipCode='" + textBox7.Text + "',PresentLandMark='" + textBox8.Text + "',ParmanentCountry='" + comboBox17.Text + "',ParmanentState='" + comboBox18.Text + "',ParmanentCity='" + textBox9.Text + "',ParmanentZipCode='" + textBox10.Text + "',ParmanentLandMark='" + textBox11.Text + "' where ApplicationNo='" + textBox1.Text + "'";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("data update sucssfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mycon ob = new mycon();                                             //search address detail
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from AddressDetails where ApplicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                comboBox15.Text = dr.GetString(6);
                comboBox16.Text = dr.GetString(7);
                textBox6.Text = dr.GetString(8);
                textBox7.Text = dr.GetString(9);
                textBox8.Text = dr.GetString(10);
                comboBox17.Text = dr.GetString(11);
                comboBox18.Text = dr.GetString(12);
                textBox9.Text = dr.GetString(13);
                textBox10.Text = dr.GetString(14);
                textBox11.Text = dr.GetString(15);
            }
            dr.Close();
            con.Close();
        }





        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";                                     //clear address detail
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox15.Text = "";
            comboBox16.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox17.Text = "";
            comboBox18.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)                            //update address detail
        {
            if (textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("Please fill all Details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = " Update ContectDetails set AddDate='" + dateTimePicker1.Value.Date.ToString() + "',RollNo='" + textBox2.Text + "',Class='" + comboBox1.Text + "',sion='" + comboBox2.Text + "',sson='" + comboBox3.Text + "',contectPerson='" + textBox12.Text + "',Relation='" + textBox13.Text + "',PhoneNo='" + textBox14.Text + "',MobileNo='" + textBox15.Text + "',Emailid='" + textBox16.Text + "' where ApplicationNo='" + textBox1.Text + "'";
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
        private void button11_Click(object sender, EventArgs e)                             //search address details
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            string sqlcmd = "Select * from ContectDetails where ApplicationNo='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox12.Text = dr.GetString(6);
                textBox13.Text = dr.GetString(7);
                textBox14.Text = dr.GetString(8);
                textBox15.Text = dr.GetString(9);
                textBox16.Text = dr.GetString(10);
            }
            dr.Close();
            con.Close();
        }
        private void button9_Click(object sender, EventArgs e)                           //clear address details
        {
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }





        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)                              //family detail update
        {
            if (textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || comboBox19.Text == "" || textBox24.Text == "" || textBox25.Text == "" || textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "" || comboBox20.Text == "" || textBox31.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                string sqlcmd = "Update FamilyDetails set AddDate='" + dateTimePicker1.Value.Date.ToString() + "',RollNo='" + textBox2.Text + "', Class='" + comboBox1.Text + "',sion='" + comboBox2.Text + "',sson='" + comboBox3.Text + "',FatherName='" + textBox17.Text + "',Relationship='" + textBox18.Text + "',FatherMobileNo='" + textBox19.Text + "',FatherPhoneNo='" + textBox20.Text + "',FatherEmailId='" + textBox21.Text + "',FatherOccupation='" + textBox22.Text + "',FatherDesignation='" + textBox23.Text + "',FatherQualification='" + comboBox19.Text + "',FatherMonthlyIncome='" + textBox24.Text + "',MotherName='" + textBox25.Text + "',MotherMobileNo='" + textBox26.Text + "',MotherPhoneNo='" + textBox27.Text + "',MotherEmailNo='" + textBox28.Text + "',MotherOccupation='" + textBox29.Text + "',MotherDesignation='" + textBox30.Text + "',MotherQualification='" + comboBox20.Text + "',MotherMonthlyIncome='" + textBox31.Text + "' where ApplicationNo='" + textBox1.Text + "'";
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

        private void button18_Click(object sender, EventArgs e)              //family detail search
        {
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from FamilyDetails where ApplicationNo ='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);                          //fetch data from table to form
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox17.Text = dr.GetString(6);
                textBox18.Text = dr.GetString(7);
                textBox19.Text = dr.GetString(8);
                textBox20.Text = dr.GetString(9);
                textBox21.Text = dr.GetString(10);
                textBox22.Text = dr.GetString(11);
                textBox23.Text = dr.GetString(12);
                comboBox19.Text = dr.GetString(13);
                textBox24.Text = dr.GetString(14);
                textBox25.Text = dr.GetString(15);
                textBox26.Text = dr.GetString(16);
                textBox27.Text = dr.GetString(17);
                textBox28.Text = dr.GetString(18);
                textBox29.Text = dr.GetString(19);
                textBox30.Text = dr.GetString(20);
                comboBox20.Text = dr.GetString(21);
                textBox31.Text = dr.GetString(22);

            }
            dr.Close();
            con.Close();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {                                                                             //family detail clear
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            comboBox19.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            comboBox20.Text = "";
            textBox31.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)                         //update pre school detais
        {
            if (textBox32.Text == "" || textBox33.Text == "" || comboBox21.Text == "" || comboBox22.Text == "" || textBox34.Text == "" || textBox35.Text == "" || textBox36.Text == "")
            {
                MessageBox.Show("Please fill all Details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Update PreSchoolDetails set AddDate='" + dateTimePicker1.Value.Date.ToString() + "',RollNo='" + textBox2.Text + "',Class='" + comboBox1.Text + "',sion='" + comboBox2.Text + "',sson='" + comboBox3.Text + "',SchoolName='" + textBox32.Text + "',SchoolAddress='" + textBox33.Text + "',PreviousClass='" + comboBox21.Text + "',Board='" + comboBox22.Text + "',ObtainMarks='" + textBox34.Text + "',OutOfMarks='" + textBox35.Text + "',Percentage='" + textBox36.Text + "',passOutdate='" + dateTimePicker3.Value.Date.ToString() + "'";
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

        private void button23_Click(object sender, EventArgs e)
        {
            mycon ob = new mycon();                                                         //search pre school details
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from PreSchoolDetails  where ApplicationNo ='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox32.Text = dr.GetString(6);
                textBox33.Text = dr.GetString(7);
                comboBox21.Text = dr.GetString(8);
                comboBox22.Text = dr.GetString(9);
                textBox34.Text = dr.GetString(10);
                textBox35.Text = dr.GetString(11);
                textBox36.Text = dr.GetString(12);
            }
            dr.Close();
            con.Close();
        }

        private void button19_Click(object sender, EventArgs e)                         //clear preschool details
        {
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            comboBox21.Text = "";
            comboBox22.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox37.Text == "" || textBox38.Text == "" || textBox39.Text == "" || textBox40.Text == "" || textBox41.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else                                                                               //update bank details
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Update BankDetails set  AddDate='" + dateTimePicker1.Value.Date.ToString() + "',RollNo='" + textBox2.Text + "',Class='" + comboBox1.Text + "',sion='" + comboBox2.Text + "',sson='" + comboBox3.Text + "',AccHolderName='" + textBox37.Text + "',BankName='" + textBox38.Text + "',BranchAddress='" + textBox39.Text + "',AccountNo='" + textBox40.Text + "',IFSCcode='" + textBox41.Text + "'where ApplicationNo='" + textBox1.Text + "'";

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

        private void button24_Click(object sender, EventArgs e)
        {                                                                   //search bank details
            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from BankDetails  where ApplicationNo ='" + textBox1.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                dateTimePicker1.Text = dr.GetString(0);
                textBox2.Text = dr.GetString(2);
                comboBox1.Text = dr.GetString(3);
                comboBox2.Text = dr.GetString(4);
                comboBox3.Text = dr.GetString(5);
                textBox37.Text = dr.GetString(6);
                textBox38.Text = dr.GetString(7);
                textBox39.Text = dr.GetString(8);
                textBox40.Text = dr.GetString(9);
                textBox41.Text = dr.GetString(10);
            }
            dr.Close();
            con.Close();
        }

        private void button21_Click(object sender, EventArgs e)                          //clear bank detail
        {
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string s1 = textBox4.Text;
            foreach (char ch in s1)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox4.Text = "";
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string s1 = textBox7.Text;
            foreach (char ch in s1)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid character");
                    textBox7.Text = "";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox2.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox2.Text = "";
                }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox10.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox10.Text = "";
                }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
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

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox15.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox15.Text = "";
                }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox19.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox19.Text = "";
                }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox20.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox20.Text = "";
                }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox26.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox26.Text = "";
                }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox27.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox27.Text = "";
                }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox34.Text;
            foreach (char ch in s1)
                if ((ch <= '9' && ch >= '0')||ch=='.')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox34.Text = "";
                }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox35.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox35.Text = "";
                }
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox36.Text;
            foreach (char ch in s1)
                if ((ch <= '9' && ch >= '0')||ch=='.' ||ch=='%')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox36.Text = "";
                }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox40.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox40.Text = "";
                }
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox41.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox41.Text = "";
                }
        }
    }
}
