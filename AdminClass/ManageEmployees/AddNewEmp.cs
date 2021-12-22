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
    public partial class AddNewEmp : Form
    {
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        public AddNewEmp()
        {
            InitializeComponent();
            makeConnection();//Making Connection
            dobDT.Value = new DateTime(2000, 01, 01);//Setting Default DateTime
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

        private void AddB_Click(object sender, EventArgs e)//Adding New Employee 
        {
            makeConnection();
            String fname = fnameT.Text, lname = lnameT.Text, pno = pnoT.Text, dob = dobDT.Text, pos = posCB.SelectedItem.ToString(), salary=salaryT.Text, sex="";
                 if (maleRB.Checked == true) sex = "M";
            else if (FemaleRB.Checked == true)   sex = "F";

           if (fname.Equals("") || lname.Equals("") || pno.Equals("") ||  dob.Equals("") ||  pos.Equals("") || salary.Equals("")  || sex.Equals("") )
            {
                MessageBox.Show("Important Fields are Empty");
                return;//Rejecting if Fields are Empty
            }   
            try
            {
                sqlCmd = new SqlCommand("Exec USP_AddEmployee @Fname , @Lname, @DOB, " +
                                        "@Salary, @sex, @phoneNo,@Position ", sqlCon);
                
                sqlCmd.Parameters.AddWithValue("@Fname", fname);
                sqlCmd.Parameters.AddWithValue("@Lname", lname);
                sqlCmd.Parameters.AddWithValue("@DOB", dob);
                sqlCmd.Parameters.AddWithValue("@Salary", double.Parse(salary));
                sqlCmd.Parameters.AddWithValue("@sex", sex);
                sqlCmd.Parameters.AddWithValue("@phoneNo", pno);
                sqlCmd.Parameters.AddWithValue("@Position", pos);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added Successfuly");
                ClearTextFields();
            }
            catch (Exception err)
            {
                MessageBox.Show("Operation Failed \n" + err.Message);
            }
        }//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public void ClearTextFields()//+++++++++++Method that clears all text fields
        {
            fnameT.Text = ""; lnameT.Text = ""; pnoT.Text = "";  dobDT.Text = ""; posCB.Text = ""; salaryT.Text="";
            maleRB.Checked = false; FemaleRB.Checked = false;
        }//-----------------------------------------------------------

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
