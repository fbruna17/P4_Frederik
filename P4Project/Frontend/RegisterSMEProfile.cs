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
using System.IO;

namespace P4Project
{
    public partial class RegisterSMEProfile : Form
    {
        #region Instance Variables & Properties
        private SQLControl SQL;
        private UserInputValidation InputValidation;
        #endregion

        #region Constructor(s)
        public RegisterSMEProfile()
        {
            InitializeComponent();
            SQL = new SQLControl();
            InputValidation = new UserInputValidation();
        }
        #endregion

        #region Text functionality
        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Button functionality
        private void RegisterSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1_SME.Image.Save(ms, pictureBox1_SME.Image.RawFormat);

            byte[] img_SME = ms.ToArray();
            string companyName = CompanyName.Text;
            string password = Password.Text;
            string confirmPass = ConfirmPass.Text;
            string email = CompanyEmail.Text;
            string username = SMEUsername.Text;

            try
            {
                InputValidation.VerifySMERegistration(companyName, password, confirmPass, email, username);
                SQL.RegisterSMEProfile(img_SME, companyName, email, password, username);
                MessageBox.Show("A new SME user has been created!");
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
        #endregion

        #region Load
        private void RegisterSMEProfile_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChooseLogoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose image(*.jpg; *.png;)|*.jpg; *.png;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1_SME.Image = Image.FromFile(opf.FileName);
            }
        }

        private void PictureBox1_SME_Click(object sender, EventArgs e)
        {

        }
    }
}
