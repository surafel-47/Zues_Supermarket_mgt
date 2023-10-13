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
using WindowsFormsApp1;
using WindowsFormsApp1.CashierClass;

namespace ShopMgtSys
{
    public partial class MakeTransaction : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        DataTable dt;
        int empID;
        public MakeTransaction(int eid)
        {
            InitializeComponent();
            LoadIntoCatagoryComboBox();
            makeConnection();// Making Connection
            LoadProductsTable();
            empID = eid; //Holding The EmpID of The Logged in Employee
        }

        // Loads List of Available Catagorys to Catagory ComboBox
        private void LoadIntoCatagoryComboBox()
        {
            String[] itemsCatagory = {"All", "Foods & Snacks", "Canned Goods", "Beverages and Drinks",
                                    "Cleaning Products ","Home Appliances","Dairy & Groceries","Hygiene Products",
                                    "Stationary Products","Others"};
            catagoryCB.Items.AddRange(itemsCatagory);
            catagoryCB.Text = "All";
        }//---------------------------------------------------


        //Loading table to select products from
        private void LoadProductsTable()
        {
            makeConnection();// Making Connection
             try
              {
                  SqlCommand sqlCmd = new SqlCommand("Exec USP_ViewProductDetailsWithStock @searchInput,@catagory",sqlCon);
                sqlCmd.Parameters.AddWithValue("@searchInput",searchT.Text);
                sqlCmd.Parameters.AddWithValue("@catagory", catagoryCB.SelectedItem.ToString());
                 SqlDataReader reader = sqlCmd.ExecuteReader();
                  dt = new DataTable();
                  dt.Load(reader);
                  productsTbl.DataSource = dt;
              }catch(Exception e){
                    MessageBox.Show(e.Message);
              }           
        }//----------------------------------------------------

        private void SearchT_TextChanged(object sender, EventArgs e)// Loads Table When Users Searches an Item
        {
            LoadProductsTable();
        }//----------------------------------------------------------

        private void CatagoryCB_SelectedIndexChanged(object sender, EventArgs e)// Loads Table When Users Select's A catagory
        {
            LoadProductsTable();
        }//---------------------------------------------------------------------

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

        private void ProductsTbl_CellClick(object sender, DataGridViewCellEventArgs e)//Loads Selected Item onto Tickets Table
        {
            String proID, Name, uprice;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productsTbl.Rows[e.RowIndex];
                proID = row.Cells[0].Value.ToString();
                Name = row.Cells[1].Value.ToString();
                uprice = row.Cells[2].Value.ToString();

                for(int i=0; i< selectedProdsTbl.Rows.Count;i++)
                {
                    if (selectedProdsTbl.Rows[i].Cells[0].Value.ToString().Equals(proID)){
                        MessageBox.Show("Item Already Selected");
                        return;
                    }
                }
                selectedProdsTbl.Rows.Add(proID, Name, uprice, "1");
            }
            transactB.Enabled = true;//Enabling the Make Transactions Button
        }//---------------------------------------------------------------------------------------

        private void RemoveB_Click(object sender, EventArgs e)// removes selected Item from list of Products Selected
        {
            try{
                int rowIndex = selectedProdsTbl.CurrentCell.RowIndex;
                if (rowIndex >= 0)
                    selectedProdsTbl.Rows.RemoveAt(rowIndex);
            }
            catch (NullReferenceException) { }
    
        }//----------------------------------------------------

        private void ClearB_Click(object sender, EventArgs e)// Clears Entire Selected Items List in Table
        {
            selectedProdsTbl.Rows.Clear();
            transactB.Enabled = false;//Disabling the Make Transactions Button

        }//---------------------------------------------------------------

        private void TransactB_Click(object sender, EventArgs e)// Call Stored Proc For Each Product Selected and Makes Transaction
        {
            makeConnection();
            int ticketID=-1;
            try //In This Try Catch Block, Last Ticket Number is being retrived and Incremented by One for the Next Ticket We r Inserting 
            {
                sqlCmd = new SqlCommand("Exec USP_GetNextTicketID", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["TicketID"].ToString().Equals(null) || reader["TicketID"].ToString().Equals(""))
                        ticketID = 1;
                    else
                        ticketID = int.Parse(reader["TicketID"].ToString());
                }
                reader.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show("Operation Failed \n\n"+err.Message);
                return;
            }//--------------------------------------------------------------------------------------------------------------------------

            //In the For Loop Below, code  Inserting Each Product and Quantity is Transactions_details table is being done
            for (int i = 0; i < selectedProdsTbl.Rows.Count; i++)
            {
                String proID = selectedProdsTbl.Rows[i].Cells[0].Value.ToString();
                String qty = selectedProdsTbl.Rows[i].Cells[3].Value.ToString();
                sqlCmd = new SqlCommand("Exec USP_Transaction @ProID, @Qty, @TicketID ", sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProID", int.Parse(proID));
                sqlCmd.Parameters.AddWithValue("@Qty", int.Parse(qty));
                sqlCmd.Parameters.AddWithValue("@TicketID", ticketID);
                try
                {
                    sqlCmd.ExecuteNonQuery();
                   
                }
                catch(Exception err)
                {
                    MessageBox.Show("Operation Failed  \n\n"+err.Message);
                    return;
                }
            }
            //-------------------------------------------------------------------------------------------------------------------------

            //+++++++++++++++++++++++++++++++++++++++++++++++++++ Finally Calling Stored Proc To Insert Ticket into Tickets Table
            try
            {
                sqlCmd = new SqlCommand("Exec USP_Ticket @EmpID", sqlCon);//Calling Proc To Add Final Ticket/rececit and Employee Who Approved the Transaction
                sqlCmd.Parameters.AddWithValue("@EmpID", empID);
                sqlCmd.ExecuteNonQuery();
            }catch(Exception err)
            {
                MessageBox.Show("Operation Failed  \n\n" + err.Message);
                return;
            }//---------------------------------------------------------------------------------------------------------------------

            this.Hide();
            new ViewTransaction(ticketID).ShowDialog();
            selectedProdsTbl.Rows.Clear();//Clearing Prievious selected product list
            this.Show();
           
        }//-----------------------------------------------------------------------------

        private void LogOffB_Click(object sender, EventArgs e)//Login Out Cashier
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }//--------------------------------------------------------------------------
    }
}
