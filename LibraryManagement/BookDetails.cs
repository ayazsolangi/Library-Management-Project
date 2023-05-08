using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }
        public DataTable Books;
        DataTable DT;

        private void BookDetails_Load(object sender, EventArgs e)
        {
            dataGridViewBookDetails.DataSource = BookDetail();
            panel1.Visible = false;
            this.Width = 666;
            this.Height = 400;
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ADQ30AI\\SQLEXPRESS;database=LMS;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter DA;
        DataTable BookDetail() {

            
          cmd  = new SqlCommand("Select * from BookIssue", conn);
            DA = new SqlDataAdapter(cmd);
            DT = new DataTable();
            DA.Fill(DT);
            return DT;
        
        
        
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var VetRowsName = from myRows in DT.AsEnumerable() where myRows.Field<String>("NameB").Contains(textBoxname.Text) select myRows;
                dataGridViewBookDetails.DataSource = VetRowsName.CopyToDataTable<DataRow>();
            }
            catch (Exception ee)
            {
                MessageBox.Show("This Book is not available in Library", "Results", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        DataRow rows;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Width = 666;
            this.Height = 600;
            panel1.Visible = true;
            int rowtoupdate = dataGridViewBookDetails.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            rows = DT.Rows[rowtoupdate];
            textBoxISBN.Text = rows["ISBN"] + "";
            textBoxstudentname.Text = rows["NameS"] + "";
            TextBoxBookName.Text = rows["NameB"] + "";
            textBoxRollno.Text = rows["ID"] + "";

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Width = 666;
            this.Height = 400;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var VetRowsName = from myRows in DT.AsEnumerable() orderby myRows[comboBoxsort.Text] ascending select myRows;
            dataGridViewBookDetails.DataSource = VetRowsName.CopyToDataTable<DataRow>();

        }

        private void ReturnButoon_Click(object sender, EventArgs e)
        {

            DialogResult Result = MessageBox.Show("Do you Really want to Return the Book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from BookIssue where ISBN='" + textBoxISBN.Text + "' and NameS='" + textBoxstudentname.Text + "' and NameB='"+TextBoxBookName.Text+"' and ID='"+textBoxRollno.Text+"'", conn);
                DA = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                DA.Fill(ds);

                dataGridViewBookDetails.DataSource = BookDetail();
            }
 
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        




    }
}
