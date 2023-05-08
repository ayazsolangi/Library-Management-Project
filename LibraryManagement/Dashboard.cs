using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addnewstudent obj = new Addnewstudent();
            obj.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addnewbook obj = new Addnewbook();
            obj.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewbooks obj = new viewbooks();
            obj.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent obj = new viewstudent();
            obj.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebook obj = new issuebook();
            obj.Show();
        }

        private void completeBookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetails obj = new BookDetails();
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void issueCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentcardprint obj = new studentcardprint();
            obj.Show();
        }

        
        
    }
}
