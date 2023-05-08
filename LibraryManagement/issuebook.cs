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
    public partial class issuebook : Form
    {
        public issuebook()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True");

        private void buttonIssue_Click(object sender, EventArgs e)
        {
            if (check() > 3) {
                MessageBox.Show("This Student book limit "+check()+"");
                return;
            
            }
            SqlCommand cmd = new SqlCommand("Select ID,Name from StudentRecord2 where id='" + textBoxID.Text + "'", conn);
            SqlDataAdapter DA;
            String ID = "";
            String Bookname = "";
            String Studentname = "";
            String ISBN = "";
            DataSet DS;
            try
            {
                DA = new SqlDataAdapter(cmd);
                DS = new DataSet();
                DA.Fill(DS);
                ID = DS.Tables[0].Rows[0][0].ToString();
                Studentname = DS.Tables[0].Rows[0][1].ToString();
            }
            catch (Exception ee)
            {
                MessageBox.Show("This Student is not Registered in Library", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                cmd = new SqlCommand("select isbn,name from BookRecord where isbn='" + textBoxISBN.Text + "'", conn);
                DA = new SqlDataAdapter(cmd);
                DS = new DataSet();
                DA.Fill(DS);
                ISBN = DS.Tables[0].Rows[0][0].ToString();
                Bookname = DS.Tables[0].Rows[0][1].ToString();

            }
            catch (Exception ee)
            {

                MessageBox.Show("This Book is not Available in Library", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            check();
            cmd = new SqlCommand("insert into BookIssue(ID,ISBN,NameS,NameB) values('" + ID + "','" + ISBN + "','" + Studentname + "','" + Bookname + "')", conn);
            DA = new SqlDataAdapter(cmd);
            DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Book has been Issued to the Student", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }


        int check()
        {
           // //MySqlCommand c=new 
           // SqlCommand cmd = new SqlCommand("select count(*) from BookIssue where ID='" + textBoxID.Text + "'   ", conn);
           // conn.Open();
            
           // MySqlCommand cmd=//SqlDataAdapter DA = new SqlDataAdapter(cmd);
           //// int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
           //// DataSet DS = new DataSet();
            
           // conn.Close();
            
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
