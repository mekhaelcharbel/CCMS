using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using SudentManagementSystem;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Please provide a UserName ");
                return;
            }
            try
            { 

                this.Hide();

                Form loggedin = new Form1(txt_UserName.Text.ToString());
                //comment.ShowDialog();

                loggedin.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Login Failed!");
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
