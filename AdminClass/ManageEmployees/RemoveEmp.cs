using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShopMgtSys;

namespace ShopMgtSys
{

    public partial class RemoveEmp : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        DataTable dt;
        public RemoveEmp()
        {
            InitializeComponent();
            makeConnection();// Making Connection
            LoadEmployeesTable();
        }
        private void LoadEmployeesTable()
        {
            makeConnection();// Making Connection

            String sqlQuery; // String to Hold SQL Query;
            sqlQuery = String.Format( "select EmpID, Fname as 'First Name', Lname 'Last Name', Salary, Positon,sex FROM staff " +
                       "where (EmpStatus = 1) AND  (Fname like '%{0}%' OR Lname like '%{0}%' OR EmpID like '%{0}%')  ",searchT.Text);
            try{
                SqlCommand sqlCmd = new SqlCommand(sqlQuery);
                sqlCmd.Connection = sqlCon;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                EmpListTbl.DataSource = dt;
            }catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }
        private void SearchT_TextChanged(object sender, EventArgs e)// Loads Table When Users Searches an Employee Name or ID
        {
            LoadEmployeesTable();
        }//------------------------------------------------------------

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

        private void EmpListTbl_CellClick(object sender, DataGridViewCellEventArgs e)//Displays Selected Employee to Be Removed
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = EmpListTbl.Rows[e.RowIndex];
                nameT.Text = row.Cells["First Name"].Value.ToString() + " " + row.Cells["Last Name"].Value.ToString();
                idT.Text = row.Cells["EmpID"].Value.ToString();
                removeB.Enabled = true;
            }
        }

        private void ClearB_Click(object sender, EventArgs e)// Clear Button Action To Clear Selected
        {
            nameT.Text = ""; idT.Text = ""; searchT.Text=""; removeB.Enabled = false;
        }//--------------------------------------------------------------------

        private void RemoveB_Click(object sender, EventArgs e)// Removing Employee By Calling Stored Proc
        {
            makeConnection();// Making Connection
            int empid =int.Parse (idT.Text);
            try
            {
                sqlCmd = new SqlCommand("Exec USP_RemoveEmployee @EmpID", sqlCon);
                sqlCmd.Parameters.AddWithValue("@EmpID", empid);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Employee Removed Succesfully");
                nameT.Text = ""; idT.Text = ""; searchT.Text = ""; removeB.Enabled = false; // clearing Text
                LoadEmployeesTable();// reloading Employees Table After Employee is Deleted
            }
            catch (Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }
        }

        private void ReturnB_Click(object sender, EventArgs e)//Return to Admin Main Menu by Closeing This Form
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------
    }
}
