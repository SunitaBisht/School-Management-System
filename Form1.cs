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
using System.IO;


namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)                 // personal detail           save button 
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "" || comboBox8.Text == "" || comboBox9.Text == "" || comboBox10.Text == "" || comboBox11.Text == "" || comboBox12.Text == "" || comboBox13.Text == "" || comboBox14.Text == "")
            // any one block is empty
            {
                MessageBox.Show("Please fill all details  ");
            }
            else
            {                                                           //details for personal detail form
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert Into PersonalDetail values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox3.Text + "','" + comboBox4.Text + "','" + dateTimePicker2.Text + "','" + comboBox5.Text + "','" + textBox4.Text + "','" + comboBox6.Text + "','" + comboBox7.Text + "','" + comboBox8.Text + "','" + comboBox9.Text + "','" + comboBox10.Text + "','" + comboBox11.Text + "','" + comboBox12.Text + "','" + comboBox13.Text + "','" + comboBox14.Text + "','" + textBox5.Text + "','" + label24.Text + "','" +label25.Text +"')";
                int n = ob.putData(sqlcmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("Data save Sucessfully ");
                }
                else
                {
                    MessageBox.Show("error");
                }
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {                                                                               ///all fill details clear
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

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)                   //Addres Details
        {
            if (comboBox15.Text == "" || comboBox16.Text == "" || comboBox17.Text == "" || comboBox18.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Please fill All Details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert Into AddressDetails values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox15.Text + "','" + comboBox16.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox17.Text + "','" + comboBox18.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
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

        private void button6_Click(object sender, EventArgs e)                       //address Details Clear Detail
        {
            comboBox15.Text = "";
            comboBox16.Text = "";
            comboBox17.Text = "";
            comboBox18.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)             //contect details
        {
            if (textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("Please fill all Details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert Into ContectDetails values( '" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "')";
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

        private void button8_Click(object sender, EventArgs e)         //clear contect detail
        {
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)            //family detail
        {
            if (textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "" || textBox21.Text == "" || textBox22.Text == "" || textBox23.Text == "" || comboBox19.Text == "" || textBox24.Text == "" || textBox25.Text == "" || textBox26.Text == "" || textBox27.Text == "" || textBox28.Text == "" || textBox29.Text == "" || textBox30.Text == "" || comboBox20.Text == "" || textBox31.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert Into FamilyDetails values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + comboBox19.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + comboBox20.Text + "','" + textBox31.Text + "','" + label43.Text + "','" +label44.Text+"','"+label56.Text+"','"+label57.Text+"')";
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

        private void button14_Click(object sender, EventArgs e)                //clear family detail
        {
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

        private void button15_Click(object sender, EventArgs e)           //preschoool detail
        {
            if (textBox32.Text == "" || textBox33.Text == "" || comboBox21.Text == "" || comboBox22.Text == "" || textBox34.Text == "" || textBox35.Text == "" || textBox36.Text == "")
            {
                MessageBox.Show("Please fill all Details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlCmd = "Insert Into PreSchoolDetails values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + comboBox21.Text + "','" + comboBox22.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "','" + dateTimePicker3.Text + "')";
                int n = ob.putData(sqlCmd, con);
                if (n >= 1)
                {
                    MessageBox.Show("Data Save sucessfully");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)              //clear preschool detail
        {
            textBox32.Text = "";
            textBox33.Text = "";
            comboBox21.Text = "";
            comboBox22.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)                              //bank details
        {
            if (textBox37.Text == "" || textBox38.Text == "" || textBox39.Text == "" || textBox40.Text == "" || textBox41.Text == "")
            {
                MessageBox.Show("Please fill all details");
            }
            else
            {
                mycon ob = new mycon();
                OleDbConnection con = ob.conn();
                String sqlcmd = "Insert Into BankDetails values('" + dateTimePicker1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + textBox41.Text + "')";
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

        private void button18_Click(object sender, EventArgs e)                 //clear bank detail
        {
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = myLogic.getRandom();
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = myLogic.getRandom();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)                                //aadhar card num only enter number not other char
        {
            string s3 = textBox4.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox4.Text = "";
                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox14.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox14.Text = "";
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox15.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox15.Text = "";
                }
            }

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox19.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox19.Text = "";
                }
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox20.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox20.Text = "";
                }
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox26.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox26.Text = "";
                }
            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox27.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox27.Text = "";
                }
            }
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox34.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || ch == '.')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox34.Text = "";
                }
            }
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox35.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox35.Text = "";
                }
            }

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox36.Text;
            foreach (char ch in s3)
            {
                if ((ch >= '0' && ch <= '9') || ch == '.' || ch == '%')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox36.Text = "";
                }
            }
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox40.Text;
            foreach (char ch in s3)
            {
                if (ch >= '0' && ch <= '9')
                {

                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox40.Text = "";
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            String s1 = textBox7.Text;
            foreach (char ch in s1)
                if (ch <= '9' && ch >= '0')
                {
                }
                else
                {
                    MessageBox.Show("invalid charecter");
                    textBox7.Text = "";
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

        private void button1_Click(object sender, EventArgs e)                         //select image
        {
            ofd.Title = "image Selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image |*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            String destpath = "E:/ssm/stuimg/";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //String newPath =Path.combine(destpath,path,GetFileName(ofd.FileName)));
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                String newFileName = "IMG" + myLogic.getid() + myLogic.getRandom();
                f1.CopyTo(String.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                String pa = newFileName + f1.Extension.ToString();
                label24.Text = pa;

            }

        }

        private void button2_Click(object sender, EventArgs e)                       //image Select
        {
            ofd.Title = "image Selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image |*.png";
            ofd.Multiselect = false;
            String destpath = "E:/ssm/stusignimg/";                         //create folder and write path
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                String newFileName = "IMG" + myLogic.getid() + myLogic.getRandom();
                f1.CopyTo(String.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                String pa = newFileName + f1.Extension.ToString();
                label25.Text = pa;
            }

        }

        private void button9_Click(object sender, EventArgs e)                  //select image
        {
            ofd.Title = "image Selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            String destpath = "E:/ssm/fatherimg/";                                       //create folder this location
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                String newFileName = "IMG" + myLogic.getid() + myLogic.getRandom();
                f1.CopyTo(String.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                String pa = newFileName + f1.Extension.ToString();
                label43.Text = pa;
            }
        }

        private void button10_Click(object sender, EventArgs e)                      //select image
        {
            ofd.Title = "image Selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            String destpath = "E:/ssm/fathersignimg/";                                       //create folder this location
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                String newFileName = "IMG" + myLogic.getid() + myLogic.getRandom();
                f1.CopyTo(String.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                String pa = newFileName + f1.Extension.ToString();
                label44.Text = pa;
            }
        }

        private void button11_Click(object sender, EventArgs e)                                //select image
        {
            ofd.Title = "image Selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            String destpath = "E:/ssm/motherimg/";                                       //create folder this location
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox5.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                String newFileName = "IMG" + myLogic.getid() + myLogic.getRandom();
                f1.CopyTo(String.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                String pa = newFileName + f1.Extension.ToString();
                label56.Text = pa;
            }
        }

        private void button12_Click(object sender, EventArgs e)                            //select image
        {
            ofd.Title = "image Selection";
            ofd.FileName = "";
            ofd.Filter = "JPEG Image|*.jpg|GIF Image|*.gif|PNG Image|*.png";
            ofd.Multiselect = false;
            String destpath = "E:/ssm/mothersignimg/";                                       //create folder this location
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox6.Image = Image.FromFile(ofd.FileName);
                FileInfo f1 = new FileInfo(ofd.FileName);
                String newFileName = "IMG" + myLogic.getid() + myLogic.getRandom();
                f1.CopyTo(String.Format("{0}{1}{2}", destpath, newFileName, f1.Extension));
                String pa = newFileName + f1.Extension.ToString();
                label57.Text = pa;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }
    }
}

