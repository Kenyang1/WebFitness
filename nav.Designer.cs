namespace fitness
{
    partial class nav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nav));
            topPanel = new Panel();
            exitButtonNav = new Button();
            topLabel = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnProfile = new Panel();
            profileButton = new Button();
            pnDashboard = new Panel();
            dashboardButton = new Button();
            menuContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            trackers = new Button();
            panel9 = new Panel();
            waterButton = new Button();
            panel6 = new Panel();
            calTrackButton = new Button();
            panel4 = new Panel();
            exerciseTrackButton = new Button();
            sleepTrackPanel = new Panel();
            sleepTrackerButton = new Button();
            pnLogout = new Panel();
            logoutButton = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            pnProfile.SuspendLayout();
            pnDashboard.SuspendLayout();
            menuContainer.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            sleepTrackPanel.SuspendLayout();
            pnLogout.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.White;
            topPanel.Controls.Add(exitButtonNav);
            topPanel.Controls.Add(topLabel);
            topPanel.Controls.Add(btnHam);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(2096, 62);
            topPanel.TabIndex = 0;
            // 
            // exitButtonNav
            // 
            exitButtonNav.FlatAppearance.BorderSize = 0;
            exitButtonNav.FlatStyle = FlatStyle.Flat;
            exitButtonNav.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButtonNav.ForeColor = SystemColors.ActiveCaptionText;
            exitButtonNav.Location = new Point(2008, -3);
            exitButtonNav.Name = "exitButtonNav";
            exitButtonNav.Size = new Size(88, 62);
            exitButtonNav.TabIndex = 3;
            exitButtonNav.Text = "O";
            exitButtonNav.UseVisualStyleBackColor = true;
            exitButtonNav.Click += exitButtonNav_Click;
            // 
            // topLabel
            // 
            topLabel.AutoSize = true;
            topLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topLabel.Location = new Point(111, 9);
            topLabel.Name = "topLabel";
            topLabel.Size = new Size(304, 41);
            topLabel.TabIndex = 2;
            topLabel.Text = "Your Webfitness Page";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(27, 6);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(66, 50);
            btnHam.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHam.TabIndex = 1;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 25, 29);
            sidebar.Controls.Add(pnProfile);
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.ForeColor = SystemColors.ControlText;
            sidebar.Location = new Point(0, 62);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(428, 1267);
            sidebar.TabIndex = 1;
            // 
            // pnProfile
            // 
            pnProfile.Controls.Add(profileButton);
            pnProfile.Location = new Point(3, 33);
            pnProfile.Name = "pnProfile";
            pnProfile.Size = new Size(416, 94);
            pnProfile.TabIndex = 5;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.FromArgb(24, 25, 29);
            profileButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profileButton.ForeColor = Color.White;
            profileButton.Image = (Image)resources.GetObject("profileButton.Image");
            profileButton.ImageAlign = ContentAlignment.MiddleLeft;
            profileButton.Location = new Point(-15, -9);
            profileButton.Name = "profileButton";
            profileButton.Padding = new Padding(20, 0, 0, 0);
            profileButton.Size = new Size(475, 107);
            profileButton.TabIndex = 4;
            profileButton.Text = "             Profile";
            profileButton.TextAlign = ContentAlignment.MiddleLeft;
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(dashboardButton);
            pnDashboard.Location = new Point(3, 133);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(416, 94);
            pnDashboard.TabIndex = 6;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(24, 25, 29);
            dashboardButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(-13, -29);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(20, 0, 0, 0);
            dashboardButton.Size = new Size(500, 152);
            dashboardButton.TabIndex = 4;
            dashboardButton.Text = "         Goals Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(32, 33, 36);
            menuContainer.Controls.Add(panel2);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(panel4);
            menuContainer.Controls.Add(sleepTrackPanel);
            menuContainer.Location = new Point(0, 230);
            menuContainer.Margin = new Padding(0);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(415, 100);
            menuContainer.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(trackers);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 94);
            panel2.TabIndex = 10;
            // 
            // trackers
            // 
            trackers.BackColor = Color.FromArgb(24, 25, 29);
            trackers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trackers.ForeColor = Color.White;
            trackers.Image = (Image)resources.GetObject("trackers.Image");
            trackers.ImageAlign = ContentAlignment.MiddleLeft;
            trackers.Location = new Point(-5, -18);
            trackers.Name = "trackers";
            trackers.Padding = new Padding(20, 0, 0, 0);
            trackers.Size = new Size(546, 131);
            trackers.TabIndex = 4;
            trackers.Text = "             Trackers";
            trackers.TextAlign = ContentAlignment.MiddleLeft;
            trackers.UseVisualStyleBackColor = false;
            trackers.Click += trackers_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(waterButton);
            panel9.Location = new Point(3, 103);
            panel9.Name = "panel9";
            panel9.Size = new Size(416, 94);
            panel9.TabIndex = 11;
            // 
            // waterButton
            // 
            waterButton.BackColor = Color.FromArgb(24, 25, 29);
            waterButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            waterButton.ForeColor = Color.White;
            waterButton.Image = (Image)resources.GetObject("waterButton.Image");
            waterButton.ImageAlign = ContentAlignment.MiddleLeft;
            waterButton.Location = new Point(-9, -4);
            waterButton.Name = "waterButton";
            waterButton.Padding = new Padding(20, 0, 0, 0);
            waterButton.Size = new Size(457, 103);
            waterButton.TabIndex = 4;
            waterButton.Text = "             Water Tracker";
            waterButton.TextAlign = ContentAlignment.MiddleLeft;
            waterButton.UseVisualStyleBackColor = false;
            waterButton.Click += waterButton_Click_1;
            // 
            // panel6
            // 
            panel6.Controls.Add(calTrackButton);
            panel6.Location = new Point(3, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(416, 94);
            panel6.TabIndex = 12;
            // 
            // calTrackButton
            // 
            calTrackButton.BackColor = Color.FromArgb(24, 25, 29);
            calTrackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calTrackButton.ForeColor = Color.White;
            calTrackButton.Image = (Image)resources.GetObject("calTrackButton.Image");
            calTrackButton.ImageAlign = ContentAlignment.MiddleLeft;
            calTrackButton.Location = new Point(-10, -10);
            calTrackButton.Margin = new Padding(0);
            calTrackButton.Name = "calTrackButton";
            calTrackButton.Padding = new Padding(20, 0, 0, 0);
            calTrackButton.Size = new Size(524, 117);
            calTrackButton.TabIndex = 4;
            calTrackButton.Text = "             Calorie Tracker";
            calTrackButton.TextAlign = ContentAlignment.MiddleLeft;
            calTrackButton.UseVisualStyleBackColor = false;
            calTrackButton.Click += calTrackButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(exerciseTrackButton);
            panel4.Location = new Point(3, 303);
            panel4.Name = "panel4";
            panel4.Size = new Size(416, 94);
            panel4.TabIndex = 13;
            // 
            // exerciseTrackButton
            // 
            exerciseTrackButton.BackColor = Color.FromArgb(24, 25, 29);
            exerciseTrackButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exerciseTrackButton.ForeColor = Color.White;
            exerciseTrackButton.Image = (Image)resources.GetObject("exerciseTrackButton.Image");
            exerciseTrackButton.ImageAlign = ContentAlignment.MiddleLeft;
            exerciseTrackButton.Location = new Point(-17, -16);
            exerciseTrackButton.Name = "exerciseTrackButton";
            exerciseTrackButton.Padding = new Padding(20, 0, 0, 0);
            exerciseTrackButton.Size = new Size(589, 123);
            exerciseTrackButton.TabIndex = 4;
            exerciseTrackButton.Text = "              Exercise Tracker";
            exerciseTrackButton.TextAlign = ContentAlignment.MiddleLeft;
            exerciseTrackButton.UseVisualStyleBackColor = false;
            exerciseTrackButton.Click += exerciseTrackButton_Click;
            // 
            // sleepTrackPanel
            // 
            sleepTrackPanel.Controls.Add(sleepTrackerButton);
            sleepTrackPanel.Location = new Point(3, 403);
            sleepTrackPanel.Name = "sleepTrackPanel";
            sleepTrackPanel.Size = new Size(416, 94);
            sleepTrackPanel.TabIndex = 12;
            // 
            // sleepTrackerButton
            // 
            sleepTrackerButton.BackColor = Color.FromArgb(24, 25, 29);
            sleepTrackerButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sleepTrackerButton.ForeColor = Color.White;
            sleepTrackerButton.Image = (Image)resources.GetObject("sleepTrackerButton.Image");
            sleepTrackerButton.ImageAlign = ContentAlignment.MiddleLeft;
            sleepTrackerButton.Location = new Point(-15, -18);
            sleepTrackerButton.Name = "sleepTrackerButton";
            sleepTrackerButton.Padding = new Padding(20, 0, 0, 0);
            sleepTrackerButton.Size = new Size(476, 132);
            sleepTrackerButton.TabIndex = 4;
            sleepTrackerButton.Text = "             Sleep Tracker";
            sleepTrackerButton.TextAlign = ContentAlignment.MiddleLeft;
            sleepTrackerButton.UseVisualStyleBackColor = false;
            sleepTrackerButton.Click += sleepTrackerButton_Click;
            // 
            // pnLogout
            // 
            pnLogout.Controls.Add(logoutButton);
            pnLogout.Location = new Point(3, 333);
            pnLogout.Name = "pnLogout";
            pnLogout.Size = new Size(416, 94);
            pnLogout.TabIndex = 7;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(24, 25, 29);
            logoutButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(-5, -39);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(20, 0, 0, 0);
            logoutButton.Size = new Size(516, 172);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "             Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // nav
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(2096, 1329);
            Controls.Add(sidebar);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "nav";
            StartPosition = FormStartPosition.CenterScreen;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            pnProfile.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            sleepTrackPanel.ResumeLayout(false);
            pnLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private PictureBox btnHam;
        private Label topLabel;
        private FlowLayoutPanel sidebar;
        private Panel pnProfile;
        private Button profileButton;
        private Panel pnDashboard;
        private Button dashboardButton;
        private Panel pnLogout;
        private Button logoutButton;
        private FlowLayoutPanel menuContainer;
        private Panel panel2;
        private Button trackers;
        private Panel panel4;
        private Button exerciseTrackButton;
        private Panel panel6;
        private Button calTrackButton;
        private Panel panel9;
        private Button waterButton;
        private Panel sleepTrackPanel;
        private Button sleepTrackerButton;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button exitButtonNav;
    }
}