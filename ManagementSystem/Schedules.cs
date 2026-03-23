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
  
    public partial class Schedules : Form
    {
        #region "Declare" 
        SqlConnection DBconnection = new SqlConnection("Data Source =\\sanitajde");
        DataTable table = new DataTable();
        DataTable tablefilter = new DataTable();
        protected static DataGridViewRow row; 
        #endregion
        public Schedules()
        {
            InitializeComponent();
            DisplayData();
        }
        public void DisplayData()
        {
            try
            {
                DBconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [JDE_Production].[PRODDTA].[F55CCMSH] where CHDESC02=<>`", DBconnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                table.Columns.Add("Customercode", typeof(string)); 
                table.Columns.Add("Schedule Date", typeof(string));
                table.Columns.Add("Remark", typeof(string));

                SqlDataReader sdrr = cmd.ExecuteReader();

                while (sdrr.Read())
                {

                    DataRow rw = table.NewRow();
                    rw[0] = sdrr["CHAN8"].ToString(); 
                    rw[2] = sdrr["CHDESC02"].ToString();
                    rw[3] = sdrr["CHDESC01"].ToString();
                    table.Rows.Add(rw);

                }
                sdrr.Close();
                dataGridView1.DataSource = table;
                DBconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
