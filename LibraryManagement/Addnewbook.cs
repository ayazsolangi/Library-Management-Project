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
    public partial class Addnewbook : Form
    {
        public Addnewbook()
        {
            InitializeComponent();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {

            if(textBoxQuatity.Text == ""|| textBoxISBN.Text == ""||textBoxYear.Text == "" ||textBoxname.Text == "" ||textBoxauthor.Text == "")
            {

            MessageBox.Show("Please Fill All the Textfields...","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            textBoxISBN.Focus();
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True");// new SqlConnection("data source=DESKTOP-ADQ30AI\\SQLEXPRESS;database=LMS;Integrated Security=True");
                String sql = "insert into BookRecord(ISBN,Name,Author,Quantity,Year) values('" + textBoxISBN.Text + "','" + textBoxname.Text + "','" + textBoxauthor.Text + "','" + textBoxQuatity.Text + "','" + textBoxYear.Text + "')";
                SqlCommand cmd = new SqlCommand(sql,conn);
               
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                
                da.Fill(ds);
                
                MessageBox.Show("Data is inserted suceessful in the database", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxQuatity.Text = "";
                textBoxISBN.Text = "";
                textBoxYear.Text = "";
                textBoxname.Text = "";
                textBoxauthor.Text = "";
            
            }
            catch (Exception ee) {

                //MessageBox.Show("Unknown Error","Error",MessageBoxIcon.Error,M);
             
                //MessageBox.Show("This Book already exists in Library");
            }
        }

        
    }
}
