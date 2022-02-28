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
using System.Data.Sql;
using Dapper;

namespace VotingApp_1._0
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        
        private void ExecuteQuery (string str_Query)
        {
            
            using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                sqlConn.Open();

                SQLiteCommand sqlCmd = new SQLiteCommand(sqlConn);
                sqlCmd = sqlConn.CreateCommand();
                sqlCmd.CommandText = str_Query;
                sqlCmd.ExecuteNonQuery();
                int int_UserAdded = sqlCmd.ExecuteNonQuery();

                if (int_UserAdded > 0)
                {
                    MessageBox.Show("Record has been added.", "Success", MessageBoxButtons.OK);
                    txt_FirstTextbox.Clear();
                    txt_SecondTextbox.Clear();
                    txt_ThirdTextbox.Clear();

                    txt_FirstTextbox.Focus();
                }
                sqlConn.Close();
                
            }
            
            
        }
        private void LoadData(string str_Query)
        {
            using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                sqlConn.Open();
                SQLiteCommand sqlCmd = new SQLiteCommand(sqlConn);
                sqlCmd = sqlConn.CreateCommand();
                sqlCmd.CommandText = str_Query;
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(str_Query,sqlConn);
                DataSet dataSet = new DataSet();
                dataSet.Reset();
                DataTable dataTable = new DataTable();
                
                sqlDa.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                data_GridOne.DataSource = dataTable;
                sqlConn.Close();
            }
            lbl_FourthLabel.Show();
            lbl_FifthLabel.Show();
            txt_FourthTextBox.Show();
            txt_FifthTextBox.Show();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Hides all the objects on start of the Form.

            //User Management buttons
            btn_AddNewUser.Hide();
            btn_UpdateUser.Hide(); 
            btn_DeleteUser.Hide();
            //Add user button
            btn_AddUser.Hide();

            //Update user details 
            btn_UpdateUserDetails.Hide();

            //delete User details
            btn_DeleteExistUser.Hide();

            //Campaign Management buttons
            btn_NewCampaign.Hide();
            btn_UpdateCampaign.Hide();
            btn_DeleteCampaign.Hide();
            //add campaign
            btn_CreateCampaign.Hide();
            //
            btn_UpdateExistCampaign.Hide();

            //
            btn_DeleteExistCampaign.Hide();

            //Labels and textboxes
            lbl_FirstLabel.Hide();
            lbl_SecondLabel.Hide();
            lbl_ThirdLabel.Hide();
            lbl_FourthLabel.Hide();
            lbl_FifthLabel.Hide();
            txt_FirstTextbox.Hide();
            txt_SecondTextbox.Hide();
            txt_ThirdTextbox.Hide();
            txt_FourthTextBox.Hide();
            txt_FifthTextBox.Hide();

            //Candidate
            btn_AddCandidate.Hide();
            btn_UpdateCandidate.Hide();
            btn_DeleteCandidate.Hide();
            //add candidate
            btn_AddNewCandidate.Hide();
            btn_UpdateExistCandidate.Hide();
            btn_DeleteExistCandidate.Hide();

            //Data grid
            data_GridOne.Hide();
            

        }
        private void ShowLabelsTextboxes(object sender, EventArgs e)
        {
            lbl_FirstLabel.Show();
            lbl_SecondLabel.Show();
            lbl_ThirdLabel.Show();
            txt_FirstTextbox.Show();
            txt_SecondTextbox.Show();
            txt_ThirdTextbox.Show();
        }
        private void ShowUserButtons(object sender, EventArgs e)
        {
            btn_AddNewUser.Show();
            btn_UpdateUser.Show();
            btn_DeleteUser.Show();
        }
        private void ShowCampaignButtons (object sender, EventArgs e)
        {
            btn_NewCampaign.Show();
            btn_UpdateCampaign.Show();
            btn_DeleteCampaign.Show();
        }

        private void UserLabels(object sender, EventArgs e)
        {
            lbl_FirstLabel.Text = "User Name";
            lbl_SecondLabel.Text = "Password";
            lbl_ThirdLabel.Text = "User Type";
        }
        private void CampaignLabels(object sender, EventArgs e)
        {
            lbl_FirstLabel.Text = "Campaign Name";
            lbl_SecondLabel.Text = "Campaign Description";
            lbl_ThirdLabel.Text = "Campaign Status";
        }
        private void CandidateLabels(object sender, EventArgs e)
        {
            lbl_FirstLabel.Text = "Candidate Name";
            lbl_SecondLabel.Text = "Campaign Name";
            lbl_ThirdLabel.Hide();
        }
        private void btn_UserManagement_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowUserButtons(sender, e);

        }

        private void btn_CampaignManagement_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowCampaignButtons(sender, e); 
        }

        private void btn_AddNewUser_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowLabelsTextboxes(sender, e);
            ShowUserButtons(sender, e);
            UserLabels(sender, e);

            btn_AddUser.Show();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            
            string str_UserName, str_Password, str_UserType;
            
            
            //Add users using the Execute query method.  
            if (txt_FirstTextbox.Text == "" || txt_SecondTextbox.Text == "" || txt_ThirdTextbox.Text == "")
            {
                MessageBox.Show("Input User Name, Password and User Type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                str_UserName = txt_FirstTextbox.Text;
                str_Password = txt_SecondTextbox.Text;
                str_UserType = txt_ThirdTextbox.Text;
                string str_Query = "INSERT INTO User (UserName, Password, UserType) VALUES ('" + str_UserName + "', '" + str_Password + "', '" + str_UserType + "')";
                ExecuteQuery(str_Query);
            }
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowLabelsTextboxes(sender, e);
            ShowUserButtons(sender, e);
            UserLabels(sender, e);
            btn_UpdateUserDetails.Show();
            data_GridOne.Show();

            string str_Query = "SELECT UserID, UserName, UserType FROM User";
            LoadData(str_Query);
            lbl_FourthLabel.Text = "User Name";
            lbl_FifthLabel.Text = "User Type";
        }

        private void btn_UpdateUserDetails_Click(object sender, EventArgs e)
        {
           
            string str_Query = "Update User set UserName = '" + txt_FourthTextBox.Text + "', UserType ='" + txt_FifthTextBox.Text + "' where UserID ='" + txt_ThirdTextbox.Text + "' ";
            string str_LoadQuery = "SELECT UserID, UserName, UserType FROM User";
            ExecuteQuery(str_Query);
            LoadData(str_LoadQuery); 
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowUserButtons(sender, e);
            ShowLabelsTextboxes(sender, e);
            data_GridOne.Show();
            string str_Query = "SELECT UserID, UserName, UserType FROM User";
            LoadData(str_Query);
            lbl_FourthLabel.Text = "User Name";
            lbl_FifthLabel.Text = "User Type";



            btn_DeleteExistUser.Show();

        }

        private void btn_DeleteExistUser_Click(object sender, EventArgs e)
        {
            string str_Query = "Delete from User where UserID ='" + txt_ThirdTextbox.Text + "' ";
            string str_LoadQuery = "SELECT UserID, UserName, UserType FROM User";
            ExecuteQuery(str_Query);
            LoadData(str_LoadQuery);

        }

        private void btn_NewCampaign_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowCampaignButtons(sender, e);
            ShowLabelsTextboxes(sender, e);
            CampaignLabels(sender, e);
            lbl_ThirdLabel.Hide();
            txt_ThirdTextbox.Hide();

            btn_CreateCampaign.Show();
        }

        private void btn_UpdateCampaign_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowCampaignButtons(sender, e);
            ShowLabelsTextboxes(sender, e);
            CampaignLabels(sender, e);

            btn_UpdateExistCampaign.Show();
            string str_Query = "SELECT * FROM Campaign";
            LoadData(str_Query);
            lbl_FourthLabel.Text = "Campaign";
            lbl_FifthLabel.Text = "Description";
        }

        private void btn_DeleteCampaign_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowCampaignButtons(sender, e);
            ShowLabelsTextboxes(sender, e);

            lbl_FirstLabel.Text = "Campaign ID";
            lbl_SecondLabel.Text = "Campaign Name";
            lbl_ThirdLabel.Hide();
            txt_ThirdTextbox.Hide();

            string str_Query = "SELECT * FROM Campaign";
            LoadData(str_Query);
            lbl_FourthLabel.Text = "Campaign";
            lbl_FifthLabel.Text = "Description";

            btn_DeleteExistCampaign.Show();
        }

        private void btn_DeleteExistCampaign_Click(object sender, EventArgs e)
        {
            string str_Query = "Delete from Campaign where CampaignID ='" + txt_ThirdTextbox.Text + "' ";
            string str_LoadQuery = "SELECT * FROM Campaign";
            ExecuteQuery(str_Query);
            LoadData(str_LoadQuery);
        }

        private void btn_CreateCampaign_Click(object sender, EventArgs e)
        {
            string str_Campaign, str_CampDescription;


            //Add users using the Execute query method.  
            if (txt_FirstTextbox.Text == "" || txt_SecondTextbox.Text == "" || txt_ThirdTextbox.Text == "")
            {
                MessageBox.Show("Input Campaign Name and Campaign Description", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                str_Campaign = txt_FirstTextbox.Text;
                str_CampDescription = txt_SecondTextbox.Text;
                
                string str_Query = "INSERT INTO Campaign (Campaign, CampaignDescription) VALUES ('" + str_Campaign + "', '" + str_CampDescription + "')";
                ExecuteQuery(str_Query);
            }
        }

        private void btn_UpdateExistCampaign_Click(object sender, EventArgs e)
        {
            string str_Query = "Update Campaign set Campaign = '" + txt_FourthTextBox.Text + "', CampaignDescription ='" + txt_FifthTextBox.Text + "' where CampaignID ='" + txt_ThirdTextbox.Text + "' ";
            string str_LoadQuery = "SELECT * FROM Campaign";
            ExecuteQuery(str_Query);
            LoadData(str_LoadQuery);

        }

        private void btn_AddCandidate_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            CandidateButtons(sender, e);
            ShowLabelsTextboxes(sender, e);
            CandidateLabels(sender, e);
            btn_AddNewCandidate.Show();
        }

        private void btn_UpdateCandidate_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            CandidateButtons(sender, e);
            ShowLabelsTextboxes(sender, e);
            CandidateLabels(sender, e);
            btn_UpdateExistCandidate.Show();
            string str_Query = "SELECT * FROM Candidate";
            LoadData(str_Query);
            lbl_FourthLabel.Text = "Candidate";
            lbl_FifthLabel.Text = "Campaign";

        }

        private void btn_DeleteCandidate_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            CandidateButtons(sender, e);
            ShowLabelsTextboxes(sender, e);
            CandidateLabels(sender, e);
            btn_DeleteExistCandidate.Show();

            string str_Query = "SELECT UserID, UserName, UserType FROM User";
            LoadData(str_Query);
            lbl_FourthLabel.Text = "Candidate";
            lbl_FifthLabel.Text = "Campaign";
        }

        private void data_GridOne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //Recheck this
            txt_ThirdTextbox.Text = data_GridOne.SelectedRows[0].Cells[0].Value.ToString();
            txt_FourthTextBox.Text = data_GridOne.SelectedRows[0].Cells[1].Value.ToString();
            txt_FifthTextBox.Text = data_GridOne.SelectedRows[0].Cells[2].Value.ToString();


        }

        private void btn_AddNewCandidate_Click(object sender, EventArgs e)
        {
            string str_Candidate, str_Campaign;


            //Add users using the Execute query method.  
            if (txt_FirstTextbox.Text == "" || txt_SecondTextbox.Text == "" || txt_ThirdTextbox.Text == "")
            {
                MessageBox.Show("Input Candidate Name and Campaign Name", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                str_Candidate = txt_FirstTextbox.Text;
                str_Campaign = txt_SecondTextbox.Text;

                string str_Query = "INSERT INTO Candidate (Campaign, CampaignDescription) VALUES ('" + str_Candidate + "', '" + str_Campaign + "')";
                ExecuteQuery(str_Query);
            }
        }

        private void btn_UpdateExistCandidate_Click(object sender, EventArgs e)
        {
            string str_Query = "Update Candidate set CandidateName = '" + txt_FourthTextBox.Text + "', Campaign ='" + txt_FifthTextBox.Text + "' where CandidateID ='" + txt_ThirdTextbox.Text + "' ";
            string str_LoadQuery = "SELECT * FROM Campaign";
            ExecuteQuery(str_Query);
            LoadData(str_LoadQuery);
        }

        private void btn_DeleteExistCandidate_Click(object sender, EventArgs e)
        {
            string str_Query = "Delete from Candidate where CandidateID ='" + txt_ThirdTextbox.Text + "' ";
            string str_LoadQuery = "SELECT * FROM Candidate";
            ExecuteQuery(str_Query);
            LoadData(str_LoadQuery);
        }
        private void CandidateButtons(object sender, EventArgs e)
        {
            btn_AddCandidate.Show();
            btn_DeleteCandidate.Show();
            btn_UpdateCandidate.Show();
        }
        private void btn_CandidateManagement_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            CandidateButtons(sender, e);
            
        }
    }
}
