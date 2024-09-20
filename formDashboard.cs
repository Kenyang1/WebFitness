using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class formDashboard : Form
    {
        public Account acc = Globals.currentAcc;
        public formDashboard()
        {
            InitializeComponent();
            updateProgressBar(acc);
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        //M.D: Updates visual end of form with new information
        private void updateProgressBar(Account acc)
        {
            //Update water info
            decimal avgWater = acc.Wellness.AverageWater;
            decimal goalWater = acc.Wellness.WaterIntakeGoal;
            lblAvgWater.Text = "Current Average Water Intake: " + ((int)(avgWater / (decimal)29.574)).ToString() + "oz"; //ml to oz
            lblGoalWater.Text = "Goal Average Water Intake: " + ((int)(goalWater / (decimal)29.574)).ToString() + "oz";
            if (avgWater < goalWater)
            {
                waterProgressBar.Value = (int)((avgWater / goalWater) * 100);
            }
            else { waterProgressBar.Value = 100; }
            

            //Update weight info
            decimal currentWeight = (decimal)acc.Wellness.Weight;
            decimal goalWeight = (decimal)acc.Wellness.WeightGoal;
            lblWeight.Text = "Body Weight:\n" + (currentWeight * (decimal)2.205).ToString("0.00") + "lbs"; //kg to lbs
            lblGoalWeight.Text = "Goal Weight:\n" + (goalWeight * (decimal)2.205).ToString("0.00") + "lbs"; //kg to lbs
            if (currentWeight > goalWeight)
            {
                progressTowardsWeight.Percentage = (int)((goalWeight / currentWeight) * 100);
            }
            else
            {
                progressTowardsWeight.Percentage = (int)((currentWeight / goalWeight) * 100);
            }

            //Update sleep info
            decimal avgSleep = acc.Wellness.AverageSleep;
            decimal goalSleep = acc.Wellness.AmountSleepGoal;
            lblAvgSleep.Text = "Average Sleep: " + (avgSleep / 60).ToString("0.0") + " hours";
            lblGoalSleep.Text = "Goal Sleep: " + (goalSleep / 60).ToString("0.0") + " hours";
            if (avgSleep < goalSleep)
            {
                sleepProgressBar.Value = (int)((avgSleep / goalSleep) * 100);
            }
            else { sleepProgressBar.Value = 100; }

            //Update calorie info
            decimal avgCal = acc.Wellness.AverageCalories;
            decimal goalCal = acc.Wellness.CalorieIntakeGoal;
            lblAvgSleep.Text = "Average Calorie Intake: " + avgCal.ToString("0");
            lblGoalSleep.Text = "Goal Calorie Intake: " + goalCal.ToString("0");
            if (avgCal < goalCal)
            {
                caloriesProgressBar.Value = (int)((avgCal / goalCal) * 100);
            }
            else { caloriesProgressBar.Value = 100; }
            
        }
    }
}
