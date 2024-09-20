//using Calorie_Tracker;
using Calorie_Tracker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    public partial class formCal : Form
    {
        private Account acc = Globals.currentAcc;
        public formCal()
        {
            InitializeComponent();
            updateProgressBar(Globals.currentAcc);
        }

        private void formCal_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void enterCalButton_Click(object sender, EventArgs e)
        {
            //M.D: Adds inputted calories
            Globals.currentAcc.Wellness.CalorieIntake += Convert.ToInt32(calInputTextBox.Value);
            updateProgressBar(Globals.currentAcc);
            Globals.updateInfo(Globals.currentAcc);

            calInputTextBox.Value = 0;
        }

        //M.D
        public void updateProgressBar(Account acc)
        {
            decimal calGoal = acc.Wellness.CalorieIntakeGoal;
            decimal currentCals = acc.Wellness.CalorieIntake;
            decimal percent = (currentCals / calGoal) * 100;

            //Add whitespace to keep numerator label centered
            var strCals = new StringBuilder();
            for (int i = 0; i < (4 - currentCals.ToString().Length); i++)
            {
                strCals.Append(" ");
            }
            strCals.Append(currentCals.ToString());

            //Updates progress bar
            calIntakeProgressBar.Value = (long)Convert.ToDouble(percent);
            calIntakeProgressLabelTop.Text = strCals.ToString();
            calIntakeProgressLabelBottom.Text = calGoal.ToString();

            //If calorie intake exceeds goal
            if (currentCals > calGoal)
            {
                calIntakeProgressBar.ProgressColor2 = Color.Red;
                totalCalIntake.ForeColor = Color.Red;
            }


            //Updates goals and total calorie labels
            goalCalIntake.Text = acc.Wellness.CalorieIntakeGoal.ToString();
            totalCalIntake.Text = acc.Wellness.CalorieIntake.ToString();
        }

        //M.D
        private void calDefButton_Click(object sender, EventArgs e)
        {
            //Opens calorie deficit calculator
            nav nav = Globals.navRef;
            nav.calTrackButton_Click(sender, e);
            nav.calDefCalc_Open();
        }

        //M.D and K.L
        private void presetBtn_Click(object sender, EventArgs e)
        {
            ReaLTaiizor.Controls.CyberButton button = sender as ReaLTaiizor.Controls.CyberButton;
            Account acc = Globals.currentAcc;
            acc.Wellness.CalorieIntake += Int32.Parse(button.TextButton);
            Globals.updateInfo(acc);
            updateProgressBar(acc);
        }

        private void endDayBtn_Click(object sender, EventArgs e)
        {
            acc.Wellness.CalorieTracking.Add(acc.Wellness.CalorieIntake);
            Globals.updateInfo(acc);
            acc.Wellness.CalorieIntake = 0;
            Globals.updateInfo(acc);
            updateProgressBar(acc);

            calIntakeProgressBar.ProgressColor2 = Color.MediumTurquoise;
            totalCalIntake.ForeColor = Color.MediumTurquoise;
        }
    }
}



