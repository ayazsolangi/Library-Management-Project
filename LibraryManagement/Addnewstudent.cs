using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Addnewstudent : Form
    {
        static SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True"); //new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True");//"da source=DESKTOP-ADQ30AI\\SQLEXPRESS;database=LMS;Integrated Security=True");
        //}


        public Addnewstudent()
        {
            InitializeComponent();
            //name();

        }
        String imglocation = "";
        private void buttonupload_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG (*.jpg)|*.jpg|GIF (*.gif)|*.gif|PNG (*.png)|*.png|All (*.*)|*.*";
            dlg.Title = "Select Image of Student";
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                imglocation = dlg.FileName.ToString();
                pictureBox2.ImageLocation = imglocation;


            }
        }
        
        private void buttonsave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                img = br.ReadBytes((int)fs.Length);
                String sql = "insert into studentrecord2 (ID,name,department,semester,contact,email,photo) values('" + textBoxID.Text + "','" + textBoxname.Text + "','" + textBoxdepart.Text + "','" + textBoxsemester.Text + "','" + textBoxcontact.Text + "','" + textBoxemail.Text + "',@img)";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add(new SqlParameter("@img", img));
                    int x = cmd.ExecuteNonQuery();
                                        conn.Close();

                    MessageBox.Show("Data is Inserted into Database successfully", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
            }
            catch (Exception ob)
            {
                MessageBox.Show("Check All Textfields are Filled, OR This Student is Already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonrefresh_Click(object sender, EventArgs e)
        {
            clear();
        }


        public void clear() {
            textBoxcontact.Clear();
            textBoxdepart.Clear();
            textBoxemail.Clear();
            textBoxID.Clear();
            textBoxsemester.Clear();
            textBoxname.Clear();
            pictureBox2.Hide();
            
        
        }
    }
}
