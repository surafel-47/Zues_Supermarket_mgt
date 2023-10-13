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
    public partial class RemoveItem : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        DataTable dt;
        public RemoveItem()
        {
            InitializeComponent();
            makeConnection();// Making Connection
            LoadProductsTable();
        }

        public void makeConnection()//Method to Make Connection with DataBase
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

        private void LoadProductsTable()// Load Data onto Products Table
         {
            makeConnection();// Making Connection

            try
            {
                SqlCommand sqlCmd;
                if (searchT.Text.Equals(""))
                {
                     sqlCmd = new SqlCommand("Exec USP_ViewActiveProductsForRemovingNoSearch", sqlCon);
                }
                else
                {
                    sqlCmd = new SqlCommand("Exec USP_ViewActiveProductsForRemoving @searchInput", sqlCon);
                    sqlCmd.Parameters.AddWithValue("@searchInput", searchT.Text);
                }
             
                SqlDataReader reader = sqlCmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(reader);
                ProductsListTbl.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }//----------------------------------------------------------------------------------

        private void SearchT_TextChanged(object sender, EventArgs e) //Load Products Table By Input Search String
        {
            LoadProductsTable();
        }//--------------------------------------------------

        private void ProductsListTbl_CellClick(object sender, DataGridViewCellEventArgs e)// Displays Selected Product
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ProductsListTbl.Rows[e.RowIndex];
                nameT.Text = row.Cells["Product Name"].Value.ToString();
                idT.Text = row.Cells["ProID"].Value.ToString();
                removeB.Enabled = true;
            }
        }//-------------------------------------------------------

        private void ClearB_Click(object sender, EventArgs e)//Clear all Text Fields
        {
            nameT.Text = ""; idT.Text = ""; removeB.Enabled = false;
        }//------------------------------------------------

        private void RemoveB_Click(object sender, EventArgs e)// Removing Selected Employee Using Stored Proc
        {
            makeConnection();// Making Connection
            int proID = int.Parse(idT.Text);
            try
            {
                sqlCmd = new SqlCommand("Exec USP_RemoveProduct @ProID", sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProID", proID);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Product Removed Succesfully");
                nameT.Text = ""; idT.Text = ""; searchT.Text = ""; removeB.Enabled = false; // clearing Text
                LoadProductsTable(); //reloading Employees Table After Employee is Deleted
            }
            catch (Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }

        }//--------------------------------------------------------------

        private void ReturnB_Click(object sender, EventArgs e)//Return to Admin Main Menu by Closeing This Form
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------
    }
}
