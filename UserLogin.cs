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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)                        
        {
           

            mycon ob = new mycon();
            OleDbConnection con = ob.conn();
            String sqlcmd = "Select * from CreateAccount where Useid='" + textBox1.Text + "'and psw='" + textBox2.Text + "'";
            OleDbDataReader dr = ob.getData(sqlcmd, con);
            if (dr.Read())
            {
                AfterLogin obj = new AfterLogin();
                obj.Show();
                
            }
            else
            {
                MessageBox.Show("invalid userid & Password Please try again");
            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgetPassword obj = new forgetPassword();
            obj.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            UpdatePassword obj = new UpdatePassword();
            obj.Show();
        }
    }
}
