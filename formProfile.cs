using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class formProfile : Form
    {
        public Account acc = Globals.currentAcc;

        public formProfile()
        {
            InitializeComponent();
            weightLabel.Text = ((int)(acc.Wellness.Weight * 2.205)).ToString() + " lbs"; //kg to lbs

            int totalInches = (int)(acc.Height / 2.54); //cm to in
            heightLabel.Text = (totalInches / 12).ToString() + "'" + (totalInches % 12).ToString();
            ageLabel.Text = acc.Age.ToString() + " years old";
            genderLabel.Text = acc.GenderString;
            userLabel.Text = acc.UserName;
            imageSavedLbl.Visible = false;

            hopePictureBox1.ImageLocation = Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Image", acc.FilePath);
        }


        private void formProfile_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void formProfile_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void importPhoto_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files|*png| ALL Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    hopePictureBox1.ImageLocation = imageLocation;
                    hopePictureBox1.Image = Image.FromFile(imageLocation);
                    imageSavedLbl.Visible = true;

                    //Save profile picture to account
                    acc.FilePath = dialog.SafeFileName;
                    Globals.updateInfo(acc);

                    //Save file to Image folder
                    File.Copy(imageLocation, Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Image", Path.GetFileName(imageLocation)), true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("An Error has Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hopePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
