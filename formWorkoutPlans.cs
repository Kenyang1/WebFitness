using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//All written by K.L
namespace fitness
{
    public partial class formWorkoutPlans : Form
    {
        public formWorkoutPlans()
        {
            InitializeComponent();
        }

        private void viewPDFBtn_Click(object sender, EventArgs e)
        {
            // Create a new ProcessStartInfo
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "https://www.setforset.com/blogs/news/full-body-workout-plan",
                UseShellExecute = true
            };

            // Start the process
            System.Diagnostics.Process.Start(startInfo);
        }

        private void viewPDF2_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://www.muscleandstrength.com/sites/default/files/workouts/6daypushpulllegsplanetfitnessworkout.pdf",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void viewPDFBtn3_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://www.muscleandstrength.com/workouts/upper-lower-4-day-gym-bodybuilding-workout",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void viewPDFBtn6_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://darebee.com/pdf/programs/30-days-of-yoga.pdf",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void viewPDFBtn4_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://darebee.com/pdf/workouts/impossible-cardio-workout.pdf",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void viewPDFBtn5_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "file:///C:/Users/kenya/Downloads/justin%20pichardo%20split.jpg",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }
    }
}
