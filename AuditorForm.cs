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
    public partial class AuditorForm : Form
    {
        public AuditorForm()
        {
            InitializeComponent();
        }

        private void AuditorForm_Load(object sender, EventArgs e)
        {
            //Hides components on form load.
            data_Candidate.Hide();
            lbl_SelectCandidate.Hide();
            lbl_Candidate.Hide();
            txt_Candidate.Hide();
            btn_TotalCandidate.Hide();
            txt_TotalCandidate.Hide();
            
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
                

                sqlConn.Close();

            }
        }
            private void LoadDataCampaign()
        {
            string str_Query = "SELECT * FROM Campaign";
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
            string str_Query = "SELECT * FROM Candidate";
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
        private void btn_TotalVotes_Click(object sender, EventArgs e)
        {
            data_Candidate.Show();
            lbl_SelectCandidate.Show();
            lbl_Candidate.Show();
            txt_Candidate.Show();
            btn_TotalCandidate.Show();
            txt_TotalCandidate.Show();
            LoadDataCandidate();
            LoadDataCampaign();

            using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                sqlConn.Open();
                string str_Query = " SELECT * FROM Vote WHERE Campaign = '"+txt_Campaign+"'";

                SQLiteCommand sqlCmd = new SQLiteCommand(str_Query, sqlConn);
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                SQLiteDataReader sqlDr = sqlCmd.ExecuteReader();
                //counts the votes
                txt_TotalCampaignVotes.Text = dataTable.Rows.Count.ToString();
                sqlDr.Close();
                sqlConn.Close();
            }
            }

            private void data_Candidate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Candidate.Text = data_Candidate.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void data_Campaign_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_CampaignID.Text = data_Candidate.SelectedRows[0].Cells[0].Value.ToString();
            txt_Campaign.Text = data_Candidate.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btn_TotalCandidate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection sqlConn = new SQLiteConnection(SQLiteDataAccess.LoadConnectionString()))
            {
                sqlConn.Open();
                string str_Query = " SELECT * FROM Vote WHERE Campaign = '" + txt_Campaign + "', Candidate = '" + txt_Candidate + "'";

                SQLiteCommand sqlCmd = new SQLiteCommand(str_Query, sqlConn);
                SQLiteDataAdapter sqlDa = new SQLiteDataAdapter(sqlCmd);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);
                SQLiteDataReader sqlDr = sqlCmd.ExecuteReader();
                //counts sepcific count for candidates. 
                txt_TotalCandidate.Text = dataTable.Rows.Count.ToString();
                sqlDr.Close();
                sqlConn.Close();
            }
        }
    }
}
