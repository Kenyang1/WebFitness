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

namespace fitness
{
    public partial class GoalSignUp : Form
    {
        public Account acc;

        public GoalSignUp(Account a)
        {
            InitializeComponent();
            acc = a;

            //M.D: Set default values of input fields to reccomendations
            goalWeight.Value = (decimal)(acc.Wellness.Weight * 2.205); //kg to lbs
            goalSleep.Value = (acc.Wellness.AmountSleepGoal / 60); //min to hrs
            goalExercise.Value = (decimal)acc.Wellness.ExerciseGoal;
            goalCalorie.Value = (decimal)acc.Wellness.CalorieIntakeGoal;
            goalWater.Value = (decimal)(acc.Wellness.WaterIntakeGoal / 29.574); //ml to oz
        }

        //A.S
        private void getStartedBtn_Click(object sender, EventArgs e)
        {
            float weightGoal = (float)goalWeight.Value;
            int sleepGoal = (int)goalSleep.Value;
            int exerciseGoal = (int)goalExercise.Value;
            int calorieGoal = (int)goalCalorie.Value;
            int waterGoal = (int)goalWater.Value;

            acc.Wellness.WeightGoal = (float)(weightGoal / 2.205); //lbs to kg
            acc.Wellness.AmountSleepGoal = sleepGoal * 60;
            acc.Wellness.ExerciseGoal = exerciseGoal;
            acc.Wellness.CalorieIntakeGoal = calorieGoal;
            acc.Wellness.WaterIntakeGoal = (int)(waterGoal * 29.574); //oz to ml

            Globals.updateInfo(acc);

            login lg = new login();
            this.Close();
            lg.Show();
        }
    }
}
