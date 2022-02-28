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
    public partial class VoterForm : Form
    {
        public VoterForm()
        {
            InitializeComponent();
        }

        private void VoterForm_Load(object sender, EventArgs e)
        {
            data_Candidate.Hide();
            lbl_SelectCandidate.Hide();
            lbl_Candidate.Hide();
            txt_Candidate.Hide();
            btn_Vote.Hide();
            lbl_UserID.Hide();
            txt_UserID.Hide();

        }
        private void ExecuteQuery(string str_Query)
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
                    
                }

                sqlConn.Close();

            }
        }
        private void LoadDataCampaign()
        {
            string str_Query = "SELECT Campaign, Campaign Description FROM Campaign";
            using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                sqlConn.Open();
                SQLiteCommand sqlCmd = new SQLiteCommand(sqlConn);
                sqlCmd = sqlConn.CreateCommand();
                sqlCmd.CommandText = str_Query;
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(str_Query, sqlConn);
                DataSet dataSet = new DataSet();
                dataSet.Reset();
                DataTable dataTable = new DataTable();

                sqlDa.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                data_Campaign.DataSource = dataTable;
                sqlConn.Close();
            }
        }
        private void LoadDataCandidate()
        {
            string str_Query = "SELECT * FROM Candidate Where Campaign = '" + txt_Campaign + "'";
            using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                sqlConn.Open();
                SQLiteCommand sqlCmd = new SQLiteCommand(sqlConn);
                sqlCmd = sqlConn.CreateCommand();
                sqlCmd.CommandText = str_Query;
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(str_Query, sqlConn);
                DataSet dataSet = new DataSet();
                dataSet.Reset();
                DataTable dataTable = new DataTable();

                sqlDa.Fill(dataSet);
                dataTable = dataSet.Tables[0];
                data_Candidate.DataSource = dataTable;
                sqlConn.Close();
            }
        }

        private void data_Candidate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Candidate.Text = data_Candidate.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_SelectCampaign_Click(object sender, EventArgs e)
        {
            data_Candidate.Show();
            lbl_SelectCandidate.Show();
            lbl_Candidate.Show();
            txt_Candidate.Show();
            btn_Vote.Show();
            lbl_UserID.Show();
            txt_UserID.Show();
            //Loads the data grids. 
            LoadDataCandidate();
            LoadDataCampaign();
        }

        private void btn_Vote_Click(object sender, EventArgs e)
        {
            //Adds the vote to the database. 
            string str_Query = "Insert into Vote(VoterID, Campaign, Candidate) values ('" + txt_UserID.Text + "','" + txt_Campaign.Text + "', '" + txt_Candidate.Text + "' ";
            ExecuteQuery(str_Query);
        }
    }
}
