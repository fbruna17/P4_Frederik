using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4Project.Frontend;
using P4Project.Exceptions;
using System.IO;
using System.Net;

namespace P4Project
{
    public partial class CreateStudProfile : Form
    {
        #region Instance Variables & Properties
        private SQLControl SQL;
        private FTPControl FTP;
        UserInputValidation InputValidation;

        //Declearing a string for the local full path of the image.
        private string LocalImagePath = string.Empty;
        //Declearing a string for the file extension of the image.
        private string LocalImageFiletype = string.Empty;


        #endregion

        #region Constructor(s)

        public CreateStudProfile()
        {
            InitializeComponent();
            SQL = new SQLControl();
            FTP = new FTPControl();
            InputValidation = new UserInputValidation();
        }
        #endregion

        #region Buttons
        private void basicSaveBut_Click(object sender, EventArgs e)
        {
            var image_Path = LocalImagePath;
            var image_Type = LocalImageFiletype;
            var serverImagePathDir = string.Empty;
            //Checks if any image file has been selected.
            if(image_Path != string.Empty)
            {
                serverImagePathDir = FTP.UploadImage(image_Path, image_Type);
            }

            string img = serverImagePathDir;
            string username = UsernameText.Text;
            string password = PasswordText.Text;
            string confirmpassword = ConfirmPasswordText.Text;
            string firstname = FirstNameText.Text;
            string lastname = LastNameText.Text;
            string email = EmailText.Text;

            try
            {
                InputValidation.VerifyStudentRegistration(username, password, confirmpassword, email);
                SQL.RegisterStudentProfile(username, password, firstname, lastname, email, img);
                MessageBox.Show("Student has been added to the database!");
                this.Hide();
            }
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
                    ErrorOutput = "This username is already in use!";
                }

                MessageBox.Show(ErrorOutput);
            }
        }

        private void ImageChooseBtn_Click(object sender, EventArgs e)
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
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                    //Stores the local path into the already decleared "LocalImagePath" string.
                    LocalImagePath = filePath;

                    //Stores the file extension into the already decleared "LocalImageFiletype" string.
                    LocalImageFiletype = fileType;
                }
            }
        }

        //Student Registration Back Buttom
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Load
        private void CreateStudProfileV2_Load(object sender, EventArgs e)
        {

        }

        private void CreateStudProfileV2_Load_1(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
