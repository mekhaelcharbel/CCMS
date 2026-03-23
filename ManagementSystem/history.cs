using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SudentManagementSystem
{
    public partial class history : Form
    {
        #region "Declare" 
        SqlConnection DBconnection = new SqlConnection("Data Source=\\sanitajde");
        DataTable table = new DataTable();
        string _CustomerNumber;
        #endregion

        public history(string customernumber)
        {
            InitializeComponent();

            // Full screen and light theme
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            _CustomerNumber = customernumber;
            customercodelbl.Text = _CustomerNumber;

            DisplayData();
        }

        private void DisplayData()
        {
            try
            {
                DBconnection.Open();
                SqlCommand cmd = new SqlCommand(
                    "SELECT CHAN8, CHDESC, CHDESC02, CHDESC01 FROM [JDE_Production].[PRODDTA].[F55CCMSH] WHERE CHAN8=@CustomerNumber",
                    DBconnection);
                cmd.Parameters.AddWithValue("@CustomerNumber", _CustomerNumber);

                SqlDataReader sdrr = cmd.ExecuteReader();

                table.Clear();
                table.Columns.Clear();
                table.Columns.Add("Customercode", typeof(string));
                table.Columns.Add("CalledDate", typeof(DateTime));
                table.Columns.Add("ScheduleDate", typeof(DateTime));
                table.Columns.Add("Remark", typeof(string));

                while (sdrr.Read())
                {
                    DataRow rw = table.NewRow();
                    rw["Customercode"] = sdrr["CHAN8"].ToString();

                    // Check for null before converting
                    string calledDateStr = sdrr["CHDESC"].ToString().Trim();

                    if (!string.IsNullOrEmpty(calledDateStr) && DateTime.TryParse(calledDateStr, out DateTime calledDate))
                        rw["CalledDate"] = calledDate;
                    else
                        rw["CalledDate"] = DBNull.Value;


                    string scheduleDateStr = sdrr["CHDESC02"].ToString().Trim();

                    if (!string.IsNullOrEmpty(scheduleDateStr) && DateTime.TryParse(scheduleDateStr, out DateTime scheduleDate))
                        rw["ScheduleDate"] = scheduleDate;
                    else
                        rw["ScheduleDate"] = DBNull.Value;

                    rw["Remark"] = sdrr["CHDESC01"] != DBNull.Value
                        ? sdrr["CHDESC01"].ToString()
                        : "";

                    table.Rows.Add(rw);
                }

                sdrr.Close();

                dataGridView1.DataSource = table;
                dataGridView1.AutoResizeColumns();
                DBconnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromdate = dateTimePicker1.Value.Date;
                DateTime todate = dateTimePicker2.Value.Date.AddDays(1);

                DBconnection.Open();
                SqlCommand cmd = new SqlCommand(
                @"
SELECT *
FROM
(
    SELECT 
        CHAN8,
        -- original CHDESC
        TRY_PARSE(LTRIM(RTRIM(CHDESC)) AS datetime USING 'en-US') AS CalledDate,
        TRY_PARSE(LTRIM(RTRIM(CHDESC02)) AS datetime USING 'en-US') AS ScheduleDate,
        CHDESC01 AS Remark,
        -- extract date from CHDESC01
        TRY_PARSE(RIGHT(LTRIM(RTRIM(CHDESC01)), 10) AS datetime USING 'en-GB') AS RemarkDate
    FROM [JDE_Production].[PRODDTA].[F55CCMSH]
    WHERE CHAN8 = @CustomerNumber
) AS ConvertedData
WHERE 
    -- filter: either CalledDate or RemarkDate is in range
    (
        (CalledDate IS NOT NULL AND CalledDate >= @FromDate AND CalledDate < @ToDate)
        OR
        (RemarkDate IS NOT NULL AND RemarkDate >= @FromDate AND RemarkDate < @ToDate)
    )
",
                DBconnection);

                cmd.Parameters.AddWithValue("@CustomerNumber", _CustomerNumber);
                cmd.Parameters.AddWithValue("@FromDate", fromdate);
                cmd.Parameters.AddWithValue("@ToDate", todate);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

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

        private void Export_grid_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            // File name = Customer Code
            sfd.FileName = _CustomerNumber + ".csv";
            sfd.Filter = "CSV file (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                // Headers
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                    sb.Append(col.HeaderText + ",");

                sb.AppendLine();

                // Rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                            sb.Append(cell.Value?.ToString() + ",");

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(sfd.FileName, sb.ToString());

                MessageBox.Show("Exported Successfully!");
            }
        }



    }
}
