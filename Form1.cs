using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Configuration;
using System.Data.SqlClient;
namespace FinanceProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("hi");
            //TODO make a check that a trade is inserted before closing and adding it to the trades table/PnL chart
            SqlConnection sqlCon = null;
            //get database parameters from App.config file
            String strServer = ConfigurationManager.AppSettings["server"];
            String strDatabase = ConfigurationManager.AppSettings["database"];
            String strLogin = ConfigurationManager.AppSettings["login"];
            String strPassword = ConfigurationManager.AppSettings["password"];

            String strConnect = $"Server={strServer};Database={strDatabase};User Id={strLogin};Password={strPassword};";
            sqlCon = new SqlConnection(strConnect);
            sqlCon.Open();
            //get values


            //set up call to stored procedure
            SqlCommand sqlCmd = new SqlCommand("get_available_tickers", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "table1");
         
            foreach (DataTable table in dataset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                   
                        comboBox1.Items.Add(item.ToString());
                    }
                }
            }

        }

        private void InsertNewTradesButton_Click(object sender, EventArgs e)
        {
            TradeForm tradeForm = new TradeForm();
            tradeForm.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Actually do something/get selected value
            string value = comboBox1.SelectedItem.ToString();
            Console.WriteLine(value);
        }

        private void endDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TransactionsStartDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
