using fitness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calorie_Tracker.formCalDefCalculator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calorie_Tracker
{
    public partial class formCalDefCalculator : Form
    {
        public formCalDefCalculator()
        {
            InitializeComponent();

            //M.D: Autofill values to account settings
            weightInput.Value = (decimal)(Globals.currentAcc.Wellness.Weight * 2.205); //kg to lbs
            int totalInches = (int)(Globals.currentAcc.Height / 2.54); //cm to in
            heightInput.Text = (totalInches / 12).ToString() + "-" + (totalInches % 12).ToString();
            genderInput.SelectedValue = Globals.currentAcc.GenderString;
            ageInput.Value = Globals.currentAcc.Age;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // K.L: Click event handler for the Calculate button
        private void btn1_Click(object sender, EventArgs e)
        {
            // K.L: Parsing user input values
            double weightkg = double.Parse(weightInput.Text);
            double weight = weightkg / 2.20462;

            //M.D: Split text input into feet and inches
            string[] feetInches = heightInput.Text.Split('-');
            double height_feet = double.Parse(feetInches[0]);
            double height_inches = double.Parse(feetInches[1]);

            //K.L
            double height = (height_feet * 12) + height_inches;
            double heightcm = height * 2.54;
            int age = int.Parse(ageInput.Text);
            string gender = genderInput.Text;
            ActivityLevel activityLevel = (ActivityLevel)activityComboBox1.SelectedIndex;

            // K.L: Calculating BMR and TDEE
            double bmr = BMR(weight, heightcm, age, gender);
            double tdee = TDEECalculator(bmr, activityLevel);
            double desiredWeightLossPerWeek = 1; // Example: 1 pound per week
            double caloricDeficit = CalculateCaloricDeficit(tdee, desiredWeightLossPerWeek);

            //M.D: Prompting user to accept or decline calorie deficit reccomendation
            if (MessageBox.Show($"Your Total Daily Energy Expenditure (TDEE) is: {tdee:F2} calories.\nYour Caloric Deficit for 1 pound per week weight loss is: {caloricDeficit:F2} calories per day. Would you like to accept this as your daily calorie intake goal?",
                "Accept as Daily Calorie Intake Goal?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //If clicked yes
                //Update information
                Globals.currentAcc.Wellness.CalorieIntakeGoal = (int)caloricDeficit;
                Globals.updateInfo(Globals.currentAcc);

                //Reopen calorie tracker
                nav nav = Globals.navRef;
                nav.calDef = null;
                object s = new object();
                EventArgs ea = new EventArgs();
                nav.calTrackButton_Click(s, ea);
                nav.cal.updateProgressBar(Globals.currentAcc);
            }
        }

        // K.L: Calculate Basal Metabolic Rate (BMR) based on weight, height, age, and gender
        private double BMR(double weight, double heightcm, double age, string gender)
        {
            if (gender == "Male")
            {
                return (10 * weight + 6.25 * heightcm - 5 * age + 5);
            }
            else if (gender == "Female")
            {
                return (10 * weight + 6.25 * heightcm - 5 * age - 161);
            }
            else
            {
                throw new ArgumentException("Invalid gender");
            }
        }

        // K.L: Calculate Total Daily Energy Expenditure (TDEE) based on BMR and activity level
        private double TDEECalculator(double bmr, ActivityLevel activityLevel)
        {
            double activityFactor = 1.0;
            switch (activityLevel)
            {
                case ActivityLevel.Sedentary:
                    activityFactor = 1.2;
                    break;
                case ActivityLevel.LightlyActive:
                    activityFactor = 1.375;
                    break;
                case ActivityLevel.ModeratelyActive:
                    activityFactor = 1.55;
                    break;
                case ActivityLevel.VeryActive:
                    activityFactor = 1.725;
                    break;
            }
            return bmr * activityFactor;
        }

        // K.L: Enum to represent different activity levels
        public enum ActivityLevel
        {
            Sedentary = 1,
            LightlyActive = 2,
            ModeratelyActive = 3,
            VeryActive = 4
        }

        // K.L: Calculate caloric deficit based on TDEE and desired weight loss per week
        private double CalculateCaloricDeficit(double tdee, double desiredWeightLossPerWeek)
        {
            double caloriesPerPound = 3500;
            return tdee - (desiredWeightLossPerWeek * caloriesPerPound / 7);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //M.D: Enter calorie goal manually
        private void enterCalGoalBtn_Click(object sender, EventArgs e)
        {
            Globals.currentAcc.Wellness.CalorieIntakeGoal = (int)calorieGoalInput.Value;
            Globals.updateInfo(Globals.currentAcc);

            //Reopen calorie tracker
            nav nav = Globals.navRef;
            nav.calDef = null;
            object s = new object();
            EventArgs ea = new EventArgs();
            nav.calTrackButton_Click(s, ea);
            nav.cal.updateProgressBar(Globals.currentAcc);
        }

        private void heightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formCal cal = new formCal();
            cal.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // K.L: Click event handler for the Calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // K.L: Parsing user input values
            double weightkg = double.Parse(weightInput.Text);
            double weight = weightkg / 2.20462;

            //M.D: Split text input into feet and inches
            string[] feetInches = heightInput.Text.Split('-');
            double height_feet = double.Parse(feetInches[0]);
            double height_inches = double.Parse(feetInches[1]);

            //K.L
            double height = (height_feet * 12) + height_inches;
            double heightcm = height * 2.54;
            int age = int.Parse(ageInput.Text);
            string gender = genderInput.Text;
            ActivityLevel activityLevel = (ActivityLevel)activityComboBox1.SelectedIndex;

            // K.L: Calculating BMR and TDEE
            double bmr = BMR(weight, heightcm, age, gender);
            double tdee = TDEECalculator(bmr, activityLevel);
            double desiredWeightLossPerWeek = 1; // Example: 1 pound per week
            double caloricDeficit = CalculateCaloricDeficit(tdee, desiredWeightLossPerWeek);

            //M.D: Prompting user to accept or decline calorie deficit reccomendation
            if (MessageBox.Show($"Your Total Daily Energy Expenditure (TDEE) is: {tdee:F2} calories.\nYour Caloric Deficit for 1 pound per week weight loss is: {caloricDeficit:F2} calories per day. Would you like to accept this as your daily calorie intake goal?",
                "Accept as Daily Calorie Intake Goal?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //If clicked yes
                //Update information
                Globals.currentAcc.Wellness.CalorieIntakeGoal = (int)caloricDeficit;
                Globals.updateInfo(Globals.currentAcc);

                //Reopen calorie tracker
                nav nav = Globals.navRef;
                nav.calDef = null;
                object s = new object();
                EventArgs ea = new EventArgs();
                nav.calTrackButton_Click(s, ea);
                nav.cal.updateProgressBar(Globals.currentAcc);
            }
        }

        //M.D: Enter calorie goal manually
        private void enterBtn_Click(object sender, EventArgs e)
        {
            Globals.currentAcc.Wellness.CalorieIntakeGoal = (int)calorieGoalInput.Value;
            Globals.updateInfo(Globals.currentAcc);

            //Reopen calorie tracker
            nav nav = Globals.navRef;
            nav.calDef = null;
            object s = new object();
            EventArgs ea = new EventArgs();
            nav.calTrackButton_Click(s, ea);
            nav.cal.updateProgressBar(Globals.currentAcc);
        }
    }
}
