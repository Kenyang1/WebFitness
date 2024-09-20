using Dapper;
using System.Data;
using System.Data.SqlClient;
namespace fitness
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("All fields must be filled in.");
            }
            //If username matches password
            else if (Globals.validLogin(Globals.accFile, usernameTextBox.Text, passwordTextBox.Text))
            {
                //Extract account info from text file
                Globals.currentAcc = Globals.onloadAccount(usernameTextBox.Text);

                //Open main menu
                this.Hide();
                Globals.navRef = new nav();
                Globals.navRef.Show();
            }
            else { MessageBox.Show("Invalid username and password combination."); }
        }

        private void extLogButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Open signup form
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            signup signUp = new signup();
            this.Hide();
            signUp.Show();
        }

        private void RememberMecheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (RememberMecheckBox1.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
