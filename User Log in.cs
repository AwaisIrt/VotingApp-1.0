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
        SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString());

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string str_UserName, str_Password, str_UserType;

            str_UserName = txt_Username.Text;
            str_Password = txt_Password.Text;

            /*
            
                string str_Query = " SELECT UserName, Password, UserTypes FROM User WHERE UserName = @str_UserName AND Password = @str_Password";
               // SQLiteCommand sqlCmd = new SQLiteCommand("SELECT UserTypes FROM User WHERE UserName = '" + txt_Username.Text + "' AND Password = '" + txt_Password.Text + "'", sqlConn);
                sqlConn.Open();
                SQLiteCommand sqlCmd = new SQLiteCommand(str_Query, sqlConn);
                // SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(str_Query,sqlConn);
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(sqlCmd);


                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

               */

            if (txt_Password.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Input User ID and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string str_Query = " SELECT UserName, Password, UserType FROM User WHERE UserName = @str_UserName AND Password = @str_Password";
               
                SQLiteCommand sqlCmd = new SQLiteCommand(str_Query, sqlConn);
                sqlCmd.Parameters.AddWithValue("@str_UserName", txt_Username.Text);
                sqlCmd.Parameters.AddWithValue("@str_Password", txt_Password.Text);
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                sqlConn.Open();
                SQLiteDataReader sqlDr = sqlCmd.ExecuteReader();


                if (dataTable.Rows.Count > 0)
                {
                    str_UserName = txt_Username.Text;
                    str_Password = txt_Password.Text;
                    //Change to form.
                    // MessageBox.Show("Welcome" + " " + str_UserName);



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
                
                sqlConn.Close();

            }
        }
    }
}
