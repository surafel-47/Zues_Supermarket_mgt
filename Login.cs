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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        public Login()
        {
            InitializeComponent();
        }

        private void AdminLoginPanelB_Click(object sender, EventArgs e)// Displays Admin Panel
        {
            mainP.Controls.Add(adminP);
            adminP.Location = new System.Drawing.Point(0, 0);
            mainP.Controls.Remove(cashierP);
        }//---------------------------------------------------------------------------------

        private void CashierLoginPanelB_Click(object sender, EventArgs e)// Displays Cashier Login Panel
        {
            mainP.Controls.Add(cashierP);
            cashierP.Location = new System.Drawing.Point(0, 0);
            mainP.Controls.Remove(adminP);
        }//-------------------------------------------------------------------------------------

        private void AdminLoginB_Click(object sender, EventArgs e)// Admin login Button Action
        {
            if(adminNameT.Text.Equals("admin") && adminPassWordT.Text.Equals("admin"))
            {
                this.Hide();
                new AdminMainMenu().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Name or PassWord");
            }

        }//--------------------------------------------------------------

        private void CashierLoginB_Click(object sender, EventArgs e)//Cashier Login Button Action
        {
            makeConnection(); //Making Connection With DataBase
            String query = String.Format("Select EmpID from Staff Where EmpID={0} AND Positon='Cashier' AND EmpStatus = 1  ", empIdT.Text);
            sqlCmd = new SqlCommand(query,sqlCon);
            try
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    new MakeTransaction(int.Parse(empIdT.Text)).ShowDialog();// Passing EmpID of Logged In Cashier Employee
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Failed!! \n\nNote: Must be Cashier to Login In");
                }
            }
            catch (Exception){
                MessageBox.Show("Login Error has Occured");
            }
           
        }//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

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

        private void ExitB_Click(object sender, EventArgs e)//Exit Application
        {
            Application.Exit();
        }//-----------------------------------------------------

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
