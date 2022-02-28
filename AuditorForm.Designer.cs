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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_SelectCampaign = new System.Windows.Forms.Label();
            this.lbl_Campaign = new System.Windows.Forms.Label();
            this.lbl_CampaignID = new System.Windows.Forms.Label();
            this.txt_CampaignID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(471, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1229, 168);
            this.dataGridView1.TabIndex = 1;
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
            this.lbl_Campaign.Location = new System.Drawing.Point(1076, 319);
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
            // AuditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2194, 945);
            this.Controls.Add(this.txt_CampaignID);
            this.Controls.Add(this.lbl_CampaignID);
            this.Controls.Add(this.lbl_Campaign);
            this.Controls.Add(this.lbl_SelectCampaign);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_AuditHub);
            this.Name = "AuditorForm";
            this.Text = "AuditorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AuditHub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_SelectCampaign;
        private System.Windows.Forms.Label lbl_Campaign;
        private System.Windows.Forms.Label lbl_CampaignID;
        private System.Windows.Forms.TextBox txt_CampaignID;
    }
}