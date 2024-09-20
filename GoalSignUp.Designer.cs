namespace fitness
{
    partial class GoalSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoalSignUp));
            lblSetGoals = new ReaLTaiizor.Controls.NightLabel();
            goalSleepLbl = new ReaLTaiizor.Controls.NightLabel();
            goalExerciseLbl = new ReaLTaiizor.Controls.NightLabel();
            goalWeightLbl = new ReaLTaiizor.Controls.NightLabel();
            getStartedBtn = new ReaLTaiizor.Controls.ParrotSuperButton();
            goalSleep = new NumericUpDown();
            goalExercise = new NumericUpDown();
            goalWeight = new NumericUpDown();
            goalWaterLbl = new ReaLTaiizor.Controls.NightLabel();
            goalWater = new NumericUpDown();
            goalCalorieLbl = new ReaLTaiizor.Controls.NightLabel();
            goalCalorie = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)goalSleep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalExercise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalCalorie).BeginInit();
            SuspendLayout();
            // 
            // lblSetGoals
            // 
            lblSetGoals.AutoSize = true;
            lblSetGoals.BackColor = Color.Transparent;
            lblSetGoals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSetGoals.ForeColor = Color.WhiteSmoke;
            lblSetGoals.Location = new Point(500, 60);
            lblSetGoals.Margin = new Padding(7, 0, 7, 0);
            lblSetGoals.Name = "lblSetGoals";
            lblSetGoals.Size = new Size(432, 81);
            lblSetGoals.TabIndex = 1;
            lblSetGoals.Text = "Set Your Goals!";
            // 
            // goalSleepLbl
            // 
            goalSleepLbl.AutoSize = true;
            goalSleepLbl.BackColor = Color.Transparent;
            goalSleepLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalSleepLbl.ForeColor = Color.WhiteSmoke;
            goalSleepLbl.Location = new Point(58, 182);
            goalSleepLbl.Margin = new Padding(7, 0, 7, 0);
            goalSleepLbl.Name = "goalSleepLbl";
            goalSleepLbl.Size = new Size(561, 65);
            goalSleepLbl.TabIndex = 2;
            goalSleepLbl.Text = "Hours of Sleep Per Night:";
            // 
            // goalExerciseLbl
            // 
            goalExerciseLbl.AutoSize = true;
            goalExerciseLbl.BackColor = Color.Transparent;
            goalExerciseLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalExerciseLbl.ForeColor = Color.WhiteSmoke;
            goalExerciseLbl.Location = new Point(58, 340);
            goalExerciseLbl.Margin = new Padding(7, 0, 7, 0);
            goalExerciseLbl.Name = "goalExerciseLbl";
            goalExerciseLbl.Size = new Size(618, 65);
            goalExerciseLbl.TabIndex = 3;
            goalExerciseLbl.Text = "Minutes of Exercise Per Day:";
            // 
            // goalWeightLbl
            // 
            goalWeightLbl.AutoSize = true;
            goalWeightLbl.BackColor = Color.Transparent;
            goalWeightLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalWeightLbl.ForeColor = Color.WhiteSmoke;
            goalWeightLbl.Location = new Point(58, 488);
            goalWeightLbl.Margin = new Padding(7, 0, 7, 0);
            goalWeightLbl.Name = "goalWeightLbl";
            goalWeightLbl.Size = new Size(400, 65);
            goalWeightLbl.TabIndex = 4;
            goalWeightLbl.Text = "Weight Goal (lbs):";
            // 
            // getStartedBtn
            // 
            getStartedBtn.BackgroundColor = Color.FromArgb(24, 202, 142);
            getStartedBtn.ButtonImage = (Image)resources.GetObject("getStartedBtn.ButtonImage");
            getStartedBtn.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            getStartedBtn.ButtonStyle = ReaLTaiizor.Controls.ParrotSuperButton.Style.RoundedEdges;
            getStartedBtn.ButtonText = "Let's Get Started!";
            getStartedBtn.CornerRadius = 5;
            getStartedBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getStartedBtn.Horizontal_Alignment = StringAlignment.Center;
            getStartedBtn.HoverBackgroundColor = Color.FromArgb(102, 217, 174);
            getStartedBtn.HoverTextColor = Color.White;
            getStartedBtn.ImagePosition = ReaLTaiizor.Controls.ParrotSuperButton.ImgPosition.Left;
            getStartedBtn.Location = new Point(474, 1061);
            getStartedBtn.Margin = new Padding(7, 8, 7, 8);
            getStartedBtn.Name = "getStartedBtn";
            getStartedBtn.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            getStartedBtn.SelectedBackColor = Color.LimeGreen;
            getStartedBtn.SelectedTextColor = Color.White;
            getStartedBtn.Size = new Size(474, 109);
            getStartedBtn.SuperSelected = false;
            getStartedBtn.TabIndex = 5;
            getStartedBtn.TextColor = Color.White;
            getStartedBtn.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            getStartedBtn.Vertical_Alignment = StringAlignment.Center;
            getStartedBtn.Click += getStartedBtn_Click;
            // 
            // goalSleep
            // 
            goalSleep.BackColor = Color.FromArgb(32, 33, 36);
            goalSleep.BorderStyle = BorderStyle.None;
            goalSleep.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalSleep.ForeColor = SystemColors.Window;
            goalSleep.Location = new Point(620, 173);
            goalSleep.Margin = new Padding(7, 8, 7, 8);
            goalSleep.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            goalSleep.Name = "goalSleep";
            goalSleep.Size = new Size(335, 83);
            goalSleep.TabIndex = 6;
            goalSleep.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // goalExercise
            // 
            goalExercise.BackColor = Color.FromArgb(32, 33, 36);
            goalExercise.BorderStyle = BorderStyle.None;
            goalExercise.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalExercise.ForeColor = SystemColors.Info;
            goalExercise.Location = new Point(680, 336);
            goalExercise.Margin = new Padding(7, 8, 7, 8);
            goalExercise.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            goalExercise.Name = "goalExercise";
            goalExercise.Size = new Size(335, 83);
            goalExercise.TabIndex = 7;
            // 
            // goalWeight
            // 
            goalWeight.BackColor = Color.FromArgb(32, 33, 36);
            goalWeight.BorderStyle = BorderStyle.None;
            goalWeight.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalWeight.ForeColor = SystemColors.Info;
            goalWeight.Location = new Point(457, 478);
            goalWeight.Margin = new Padding(7, 8, 7, 8);
            goalWeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            goalWeight.Name = "goalWeight";
            goalWeight.Size = new Size(335, 83);
            goalWeight.TabIndex = 8;
            // 
            // goalWaterLbl
            // 
            goalWaterLbl.AutoSize = true;
            goalWaterLbl.BackColor = Color.Transparent;
            goalWaterLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalWaterLbl.ForeColor = Color.WhiteSmoke;
            goalWaterLbl.Location = new Point(58, 652);
            goalWaterLbl.Margin = new Padding(7, 0, 7, 0);
            goalWaterLbl.Name = "goalWaterLbl";
            goalWaterLbl.Size = new Size(364, 65);
            goalWaterLbl.TabIndex = 9;
            goalWaterLbl.Text = "Water Goal (oz):";
            // 
            // goalWater
            // 
            goalWater.BackColor = Color.FromArgb(32, 33, 36);
            goalWater.BorderStyle = BorderStyle.None;
            goalWater.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalWater.ForeColor = SystemColors.Info;
            goalWater.Location = new Point(438, 643);
            goalWater.Margin = new Padding(7, 8, 7, 8);
            goalWater.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            goalWater.Name = "goalWater";
            goalWater.Size = new Size(335, 83);
            goalWater.TabIndex = 10;
            // 
            // goalCalorieLbl
            // 
            goalCalorieLbl.AutoSize = true;
            goalCalorieLbl.BackColor = Color.Transparent;
            goalCalorieLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalCalorieLbl.ForeColor = Color.WhiteSmoke;
            goalCalorieLbl.Location = new Point(58, 834);
            goalCalorieLbl.Margin = new Padding(7, 0, 7, 0);
            goalCalorieLbl.Name = "goalCalorieLbl";
            goalCalorieLbl.Size = new Size(296, 65);
            goalCalorieLbl.TabIndex = 11;
            goalCalorieLbl.Text = "Calorie Goal:";
            // 
            // goalCalorie
            // 
            goalCalorie.BackColor = Color.FromArgb(32, 33, 36);
            goalCalorie.BorderStyle = BorderStyle.None;
            goalCalorie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            goalCalorie.ForeColor = SystemColors.Info;
            goalCalorie.Location = new Point(364, 827);
            goalCalorie.Margin = new Padding(7, 8, 7, 8);
            goalCalorie.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            goalCalorie.Name = "goalCalorie";
            goalCalorie.Size = new Size(335, 83);
            goalCalorie.TabIndex = 12;
            // 
            // GoalSignUp
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1452, 1323);
            Controls.Add(goalCalorie);
            Controls.Add(goalCalorieLbl);
            Controls.Add(goalWater);
            Controls.Add(goalWaterLbl);
            Controls.Add(goalWeight);
            Controls.Add(goalExercise);
            Controls.Add(goalSleep);
            Controls.Add(getStartedBtn);
            Controls.Add(goalWeightLbl);
            Controls.Add(goalExerciseLbl);
            Controls.Add(goalSleepLbl);
            Controls.Add(lblSetGoals);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "GoalSignUp";
            Text = "GoalSignUp";
            ((System.ComponentModel.ISupportInitialize)goalSleep).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalExercise).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalCalorie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightLabel lblSetGoals;
        private ReaLTaiizor.Controls.NightLabel goalSleepLbl;
        private ReaLTaiizor.Controls.NightLabel goalExerciseLbl;
        private ReaLTaiizor.Controls.NightLabel goalWeightLbl;
        private ReaLTaiizor.Controls.ParrotSuperButton getStartedBtn;
        private NumericUpDown goalSleep;
        private NumericUpDown goalExercise;
        private NumericUpDown goalWeight;
        private ReaLTaiizor.Controls.NightLabel goalWaterLbl;
        private NumericUpDown goalWater;
        private ReaLTaiizor.Controls.NightLabel goalCalorieLbl;
        private NumericUpDown goalCalorie;
    }
}