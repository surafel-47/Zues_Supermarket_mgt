using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ShopMgtSys;
using WindowsFormsApp1;
using WindowsFormsApp1.AdminClass;

namespace ShopMgtSys
{
    public partial class AdminMainMenu : Form
    {
        private bool mouseDown;    //Var to hold state of Mouse Pointer for Draging Panel
        private Point lastLocation; //var to Hold Last Cordainate Location of Mouse Pointer

        public AdminMainMenu()
        {
            InitializeComponent();
            mainP.Controls.Remove(pwChangeP);
            mainP.Controls.Remove(manageEmpsP);
            mainP.Controls.Remove(viewLogsP);
            mainP.Controls.Remove(manageProdP);
        }

        private void ProductB_Click(object sender, EventArgs e)//Displaying Manage Products Panel only By Removeing Others Panels From Parent Panel
        {
            mainP.Controls.Add(manageProdP);
            manageProdP.Location = new System.Drawing.Point(0, 0);
            mainP.Controls.Remove(manageEmpsP);
            mainP.Controls.Remove(viewLogsP); 
            mainP.Controls.Remove(pwChangeP);
        }//---------------------------------------------------------------------------------------------------

        private void LogsB_Click(object sender, EventArgs e)//Displaying Manage Products Panel only By Removeing Others Panels From Parent Panel
        {
            mainP.Controls.Add(viewLogsP);
            viewLogsP.Location = new System.Drawing.Point(0, 0);
            mainP.Controls.Remove(manageEmpsP);
            mainP.Controls.Remove(pwChangeP);
            mainP.Controls.Remove(manageProdP);
        }//---------------------------------------------------------------------------------------------------
        private void EmployeeB_Click(object sender, EventArgs e)//Displaying Manage Products Panel only By Removeing Others Panels From Parent Panel
        {
            mainP.Controls.Remove(pwChangeP);
            mainP.Controls.Remove(viewLogsP);
            mainP.Controls.Remove(manageProdP);
            mainP.Controls.Add(manageEmpsP);
            manageEmpsP.Location = new System.Drawing.Point(0, 0);
        }//---------------------------------------------------------------------------------------------------
        private void SettingsB_Click(object sender, EventArgs e)////Displaying Settings Panel only By Removeing Others Panels From Parent Panel
        {
            mainP.Controls.Add(pwChangeP);
            pwChangeP.Location = new System.Drawing.Point(0, 0);
            mainP.Controls.Remove(manageProdP);
            mainP.Controls.Remove(viewLogsP);
            mainP.Controls.Remove(manageEmpsP);

        }//------------------------------------------------------------------------------------------------

        private void AddProdB_Click(object sender, EventArgs e)//Hides This Form and Creates New Form To Add New Product
        {
            this.Hide();
            new AddNewItem().ShowDialog();
            this.Close();
        }//---------------------------------------------------------------------

        private void RemoveProdB_Click(object sender, EventArgs e)//Hides This Form and Creates New Form To Remove New Product
        {
            this.Hide();
            new RemoveItem().ShowDialog();
            this.Close();
        }//----------------------------------------------------------------------------

        private void AddEmpB_Click(object sender, EventArgs e)//Hides This Form and Creates New Form To Add  New Emp
        {
            this.Hide();
            new AddNewEmp().ShowDialog();
            this.Close();
        }//------------------------------------------------------------------------------

        private void RemoveEmpB_Click(object sender, EventArgs e)//Hides This Form and Creates New Form Remove Emp
        {
            this.Hide();
            new RemoveEmp().ShowDialog();
            this.Close();
        }//-----------------------------------------------------------------------------

        private void CloseB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateProdPriceB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateProdPrice().ShowDialog();
            this.Close();
        }

        private void UpdateProductStockB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UpdateProductStock().ShowDialog();
            this.Close();
        }

        private void ViewAllProdB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewAllItems().ShowDialog();
            this.Close();
        }

        private void ViewAllEmpB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewAllEmps().ShowDialog();
            this.Close();
        }

        private void PriceUpdateLogB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewPriceUpdateLogs().ShowDialog();
            this.Close();
        }

        private void TransactionLogB_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewTransactionLogs().ShowDialog();
            this.Close();
        }

        private void LogOutB_Click(object sender, EventArgs e)// Returning to Login Menu
        {
            this.Hide();
            new Login().ShowDialog();
            this.Close();
        }//-----------------------------------------------------------------------

        private void AdminMainMenu_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Starting timer Object on Main Form Load
        }

        private void Timer1_Tick(object sender, EventArgs e)//Loading Date and Time to the Labels Continouly on Tick/Every Second 
        {
            timeL.Text = DateTime.Now.ToLongTimeString();
            dateL.Text = DateTime.Now.ToLongDateString();
        }//-------------------------------------------------------------------------------

   

        private void ChangeB_Click(object sender, EventArgs e)//Password Changing
        {

        }//--------------------------------------------------

        private void AdminMainMenu_MouseDown(object sender, MouseEventArgs e)//Method to Drag drop Admin MainMenu
        {     //To make the form movable by holding the panel in the top
            mouseDown = true;
            lastLocation = e.Location;
        }//----------------------------------------------------------------------------

        private void AdminMainMenu_MouseUp(object sender, MouseEventArgs e)//Method to Drag drop Admin MainMenu
        {
            mouseDown = false;
        }//----------------------------------------------------------------------------------------------

        private void AdminMainMenu_MouseMove(object sender, MouseEventArgs e)//Method to Drag drop Admin MainMenu
        {
                if (mouseDown)
                {
                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                    this.Update();
                }
        }//--------------------------------------------------------------------------------------------
    }
}
