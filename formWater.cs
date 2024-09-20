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
    public partial class formWater : Form
    {
        Account acc = Globals.currentAcc;

        public formWater()
        {
            InitializeComponent();
            updateProgressBar(acc);
        }

        private void formWater_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        //M.D: Updates visual end of form with new information
        public void updateProgressBar(Account acc)
        {
            totalWaterIntakeLbl.Text = "Total Water Intake: " + ((int)(acc.Wellness.WaterIntake / 29.574)).ToString();
        }

        //J.P
        private void btnAddWater_Click(object sender, EventArgs e)
        {
            if (int.TryParse(waterInput.Text, out int waterAmount))
            {
                if (waterAmount > 0)
                {
                    //M.D
                    acc.Wellness.WaterIntake += (int)(waterAmount * 29.574); //oz to ml
                    Globals.updateInfo(acc);
                    updateProgressBar(acc);
                }
                else
                {
                    MessageBox.Show("Please enter a valid amount of water.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        //K.L: Preset buttons
        private void waterIntake(int amount)
        {
            if (amount > 0)
            {
                acc.Wellness.WaterIntake += (int)(amount * 29.574); //oz to ml
                Globals.updateInfo(acc);
                updateProgressBar(acc);
            }
        }
        private void btn6oz_Click(object sender, EventArgs e)
        {
            waterIntake(6);
        }
        private void btn8oz_Click(object sender, EventArgs e)
        {
            waterIntake(8);
        }
        private void btn16oz_Click(object sender, EventArgs e)
        {
            waterIntake(16);
        }
        private void btn32oz_Click(object sender, EventArgs e)
        {
            waterIntake(32);
            // Water Intake
        }

        //M.D: Resets water intake to 0 and adds an entry to the water tracking list
        private void endDayBtn_Click(object sender, EventArgs e)
        {
            acc.Wellness.WaterTracking.Add(acc.Wellness.WaterIntake);
            Globals.updateInfo(acc);
            acc.Wellness.WaterIntake = 0;
            Globals.updateInfo(acc);
            updateProgressBar(acc);
        }
    }
}
