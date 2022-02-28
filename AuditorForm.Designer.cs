namespace VotingApp_1._0
{
    partial class AuditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_AuditHub = new System.Windows.Forms.Label();
            this.data_Campaign = new System.Windows.Forms.DataGridView();
            this.lbl_SelectCampaign = new System.Windows.Forms.Label();
            this.lbl_Campaign = new System.Windows.Forms.Label();
            this.lbl_CampaignID = new System.Windows.Forms.Label();
            this.txt_CampaignID = new System.Windows.Forms.TextBox();
            this.txt_Campaign = new System.Windows.Forms.TextBox();
            this.btn_TotalVotes = new System.Windows.Forms.Button();
            this.txt_TotalCampaignVotes = new System.Windows.Forms.TextBox();
            this.data_Candidate = new System.Windows.Forms.DataGridView();
            this.lbl_SelectCandidate = new System.Windows.Forms.Label();
            this.lbl_Candidate = new System.Windows.Forms.Label();
            this.txt_Candidate = new System.Windows.Forms.TextBox();
            this.btn_TotalCandidate = new System.Windows.Forms.Button();
            this.txt_TotalCandidate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Campaign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Candidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AuditHub
            // 
            this.lbl_AuditHub.AutoSize = true;
            this.lbl_AuditHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AuditHub.Location = new System.Drawing.Point(759, 31);
            this.lbl_AuditHub.Name = "lbl_AuditHub";
            this.lbl_AuditHub.Size = new System.Drawing.Size(509, 46);
            this.lbl_AuditHub.TabIndex = 0;
            this.lbl_AuditHub.Text = "Welcome to the Audit Hub";
            // 
            // data_Campaign
            // 
            this.data_Campaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Campaign.Location = new System.Drawing.Point(471, 126);
            this.data_Campaign.Name = "data_Campaign";
            this.data_Campaign.RowHeadersWidth = 102;
            this.data_Campaign.RowTemplate.Height = 40;
            this.data_Campaign.Size = new System.Drawing.Size(1229, 168);
            this.data_Campaign.TabIndex = 1;
            this.data_Campaign.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Campaign_CellClick);
            // 
            // lbl_SelectCampaign
            // 
            this.lbl_SelectCampaign.AutoSize = true;
            this.lbl_SelectCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCampaign.Location = new System.Drawing.Point(464, 77);
            this.lbl_SelectCampaign.Name = "lbl_SelectCampaign";
            this.lbl_SelectCampaign.Size = new System.Drawing.Size(302, 39);
            this.lbl_SelectCampaign.TabIndex = 2;
            this.lbl_SelectCampaign.Text = "Select Campaign:";
            // 
            // lbl_Campaign
            // 
            this.lbl_Campaign.AutoSize = true;
            this.lbl_Campaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Campaign.Location = new System.Drawing.Point(1157, 319);
            this.lbl_Campaign.Name = "lbl_Campaign";
            this.lbl_Campaign.Size = new System.Drawing.Size(191, 39);
            this.lbl_Campaign.TabIndex = 3;
            this.lbl_Campaign.Text = "Campaign:";
            // 
            // lbl_CampaignID
            // 
            this.lbl_CampaignID.AutoSize = true;
            this.lbl_CampaignID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CampaignID.Location = new System.Drawing.Point(464, 319);
            this.lbl_CampaignID.Name = "lbl_CampaignID";
            this.lbl_CampaignID.Size = new System.Drawing.Size(228, 39);
            this.lbl_CampaignID.TabIndex = 4;
            this.lbl_CampaignID.Text = "CampaignID:";
            // 
            // txt_CampaignID
            // 
            this.txt_CampaignID.Location = new System.Drawing.Point(713, 308);
            this.txt_CampaignID.Multiline = true;
            this.txt_CampaignID.Name = "txt_CampaignID";
            this.txt_CampaignID.Size = new System.Drawing.Size(331, 61);
            this.txt_CampaignID.TabIndex = 5;
            // 
            // txt_Campaign
            // 
            this.txt_Campaign.Location = new System.Drawing.Point(1369, 308);
            this.txt_Campaign.Multiline = true;
            this.txt_Campaign.Name = "txt_Campaign";
            this.txt_Campaign.Size = new System.Drawing.Size(331, 61);
            this.txt_Campaign.TabIndex = 6;
            // 
            // btn_TotalVotes
            // 
            this.btn_TotalVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TotalVotes.Location = new System.Drawing.Point(471, 414);
            this.btn_TotalVotes.Name = "btn_TotalVotes";
            this.btn_TotalVotes.Size = new System.Drawing.Size(339, 70);
            this.btn_TotalVotes.TabIndex = 7;
            this.btn_TotalVotes.Text = "Total Campaign Votes";
            this.btn_TotalVotes.UseVisualStyleBackColor = true;
            this.btn_TotalVotes.Click += new System.EventHandler(this.btn_TotalVotes_Click);
            // 
            // txt_TotalCampaignVotes
            // 
            this.txt_TotalCampaignVotes.Location = new System.Drawing.Point(898, 414);
            this.txt_TotalCampaignVotes.Multiline = true;
            this.txt_TotalCampaignVotes.Name = "txt_TotalCampaignVotes";
            this.txt_TotalCampaignVotes.Size = new System.Drawing.Size(219, 70);
            this.txt_TotalCampaignVotes.TabIndex = 8;
            // 
            // data_Candidate
            // 
            this.data_Candidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Candidate.Location = new System.Drawing.Point(471, 566);
            this.data_Candidate.Name = "data_Candidate";
            this.data_Candidate.RowHeadersWidth = 102;
            this.data_Candidate.RowTemplate.Height = 40;
            this.data_Candidate.Size = new System.Drawing.Size(1229, 168);
            this.data_Candidate.TabIndex = 9;
            this.data_Candidate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Candidate_CellClick);
            // 
            // lbl_SelectCandidate
            // 
            this.lbl_SelectCandidate.AutoSize = true;
            this.lbl_SelectCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCandidate.Location = new System.Drawing.Point(464, 508);
            this.lbl_SelectCandidate.Name = "lbl_SelectCandidate";
            this.lbl_SelectCandidate.Size = new System.Drawing.Size(303, 39);
            this.lbl_SelectCandidate.TabIndex = 10;
            this.lbl_SelectCandidate.Text = "Select Candidate:";
            // 
            // lbl_Candidate
            // 
            this.lbl_Candidate.AutoSize = true;
            this.lbl_Candidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Candidate.Location = new System.Drawing.Point(464, 762);
            this.lbl_Candidate.Name = "lbl_Candidate";
            this.lbl_Candidate.Size = new System.Drawing.Size(192, 39);
            this.lbl_Candidate.TabIndex = 11;
            this.lbl_Candidate.Text = "Candidate:";
            // 
            // txt_Candidate
            // 
            this.txt_Candidate.Location = new System.Drawing.Point(672, 751);
            this.txt_Candidate.Multiline = true;
            this.txt_Candidate.Name = "txt_Candidate";
            this.txt_Candidate.Size = new System.Drawing.Size(331, 59);
            this.txt_Candidate.TabIndex = 12;
            // 
            // btn_TotalCandidate
            // 
            this.btn_TotalCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TotalCandidate.Location = new System.Drawing.Point(483, 854);
            this.btn_TotalCandidate.Name = "btn_TotalCandidate";
            this.btn_TotalCandidate.Size = new System.Drawing.Size(340, 70);
            this.btn_TotalCandidate.TabIndex = 13;
            this.btn_TotalCandidate.Text = "Total Candidate Votes";
            this.btn_TotalCandidate.UseVisualStyleBackColor = true;
            this.btn_TotalCandidate.Click += new System.EventHandler(this.btn_TotalCandidate_Click);
            // 
            // txt_TotalCandidate
            // 
            this.txt_TotalCandidate.Location = new System.Drawing.Point(881, 854);
            this.txt_TotalCandidate.Multiline = true;
            this.txt_TotalCandidate.Name = "txt_TotalCandidate";
            this.txt_TotalCandidate.Size = new System.Drawing.Size(353, 66);
            this.txt_TotalCandidate.TabIndex = 14;
            // 
            // AuditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2194, 1070);
            this.Controls.Add(this.txt_TotalCandidate);
            this.Controls.Add(this.btn_TotalCandidate);
            this.Controls.Add(this.txt_Candidate);
            this.Controls.Add(this.lbl_Candidate);
            this.Controls.Add(this.lbl_SelectCandidate);
            this.Controls.Add(this.data_Candidate);
            this.Controls.Add(this.txt_TotalCampaignVotes);
            this.Controls.Add(this.btn_TotalVotes);
            this.Controls.Add(this.txt_Campaign);
            this.Controls.Add(this.txt_CampaignID);
            this.Controls.Add(this.lbl_CampaignID);
            this.Controls.Add(this.lbl_Campaign);
            this.Controls.Add(this.lbl_SelectCampaign);
            this.Controls.Add(this.data_Campaign);
            this.Controls.Add(this.lbl_AuditHub);
            this.Name = "AuditorForm";
            this.Text = "AuditorForm";
            this.Load += new System.EventHandler(this.AuditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Campaign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Candidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AuditHub;
        private System.Windows.Forms.DataGridView data_Campaign;
        private System.Windows.Forms.Label lbl_SelectCampaign;
        private System.Windows.Forms.Label lbl_Campaign;
        private System.Windows.Forms.Label lbl_CampaignID;
        private System.Windows.Forms.TextBox txt_CampaignID;
        private System.Windows.Forms.TextBox txt_Campaign;
        private System.Windows.Forms.Button btn_TotalVotes;
        private System.Windows.Forms.TextBox txt_TotalCampaignVotes;
        private System.Windows.Forms.DataGridView data_Candidate;
        private System.Windows.Forms.Label lbl_SelectCandidate;
        private System.Windows.Forms.Label lbl_Candidate;
        private System.Windows.Forms.TextBox txt_Candidate;
        private System.Windows.Forms.Button btn_TotalCandidate;
        private System.Windows.Forms.TextBox txt_TotalCandidate;
    }
}