using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void RememberMecheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (RememberMecheckBox2.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                con_passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                con_passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            bool validInputs = true;
            //If any fields are left empty
            if (string.IsNullOrEmpty(genderComboBox.Text))
            {
                MessageBox.Show("All fields must be filled in.");
                validInputs = false;
            }
            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show("All fields must be filled in.");
                    validInputs = false;
                }
            }

            //If password matches confirm password
            if (validInputs && passwordTextBox.Text == con_passwordTextBox.Text)
            {
               //If username is not already taken
               if (!Globals.isUserTaken(Globals.accFile, usernameTextBox.Text))
               {
                    bool gender;
                    if (genderComboBox.Text == "male") { gender = false; }
                    else { gender = true; }

                    //Create account
                    try
                    {
                        string[] heightFeetInches = heightTextBox.Text.Split("-");
                        int heightFeet = Int32.Parse(heightFeetInches[0]);
                        int heightInches = Int32.Parse(heightFeetInches[1]);
                        int heightCentimeters = (int)(heightFeet * 30.48 + heightInches * 2.54);

                        Account acc = new Account(usernameTextBox.Text, passwordTextBox.Text, Int32.Parse(ageTextBox.Text), heightCentimeters, gender);
                        acc.Wellness.Weight = (float)((float.Parse(weightTextBox.Text) / 2.205)); //lbs to kg

                        //Error check numerical values
                        if (acc.Age <= 0) { MessageBox.Show("Age must be greater than 0"); }
                        else if (acc.Height <= 0) { MessageBox.Show("Height must be greater than 0"); }
                        else if (acc.Wellness.Weight <= 0) { MessageBox.Show("Weight must be greater than 0"); }
                        else
                        {
                            //Add account info to AccountInfo.txt
                            Globals.editLine(Globals.accFile, Globals.findEmptyLine(Globals.accFile), acc.ConvertToString());

                            //Add tracking info to TrackingInfo.txt
                            Globals.editLine(Globals.trackingFile, Globals.findEmptyLine(Globals.trackingFile), acc.UserName + " " + acc.Wellness.ConvertToString());

                            //Add water tracking info to WaterTracking.txt
                            Globals.editLine(Globals.waterTrackingFile, Globals.findEmptyLine(Globals.waterTrackingFile), acc.UserName);

                            //Add sleep tracking info to SleepTracking.txt
                            Globals.editLine(Globals.sleepTrackingFile, Globals.findEmptyLine(Globals.sleepTrackingFile), acc.UserName);

                            //Add calorie tracking info to CalorieTracking.txt
                            Globals.editLine(Globals.calorieTrackingFile, Globals.findEmptyLine(Globals.calorieTrackingFile), acc.UserName);

                            MessageBox.Show("Account created successfully.");
                            GoalSignUp setGoal = new GoalSignUp(acc);
                            this.Close();
                            setGoal.Show();
                        }
                    }
                    catch { MessageBox.Show("Input height in format: (feet-inches)"); }
               }
               else { MessageBox.Show("Username is taken."); }
            }
            else { MessageBox.Show("Password fields must match."); }
        }

        private void signInLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login login = new login();
            login.Show();
        }
    }
}
