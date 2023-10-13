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
    public partial class ViewAllItems : Form
    {
        SqlConnection sqlCon;
        DataTable dt;
        public ViewAllItems()
        {
            InitializeComponent();
            makeConnection();//Making Connection
            LoadProductsTable();// loading all items on class start up
        }
        public void makeConnection()//+Method to Make Connection with DataBase
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

        private void LoadProductsTable() //Loads Products from database to DataGridViewTable 
        {
            makeConnection();// Making Connection
            try
            {
                SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewAllProducts @searchInput", sqlCon);
                sqlCmd.Parameters.AddWithValue("@searchInput", searchT.Text);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                ProdListTbl.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }//--------------------------------------------------------------------

        private void SearchT_TextChanged(object sender, EventArgs e)//Searches and Loads Products
        {
            LoadProductsTable();
        }//-----------------------------------------------------

        private void ReturnB_Click(object sender, EventArgs e)//Return to Admin Main Menu by Closeing This Form
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------
    }
}
