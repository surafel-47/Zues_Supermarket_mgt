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
    public partial class ViewAllEmps : Form
    {
        SqlConnection sqlCon;
        DataTable dt;
        public ViewAllEmps()
        {
            InitializeComponent();
            makeConnection();//Making Connection
            LoadEmployeesTable();
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
        }//------------------------------------------------------------------------------------

        private void LoadEmployeesTable()
        {
            makeConnection();// Making Connection

            try
            {
                SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewAllEmployees @searchInput",sqlCon);
                sqlCmd.Parameters.AddWithValue("@searchInput", searchT.Text);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                EmpListTbl.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SearchT_TextChanged(object sender, EventArgs e)//Searches and Loads Employees
        {
            LoadEmployeesTable();
        }//-----------------------------------------------------

        private void ReturnB_Click(object sender, EventArgs e)//Return to Admin Main Menu by Closeing This Form
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------

    }
}
