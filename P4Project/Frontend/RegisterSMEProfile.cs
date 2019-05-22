using System;
using System.Drawing;
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
        private FTPControl FTP;
        private UserInputValidation InputValidation;

        //Declearing a string for the local full path of the image.
        private string LocalImagePath = string.Empty;
        //Declearing a string for the file extension of the image.
        private string LocalImageFiletype = string.Empty;
        #endregion

        #region Constructor(s)
        public RegisterSMEProfile()
        {
            InitializeComponent();
            SQL = new SQLControl();
            FTP = new FTPControl();
            InputValidation = new UserInputValidation();
        }
        #endregion

        #region Button functionality
        private void RegisterSave_Click(object sender, EventArgs e)
        {
            try
            {
                var image_Path = LocalImagePath;
                var image_Type = LocalImageFiletype;
                var serverImagePathDir = string.Empty;
                if (image_Path != string.Empty)
                {
                    serverImagePathDir = FTP.UploadImage(image_Path, image_Type);
                }


                string img_SME = serverImagePathDir;
                string companyName = CompanyName.Text;
                string password = Password.Text;
                string confirmPass = ConfirmPass.Text;
                string email = CompanyEmail.Text;
                string username = SMEUsername.Text;


                InputValidation.VerifySMERegistration(companyName, password, confirmPass, email, username);
                SQL.RegisterSMEProfile(img_SME, companyName, email, password, username);
                MessageBox.Show("A new SME user has been created!");
                Close();
            }
            #region Exception Catching:
            catch (InvalidEmailException ex)
            {
                MessageBox.Show("Invalid Email Address! " + ex.i);
            }
            catch (InvalidUsernameException ex)
            {
                MessageBox.Show("Invalid Username! " + ex.i);
            }
            catch (PasswordsDoesNotMatchException)
            {
                MessageBox.Show("Passwords does not match!");
            }
            catch (PasswordToShortException)
            {
                MessageBox.Show("Your Password is to short! Password must be atleast 8 characters!");
            }
            catch (MySqlException ex)
            {
                int errorcode = ex.Number;
                string ErrorOutput = ex.Message;

                if ((errorcode == 1062))
                {
                    MessageBox.Show("This username is already in use!");
                }
                else
                {
                    MessageBox.Show("An onexpected error has occured while registrering! Please try again or contact system administrators! \n Error message:" + ErrorOutput);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error has occured while registrering! Please contact system administrators!" + ex.Message);
            }
            #endregion
        }

        private void ChooseLogoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {

                    //Sets the FileDialog "Start path" to the C drive
                    openFileDialog.InitialDirectory = "c:\\";
                    //Applies filter for allowed filetypes
                    openFileDialog.Filter = "Choose your image file (*.jpg)|*.jpg|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Stores the name of the chosen file into "fileName"
                        var fileName = openFileDialog.SafeFileName;

                        //Stores the fileextension into "fileType"
                        var fileType = Path.GetExtension(openFileDialog.FileName);

                        //Get the path of specified file
                        var filePath = openFileDialog.FileName;

                        //Displays the choosen image in the PictureBox
                        pictureBox1_SME.Image = Image.FromFile(openFileDialog.FileName);

                        //Stores the local path into the already decleared "LocalImagePath" string.
                        LocalImagePath = filePath;

                        //Stores the file extension into the already decleared "LocalImageFiletype" string.
                        LocalImageFiletype = fileType;
                    }
                }
            }
            #region Exception Catching:
            catch (Exception ex)
            {
                MessageBox.Show("An Unknown error uccored while trying to upload the Picture! Please make sure you use a picture, and that its not too big." + ex.Message);
            }
            #endregion
        }

        private void SMERegBackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
