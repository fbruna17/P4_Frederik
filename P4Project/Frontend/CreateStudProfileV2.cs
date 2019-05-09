using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace P4Project
{
    public partial class CreateStudProfileV2 : Form
    {
        #region Instance Variables & Properties
        private SQLControl SQL;
                private string myConnectionString = "server=mysql33.unoeuro.com;uid=blo_store_dk;pwd=3pdaxzyt;database=blo_store_dk_db_wd";
        private MySqlConnection connection = null;
        #endregion

        #region Constructor(s)
        public CreateStudProfileV2()
        {
            InitializeComponent();
            SQL = new SQLControl();
        }
        #endregion

        #region Buttons
        private void basicSaveBut_Click(object sender, EventArgs e)
        {
            string firstname = FirstNameText.Text;
            string lastname = LastNameText.Text;
            string email = EmailText.Text;
            try
            {
                SQL.AddStudent(firstname, lastname, email);
                MessageBox.Show("Student has been added to the database!");
                this.Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void ImageChooseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose image(*.jpg; *.png;)|*.jpg; *.png;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ImageUploadBtn_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            string insertQuery = "INSERT INTO blo_store_dk_db_wd.Student(PictureDIR) VALUES(@PictureDIR)";

            connection = new MySqlConnection(myConnectionString);

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(insertQuery, connection);

            cmd.Parameters.Add("@PictureDIR", MySqlDbType.Blob);

            cmd.Parameters["@PictureDIR"].Value = img;

            if(cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data inserted");
            }

            connection.Close();



        }
    }
}
