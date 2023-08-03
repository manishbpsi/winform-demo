using BalDemo;
using Meeting.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meeting
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {

            //Sets the culture to French(France)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");


            InitializeComponent();

            lblLogin.Text = EngDisplayResource.Login;
            lblPassword.Text = EngDisplayResource.EnterPassword;
            lblUserName.Text = EngDisplayResource.EnterUserName;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show(EngValidationResource.EnterUserName, EngDisplayResource.ProjectCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(EngValidationResource.EnterPassword, EngDisplayResource.ProjectCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BalAccount balAccount = new BalAccount();
                if (balAccount.ValidateUser(txtUserName.Text, txtPassword.Text))
                {
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(EngValidationResource.IncorrectLoginDetails, EngDisplayResource.ProjectCaption, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtUserName.Text == "")
            {
                errorProvider1.SetError(txtUserName, EngValidationResource.EnterUserName);
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, EngValidationResource.EnterPassword);
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Text = "";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
