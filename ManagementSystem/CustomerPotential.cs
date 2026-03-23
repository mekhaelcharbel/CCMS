using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudentManagementSystem
{
    public partial class CustomerPotential : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source =\\sanitajde");
        DataTable table = new DataTable();
        public CustomerPotential()
        {
            InitializeComponent();
        }

        private void _addCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DBconnection.Open();
                int counter;
                SqlCommand count = new SqlCommand("select COUNT (*) from [PRODDTA].[F55CCMSP]", DBconnection);
                counter = (int)count.ExecuteScalar() + 1;

                SqlCommand insert = new SqlCommand("INSERT INTO[PRODDTA].[F55CCMSP]([CCAN8]  ,[CCALPH],[CCDESC],[CCDESC01],[CCDESC02],[CCDESC03],[CCDESC04] )  VALUES  ('" + counter + "','" + customerNametxt.Text.ToString() + "','" + phonetxt.Text.ToString() + "','" + emailtxt.Text.ToString() + "','" + addtxt.Text.ToString() + "','" + channeltxt.Text.ToString() + "','" + rmktxt.Text.ToString() + "')", DBconnection);


                insert.ExecuteNonQuery();
                MessageBox.Show("Customer Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBconnection.Close();
                this.Close();
            }
        }
    }
}
