using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using ClosedXML.Excel;
using System;
using System.Threading;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;
using Timer = System.Windows.Forms.Timer;
using DocumentFormat.OpenXml.Spreadsheet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SudentManagementSystem
{
    public partial class Form1 : Form
    {
        #region "Declare" 
        SqlConnection DBconnection = new SqlConnection("Data Source =\\sanitajde");
        static DataTable table = new DataTable();
        static DataTable tableschedule = new DataTable();
        protected DataGridViewRow row;
        private DataTable filterschedule = new DataTable();
        private DataGridViewRow filterschedulerow;

        public string combinedString { get; set; }

        public string phone { get; set; }

        public string email { get; set; }
        public string freeremark { get; set; }
        public string Contact { get; set; }
        public DataGridView gridView { get; set; }


        protected static string CustomerNumber = "";
        int row_removed;
        protected static string _user = "";
        protected static string CustomerChannel = "";
        protected static string docco = "";
        protected static string kcoo = "";
        protected static string dcto = "";
        protected static string CustomerName = "";
        protected static string CustomerNametosend = "";
        protected string phonenumber = "";
        protected static string datetosend = "";
        protected static string amount = "";
        protected int customercount;
        protected static string date = "";
        int count = 0;
        protected string Salesmanname;
        protected static string dateschedule = "";
        protected static int row_index;
        protected static int return_row_index;
        protected static string datecalled = "";
        public static string returnedremark = "";
        public static string returnedfreeremark = "";
        public static string returnedphone = "";
        public static string returnedcontact = "";
        public static string returnedemail = "";
        public static string SalesmanNameGlobal { get; set; } = "";
        #endregion

        public Form1(string User)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _user = User;


            DisplayData();
        }
        public void DisplayData()
        {
            try
            {
                DBconnection.Open();
                SqlCommand count = new SqlCommand("select COUNT (*) from [PRODDTA].[F55CCMS] where CCAC07=" + _user + "", DBconnection);
                customercount = (int)count.ExecuteScalar();
                _customercount.Text = customercount.ToString();


                SqlCommand cmd = new SqlCommand("SELECT * FROM [JDE_Production].[PRODDTA].[F55CCMS] where CCAC07=" + _user + "", DBconnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);


                if (!table.Columns.Contains("Select"))
                {
                    table.Columns.Add("Select", System.Type.GetType("System.Boolean"));
                    table.Columns.Add("Customercode", typeof(string));
                    table.Columns.Add("CustomerName", typeof(string));
                    table.Columns.Add("CalledDate", typeof(string));
                    table.Columns.Add("Schedule Date", typeof(string));
                    table.Columns.Add("Remark", typeof(string));
                    table.Columns.Add("PhoneNumber", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Contact Person", typeof(string));
                    table.Columns.Add("Address", typeof(string));
                    table.Columns.Add("Address1", typeof(string));
                    table.Columns.Add("Amount", typeof(string));
                    table.Columns.Add("Businessunit", typeof(string));
                    table.Columns.Add("Invoice Date", typeof(string));
                    table.Columns.Add("Order Number", typeof(string));
                    table.Columns.Add("Order Type", typeof(string));
                    table.Columns.Add("Selling Company", typeof(string));
                    table.Columns.Add("Channel", typeof(string));
                    table.Columns.Add("CallCycle", typeof(string));
                }
                SqlDataReader sdrr = cmd.ExecuteReader();

                while (sdrr.Read())
                {

                    DataRow rw = table.NewRow();
                    rw[0] = false;
                    rw[1] = sdrr["CCAN8"].ToString().TrimEnd();
                    rw[2] = sdrr["CCALPH"].ToString().TrimEnd();
                    rw[3] = sdrr["CCDESC01"].ToString().TrimEnd();
                    rw[4] = sdrr["CCDESC"].ToString().TrimEnd();
                    rw[5] = sdrr["CCDESC02"].ToString().TrimEnd();
                    rw[6] = sdrr["CCPH1"].ToString().TrimEnd();
                    rw[7] = sdrr["CCDESC03"].ToString().TrimEnd();
                    rw[8] = sdrr["CCDESC04"].ToString().TrimEnd();
                    rw[9] = sdrr["CCADD2"].ToString().TrimEnd();
                    rw[10] = sdrr["CCADD3"].ToString().TrimEnd();
                    rw[11] = Convert.ToDouble(sdrr["CCAA1"]) / 100;
                    rw[12] = sdrr["CCMCU"].ToString().TrimEnd();
                    rw[13] = getDate(sdrr["CCDRQJ"].ToString()).TrimEnd();
                    rw[14] = sdrr["CCDOCO"].ToString().TrimEnd();
                    rw[15] = sdrr["CCDCTO"].ToString().TrimEnd();
                    rw[16] = sdrr["CCKCOO"].ToString().TrimEnd();
                    rw[17] = sdrr["CCDESC5"].ToString().TrimEnd();
                    rw[18] = sdrr["CCDESC6"].ToString().TrimEnd();
                    table.Rows.Add(rw);
                    Salesmanname = sdrr["CCALPH1"].ToString();
                }
                sdrr.Close();
                dataGridView1.DataSource = table;
                SalesmanNameGlobal = Salesmanname.TrimEnd();
                salesman.Text = Salesmanname;
                
                DBconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
         
        public  void updatemygrid(int rtindex, string remark, string phone, string email, string contactperson, string freeremarktxt)
        {
            try
            {
                return_row_index = rtindex;
                returnedremark = remark;
                returnedfreeremark = freeremarktxt;
                returnedphone = phone;
                returnedemail = email;
                returnedcontact = contactperson;
                dataGridView1.Rows[return_row_index].Cells[5].Value = returnedremark;

                if (returnedphone != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[6].Value = returnedphone;
                }
                if (returnedemail != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[7].Value = returnedemail;
                }
                if (returnedcontact != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[8].Value = returnedcontact;
                }
                if (returnedfreeremark == "")
                {
                    dataGridView1.Rows[return_row_index].Cells[5].Value = returnedfreeremark;
                }
            }
            catch (Exception)
            {
            }
        }
        public string getDate(string julianDate)
        {

            int jDate = Convert.ToInt32(julianDate);
            int day = jDate % 1000;
            int year = jDate / 1000;
            year = year - 100 + 2000;

            var date1 = new DateTime(year, 1, 1);
            var result = date1.AddDays(day - 1).ToString("MM/dd/yyyy"); ;
            return result;

        }
        private void ApplyFilters()
        {
            try
            {
                string filter = $"Customercode LIKE '%{Customercode.Text}%' AND " +
                                $"CustomerName LIKE '%{customername.Text}%' AND " +
                                $"PhoneNumber LIKE '%{Mobile.Text}%' AND " +
                                $"CallCycle LIKE '%{callcycle.Text}%'";

                DataView dv = table.DefaultView;
                dv.RowFilter = filter;
                dataGridView1.DataSource = dv;
            }
            catch { }
        } 
        private void CustomerName_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void Mobile_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void callcycle_TextChanged(object sender, EventArgs e) => ApplyFilters();
        private void CustomerCode_TextChanged(object sender, EventArgs e) => ApplyFilters();

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row_index = e.RowIndex;

                if (e.RowIndex >= 0)
                {
                    row = dataGridView1.Rows[e.RowIndex];
                    CustomerNumber = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().TrimEnd();
                    CustomerNametosend = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().TrimEnd();
                    phonenumber = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString().TrimEnd();
                    amount = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString().TrimEnd();
                    datetosend = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString().TrimEnd();
                    docco = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString().TrimEnd();
                    dcto = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString().TrimEnd();
                    kcoo = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString().TrimEnd();
                    CustomerChannel = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString().TrimEnd();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int counter;
                DBconnection.Open();
                SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC=@schedule where CCAN8=@CustomerNumber", DBconnection);

                SqlCommand count = new SqlCommand("select COUNT (*) from [PRODDTA].[F55CCMSH]", DBconnection);
                counter = (int)count.ExecuteScalar() + 1;
                SqlCommand insert = new SqlCommand("INSERT INTO[PRODDTA].[F55CCMSH]([CHUKID],[CHAN8]  ,[CHDESC02],[CHDESC03],[CHDESC5])  VALUES  ('" + counter + "','" + CustomerNumber + "','" + date.ToString() + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + _user + "')", DBconnection);

                if (date == null)
                {
                    MessageBox.Show("Please pick a Schedule Date ");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@schedule", date.ToString());

                }
                if (CustomerNumber == null)
                {
                    MessageBox.Show("Please Select a customer ");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CustomerNumber", CustomerNumber);
                }
                insert.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                dataGridView1.Rows[row_index].Cells[4].Value = date;
            }
            catch (Exception)
            {
            }
            finally
            {
                DBconnection.Close();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerNumber == null)
                {
                    MessageBox.Show("Please Select a customer");
                }
                else
                {
                    DBconnection.Open();
                    int counter;
                    SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC01='" + DateTime.Now.ToString() + "' where CCAN8=@CustomerNumber", DBconnection);
                    SqlCommand count = new SqlCommand("select COUNT (*) from [PRODDTA].[F55CCMSH]", DBconnection);
                    counter = (int)count.ExecuteScalar() + 1;
                    SqlCommand insert = new SqlCommand("INSERT INTO[PRODDTA].[F55CCMSH]([CHUKID],[CHAN8]  ,[CHDESC],[CHDESC03] )  VALUES  ('" + counter + "','" + CustomerNumber + "','" + DateTime.Now.ToString() + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "')", DBconnection);


                    if (phonenumber == "")
                    {

                        MessageBox.Show("Choose a customer with PhoneNumber");
                    }
                    else
                    {
                        var startInfo = new ProcessStartInfo("CISCOTELCONF:" + phonenumber + " ")
                        {
                            UseShellExecute = true
                        };

                        Process.Start(startInfo);
                        Thread.Sleep(1000);

                    }
                    Thread.Sleep(10000);
                    dataGridView1.Rows[row_index].Cells[3].Value = DateTime.Now.ToString();
                    dataGridView1.Refresh();
                    if (CustomerNumber == null)
                    {
                        MessageBox.Show("Please Select a customer ");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@CustomerNumber", CustomerNumber);
                    }
                    insert.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBconnection.Close();
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Create a fresh DataTable
                tableschedule = new DataTable();

                // Define columns
                tableschedule.Columns.Add("Select", typeof(bool));
                tableschedule.Columns.Add("Customercode", typeof(string));
                tableschedule.Columns.Add("CustomerName", typeof(string));
                tableschedule.Columns.Add("CalledDate", typeof(string));
                tableschedule.Columns.Add("Schedule Date", typeof(string));
                tableschedule.Columns.Add("Remark", typeof(string));
                tableschedule.Columns.Add("PhoneNumber", typeof(string));
                tableschedule.Columns.Add("Email", typeof(string));
                tableschedule.Columns.Add("Contact Person", typeof(string));
                tableschedule.Columns.Add("Address", typeof(string));
                tableschedule.Columns.Add("Address1", typeof(string));
                tableschedule.Columns.Add("Amount", typeof(string));
                tableschedule.Columns.Add("Businessunit", typeof(string));
                tableschedule.Columns.Add("Invoice Date", typeof(string));
                tableschedule.Columns.Add("Order Number", typeof(string));
                tableschedule.Columns.Add("Order Type", typeof(string));
                tableschedule.Columns.Add("Selling Company", typeof(string));
                tableschedule.Columns.Add("Channel", typeof(string));
                tableschedule.Columns.Add("CallCycle", typeof(string));

                // Format the date to match DB (adjust format if needed)
                string dateschedule = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                // Open connection
                DBconnection.Open();

                // Parameterized query with trimming to remove extra spaces
                string query = @"
            SELECT * FROM [JDE_Production].[PRODDTA].[F55CCMS]
            WHERE LTRIM(RTRIM([CCDESC])) = @date
        ";
                SqlCommand cmd = new SqlCommand(query, DBconnection);
                cmd.Parameters.AddWithValue("@date", dateschedule);

                SqlDataReader sdrr = cmd.ExecuteReader();

                // Fill DataTable
                while (sdrr.Read())
                {
                    DataRow rw1 = tableschedule.NewRow();
                    rw1[0] = false;
                    rw1[1] = sdrr["CCAN8"].ToString().Trim();
                    rw1[2] = sdrr["CCALPH"].ToString().Trim();
                    rw1[3] = sdrr["CCDESC01"].ToString().Trim();
                    rw1[4] = sdrr["CCDESC"].ToString().Trim();
                    rw1[5] = sdrr["CCDESC02"].ToString().Trim();
                    rw1[6] = sdrr["CCPH1"].ToString().Trim();
                    rw1[7] = sdrr["CCDESC03"].ToString().Trim();
                    rw1[8] = sdrr["CCDESC04"].ToString().Trim();
                    rw1[9] = sdrr["CCADD2"].ToString().Trim();
                    rw1[10] = sdrr["CCADD3"].ToString().Trim();
                    rw1[11] = Convert.ToDouble(sdrr["CCAA1"]) / 100;
                    rw1[12] = sdrr["CCMCU"].ToString().Trim();
                    rw1[13] = getDate(sdrr["CCDRQJ"].ToString()).Trim();
                    rw1[14] = sdrr["CCDOCO"].ToString().Trim();
                    rw1[15] = sdrr["CCDCTO"].ToString().Trim();
                    rw1[16] = sdrr["CCKCOO"].ToString().Trim();
                    rw1[17] = sdrr["CCDESC5"].ToString().Trim();
                    rw1[18] = sdrr["CCDESC6"].ToString().Trim();
                    tableschedule.Rows.Add(rw1);
                }

                sdrr.Close();

                // Bind to DataGridView
                dataGridView1.DataSource = tableschedule;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBconnection.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Form orderForm = new OrderForm(CustomerNumber, CustomerNametosend);

                orderForm.WindowState = FormWindowState.Maximized;
                orderForm.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please Select a customer");
                    return;
                }

                int index = dataGridView1.CurrentRow.Index;

                // Get values directly from the selected row
                CustomerNumber = dataGridView1.Rows[index].Cells[1].Value.ToString().Trim();
                CustomerNametosend = dataGridView1.Rows[index].Cells[2].Value.ToString().Trim();
                combinedString = dataGridView1.Rows[index].Cells[5].Value.ToString();
                phone = dataGridView1.Rows[index].Cells[6].Value.ToString();
                email = dataGridView1.Rows[index].Cells[7].Value.ToString();
                Contact = dataGridView1.Rows[index].Cells[8].Value.ToString();
                freeremark = dataGridView1.Rows[index].Cells[5].Value.ToString();
                gridView = dataGridView1;

                Form comment = new Commentform(CustomerNumber, index);
                comment.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Please Select a customer");
                    return;
                }

                int index = dataGridView1.CurrentRow.Index;
                CustomerNumber = dataGridView1.Rows[index].Cells[1].Value.ToString().Trim();

                Form history = new history(CustomerNumber);
                history.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var column = dataGridView1.Rows[e.ColumnIndex].Index;
            var rowCustomernumber = row.Cells[1].Value.ToString();
            if (column == 5)
            {
                var changedValueemail = row.Cells[e.ColumnIndex].Value.ToString();

                try
                {

                    DBconnection.Open();
                    SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC02=@remark where CCAN8=@CustomerNumber", DBconnection);

                    cmd.Parameters.AddWithValue("@remark", changedValueemail);
                    cmd.Parameters.AddWithValue("@CustomerNumber", rowCustomernumber);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                }
                finally
                {
                    DBconnection.Close();
                }
            }
            if (column == 6)
            {
                var changedValueemail = row.Cells[e.ColumnIndex].Value.ToString();

                try
                {

                    DBconnection.Open();
                    SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCPH1=@PhoneNumber where CCAN8=@CustomerNumber", DBconnection);

                    cmd.Parameters.AddWithValue("@PhoneNumber", changedValueemail);
                    cmd.Parameters.AddWithValue("@CustomerNumber", rowCustomernumber);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                }
                finally
                {
                    DBconnection.Close();
                }
            }
            if (column == 7)
            {
                var changedValueemail = row.Cells[e.ColumnIndex].Value.ToString();
                try
                {

                    DBconnection.Open();
                    SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC03=@Email where CCAN8=@CustomerNumber", DBconnection);

                    cmd.Parameters.AddWithValue("@Email", changedValueemail);
                    cmd.Parameters.AddWithValue("@CustomerNumber", rowCustomernumber);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                }
                finally
                {
                    DBconnection.Close();
                }

            }

            if (column == 8)
            {
                var changedValueemail = row.Cells[e.ColumnIndex].Value.ToString();

                try
                {

                    DBconnection.Open();
                    SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC04=@contact where CCAN8=@CustomerNumber", DBconnection);

                    cmd.Parameters.AddWithValue("@contact", changedValueemail);
                    cmd.Parameters.AddWithValue("@CustomerNumber", rowCustomernumber);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception)
                {
                }
                finally
                {
                    DBconnection.Close();
                }
            }


        }

        private void UpdateCell(string columnName, string customerNumber, string value)
        {
            try
            {
                DBconnection.Open();
                SqlCommand cmd = new SqlCommand(
                    $"UPDATE [PRODDTA].[F55CCMS] SET {columnName}=@value WHERE CCAN8=@customer", DBconnection);
                cmd.Parameters.AddWithValue("@value", value ?? "");
                cmd.Parameters.AddWithValue("@customer", customerNumber);
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally { DBconnection.Close(); }
        }

        private void export_grid_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application excl = new Microsoft.Office.Interop.Excel.Application();
                    excl.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView1.Columns.Count; i++)
                    {
                        excl.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            excl.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excl.Columns.AutoFit();
                    excl.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please Login with Valid User");
                }
            }
            catch (Exception)
            {
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Form CustomerPicker = new CustomerPicker();
                CustomerPicker.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
        public  void refresh()
        {
            try
            {
                table.Rows.Clear();
                table.Clear();
                table = new DataTable();
                //DisplayData();
                if (returnedremark != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[5].Value = returnedremark;
                }
                if (returnedphone != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[6].Value = returnedphone;
                }
                if (returnedemail != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[7].Value = returnedemail;
                }
                if (returnedcontact != "")
                {
                    dataGridView1.Rows[return_row_index].Cells[8].Value = returnedcontact;
                }
                //MessageBox.Show(CustomerNumber + "Refreshed");
            }
            catch (Exception)
            {
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 7)
            {
                MessageBox.Show("Charbel");
            }
            if (count == 8)
            {
                MessageBox.Show("Mekhaêl");
            }
            if (count == 9)
            {
                MessageBox.Show("                 (:)");
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int counter;
                DBconnection.Open();

                SqlCommand count = new SqlCommand("select COUNT (*) from [PRODDTA].[F55CCMSH]", DBconnection);
                counter = (int)count.ExecuteScalar() + 1;
                SqlCommand insert = new SqlCommand("INSERT INTO[PRODDTA].[F55CCMSH]([CHUKID],[CHAN8]  ,[CHDESC01])  VALUES  ('" + counter + "','" + CustomerNumber + "','  Called By whatsapp at " + DateTime.Now.ToString("dd/MM/yyyy") + "')", DBconnection);

                SqlCommand addwtsp = new SqlCommand("update [PRODDTA].[F55CCMS] set [CCDESC01]='" + DateTime.Now.ToString() + " By whatsapp' where [CCAN8]=" + CustomerNumber + "", DBconnection);

                if (string.IsNullOrWhiteSpace(CustomerNumber))
                {
                    MessageBox.Show("Please Select a customer");
                    return;
                }

                insert.ExecuteNonQuery();
                addwtsp.ExecuteNonQuery();
                dataGridView1.Rows[row_index].Cells[3].Value = DateTime.Now.ToString() + " Called By Whatsapp";
            }
            catch (Exception)
            {
            }
            finally
            {
                DBconnection.Close();
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {


            try
            {
                filterschedule.Rows.Clear();
                filterschedule.Clear();
                filterschedule = new DataTable();
                DBconnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [JDE_Production].[PRODDTA].[F55CCMSH] where CHDESC02<>'' and CHDESC5=" + _user + "", DBconnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                filterschedule.Columns.Add("Customercode", typeof(string));
                filterschedule.Columns.Add("Schedule Date", typeof(string));
                filterschedule.Columns.Add("Remark", typeof(string));

                SqlDataReader sdrr = cmd.ExecuteReader();

                while (sdrr.Read())
                {

                    DataRow filterschedulerow = filterschedule.NewRow();
                    filterschedulerow[0] = sdrr["CHAN8"].ToString();
                    filterschedulerow[1] = sdrr["CHDESC02"].ToString();
                    filterschedulerow[2] = sdrr["CHDESC01"].ToString();
                    filterschedule.Rows.Add(filterschedulerow);

                }
                sdrr.Close();
                dataGridView1.DataSource = filterschedule;

            }
            catch (Exception)
            {
                MessageBox.Show("Hit Refresh");
            }
            finally
            {

                DBconnection.Close();
            }
        }
        private void Remark_TextChanged(object sender, EventArgs e)
        {
            DataView dv = table.DefaultView;
            dv.RowFilter = "Remark Like '%" + Remark.Text + "%'";
            dataGridView1.DataSource = dv;
        }
        private void RefreshGrid_Click(object sender, EventArgs e)
        {
            try
            {

                table.Rows.Clear();
                table.Clear();
                table = new DataTable();
                dataGridView1.DataSource = null;
                DisplayData();
                //MessageBox.Show("Refreshed");
            }
            catch (Exception)
            {
            }
        }
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row_removed = e.ColumnIndex;
        }
        private void Hide_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[row_removed].Visible = false;
            MessageBox.Show(" Column Removed");
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Call By whatsapp";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Edit Customer";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void RefreshGrid_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void RefreshGrid_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Refresh";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Customer History";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Schedules";
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";

        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Phone Call";
        }

        private void Hide_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Hide Column";
        }

        private void Hide_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void export_grid_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void export_grid_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Export Grid";
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "Potential Customer";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }
         
    }
}