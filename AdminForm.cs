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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString());


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
            txt_FirstTextbox.Hide();
            txt_SecondTextbox.Hide();
            txt_ThirdTextbox.Hide();
            

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
            str_UserName = lbl_FirstLabel.Text;
            str_Password = lbl_SecondLabel.Text;
            str_UserType = lbl_ThirdLabel.Text;
            //Add user and add the code for it. 
            if (txt_FirstTextbox.Text == "" || txt_SecondTextbox.Text == "" || txt_ThirdTextbox.Text == "")
            {
                MessageBox.Show("Input User Name, Password and User Type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowLabelsTextboxes(sender, e);
            ShowUserButtons(sender, e);
            UserLabels(sender, e);
            btn_UpdateUserDetails.Show();

            

        }

        private void btn_UpdateUserDetails_Click(object sender, EventArgs e)
        {
            
            
            
            if (txt_FirstTextbox.Text == "" || txt_SecondTextbox.Text == "" || txt_ThirdTextbox.Text == "")
            {
                MessageBox.Show("Input User ID, Password and User Type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
            ShowUserButtons(sender, e);
            ShowLabelsTextboxes(sender, e);

            lbl_FirstLabel.Text = "User ID";
            lbl_SecondLabel.Text = "User Name";
            lbl_ThirdLabel.Hide();
            txt_ThirdTextbox.Hide();
            

            btn_DeleteExistUser.Show();


        }

        private void btn_DeleteExistUser_Click(object sender, EventArgs e)
        {
            if (txt_FirstTextbox.Text == "" || txt_SecondTextbox.Text == "" || txt_ThirdTextbox.Text == "")
            {
                MessageBox.Show("Input User ID, Password and User Type", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
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

            btn_DeleteExistCampaign.Show();
        }
    }
}
