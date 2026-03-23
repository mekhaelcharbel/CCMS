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
    public partial class Commentform : Form
    {
        SqlConnection DBconnection = new SqlConnection("Data Source =\\sanitajde");

        Form1 form = (Form1)Application.OpenForms["Form1"];
        protected static int _index;
        protected static string _CustomerNumber;
        public Commentform(string customernumber,int index)
        {
            InitializeComponent();
            _CustomerNumber = customernumber;
            _index=index;
            Phonenumbertxt.Text = form.phone.ToString();
          //  remarktxt.Text = form.combinedString.ToString();
            emailtxt.Text = form.email.ToString();
            Freeremarktxt.Text=form.freeremark.ToString();
            contactpersontxt.Text = form.Contact.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> checkedValues = new List<string>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    checkedValues.Add(item.ToString());
                }
                string combinedString = string.Join(",", checkedValues.ToArray());

                if (combinedString == "Blank") {
                    combinedString = "";
                }
                int counter;
                DBconnection.Open();
                SqlCommand cmd = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC02='" + combinedString + "' where CCAN8='" + _CustomerNumber + "'", DBconnection);

                SqlCommand count = new SqlCommand("select COUNT (*) from [PRODDTA].[F55CCMSH]", DBconnection);
                counter = (int)count.ExecuteScalar() + 1;

                SqlCommand insertremarkhis = new SqlCommand("INSERT INTO[PRODDTA].[F55CCMSH]([CHUKID],[CHAN8] ,[CHDESC03] ,[CHDESC01])  VALUES  ('" + counter + "','" + _CustomerNumber + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + combinedString + "')", DBconnection);


                SqlCommand insertphonenumber = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCPH1='" + Phonenumbertxt.Text.ToString() + "' where CCAN8='" + _CustomerNumber + "'", DBconnection);
                SqlCommand insertremark = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC02='" + combinedString + "' where CCAN8='" + _CustomerNumber + "'", DBconnection);
                SqlCommand insertemail = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC03='" + emailtxt.Text.ToString() + "' where CCAN8='" + _CustomerNumber + "'", DBconnection);
                SqlCommand insertcontact = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC04='" + contactpersontxt.Text.ToString() + "' where CCAN8='" + _CustomerNumber + "'", DBconnection);

                SqlCommand insertFreeRemark = new SqlCommand("Update [PRODDTA].[F55CCMS] set CCDESC02='" + Freeremarktxt.Text.ToString() + "' where CCAN8='" + _CustomerNumber + "'", DBconnection);


                SqlCommand insertFreeRemarkhis = new SqlCommand("Update  [PRODDTA].[F55CCMSH] set CHAN8='" + _CustomerNumber + "' , [CHDESC03]='" + DateTime.Now.ToString("yyyy/MM/dd") + "' , [CHDESC01]='" + Freeremarktxt.Text.ToString() + "' where CHUKID='" + counter + "'", DBconnection);


                //SqlCommand insertFreeRemarkhis = new SqlCommand("INSERT INTO [PRODDTA].[F55CCMSH]([CHUKID],[CHAN8] ,[CHDESC03] ,[CHDESC01])  VALUES  ('" + counter + "','" + _CustomerNumber + "','" + DateTime.Now.ToString("yyyy/MM/dd") + "','" + Freeremarktxt.Text.ToString() + "')", DBconnection);
                if (_CustomerNumber == null)
                {
                    MessageBox.Show("Please Select a customer ");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@CustomerNumber", _CustomerNumber);
                }

                cmd.ExecuteNonQuery();
                if (combinedString != "")
                {
                    insertremark.ExecuteNonQuery();
                    insertremarkhis.ExecuteNonQuery();
                }
                if (Phonenumbertxt.Text != "")
                {
                    insertphonenumber.ExecuteNonQuery();
                }
                if (contactpersontxt.Text != "")
                {
                    insertcontact.ExecuteNonQuery();
                }
                if (emailtxt.Text != "")
                {
                    insertemail.ExecuteNonQuery();
                }
                if (Freeremarktxt.Text != "")
                {
                    insertFreeRemark.ExecuteNonQuery();
                    insertFreeRemarkhis.ExecuteNonQuery();
                }
                DBconnection.Close();
                Form1 mainForm = (Form1)Application.OpenForms["Form1"];

                if (mainForm != null)
                {
                    mainForm.updatemygrid(
                        _index,
                        combinedString,
                        Phonenumbertxt.Text,
                        emailtxt.Text,
                        contactpersontxt.Text,
                        Freeremarktxt.Text
                    );
                }


                MessageBox.Show("Customer edited successfully");

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
