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
using ShopMgtSys;

namespace ShopMgtSys
{
    public partial class AddNewItem : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        public AddNewItem()
        {
            InitializeComponent();
            LoadIntoCatagoryComboBox();
            try {
                sqlCon = new SqlConnection("Data Source=DESKTOP-8QIRQ1E; Initial Catalog=Shop; Integrated Security=True");
                sqlCon.Open();
            } catch (Exception e){
                MessageBox.Show("Unable To Make Connection \n " + e.Message + "\n\n Program Will Exit Now");
                Application.Exit();
            }
        }
        //++++++++++++++++++++++++++++++++++++ Loads List of Available Catagorys to Catagory ComboBox
        private void LoadIntoCatagoryComboBox()
        {
            String[] itemsCatagory = {"Foods & Snacks", "Canned Goods", "Beverages and Drinks",
                                    "Cleaning Products ","Home Appliances","Dairy & Groceries","Hygiene Products",
                                    "Stationary Products","Others"};
            catagoryCB.Items.AddRange(itemsCatagory);
            catagoryCB.Text = "Others";
        }//---------------------------------------------------

        //+++++++++++++++++++++++++++++++++++++++++++++++++ Adding New Item 
        private void AddB_Click(object sender, EventArgs e)
        {
            String name = nameT.Text, uprice = upriceT.Text, stock = stockT.Text, catagory=catagoryCB.SelectedItem.ToString();
            if (name.Equals("") || uprice.Equals("") || stock.Equals(""))
            {
                MessageBox.Show("Important Fields are Empty");
                return;
            }
            try
            {
                sqlCmd = new SqlCommand("Exec USP_AddProduct @Name, @Uprice,@Catagory,@Initial_Stock", sqlCon);
                sqlCmd.Parameters.AddWithValue("@Name", name);
                sqlCmd.Parameters.AddWithValue("@Uprice", double.Parse(uprice));
                sqlCmd.Parameters.AddWithValue("@Catagory", catagory);
                sqlCmd.Parameters.AddWithValue("@Initial_Stock", int.Parse(stock));
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Item Added Successfuly");
                ClearTextFields();
            }
            catch(Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }

        }
        //--------------------------------------------------

        
        public void ClearTextFields()//+++++++++++++++ Method That Clears All Text Fields
        {
            nameT.Text = ""; upriceT.Text = ""; stockT.Text = ""; catagoryCB.Text = "Others";
        }//--------------------------------------------------

        private void ClearB_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }

        private void ReturnB_Click(object sender, EventArgs e)//Return to Admin Main Menu by Closeing This Form
        {
            this.Hide();
            new AdminMainMenu().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------
    }
}
