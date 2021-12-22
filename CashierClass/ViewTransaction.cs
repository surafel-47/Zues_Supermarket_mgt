using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CashierClass
{
    public partial class ViewTransaction : Form
    {
        SqlConnection sqlCon;
        DataTable dt;
        int ticketID;
        public ViewTransaction(int tid)
        {
            InitializeComponent();
            makeConnection(); //Make Connection
            ticketID = tid;//Passing Ticket ID Value
            loadTransactionTbl();// Loading the Table
        }
        public void makeConnection()//++++++++++++++++++++++++++++++++++++++++++++Method to Make Connection with DataBase
        {
            try
            {
                sqlCon = new SqlConnection("Data Source=DESKTOP-8QIRQ1E; Initial Catalog=Shop; Integrated Security=True");
                sqlCon.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable To Make Connection \n " + e.Message + "\n\n Program Will Exit Now");
                Application.Exit();
            }
        }//---------------------------------------------------------------------------------------

        public void loadTransactionTbl()
        {
            try//++++++++++++ Loading The Products Bought on To The Table
            {
                SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewTicketDetails @TicketID", sqlCon);
                sqlCmd.Parameters.AddWithValue("@TicketID", ticketID);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                transactionDetailsTbl.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }//--------------------------------------------------------------------------------

            try//++++++++++++++++++++++++++++++++++++ Loading the Total Amount on to The Text Field
            {
                String query = String.Format("select Total from Ticket Where TicketID={0} ", ticketID);
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    totalT.Text = String.Format("{0:c}",reader["Total"].ToString());
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }//--------------------------------------------------------------------------------------------
         
        }

        private void ReturnB_Click(object sender, EventArgs e)// Return Button ACtion
        {
            this.Close();
        }//---------------------------------------------------------
    }
}
