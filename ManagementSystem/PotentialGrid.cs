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
    public partial class PotentialGrid : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source =\\sanitajde");
        DataTable table = new DataTable();
        public PotentialGrid()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            DisplayData();
        }
        public void DisplayData()
        {
            try
            {

                DBconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [JDE_Production].[PRODDTA].[F55CCMSP]", DBconnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                table.Columns.Add("CustomerName", typeof(string));
                table.Columns.Add("PhoneNumber", typeof(string));
                table.Columns.Add("Email", typeof(string));
                table.Columns.Add("Address", typeof(string));
                table.Columns.Add("Call Cycle", typeof(string));
                table.Columns.Add("Remark", typeof(string));

                SqlDataReader sdrr = cmd.ExecuteReader();

                while (sdrr.Read())
                {

                    DataRow rw = table.NewRow();
                    rw[0] = sdrr["CCALPH"].ToString();
                    rw[1] = sdrr["CCDESC"].ToString();
                    rw[2] = sdrr["CCDESC01"].ToString();
                    rw[3] = sdrr["CCDESC02"].ToString();
                    rw[4] = sdrr["CCDESC03"].ToString();
                    rw[5] = sdrr["CCDESC04"].ToString();
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = ((TextBox)sender).Text.Replace("'", "''");

            if (string.IsNullOrEmpty(filterText))
            {
                table.DefaultView.RowFilter = "";
            }
            else
            {
                table.DefaultView.RowFilter = $"CustomerName LIKE '%{filterText}%'";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}