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
    public partial class UpdateProductStock : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        DataTable dt;
        public UpdateProductStock()
        {
            InitializeComponent();
            makeConnection();// Making Connection
            LoadProductsTable();
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

        private void LoadProductsTable()//+++++++++++++++ Load Data onto Products Table
        {
            makeConnection();// Making Connection

            try
            {
                SqlCommand sqlCmd = new SqlCommand(" USP_ViewProductStock @searchInput",sqlCon);
                sqlCmd.Parameters.AddWithValue("@searchInput", searchT.Text);
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
            }
        }//-------------------------------------------------------

        private void NewStock_TextChanged(object sender, EventArgs e)//Enables update Button
        {
            if (!newStockT.Text.Equals("") && !idT.Text.Equals(""))
                updateB.Enabled = true;
            else
                updateB.Enabled = false;
        }//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        private void UpdateB_Click(object sender, EventArgs e)//+++ Calling Stored Proc To Update Price
        {
            makeConnection();// Making Connection
            int proID = int.Parse(idT.Text), newStock;
            try
            {
                newStock = int.Parse(newStockT.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input Value");
                return;
            }
            try
            {
                sqlCmd = new SqlCommand("Exec  USP_AddToSTOCK @ProID ,@Amount  ", sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProID", proID);
                sqlCmd.Parameters.AddWithValue("@Amount", newStock);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Product Stock Updated Succesfully");
                nameT.Text = ""; idT.Text = ""; searchT.Text = ""; updateB.Enabled = false; newStockT.Text = "";// clearing Text
                LoadProductsTable();// reloading Employees Table After Employee is Deleted
            }
            catch (Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }
        }//----------------------------------------------------------------------

        private void ReturnB_Click(object sender, EventArgs e)//Return to Admin Main Menu by Closeing This Form
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------
    }
}
