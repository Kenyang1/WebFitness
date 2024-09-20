using Calorie_Tracker;
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
    public partial class nav : Form
    {
        //initializing forms
            formDashboard dashboard;
            public formCal cal;
            public formCalDefCalculator calDef;
            formSleep sleep;
            formExercise exercise;
            formWater water;
            formProfile profile;

        public nav()
        {
            InitializeComponent();
            mdiProp();
        }
        bool menuExpand = false;
        private void mdiProp()
        {
            /*this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);*/
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 512)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 96)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void trackers_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 56)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    pnProfile.Width = sidebar.Width;

                    menuContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 428)
                {
                    sidebarExpand = true; sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    pnProfile.Width = sidebar.Width;

                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void exitNavButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profile = new formProfile();
            profile.FormClosed += Profile_FormClosed;
            profile.MdiParent = this;
            profile.Dock = DockStyle.Fill;
            profile.Show();
        }

        private void Profile_FormClosed(object? sender, FormClosedEventArgs e)
        {
            profile = null;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dashboard = new formDashboard();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.MdiParent = this;
            dashboard.Dock = DockStyle.Fill;
            dashboard.Show();    
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void exerciseTrackButton_Click(object sender, EventArgs e)
        {
            exercise = new formExercise();
            exercise.FormClosed += Exercise_FormClosed;
            exercise.MdiParent = this;
            exercise.Dock = DockStyle.Fill;
            exercise.Show();
        }

        private void Exercise_FormClosed(object? sender, FormClosedEventArgs e)
        {
            exercise = null;
        }

        private void sleepTrackerButton_Click(object sender, EventArgs e)
        {
            sleep = new formSleep();
            sleep.FormClosed += Sleep_FormClosed;
            sleep.MdiParent = this;
            sleep.Dock = DockStyle.Fill;
            sleep.Show();
        }

        private void Sleep_FormClosed(object? sender, FormClosedEventArgs e)
        {
            sleep = null;
        }

        public void calTrackButton_Click(object sender, EventArgs e)
        {
            cal = new formCal();
            cal.FormClosed += Cal_FormClosed;
            cal.MdiParent = this;
            cal.Dock = DockStyle.Fill;
            cal.Show();
        }

        public void calDefCalc_Open()
        { 
            calDef = new formCalDefCalculator();
            calDef.FormClosed += CalDef_FormClosed;
            calDef.MdiParent = this;
            calDef.Dock = DockStyle.Fill;
            calDef.Show();
        }

        public void CalDef_FormClosed(object? sender, FormClosedEventArgs e)
        {
            calDef = null;
        }

        private void Cal_FormClosed(object? sender, FormClosedEventArgs e)
        {
            cal = null;
        }

        private void waterButton_Click(object sender, EventArgs e)
        { 
            water = new formWater();
            water.FormClosed += Water_FormClosed;
            water.MdiParent = this;
            water.Dock = DockStyle.Fill;
            water.Show();
        }

        private void Water_FormClosed(object? sender, FormClosedEventArgs e)
        {
            water = null;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            login lgn = new login();
            lgn.ShowDialog();
        }

        private void exitButtonNav_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void waterButton_Click_1(object sender, EventArgs e)
        {
            water = new formWater();
            water.FormClosed += Water_FormClosed;
            water.MdiParent = this;
            water.Dock = DockStyle.Fill;
            water.Show();
        }
    }
}
