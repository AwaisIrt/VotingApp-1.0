namespace VotingApp_1._0
{
    partial class VoterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SelectCampaign = new System.Windows.Forms.Label();
            this.data_Campaign = new System.Windows.Forms.DataGridView();
            this.lbl_CampaignID = new System.Windows.Forms.Label();
            this.txt_CampaignID = new System.Windows.Forms.TextBox();
            this.lbl_Campaign = new System.Windows.Forms.Label();
            this.txt_Campaign = new System.Windows.Forms.TextBox();
            this.lbl_SelectCandidate = new System.Windows.Forms.Label();
            this.data_Candidate = new System.Windows.Forms.DataGridView();
            this.lbl_Candidate = new System.Windows.Forms.Label();
            this.txt_Candidate = new System.Windows.Forms.TextBox();
            this.btn_SelectCampaign = new System.Windows.Forms.Button();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.btn_Vote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Campaign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Candidate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31833, 7613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place your Vote below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(846, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Place your Vote Below";
            // 
            // lbl_SelectCampaign
            // 
            this.lbl_SelectCampaign.AutoSize = true;
            this.lbl_SelectCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCampaign.Location = new System.Drawing.Point(621, 133);
            this.lbl_SelectCampaign.Name = "lbl_SelectCampaign";
            this.lbl_SelectCampaign.Size = new System.Drawing.Size(302, 39);
            this.lbl_SelectCampaign.TabIndex = 3;
            this.lbl_SelectCampaign.Text = "Select Campaign:";
            // 
            // data_Campaign
            // 
            this.data_Campaign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Campaign.Location = new System.Drawing.Point(628, 190);
            this.data_Campaign.Name = "data_Campaign";
            this.data_Campaign.RowHeadersWidth = 102;
            this.data_Campaign.RowTemplate.Height = 40;
            this.data_Campaign.Size = new System.Drawing.Size(988, 185);
            this.data_Campaign.TabIndex = 4;
            // 
            // lbl_CampaignID
            // 
            this.lbl_CampaignID.AutoSize = true;
            this.lbl_CampaignID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CampaignID.Location = new System.Drawing.Point(621, 397);
            this.lbl_CampaignID.Name = "lbl_CampaignID";
            this.lbl_CampaignID.Size = new System.Drawing.Size(228, 39);
            this.lbl_CampaignID.TabIndex = 5;
            this.lbl_CampaignID.Text = "CampaignID:";
            // 
            // txt_CampaignID
            // 
            this.txt_CampaignID.Location = new System.Drawing.Point(868, 393);
            this.txt_CampaignID.Multiline = true;
            this.txt_CampaignID.Name = "txt_CampaignID";
            this.txt_CampaignID.Size = new System.Drawing.Size(259, 55);
            this.txt_CampaignID.TabIndex = 6;
            // 
            // lbl_Campaign
            // 
            this.lbl_Campaign.AutoSize = true;
            this.lbl_Campaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Campaign.Location = new System.Drawing.Point(1149, 397);
            this.lbl_Campaign.Name = "lbl_Campaign";
            this.lbl_Campaign.Size = new System.Drawing.Size(191, 39);
            this.lbl_Campaign.TabIndex = 7;
            this.lbl_Campaign.Text = "Campaign:";
            // 
            // txt_Campaign
            // 
            this.txt_Campaign.Location = new System.Drawing.Point(1360, 387);
            this.txt_Campaign.Multiline = true;
            this.txt_Campaign.Name = "txt_Campaign";
            this.txt_Campaign.Size = new System.Drawing.Size(256, 61);
            this.txt_Campaign.TabIndex = 8;
            // 
            // lbl_SelectCandidate
            // 
            this.lbl_SelectCandidate.AutoSize = true;
            this.lbl_SelectCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SelectCandidate.Location = new System.Drawing.Point(620, 549);
            this.lbl_SelectCandidate.Name = "lbl_SelectCandidate";
            this.lbl_SelectCandidate.Size = new System.Drawing.Size(303, 39);
            this.lbl_SelectCandidate.TabIndex = 11;
            this.lbl_SelectCandidate.Text = "Select Candidate:";
            // 
            // data_Candidate
            // 
            this.data_Candidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Candidate.Location = new System.Drawing.Point(618, 611);
            this.data_Candidate.Name = "data_Candidate";
            this.data_Candidate.RowHeadersWidth = 102;
            this.data_Candidate.RowTemplate.Height = 40;
            this.data_Candidate.Size = new System.Drawing.Size(998, 168);
            this.data_Candidate.TabIndex = 12;
            this.data_Candidate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Candidate_CellClick);
            // 
            // lbl_Candidate
            // 
            this.lbl_Candidate.AutoSize = true;
            this.lbl_Candidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Candidate.Location = new System.Drawing.Point(620, 811);
            this.lbl_Candidate.Name = "lbl_Candidate";
            this.lbl_Candidate.Size = new System.Drawing.Size(192, 39);
            this.lbl_Candidate.TabIndex = 13;
            this.lbl_Candidate.Text = "Candidate:";
            // 
            // txt_Candidate
            // 
            this.txt_Candidate.Location = new System.Drawing.Point(827, 801);
            this.txt_Candidate.Multiline = true;
            this.txt_Candidate.Name = "txt_Candidate";
            this.txt_Candidate.Size = new System.Drawing.Size(373, 60);
            this.txt_Candidate.TabIndex = 14;
            // 
            // btn_SelectCampaign
            // 
            this.btn_SelectCampaign.Location = new System.Drawing.Point(1026, 479);
            this.btn_SelectCampaign.Name = "btn_SelectCampaign";
            this.btn_SelectCampaign.Size = new System.Drawing.Size(256, 49);
            this.btn_SelectCampaign.TabIndex = 15;
            this.btn_SelectCampaign.Text = "Select Campaign";
            this.btn_SelectCampaign.UseVisualStyleBackColor = true;
            this.btn_SelectCampaign.Click += new System.EventHandler(this.btn_SelectCampaign_Click);
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserID.Location = new System.Drawing.Point(621, 908);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(235, 39);
            this.lbl_UserID.TabIndex = 17;
            this.lbl_UserID.Text = "Your User ID:";
            // 
            // txt_UserID
            // 
            this.txt_UserID.Location = new System.Drawing.Point(868, 895);
            this.txt_UserID.Multiline = true;
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(346, 61);
            this.txt_UserID.TabIndex = 18;
            // 
            // btn_Vote
            // 
            this.btn_Vote.Location = new System.Drawing.Point(1026, 985);
            this.btn_Vote.Name = "btn_Vote";
            this.btn_Vote.Size = new System.Drawing.Size(256, 76);
            this.btn_Vote.TabIndex = 19;
            this.btn_Vote.Text = "Vote";
            this.btn_Vote.UseVisualStyleBackColor = true;
            this.btn_Vote.Click += new System.EventHandler(this.btn_Vote_Click);
            // 
            // VoterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2282, 1411);
            this.Controls.Add(this.btn_Vote);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.btn_SelectCampaign);
            this.Controls.Add(this.txt_Candidate);
            this.Controls.Add(this.lbl_Candidate);
            this.Controls.Add(this.data_Candidate);
            this.Controls.Add(this.lbl_SelectCandidate);
            this.Controls.Add(this.txt_Campaign);
            this.Controls.Add(this.lbl_Campaign);
            this.Controls.Add(this.txt_CampaignID);
            this.Controls.Add(this.lbl_CampaignID);
            this.Controls.Add(this.data_Campaign);
            this.Controls.Add(this.lbl_SelectCampaign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VoterForm";
            this.Text = "VoterForm";
            this.Load += new System.EventHandler(this.VoterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Campaign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Candidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SelectCampaign;
        private System.Windows.Forms.DataGridView data_Campaign;
        private System.Windows.Forms.Label lbl_CampaignID;
        private System.Windows.Forms.TextBox txt_CampaignID;
        private System.Windows.Forms.Label lbl_Campaign;
        private System.Windows.Forms.TextBox txt_Campaign;
        private System.Windows.Forms.Label lbl_SelectCandidate;
        private System.Windows.Forms.DataGridView data_Candidate;
        private System.Windows.Forms.Label lbl_Candidate;
        private System.Windows.Forms.TextBox txt_Candidate;
        private System.Windows.Forms.Button btn_SelectCampaign;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Button btn_Vote;
    }
}