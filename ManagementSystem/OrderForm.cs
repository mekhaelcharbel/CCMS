using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudentManagementSystem
{
    public partial class OrderForm : Form
    {
        #region "Declare" 
        SqlConnection DBconnection = new SqlConnection("Data Source =\\sanitajde"); 
        DataTable table = new DataTable();
        DataTable tabletop10 = new DataTable();
        DataTable tableSales = new DataTable();

        protected static string _customerNumber;
        protected static string _customerchannel;
        protected static string _customerName;
        protected static string _amount; 
        protected static string _kcoo;
        #endregion
        public OrderForm(string CustomerNumber, string CustomerName)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _customerNumber = CustomerNumber;
            _customerName = CustomerName;  
            _customercode.Text = CustomerNumber;
            DisplayData();
        }
        public void DisplayData()
        {
            try
            {
                DBconnection.Open(); 

                SqlCommand sold3monthsfamily = new SqlCommand(@"SELECT PRODDTA.F55CCMSL.CFDESC01 FROM PRODDTA.F55CCMSL
INNER JOIN PRODDTA.F55CCMS
ON PRODDTA.F55CCMSL.CFAC04= 'ALL'
WHERE PRODDTA.F55CCMS.CCAN8 =@CustomerNumber AND PRODDTA.F55CCMSL.CFSRP1  IN
(SELECT DISTINCT SDSRP1 FROM PRODDTA.F42119
WHERE PRODDTA.F42119.SDDCTO='SO' 
and PRODDTA.F42119.SDAN8=@CustomerNumber 
AND PRODDTA.F42119.SDDOCO 
in (SELECT TOP (3) SDDOCO FROM PRODDTA.F42119 WHERE PRODDTA.F42119.SDAN8=@CustomerNumber and PRODDTA.F42119.SDDCTO='SO' 
GROUP BY  SDDOCO,SDIVD 
ORDER BY SDIVD DESC))", DBconnection);

                sold3monthsfamily.Parameters.AddWithValue("@CustomerNumber", _customerNumber);
                 
                SqlCommand TOP10 = new SqlCommand("SELECT DISTINCT TOP (10) SDLITM, MAX(SDPQOR/10000) AS QTYEA\r\n ,SDDSC1 FROM PRODDTA.F42119\r\nwhere PRODDTA.F42119.SDAN8=" + _customerNumber + " and PRODDTA.F42119.SDDCTO='SO'\r\n and PRODDTA.F42119.SDIVD > 122000 GROUP BY SDLITM  ,SDDSC1\r\norder by QTYEA desc", DBconnection);

                SqlCommand unsoldcmd = new SqlCommand("SELECT PRODDTA.F55CCMSL.CFDESC01 FROM PRODDTA.F55CCMSL\r\nINNER JOIN PRODDTA.F55CCMS\r\nON PRODDTA.F55CCMSL.CFAC04= PRODDTA.F55CCMS.CCDESC5\r\nWHERE PRODDTA.F55CCMS.CCAN8 = '" + _customerNumber + "'\r\nAND PRODDTA.F55CCMSL.CFSRP1 NOT IN (\r\nSELECT DISTINCT SDSRP1 FROM PRODDTA.F42119 WHERE PRODDTA.F42119.SDDCTO='SO' and PRODDTA.F42119.SDAN8='" + _customerNumber + "' And PRODDTA.F42119.SDDOCO in (\r\nSELECT TOP (3) SDDOCO\r\nFROM PRODDTA.F42119\r\nWHERE PRODDTA.F42119.SDAN8='" + _customerNumber + "' and PRODDTA.F42119.SDDCTO='SO'\r\nGROUP BY  SDDOCO,SDIVD\r\nORDER BY SDIVD DESC\r\n)\r\n)\r\n", DBconnection);

                SqlCommand unsoldcmdAll = new SqlCommand("SELECT PRODDTA.F55CCMSL.CFDESC01 FROM PRODDTA.F55CCMSL\r\nINNER JOIN PRODDTA.F55CCMS\r\nON PRODDTA.F55CCMSL.CFAC04= 'ALL'\r\nWHERE PRODDTA.F55CCMS.CCAN8 = '" + _customerNumber + "'\r\nAND PRODDTA.F55CCMSL.CFSRP1 NOT IN (\r\nSELECT DISTINCT SDSRP1 FROM PRODDTA.F42119 WHERE PRODDTA.F42119.SDDCTO='SO' and PRODDTA.F42119.SDAN8='" + _customerNumber + "' AND PRODDTA.F42119.SDDOCO in (\r\nSELECT TOP (3) SDDOCO\r\nFROM PRODDTA.F42119\r\nWHERE PRODDTA.F42119.SDAN8='" + _customerNumber + "' and PRODDTA.F42119.SDDCTO='SO'\r\nGROUP BY  SDDOCO,SDIVD\r\nORDER BY SDIVD DESC\r\n)\r\n)\r\n", DBconnection);


                SqlCommand cmd = new SqlCommand(" SELECT SDDOCO, SDIVD ,SDLITM, SDDSC1, SDPQOR/10000 AS QTY, SDAEXP/100 AS AMTUSD\r\nFROM PRODDTA.F42119\r\nWHERE PRODDTA.F42119.SDDOCO IN (\r\n    SELECT TOP (3) SDDOCO\r\n    FROM PRODDTA.F42119\r\n\tWHERE PRODDTA.F42119.SDAN8=" + _customerNumber + " and PRODDTA.F42119.SDDCTO='SO'\r\n  and PRODDTA.F42119.SDIVD > 122000 GROUP BY  SDDOCO,SDIVD\r\n    ORDER BY SDIVD DESC\r\n ) And PRODDTA.F42119.SDAN8=" + _customerNumber + ";", DBconnection);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                table.Columns.Add("Invoice Date", typeof(string));
                table.Columns.Add("Order Number", typeof(string));
                table.Columns.Add("ItemNumber", typeof(string));
                table.Columns.Add("ItemDesc", typeof(string));
                table.Columns.Add("QtyEA", typeof(double));
                table.Columns.Add("Amount", typeof(double));
                SqlDataReader sdrr = cmd.ExecuteReader();
                while (sdrr.Read())
                {
                    DataRow rw = table.NewRow();
                    rw[0] = getDate(sdrr["SDIVD"].ToString());
                    rw[1] = sdrr["SDDOCO"].ToString();
                    rw[2] = sdrr["SDLITM"].ToString();
                    rw[3] = sdrr["SDDSC1"].ToString();
                    rw[4] = (double)sdrr["QTY"];
                    rw[5] = Convert.ToDouble(sdrr["AMTUSD"]);

                    table.Rows.Add(rw);
                    dataGridView1.DataSource = table;

                }
                sdrr.Close();
                SqlDataAdapter sdatop10 = new SqlDataAdapter(TOP10);
                tabletop10.Columns.Add("ItemNumber", typeof(string));
                tabletop10.Columns.Add("ItemDesc", typeof(string));
                tabletop10.Columns.Add("QtyEA", typeof(double));
                SqlDataReader sdrtop10 = TOP10.ExecuteReader();
                while (sdrtop10.Read())
                {
                    DataRow rw1 = tabletop10.NewRow();
                    rw1[0] = sdrtop10["SDLITM"].ToString();
                    rw1[1] = sdrtop10["SDDSC1"].ToString();
                    rw1[2] = (double)sdrtop10["QtyEA"];

                    tabletop10.Rows.Add(rw1);
                    dataGridView2.DataSource = tabletop10;

                }
                sdrtop10.Close();
                customerNamelbl.Text = _customerName.ToString().TrimEnd();
                _orderdate.Text = LoadLastInvoiceDate();

                string query = "SELECT CCDESC5 FROM [JDE_Production].[PRODDTA].[F55CCMS] WHERE CCAN8 = @CustomerNumber";

                using (SqlCommand cmdC = new SqlCommand(query, DBconnection))
                {
                    cmdC.Parameters.AddWithValue("@CustomerNumber",_customerNumber);

                    object result = cmdC.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        _customerchannel = result.ToString().TrimEnd();
                    }
                    else
                    {
                        _customerchannel = string.Empty; // or handle null as needed
                    } 
                }

                if (_customerchannel == "FNB" || _customerchannel == "PRF")
                {
                    SqlDataAdapter unsoldfamiliesadp = new SqlDataAdapter(unsoldcmd);
                    SqlDataReader unsoldfamiliesrdr = unsoldcmd.ExecuteReader();
                    while (unsoldfamiliesrdr.Read())
                    {
                        Unsoldfamilieslbl.Text = "  " + Unsoldfamilieslbl.Text.TrimEnd().TrimStart() + "  " + unsoldfamiliesrdr["CFDESC01"].ToString().TrimEnd().TrimStart();
                    }


                    unsoldfamiliesrdr.Close();
                }
                else
                {
                    SqlDataAdapter unsoldfamiliesalladp = new SqlDataAdapter(unsoldcmdAll);
                    SqlDataReader unsoldfamiliesallrdr = unsoldcmdAll.ExecuteReader();
                    while (unsoldfamiliesallrdr.Read())
                    {
                        Unsoldfamilieslbl.Text = "   " + Unsoldfamilieslbl.Text.TrimEnd() + "  " + unsoldfamiliesallrdr["CFDESC01"].ToString().TrimStart().TrimEnd();
                    }
                    unsoldfamiliesallrdr.Close();
                }



                SqlDataReader soldfamilies3months = sold3monthsfamily.ExecuteReader();

                last3months.Text = "";

                while (soldfamilies3months.Read())
                {
                    last3months.Text += " " + soldfamilies3months["CFDESC01"].ToString().TrimEnd().TrimStart();
                }
                soldfamilies3months.Close();
                LoadItemSales();
                DBconnection.Close();
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
        private string LoadLastInvoiceDate()
        {
            string sql = @"
        SELECT MAX(
            DATEADD(
                DAY,
                SDIVD % 1000 - 1,
                DATEFROMPARTS(2000 + (SDIVD / 1000 - 100), 1, 1)
            )
        )
        FROM PRODDTA.F42119
        WHERE SDAN8 = @CustomerNumber
          AND SDDCTO = 'SO'
    ";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, DBconnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerNumber", _customerNumber);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        DateTime lastDate = Convert.ToDateTime(result);
                        return lastDate.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        return "No Invoices";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading last invoice date: " + ex.Message);
                return "";
            }
        }


        void LoadItemSales()
        {
            DateTime today = DateTime.Today;

            DateTime firstDayLastMonth = new DateTime(today.Year, today.Month, 1).AddMonths(-1);
            DateTime firstDayThisMonth = new DateTime(today.Year, today.Month, 1);
            DateTime threeMonthsAgo = firstDayThisMonth.AddMonths(-3);

            tableSales.Clear();


            string sql = @"WITH SalesData AS
(
    SELECT 
        SDLITM,
        SDDOCO,
        DATEADD(
            DAY,
            SDIVD % 1000 - 1,
            DATEFROMPARTS(2000 + (SDIVD / 1000 - 100), 1, 1)
        ) AS OrderDate,
        SDPQOR / 10000.0 AS Qty,
        SDAEXP / 100.0 AS Amount
    FROM PRODDTA.F42119
    WHERE SDAN8 = @CustomerNumber
      AND SDDCTO = 'SO'
      AND SDIVD >= @ThreeMonthsAgo
),

-- Aggregate per Item + DOCO
DocItemAgg AS
(
    SELECT
        SDLITM,
        SDDOCO,
        OrderDate,
        SUM(Qty) AS Qty,
        SUM(Amount) AS Amount
    FROM SalesData
    GROUP BY SDLITM, SDDOCO, OrderDate
)

SELECT
    SDLITM AS ItemNumber,

    /* ---------- LAST MONTH ---------- */

    ROUND(SUM(CASE
        WHEN OrderDate >= @LastMonthStart
         AND OrderDate <  @ThisMonthStart
        THEN Qty ELSE 0 END), 2) AS LastMonthQty,

    ROUND(SUM(CASE
        WHEN OrderDate >= @LastMonthStart
         AND OrderDate <  @ThisMonthStart
        THEN Amount ELSE 0 END), 2) AS LastMonthAmount,

    ROUND(
        CASE
            WHEN SUM(CASE
                WHEN OrderDate >= @LastMonthStart
                 AND OrderDate <  @ThisMonthStart
                THEN Qty ELSE 0 END) = 0
            THEN 0
            ELSE
                SUM(CASE
                    WHEN OrderDate >= @LastMonthStart
                     AND OrderDate <  @ThisMonthStart
                    THEN Amount ELSE 0 END)
                /
                SUM(CASE
                    WHEN OrderDate >= @LastMonthStart
                     AND OrderDate <  @ThisMonthStart
                    THEN Qty ELSE 0 END)
        END
    , 2) AS LastMonthPricePerUnit,

    /* ---------- 3 MONTHS ---------- */

    ROUND(SUM(Qty) / 3.0, 2) AS ThreeMonthAvgQty,
    ROUND(SUM(Amount) / 3.0, 2) AS ThreeMonthAvgAmount,

    ROUND(
        CASE
            WHEN SUM(Qty) = 0 THEN 0
            ELSE SUM(Amount) / SUM(Qty)
        END
    , 2) AS ThreeMonthAvgPricePerUnit

FROM DocItemAgg
GROUP BY SDLITM
ORDER BY SDLITM;
";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, DBconnection))
                {
                    cmd.Parameters.AddWithValue("@CustomerNumber", _customerNumber);
                    cmd.Parameters.AddWithValue("@ThreeMonthsAgo", threeMonthsAgo);
                    cmd.Parameters.AddWithValue("@LastMonthStart", firstDayLastMonth);
                    cmd.Parameters.AddWithValue("@ThisMonthStart", firstDayThisMonth);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tableSales);
                        dataGridView3.DataSource = tableSales;

                    }
                }

                dataGridView3.AutoGenerateColumns = true;
                dataGridView3.DataSource = tableSales;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales data: " + ex.Message);
            }
        }


        public string getDate(string julianDate)
        {

            int jDate = Convert.ToInt32(julianDate);
            int day = jDate % 1000;
            int year = jDate / 1000;
            year = year - 100;
            year = year + 2000;
            var date1 = new DateTime(year, 1, 1);
            var result = date1.AddDays(day - 1).ToString("MM/dd/yyyy"); ;
            return result;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customercode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Filter grid1
                DataView dv1 = table.DefaultView;
                dv1.RowFilter = $"ItemNumber LIKE '%{ItemNumber.Text}%'";
                dataGridView1.DataSource = dv1;

                // Filter grid3
                DataView dv3 = tableSales.DefaultView;
                dv3.RowFilter = $"ItemNumber LIKE '%{ItemNumber.Text}%'";
                dataGridView3.DataSource = dv3;
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = table.DefaultView;
                dv.RowFilter = "ItemDesc Like '%" + Itemdesc.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
