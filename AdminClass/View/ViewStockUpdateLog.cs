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

namespace WindowsFormsApp1.AdminClass.View
{
    public partial class ViewStockUpdateLog : Form
    {
        SqlConnection sqlCon;
        DataTable dt;
        public ViewStockUpdateLog()
        {
            makeConnection();
            InitializeComponent();
            LoadStockUpdateLogsTable();
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


        private void LoadStockUpdateLogsTable()
        {
            makeConnection();// Making Connection
            try
            {
                SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewStockUpdateLogs", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                stockUpdateLogTbl.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void ReturnB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }
    }
}
