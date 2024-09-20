namespace fitness
{
    partial class formDashboard
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
            lblDashboardHead = new ReaLTaiizor.Controls.HeaderLabel();
            lblWeight = new ReaLTaiizor.Controls.NightLabel();
            lblGoalWeight = new ReaLTaiizor.Controls.NightLabel();
            waterProgressBar = new ReaLTaiizor.Controls.CyberProgressBar();
            sleepProgressBar = new ReaLTaiizor.Controls.CyberProgressBar();
            lblAvgSleep = new ReaLTaiizor.Controls.NightLabel();
            lblGoalSleep = new ReaLTaiizor.Controls.NightLabel();
            lblAvgWater = new ReaLTaiizor.Controls.NightLabel();
            lblGoalWater = new ReaLTaiizor.Controls.NightLabel();
            progressTowardsWeight = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            lblGoalCalories = new ReaLTaiizor.Controls.NightLabel();
            lblAverageCalories = new ReaLTaiizor.Controls.NightLabel();
            caloriesProgressBar = new ReaLTaiizor.Controls.CyberProgressBar();
            SuspendLayout();
            // 
            // lblDashboardHead
            // 
            lblDashboardHead.AutoSize = true;
            lblDashboardHead.BackColor = Color.Transparent;
            lblDashboardHead.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblDashboardHead.ForeColor = Color.FromArgb(255, 255, 255);
            lblDashboardHead.Location = new Point(75, 87);
            lblDashboardHead.Margin = new Padding(7, 0, 7, 0);
            lblDashboardHead.Name = "lblDashboardHead";
            lblDashboardHead.Size = new Size(419, 42);
            lblDashboardHead.TabIndex = 0;
            lblDashboardHead.Text = "Your Goals Dashboard";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Transparent;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeight.ForeColor = Color.FromArgb(114, 118, 127);
            lblWeight.Location = new Point(1142, 87);
            lblWeight.Margin = new Padding(7, 0, 7, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(250, 54);
            lblWeight.TabIndex = 1;
            lblWeight.Text = "Body Weight";
            lblWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGoalWeight
            // 
            lblGoalWeight.AutoSize = true;
            lblGoalWeight.BackColor = Color.Transparent;
            lblGoalWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoalWeight.ForeColor = Color.FromArgb(114, 118, 127);
            lblGoalWeight.Location = new Point(1131, 716);
            lblGoalWeight.Margin = new Padding(7, 0, 7, 0);
            lblGoalWeight.Name = "lblGoalWeight";
            lblGoalWeight.Size = new Size(261, 54);
            lblGoalWeight.TabIndex = 2;
            lblGoalWeight.Text = "Goal Weight: ";
            lblGoalWeight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // waterProgressBar
            // 
            waterProgressBar.Alpha = 50;
            waterProgressBar.BackColor = Color.Transparent;
            waterProgressBar.Background = true;
            waterProgressBar.Background_WidthPen = 3F;
            waterProgressBar.BackgroundPen = true;
            waterProgressBar.ColorBackground = Color.FromArgb(37, 52, 68);
            waterProgressBar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            waterProgressBar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            waterProgressBar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            waterProgressBar.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            waterProgressBar.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            waterProgressBar.ColorLighting = Color.FromArgb(29, 200, 238);
            waterProgressBar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            waterProgressBar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            waterProgressBar.ColorProgressBar = Color.FromArgb(29, 200, 238);
            waterProgressBar.ColorValue_Transparency = 200;
            waterProgressBar.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            waterProgressBar.Font = new Font("Arial", 11F);
            waterProgressBar.ForeColor = Color.FromArgb(245, 245, 245);
            waterProgressBar.Lighting = false;
            waterProgressBar.LinearGradient_Background = false;
            waterProgressBar.LinearGradient_Value = false;
            waterProgressBar.LinearGradientPen = false;
            waterProgressBar.Location = new Point(75, 498);
            waterProgressBar.Margin = new Padding(7, 8, 7, 8);
            waterProgressBar.Maximum = 100;
            waterProgressBar.Minimum = 0;
            waterProgressBar.Name = "waterProgressBar";
            waterProgressBar.PenWidth = 10;
            waterProgressBar.ProgressText = true;
            waterProgressBar.RGB = false;
            waterProgressBar.Rounding = true;
            waterProgressBar.RoundingInt = 70;
            waterProgressBar.Size = new Size(729, 93);
            waterProgressBar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            waterProgressBar.StartDrawingValue = 0;
            waterProgressBar.TabIndex = 4;
            waterProgressBar.Tag = "Cyber";
            waterProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            waterProgressBar.Timer_RGB = 300;
            waterProgressBar.Value = 0;
            // 
            // sleepProgressBar
            // 
            sleepProgressBar.Alpha = 50;
            sleepProgressBar.BackColor = Color.Transparent;
            sleepProgressBar.Background = true;
            sleepProgressBar.Background_WidthPen = 3F;
            sleepProgressBar.BackgroundPen = true;
            sleepProgressBar.ColorBackground = Color.FromArgb(37, 52, 68);
            sleepProgressBar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            sleepProgressBar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            sleepProgressBar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            sleepProgressBar.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            sleepProgressBar.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            sleepProgressBar.ColorLighting = Color.FromArgb(29, 200, 238);
            sleepProgressBar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            sleepProgressBar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            sleepProgressBar.ColorProgressBar = Color.FromArgb(29, 200, 238);
            sleepProgressBar.ColorValue_Transparency = 200;
            sleepProgressBar.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            sleepProgressBar.Font = new Font("Arial", 11F);
            sleepProgressBar.ForeColor = Color.FromArgb(245, 245, 245);
            sleepProgressBar.Lighting = false;
            sleepProgressBar.LinearGradient_Background = false;
            sleepProgressBar.LinearGradient_Value = false;
            sleepProgressBar.LinearGradientPen = false;
            sleepProgressBar.Location = new Point(75, 241);
            sleepProgressBar.Margin = new Padding(7, 8, 7, 8);
            sleepProgressBar.Maximum = 100;
            sleepProgressBar.Minimum = 0;
            sleepProgressBar.Name = "sleepProgressBar";
            sleepProgressBar.PenWidth = 10;
            sleepProgressBar.ProgressText = true;
            sleepProgressBar.RGB = false;
            sleepProgressBar.Rounding = true;
            sleepProgressBar.RoundingInt = 70;
            sleepProgressBar.Size = new Size(729, 93);
            sleepProgressBar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            sleepProgressBar.StartDrawingValue = 0;
            sleepProgressBar.TabIndex = 5;
            sleepProgressBar.Tag = "Cyber";
            sleepProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            sleepProgressBar.Timer_RGB = 300;
            sleepProgressBar.Value = 0;
            // 
            // lblAvgSleep
            // 
            lblAvgSleep.AutoSize = true;
            lblAvgSleep.BackColor = Color.Transparent;
            lblAvgSleep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgSleep.ForeColor = Color.FromArgb(114, 118, 127);
            lblAvgSleep.Location = new Point(102, 167);
            lblAvgSleep.Margin = new Padding(7, 0, 7, 0);
            lblAvgSleep.Name = "lblAvgSleep";
            lblAvgSleep.Size = new Size(429, 54);
            lblAvgSleep.TabIndex = 6;
            lblAvgSleep.Text = "Current Average Sleep:";
            // 
            // lblGoalSleep
            // 
            lblGoalSleep.AutoSize = true;
            lblGoalSleep.BackColor = Color.Transparent;
            lblGoalSleep.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoalSleep.ForeColor = Color.FromArgb(114, 118, 127);
            lblGoalSleep.Location = new Point(102, 342);
            lblGoalSleep.Margin = new Padding(7, 0, 7, 0);
            lblGoalSleep.Name = "lblGoalSleep";
            lblGoalSleep.Size = new Size(375, 54);
            lblGoalSleep.TabIndex = 7;
            lblGoalSleep.Text = "Goal Average Sleep:";
            // 
            // lblAvgWater
            // 
            lblAvgWater.AutoSize = true;
            lblAvgWater.BackColor = Color.Transparent;
            lblAvgWater.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvgWater.ForeColor = Color.FromArgb(114, 118, 127);
            lblAvgWater.Location = new Point(102, 430);
            lblAvgWater.Margin = new Padding(7, 0, 7, 0);
            lblAvgWater.Name = "lblAvgWater";
            lblAvgWater.Size = new Size(556, 54);
            lblAvgWater.TabIndex = 8;
            lblAvgWater.Text = "Current Average Water Intake:";
            // 
            // lblGoalWater
            // 
            lblGoalWater.AutoSize = true;
            lblGoalWater.BackColor = Color.Transparent;
            lblGoalWater.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoalWater.ForeColor = Color.FromArgb(114, 118, 127);
            lblGoalWater.Location = new Point(102, 608);
            lblGoalWater.Margin = new Padding(7, 0, 7, 0);
            lblGoalWater.Name = "lblGoalWater";
            lblGoalWater.Size = new Size(502, 54);
            lblGoalWater.TabIndex = 9;
            lblGoalWater.Text = "Goal Average Water Intake:";
            // 
            // progressTowardsWeight
            // 
            progressTowardsWeight.AnimationSpeed = 5;
            progressTowardsWeight.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            progressTowardsWeight.FilledColor = Color.FromArgb(60, 220, 210);
            progressTowardsWeight.FilledColorAlpha = 130;
            progressTowardsWeight.FilledThickness = 40;
            progressTowardsWeight.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            progressTowardsWeight.IsAnimated = false;
            progressTowardsWeight.Location = new Point(1058, 208);
            progressTowardsWeight.Margin = new Padding(7, 8, 7, 8);
            progressTowardsWeight.Name = "progressTowardsWeight";
            progressTowardsWeight.Percentage = 0;
            progressTowardsWeight.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            progressTowardsWeight.ShowText = true;
            progressTowardsWeight.Size = new Size(413, 454);
            progressTowardsWeight.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            progressTowardsWeight.TabIndex = 10;
            progressTowardsWeight.TextColor = Color.Gray;
            progressTowardsWeight.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            progressTowardsWeight.TextSize = 25;
            progressTowardsWeight.UnFilledColor = Color.FromArgb(114, 114, 114);
            progressTowardsWeight.UnfilledThickness = 24;
            // 
            // lblGoalCalories
            // 
            lblGoalCalories.AutoSize = true;
            lblGoalCalories.BackColor = Color.Transparent;
            lblGoalCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGoalCalories.ForeColor = Color.FromArgb(114, 118, 127);
            lblGoalCalories.Location = new Point(102, 890);
            lblGoalCalories.Margin = new Padding(7, 0, 7, 0);
            lblGoalCalories.Name = "lblGoalCalories";
            lblGoalCalories.Size = new Size(366, 54);
            lblGoalCalories.TabIndex = 13;
            lblGoalCalories.Text = "Goal Calorie Intake:";
            // 
            // lblAverageCalories
            // 
            lblAverageCalories.AutoSize = true;
            lblAverageCalories.BackColor = Color.Transparent;
            lblAverageCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAverageCalories.ForeColor = Color.FromArgb(114, 118, 127);
            lblAverageCalories.Location = new Point(102, 716);
            lblAverageCalories.Margin = new Padding(7, 0, 7, 0);
            lblAverageCalories.Name = "lblAverageCalories";
            lblAverageCalories.Size = new Size(430, 54);
            lblAverageCalories.TabIndex = 12;
            lblAverageCalories.Text = "Average Calorie Intake:";
            // 
            // caloriesProgressBar
            // 
            caloriesProgressBar.Alpha = 50;
            caloriesProgressBar.BackColor = Color.Transparent;
            caloriesProgressBar.Background = true;
            caloriesProgressBar.Background_WidthPen = 3F;
            caloriesProgressBar.BackgroundPen = true;
            caloriesProgressBar.ColorBackground = Color.FromArgb(37, 52, 68);
            caloriesProgressBar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            caloriesProgressBar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            caloriesProgressBar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            caloriesProgressBar.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            caloriesProgressBar.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            caloriesProgressBar.ColorLighting = Color.FromArgb(29, 200, 238);
            caloriesProgressBar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            caloriesProgressBar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            caloriesProgressBar.ColorProgressBar = Color.FromArgb(29, 200, 238);
            caloriesProgressBar.ColorValue_Transparency = 200;
            caloriesProgressBar.CyberProgressBarStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            caloriesProgressBar.Font = new Font("Arial", 11F);
            caloriesProgressBar.ForeColor = Color.FromArgb(245, 245, 245);
            caloriesProgressBar.Lighting = false;
            caloriesProgressBar.LinearGradient_Background = false;
            caloriesProgressBar.LinearGradient_Value = false;
            caloriesProgressBar.LinearGradientPen = false;
            caloriesProgressBar.Location = new Point(75, 784);
            caloriesProgressBar.Margin = new Padding(7, 8, 7, 8);
            caloriesProgressBar.Maximum = 100;
            caloriesProgressBar.Minimum = 0;
            caloriesProgressBar.Name = "caloriesProgressBar";
            caloriesProgressBar.PenWidth = 10;
            caloriesProgressBar.ProgressText = true;
            caloriesProgressBar.RGB = false;
            caloriesProgressBar.Rounding = true;
            caloriesProgressBar.RoundingInt = 70;
            caloriesProgressBar.Size = new Size(729, 93);
            caloriesProgressBar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            caloriesProgressBar.StartDrawingValue = 0;
            caloriesProgressBar.TabIndex = 11;
            caloriesProgressBar.Tag = "Cyber";
            caloriesProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            caloriesProgressBar.Timer_RGB = 300;
            caloriesProgressBar.Value = 0;
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1943, 1230);
            Controls.Add(lblGoalCalories);
            Controls.Add(lblAverageCalories);
            Controls.Add(caloriesProgressBar);
            Controls.Add(progressTowardsWeight);
            Controls.Add(lblGoalWater);
            Controls.Add(lblAvgWater);
            Controls.Add(lblGoalSleep);
            Controls.Add(lblAvgSleep);
            Controls.Add(sleepProgressBar);
            Controls.Add(waterProgressBar);
            Controls.Add(lblGoalWeight);
            Controls.Add(lblWeight);
            Controls.Add(lblDashboardHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "formDashboard";
            Text = "formDashboard";
            Load += formDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HeaderLabel lblDashboardHead;
        private ReaLTaiizor.Controls.NightLabel lblWeight;
        private ReaLTaiizor.Controls.NightLabel lblGoalWeight;
        private ReaLTaiizor.Controls.CyberProgressBar waterProgressBar;
        private ReaLTaiizor.Controls.CyberProgressBar sleepProgressBar;
        private ReaLTaiizor.Controls.NightLabel lblAvgSleep;
        private ReaLTaiizor.Controls.NightLabel lblGoalSleep;
        private ReaLTaiizor.Controls.NightLabel lblAvgWater;
        private ReaLTaiizor.Controls.NightLabel lblGoalWater;
        private ReaLTaiizor.Controls.ParrotCircleProgressBar progressTowardsWeight;
        private ReaLTaiizor.Controls.NightLabel lblGoalCalories;
        private ReaLTaiizor.Controls.NightLabel lblAverageCalories;
        private ReaLTaiizor.Controls.CyberProgressBar caloriesProgressBar;
    }
}