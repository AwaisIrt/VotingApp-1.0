using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using VotingApp;


namespace VotingApp_1._0
{
    public partial class form_UserLogin : Form
    {
       
        public form_UserLogin()
        {
            InitializeComponent();
            
        }
        SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString());

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string str_UserName, str_Password;

            str_UserName = txt_Username.Text;
            str_Password = txt_Password.Text;

            try
            {
                string str_Query = " SELECT * FROM User WHERE UserName = '" + txt_Username.Text + "' AND Password = '" + txt_Password.Text + "'";
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(str_Query, sqlConn);

                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                if (txt_Password.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Input User ID and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        str_UserName = txt_Username.Text;
                        str_Password = txt_Password.Text;
                        //Change to form.

                        MessageBox.Show("Welcome" + " " + str_UserName);
                    }
                    else
                    {
                        //Show Error
                        MessageBox.Show("Your user ID or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        //Clears the textbox so the user can enter User ID and Password again.
                        txt_Username.Clear();
                        txt_Password.Clear();
                        
                        //Focuses on User ID.
                        txt_Username.Focus();
                    }
                }

            }
            catch
            {

            }
            finally
            {
                sqlConn.Close();
            }
        }
    }
}
