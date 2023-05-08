using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class viewstudent : Form
    {
       
        public viewstudent()
        {
            InitializeComponent();
        }

        public DataTable students;
        SqlDataAdapter DA;
        SqlConnection conn  = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True");
        public void showData() {
            SqlCommand cmd = new SqlCommand("select * from studentrecord2", conn);
            students = new DataTable();
            DA = new SqlDataAdapter(cmd);
            DA.Fill(students);
            panel1.Visible = false;
            dataGridView1.DataSource = students;
        
        }
        
        private void viewstudent_Load(object sender, EventArgs e)
        {

            showData();


        }


        private DataTable books()
        {
            students = new DataTable();
            cmd = new SqlCommand("select * from BookRecord", conn);
            //cmd.CommandType = CommandType.Text;

            DA = new SqlDataAdapter(cmd);

            DA.Fill(students);
            return students;
        }

        String name = "";
        String ID = "";
        String semester = "";
        String phone = "";
        String email = "";
        String department = "";

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            buttonDelete.Visible = true;
            buttonUpdate.Visible = false;
            int rowtoupdate = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            rows = students.Rows[rowtoupdate];
            name=rows["Name"]+"";
            ID = rows["ID"] + "";
            semester=rows["Semester"]+"";
            phone=rows["Contact"]+"";
            email = rows["Email"] + "";
            department = rows["department"] + "";
            textBoxcontact.Text = phone;
            textBoxdepart.Text = department;
            textBoxnameee.Text = name;
            textBoxsemester.Text = semester;
            textBoxID.Text = ID;
            textBoxemail.Text = email;



            //Author = rows["author"] + "";
            
            //int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            //dataGridView1.Rows.RemoveAt(index);
            //SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(DA);
            //DA.Update(students);
            panel1.Visible = true;

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var curser = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.Rows[curser.RowIndex].Selected = true;



            }


        }

        private void dataGridView1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var curser = dataGridView1.HitTest(e.X, e.Y);
                dataGridView1.Rows[curser.RowIndex].Selected = true;



            }
        }
       // private DataTable dtbook;
        //private SqlDataAdapter DA;
        private SqlCommand cmd;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var VetRowsName = from myRows in students.AsEnumerable() where myRows.Field<String>("Name").Contains(textBoxname.Text) select myRows;
                dataGridView1.DataSource = VetRowsName.CopyToDataTable<DataRow>();
            }
            catch (Exception ee)
            {
                MessageBox.Show("This Book is not available in Library", "Results", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            var VetRowsName = from myRows in students.AsEnumerable() orderby myRows[comboBoxSort.Text] ascending select myRows;
            dataGridView1.DataSource = VetRowsName.CopyToDataTable<DataRow>();

        }
        DataRow rows;

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonDelete.Visible = false;
            buttonUpdate.Visible = true;
            
            
            //panel1.Visible = true;
            panel1.Visible = true;
            int rowtoupdate = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            rows = students.Rows[rowtoupdate];
            //textBoxauthor.Text = rows["author"] + "";
            textBoxcontact.Text = rows["Contact"] + "";
            textBoxdepart.Text = rows["department"] + "";
            textBoxemail.Text = rows["email"] + " ";
            textBoxID.Text = rows["ID"] + "";
            textBoxnameee.Text = rows["Name"] + "";
            textBoxsemester.Text = rows["semester"] + "";
           
        }
        

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("UPDATE STUDENTRECORD2 SET Name='" + textBoxnameee.Text + "',contact='" + textBoxcontact.Text + "', department='" + textBoxdepart.Text + "', Email='" + textBoxemail.Text + "', Semester='" + textBoxsemester.Text + "' where ID='" + textBoxID.Text + "' ", conn);
            DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DA.Fill(students);
            dataGridView1.DataSource = students;
            showData();
            panel1.Visible = false;
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you Really want to delete the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                
                cmd = new SqlCommand("delete from STUDENTRECORD2 where ID='" + textBoxID.Text + "'", conn);
                DA = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                DA.Fill(ds);
                showData();
                dataGridView1.DataSource = books();
                panel1.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var VetRowsName = from myRows in students.AsEnumerable() where myRows.Field<String>("Name").Contains(textBoxname.Text) select myRows;
                dataGridView1.DataSource = VetRowsName.CopyToDataTable<DataRow>();
            }
            catch (Exception ee)
            {
                textBoxname.Focus();
            }
        }

        


    }

       
}
