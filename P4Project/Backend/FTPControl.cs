 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using MySql.Data.MySqlClient;
using P4Project.Exceptions;
using P4Project.Backend.Classes;
using System.Windows.Forms;

namespace P4Project
{
    class FTPControl
    {
        #region Instances and properties
        //Hostname to FTP Server!
        private string FTPHost = "ftp://85.191.201.7";

        //Full Dir path to image folder on server!
        private string FTPImageDir = "/p4projekt/images/";
        //Full Dir path to pdf folder on server!
        private string FTPPDFDir = "/p4projekt/pdf/";

        private SQLControl SQL;
        #endregion

        #region Random FileName Generator
        //Random Filename generator.
        //This will be used for every uploaded file to ensure that we don't have duplicate filenames (not bulletproof - but okay)
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion //End of Random Region

        #region Constructor
        public FTPControl()
        {
            SQL = new SQLControl();
        }
        #endregion

        #region Upload Functions
        public string UploadImage(string image_Path, string image_Type)
        {
            string randomName = RandomString(10);
            string newImageName = randomName + image_Type;
            string serverImagePathDir = FTPHost + FTPImageDir + newImageName;

            using (WebClient client = new WebClient())
            {
                client.UploadFile(serverImagePathDir, WebRequestMethods.Ftp.UploadFile, image_Path);
            }

            //Returns the serverpath of the uploaded image.
            return serverImagePathDir;
        }

        public string UploadFile(string file_Path, string file_Type)
        {
            string randomName = RandomString(10);
            string newFileName = randomName + file_Type;
            string serverFilePathDir = FTPHost + FTPPDFDir + newFileName;

            using (WebClient client = new WebClient())
            {
                client.UploadFile(serverFilePathDir, WebRequestMethods.Ftp.UploadFile, file_Path);
            }

            //Returns the serverpath of the uploaded file
            return serverFilePathDir;
        }
        #endregion //End of Upload region

        
    }
}
