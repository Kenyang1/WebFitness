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
    public partial class formWorkoutVideos : Form
    {
        public formWorkoutVideos()
        {
            InitializeComponent();
        }

        private void watchVideoBtn_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/9FBIaqr7TjQ?si=LOLbmouA22zOa_Y2",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn2_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtube.com/playlist?list=PLx1BpimlFJq02VJMBbTE1wgQJnRiL5ovx&si=m9BJrgExjYfeZ_m3",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn3_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/3IQVNjWH60A?si=1Tr9c-4C84mB0Ax0",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn4_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/7-zjc6dAufg?si=_H9Lf2feh9076v5k",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn5_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/Eml2xnoLpYE?si=glFLi5A39ssjp2gH",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn6_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/i-NAonI5aBU?si=Xcyprgb_0tFe6RNt",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn7_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/__uIuGojJU4?si=KPcyUVX27_eSSJfY",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn8_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/DI7N6819fNk?si=z1qQsEHyqdUDdmHK",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }

        private void watchVideoBtn9_Click(object sender, EventArgs e)
        {
            {
                // Create a new ProcessStartInfo
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "https://youtu.be/5Q4ewnHMNW8?si=e9vxxVs19M4SGJUr",
                    UseShellExecute = true
                };

                // Start the process
                System.Diagnostics.Process.Start(startInfo);
            }
        }
    }
}
