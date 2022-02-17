using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp_1._0
{
    public partial class form_UserLogin : Form
    {
        public form_UserLogin()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            //Opens the Registration form and close user login form. 
            var userRegistraion = new form_Registration();
            userRegistraion.Show();
            //this.Close();        //closes the current form
        }
    }
}
