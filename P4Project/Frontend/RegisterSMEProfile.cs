using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Exceptions;
using MySql.Data.MySqlClient;

namespace P4Project
{
    public partial class RegisterSMEProfile : Form
    {
        private SQLControl SQL;
        private UserInputValidation InputValidation;

        public RegisterSMEProfile()
        {
            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterSave_Click(object sender, EventArgs e)
        {
            string companyName = CompanyName.Text;
            string password = Password.Text;
            string confirmPass = ConfirmPass.Text;
            string email = CompanyEmail.Text;

            try
            {
                InputValidation.VerifySMERegistration(companyName, password, confirmPass, email);
                SQL.RegisterSMEProfile(companyName, email, password);
                MessageBox.Show("A new SME user has ben created!");
                this.Hide();
            }
            catch(InvalidEmailException ex)
            {
                MessageBox.Show("Invalid Email Address! " + ex.i);
            }
            catch(InvalidNameException ex)
            {
                MessageBox.Show("Invalid Company name! " + ex.i);
            }
            catch(PasswordsDoesNotMatchException)
            {
                MessageBox.Show("Passwords does not match!");
            }
            catch(PasswordToShortException)
            {
                MessageBox.Show("Your Password is to short! Password must be atleast 8 characters!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
