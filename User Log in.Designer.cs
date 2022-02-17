namespace VotingApp_1._0
{
    partial class form_UserLogin
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
            this.lbl_signIn = new System.Windows.Forms.Label();
            this.lbl_UserID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_signIn
            // 
            this.lbl_signIn.AutoSize = true;
            this.lbl_signIn.Location = new System.Drawing.Point(532, 117);
            this.lbl_signIn.Name = "lbl_signIn";
            this.lbl_signIn.Size = new System.Drawing.Size(102, 32);
            this.lbl_signIn.TabIndex = 0;
            this.lbl_signIn.Text = "Sign in";
            this.lbl_signIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_signIn.UseMnemonic = false;
            // 
            // lbl_UserID
            // 
            this.lbl_UserID.AutoSize = true;
            this.lbl_UserID.Location = new System.Drawing.Point(425, 196);
            this.lbl_UserID.Name = "lbl_UserID";
            this.lbl_UserID.Size = new System.Drawing.Size(115, 32);
            this.lbl_UserID.TabIndex = 1;
            this.lbl_UserID.Text = "User ID:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(425, 302);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(146, 32);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(431, 245);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(298, 38);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(431, 363);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(292, 38);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(431, 428);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(126, 51);
            this.btn_SignIn.TabIndex = 5;
            this.btn_SignIn.Text = "Sign in";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            // 
            // form_UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 663);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserID);
            this.Controls.Add(this.lbl_signIn);
            this.Name = "form_UserLogin";
            this.Text = "User Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_signIn;
        private System.Windows.Forms.Label lbl_UserID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_SignIn;
    }
}

