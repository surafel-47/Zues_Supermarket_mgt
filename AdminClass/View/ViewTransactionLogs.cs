using ShopMgtSys;
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

namespace WindowsFormsApp1.AdminClass
{
    public partial class ViewTransactionLogs : Form
    {
        SqlConnection sqlCon;
        DataTable dt;
        public ViewTransactionLogs()
        {
            InitializeComponent();
            makeConnection();//Making Connection
            LoadTrasactionLogs();
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

        private void LoadTrasactionLogs()//loading all transactions made onto top table
        {
            makeConnection();// Making Connection
            try
            {
                SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewTicketsTable", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                transactionsLogTbl.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }//+--------------------------------------------------------------------

        private void ReturnB_Click(object sender, EventArgs e)// return to Main Admin Menu
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//-----------------------------------------------------------------------------

        private void TransactionsLogTbl_CellClick(object sender, DataGridViewCellEventArgs e)// loads ticket details of a selected table
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = transactionsLogTbl.Rows[e.RowIndex];
                selectTicketT.Text = row.Cells["TicketID"].Value.ToString();

                transactionDetailsTbl.Visible = true; // making Details Table Visble
                makeConnection();// Making Connection
                int ticketId = int.Parse(selectTicketT.Text);

                try
                {
                    SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewTicketDetails @TicketID", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@TicketID", ticketId);
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(reader);
                    transactionDetailsTbl.DataSource = dt;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Operation Failed \n" + err.Message);
                }
            }
        }//-------------------------------------------------------------------------
    }
}
