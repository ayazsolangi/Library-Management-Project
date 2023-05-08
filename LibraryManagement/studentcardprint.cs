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
    public partial class studentcardprint : Form
    {
        //String expire;
        public studentcardprint()
        {
            InitializeComponent();
           // expire = dateTimePicker1.Text;
            yearr();


        }
        String card = "";
        static String photo = "";
        SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\LMS.mdf;Integrated Security=True;User Instance=True");

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            yearr();
            try
            {
                photo = textBoxID.Text.ToString();
                String sql = "SELECT name, department, photo from studentrecord2 WHERE ID='"+textBoxID.Text+"'";
                byte[] img = null;
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        labelname.Text = reader[0] + "";
                        labeldepartment.Text = reader[1] + "";
                        labelrollno.Text = textBoxID.Text;
                        labelissuecard.Text = dateTimePicker1.Text;
                        img = (byte[])reader[2];
                    }
                    MemoryStream ms = new MemoryStream(img);
                     pictureBox1.Image = Image.FromStream(ms);

                    conn.Close();
                }
            }
            catch (Exception o)
            {
                conn.Close();
                //MessageBox.Show(o.Message);
               
            }
        }




        private void printbutton_Click(object sender, EventArgs e)
        {
            DVprintPreviewDialog.Document = DVprintDocument;
            DVprintPreviewDialog.ShowDialog();
           
        }
        Bitmap bmp;
        Image image;
        private void DVprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            yearr();
             bmp = (Bitmap)Properties.Resources.frame;
             image = bmp;
             e.Graphics.DrawImage(image, 5, 5, image.Width, image.Height);
             e.Graphics.DrawString(labelname.Text, new Font("Arial Narrow",16, FontStyle.Bold),Brushes.Black, new Point(142, 116));
             e.Graphics.DrawString(labeldepartment.Text, new Font("Arial Narrow", 16, FontStyle.Bold), Brushes.Black, new Point(142, 156));
             e.Graphics.DrawString(labelrollno.Text, new Font("Arial Narrow", 16, FontStyle.Bold), Brushes.Black, new Point(142, 197));
             e.Graphics.DrawString(dateTimePicker1.Text, new Font("Arial Narrow", 16, FontStyle.Bold), Brushes.Black, new Point(142, 234));
             e.Graphics.DrawString(labelexpires.Text, new Font("Arial Narrow", 16, FontStyle.Bold), Brushes.Black, new Point(142, 274));
            
            try
            {
                //SqlConnection conn = new SqlConnection("data source=DESKTOP-ADQ30AI\\SQLEXPRESS;Initial catalog=LMS;Integrated Security=True");
                byte[] img = null;
                

                //img = br.ReadBytes((int)fs.Length);
                String sql = "select photo from StudentRecord2 where ID='"+textBoxID.Text+"'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        img = (byte[])reader[0];

                    }
                    MemoryStream ms = new MemoryStream(img);
                     bmp =(Bitmap) Image.FromStream(ms);
                     image = bmp;
                     e.Graphics.DrawImage(image, 449, 121, 146, 198);
                    conn.Close();

                    // MessageBox.Show("Data is inserted in Database", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                byte[] img = null;


                //img = br.ReadBytes((int)fs.Length);
                String sql = "select photo from StudentRecord2 where id='cccc'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        img = (byte[])reader[0];

                    }
                    MemoryStream ms = new MemoryStream(img);
                   // pictureBox1.Image = Image.FromStream(ms);
                    //Bitmap bmp = (Bitmap)ms;
                    //Image image = bmp;
                    //e.Graphics.DrawImage(image, 24, 34, image.Width, image.Height);
                    conn.Close();

                    // MessageBox.Show("Data is inserted in Database", "Informaion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ob)
            {
              MessageBox.Show(ob.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void studentcardprint_Load(object sender, EventArgs e)
        {
            yearr();
            dateTimePicker1.Visible = false;
            labelexpires.Text = dateTimePicker1.Text;
            labelissuecard.Text = dateTimePicker1.Text;
        }

       


       
        public void yearr()
        {
            try
            {
                 card = dateTimePicker1.Text;
                //21/10/2020
                Char[] array = card.ToCharArray();
                card = array[9] + "";
                int num = Convert.ToInt32(card);
                num++;
                card = "";
                for (int i = 0; i <= 8; i++)
                { card = card + array[i]; }
                card = card + num;
                labelexpires.Text = card;
            }
            catch (Exception ee) {
              //  MessageBox.Show(ee.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPRINT_Click(object sender, EventArgs e)
        {
            DVprintDocument.Print();
        }

       

       

        

    }
    }

