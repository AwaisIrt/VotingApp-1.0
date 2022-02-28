using Dapper;
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
        

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string str_UserName, str_Password, str_UserType;
            //Assigns the textbox to string variables.
            str_UserName = txt_Username.Text;
            str_Password = txt_Password.Text;

            //If the User has not inpput any values, this will give message to enter values. 
            if (txt_Password.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Input User ID and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //This uses the connection string to create a connection. Used 'using' to ensure all the connection are opened and closed within so they don't stay open.
                //This can cause locking of the Database. 
                using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
                {
                    //Opens the connection. 
                    sqlConn.Open();
                    //the query that will be used to select the username and password. 
                    string str_Query = " SELECT UserName, Password, UserType FROM User WHERE UserName = @str_UserName AND Password = @str_Password";
                    
                    //this creates a command to be used.
                    SQLiteCommand sqlCmd = new SQLiteCommand(str_Query, sqlConn);
                    //Parameters that need to be used indicate where th values are coming from. 
                    sqlCmd.Parameters.AddWithValue("@str_UserName", txt_Username.Text);
                    sqlCmd.Parameters.AddWithValue("@str_Password", txt_Password.Text);
                    
                    SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(sqlCmd);
                    DataTable dataTable = new DataTable();
                    //fills a table using data adapter
                    sqlDa.Fill(dataTable);
                    //reads the data using command. 
                    SQLiteDataReader sqlDr = sqlCmd.ExecuteReader();


                    if (dataTable.Rows.Count > 0)
                    {
                        //Reads the calues using data reader compares them to see which form needs to be opened depending on the user. 
                        if (sqlDr.Read())
                        {
                            str_UserType = sqlDr.GetValue(2).ToString();

                            if (str_UserType == "Admin" || str_UserType == "admin")
                            {
                                AdminForm form2 = new AdminForm();
                                form2.Show();
                                this.Hide();
                            }
                            else
                            {
                                if (str_UserType == "Voter" || str_UserType == "voter" || str_UserType == null)
                                {
                                    VoterForm form3 = new VoterForm();
                                    form3.Show();
                                    this.Hide();
                                }
                                else if (str_UserType == "Auditor" || str_UserType == "auditor")
                                {
                                    AuditorForm form4 = new AuditorForm();
                                    form4.Show();
                                    this.Hide();
                                }
                            }
                        }
                        //closes the reader connection.
                        sqlDr.Close();

                    }
                    else
                    {
                        //Shows Error if username and password don't match. 
                        MessageBox.Show("Your username or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //Clears the textbox so the user can enter User ID and Password again.
                        txt_Username.Clear();
                        txt_Password.Clear();

                        //Focuses on User ID.
                        txt_Username.Focus();
                    }
                    //closes the connection to the database. 
                    sqlConn.Close();
                }
            

            }
        }
    }
}
