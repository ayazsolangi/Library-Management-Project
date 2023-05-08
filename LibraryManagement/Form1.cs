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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            
            if (textBoxusername.Text == "admin" && textBoxpassword.Text == "password")
            {

                this.Hide();
                Dashboard obj = new Dashboard();
                obj.Show();


            }
            else {
                textBoxusername.Focus();
                MessageBox.Show("Incorrect Username Or Password, Try Again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
