using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq.Expressions;
//using System.forms.DataGridView;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class viewbooks : Form
    {

        
        private SqlDataAdapter DA;
        private SqlCommand cmd;

        

        public viewbooks()
        {
            InitializeComponent();
        }

        
       
        private void viewbooks_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dataGridView1.DataSource = books();
             
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True");// new SqlConnection("data source=DESKTOP-ADQ30AI\\SQLEXPRESS;database=LMS;Integrated Security=True");
        private DataTable books() {
            dtbook = new DataTable();
             cmd = new SqlCommand("select * from BookRecord",conn);
             //cmd.CommandType = CommandType.Text;
           
            DA = new SqlDataAdapter(cmd);

            DA.Fill(dtbook);
            return dtbook;   }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var VetRowsName = from myRows in dtbook.AsEnumerable() where myRows.Field<String>("Name").Contains(textBoxname.Text) select myRows;
                dataGridView1.DataSource = VetRowsName.CopyToDataTable<DataRow>();
            }
            catch (Exception ee) {
                MessageBox.Show("This Book is not available in Library", "Results", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }}

        private void SortButton_Click(object sender, EventArgs e)
        {
            
            var VetRowsName = from myRows in dtbook.AsEnumerable() orderby myRows[comboBoxSort.Text] ascending select myRows;
            dataGridView1.DataSource = VetRowsName.CopyToDataTable<DataRow>();

        }


        DataRow rows;
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            panel1.Visible = true;
            int rowtoupdate = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            rows = dtbook.Rows[rowtoupdate];
            textBoxauthor.Text = rows["author"] + "";
            textBoxNaame.Text = rows["name"] + "";
            textBoxISBN.Text = rows["isbn"] + "";
            textBoxquantity.Text = rows["quantity"] + ""; ;
            textBoxyear.Text = rows["year"] + "";
            
            }
        //SqlCommandBuilder cmdbuilder;
        

        private void UpdateButoon_Click(object sender, EventArgs e)
        {
            if (UpdateButoon.Text == "Update")
            {
                cmd = new SqlCommand("UPDATE BookRecord SET ISBN='" + textBoxISBN.Text + "',Name='" + textBoxNaame.Text + "', Author='" + textBoxauthor.Text + "', Year='" + textBoxyear.Text + "', Quantity='" + textBoxquantity.Text + "' where Author='" + Author + "' and Name='" + Namee + "' and ISBN='" + ISBN + "' and Quantity='" + Quantity + "' and year='" + Year + "'  ", conn);
                
                DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                panel1.Visible = false;
            }
            if (UpdateButoon.Text == "Insert") {

                
                panel1.Visible = true;
               // SqlConnection conn = new SqlConnection("data source=DESKTOP-ADQ30AI\\SQLEXPRESS;database=LMS;Integrated Security=True");
                String sql = "insert into BookRecord(ISBN,Name,Author,Year,Quantity) values('" + textBoxISBN.Text + "','" + textBoxNaame.Text + "','" + textBoxauthor.Text + "','" + textBoxyear.Text + "','" + textBoxquantity.Text + "')";
                 cmd = new SqlCommand(sql, conn);
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                MessageBox.Show("Data is insert suceessful", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Visible = false;
            
            
            
            }


            dataGridView1.DataSource = books();


        }
            String Author = "";
            String Namee = "";
            String ISBN = "";
            String Quantity = "";
            String Year = "";
        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            buttonDelete.Visible = false;
             textBoxauthor.Text="";
             textBoxNaame.Text="";
             ISBN = textBoxISBN.Text="";
             Quantity = textBoxquantity.Text="";
             Year = textBoxyear.Text="";
            UpdateButoon.Text = "Insert";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateButoon.Text = "Update";
            buttonDelete.Visible = true;
            panel1.Visible = true;
            int rowtoupdate = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            rows = dtbook.Rows[rowtoupdate];
            Author = rows["author"] + "";
            Namee = rows["name"] + "";
            ISBN = rows["isbn"] + "";
            Quantity = rows["quantity"] + "";
            Year = rows["year"] + "";

            
            textBoxauthor.Text = rows["author"] + "";
            textBoxNaame.Text = rows["name"] + "";
            textBoxISBN.Text = rows["isbn"] + "";
            textBoxquantity.Text = rows["quantity"] + ""; 
            textBoxyear.Text = rows["year"] + "";
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                var hti = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.ClearSelection();
                dataGridView1.Rows[hti.RowIndex].Selected = true;

                
            
            }
        }
        SqlDataAdapter adapter;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult Result =MessageBox.Show("Do you Really want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if( Result==DialogResult.Yes)
            {
            cmd = new SqlCommand("delete from BookRecord where ISBN='" + textBoxISBN.Text + "' and Name='" + textBoxNaame.Text + "'",conn);
             adapter = new SqlDataAdapter(cmd);
            
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = books();}
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

            try
            {
                var VetRowsName = from myRows in dtbook.AsEnumerable() where myRows.Field<String>("Name").Contains(textBoxname.Text) select myRows;
                dataGridView1.DataSource = VetRowsName.CopyToDataTable<DataRow>();
            }
            catch (Exception ee)
            {
                textBoxname.Focus();
                //   MessageBox.Show("This Book is not available in Library", "Results", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        
       
       
    }
}

