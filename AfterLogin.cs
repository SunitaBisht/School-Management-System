using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AfterLogin : Form
    {
        public AfterLogin()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();                               //create object 
            ob.MdiParent = this;
            ob.Show();

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyRegi ob = new FacultyRegi();
            ob.MdiParent = this;
            ob.Show();
        }

        private void addSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddnewSubject ob = new AddnewSubject();
            ob.MdiParent = this;
            ob.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feesubmit ob = new Feesubmit();
            ob.MdiParent = this;
            ob.Show();
        }

        private void studentUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1Updates ob = new Form1Updates();
            ob.MdiParent = this;
            ob.Show();
        }

        private void staffUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyRegiUPDATE ob = new FacultyRegiUPDATE();
            ob.MdiParent = this;
            ob.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creat ob = new creat();
            ob.MdiParent = this;
            ob.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
