namespace Calorie_Tracker
{
    partial class formCalDefCalculator
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
            weightLbl = new Label();
            heightLbl = new Label();
            activityLbl = new Label();
            activityComboBox1 = new ComboBox();
            ageLbl = new Label();
            genderLbl = new Label();
            weightInput = new NumericUpDown();
            ageInput = new NumericUpDown();
            heightInput = new TextBox();
            genderInput = new ComboBox();
            calorieGoalInput = new NumericUpDown();
            calGoalInputLbl = new Label();
            pnTop = new Panel();
            extLogButton = new ReaLTaiizor.Controls.Button();
            btnCalculate = new ReaLTaiizor.Controls.CyberButton();
            enterBtn = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)weightInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ageInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)calorieGoalInput).BeginInit();
            pnTop.SuspendLayout();
            SuspendLayout();
            // 
            // weightLbl
            // 
            weightLbl.AutoSize = true;
            weightLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            weightLbl.ForeColor = Color.FromArgb(0, 192, 192);
            weightLbl.Location = new Point(65, 89);
            weightLbl.Name = "weightLbl";
            weightLbl.Size = new Size(192, 41);
            weightLbl.TabIndex = 0;
            weightLbl.Text = "Weight (lbs)";
            // 
            // heightLbl
            // 
            heightLbl.AutoSize = true;
            heightLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            heightLbl.ForeColor = Color.FromArgb(0, 192, 192);
            heightLbl.Location = new Point(378, 89);
            heightLbl.Name = "heightLbl";
            heightLbl.Size = new Size(208, 41);
            heightLbl.TabIndex = 1;
            heightLbl.Text = "Height (ft-in)";
            // 
            // activityLbl
            // 
            activityLbl.AutoSize = true;
            activityLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            activityLbl.ForeColor = Color.FromArgb(0, 192, 192);
            activityLbl.Location = new Point(757, 89);
            activityLbl.Name = "activityLbl";
            activityLbl.Size = new Size(210, 41);
            activityLbl.TabIndex = 4;
            activityLbl.Text = "Activity Label";
            activityLbl.Click += label5_Click;
            // 
            // activityComboBox1
            // 
            activityComboBox1.FormattingEnabled = true;
            activityComboBox1.Items.AddRange(new object[] { "Sedentary (Little or no exercise)", "Lightly Active (Exercise 1-3 days)", "Moderately Active (Exercise 3-5 days a week)", "Very Active (Exercise 6-7 days a week) " });
            activityComboBox1.Location = new Point(685, 161);
            activityComboBox1.Margin = new Padding(3, 4, 3, 4);
            activityComboBox1.Name = "activityComboBox1";
            activityComboBox1.Size = new Size(377, 49);
            activityComboBox1.TabIndex = 6;
            activityComboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ageLbl.ForeColor = Color.FromArgb(0, 192, 192);
            ageLbl.Location = new Point(89, 314);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(74, 41);
            ageLbl.TabIndex = 8;
            ageLbl.Text = "Age";
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            genderLbl.ForeColor = Color.FromArgb(0, 192, 192);
            genderLbl.Location = new Point(1218, 89);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(120, 41);
            genderLbl.TabIndex = 11;
            genderLbl.Text = "Gender";
            // 
            // weightInput
            // 
            weightInput.Location = new Point(74, 161);
            weightInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            weightInput.Name = "weightInput";
            weightInput.Size = new Size(148, 47);
            weightInput.TabIndex = 12;
            // 
            // ageInput
            // 
            ageInput.Location = new Point(65, 392);
            ageInput.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(148, 47);
            ageInput.TabIndex = 13;
            // 
            // heightInput
            // 
            heightInput.Location = new Point(392, 160);
            heightInput.Name = "heightInput";
            heightInput.Size = new Size(163, 47);
            heightInput.TabIndex = 14;
            heightInput.TextChanged += heightInput_TextChanged;
            // 
            // genderInput
            // 
            genderInput.FormattingEnabled = true;
            genderInput.Items.AddRange(new object[] { "Male", "Female" });
            genderInput.Location = new Point(1168, 159);
            genderInput.Margin = new Padding(3, 4, 3, 4);
            genderInput.Name = "genderInput";
            genderInput.Size = new Size(218, 49);
            genderInput.TabIndex = 15;
            // 
            // calorieGoalInput
            // 
            calorieGoalInput.Location = new Point(269, 392);
            calorieGoalInput.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            calorieGoalInput.Name = "calorieGoalInput";
            calorieGoalInput.Size = new Size(186, 47);
            calorieGoalInput.TabIndex = 16;
            // 
            // calGoalInputLbl
            // 
            calGoalInputLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            calGoalInputLbl.ForeColor = Color.FromArgb(0, 192, 192);
            calGoalInputLbl.Location = new Point(246, 274);
            calGoalInputLbl.Name = "calGoalInputLbl";
            calGoalInputLbl.Size = new Size(258, 115);
            calGoalInputLbl.TabIndex = 17;
            calGoalInputLbl.Text = "Set Caloric Intake Manually";
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(24, 25, 29);
            pnTop.Controls.Add(extLogButton);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Margin = new Padding(7, 8, 7, 8);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1545, 56);
            pnTop.TabIndex = 19;
            // 
            // extLogButton
            // 
            extLogButton.BackColor = Color.Transparent;
            extLogButton.BorderColor = Color.FromArgb(32, 34, 37);
            extLogButton.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            extLogButton.EnteredColor = Color.FromArgb(32, 34, 37);
            extLogButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extLogButton.Image = null;
            extLogButton.ImageAlign = ContentAlignment.MiddleLeft;
            extLogButton.InactiveColor = Color.FromArgb(32, 34, 37);
            extLogButton.Location = new Point(1841, 0);
            extLogButton.Margin = new Padding(7, 8, 7, 8);
            extLogButton.Name = "extLogButton";
            extLogButton.PressedBorderColor = Color.FromArgb(165, 37, 37);
            extLogButton.PressedColor = Color.FromArgb(165, 37, 37);
            extLogButton.Size = new Size(102, 90);
            extLogButton.TabIndex = 0;
            extLogButton.Text = "O";
            extLogButton.TextAlignment = StringAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.Alpha = 20;
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.Background = true;
            btnCalculate.Background_WidthPen = 4F;
            btnCalculate.BackgroundPen = true;
            btnCalculate.ColorBackground = Color.FromArgb(37, 52, 68);
            btnCalculate.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnCalculate.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCalculate.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnCalculate.ColorLighting = Color.FromArgb(29, 200, 238);
            btnCalculate.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCalculate.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCalculate.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCalculate.Effect_1 = true;
            btnCalculate.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCalculate.Effect_1_Transparency = 25;
            btnCalculate.Effect_2 = true;
            btnCalculate.Effect_2_ColorBackground = Color.White;
            btnCalculate.Effect_2_Transparency = 20;
            btnCalculate.Font = new Font("Arial Black", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.FromArgb(245, 245, 245);
            btnCalculate.Lighting = false;
            btnCalculate.LinearGradient_Background = false;
            btnCalculate.LinearGradientPen = false;
            btnCalculate.Location = new Point(541, 341);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.PenWidth = 15;
            btnCalculate.Rounding = true;
            btnCalculate.RoundingInt = 70;
            btnCalculate.Size = new Size(325, 125);
            btnCalculate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCalculate.TabIndex = 20;
            btnCalculate.Tag = "Cyber";
            btnCalculate.TextButton = "Calculate";
            btnCalculate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCalculate.Timer_Effect_1 = 5;
            btnCalculate.Timer_RGB = 300;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // enterBtn
            // 
            enterBtn.Alpha = 20;
            enterBtn.BackColor = Color.Transparent;
            enterBtn.Background = true;
            enterBtn.Background_WidthPen = 4F;
            enterBtn.BackgroundPen = true;
            enterBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            enterBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            enterBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            enterBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            enterBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            enterBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            enterBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            enterBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            enterBtn.Effect_1 = true;
            enterBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            enterBtn.Effect_1_Transparency = 25;
            enterBtn.Effect_2 = true;
            enterBtn.Effect_2_ColorBackground = Color.White;
            enterBtn.Effect_2_Transparency = 20;
            enterBtn.Font = new Font("Arial Narrow", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterBtn.ForeColor = Color.FromArgb(245, 245, 245);
            enterBtn.Lighting = false;
            enterBtn.LinearGradient_Background = false;
            enterBtn.LinearGradientPen = false;
            enterBtn.Location = new Point(269, 483);
            enterBtn.Name = "enterBtn";
            enterBtn.PenWidth = 15;
            enterBtn.Rounding = true;
            enterBtn.RoundingInt = 70;
            enterBtn.Size = new Size(169, 62);
            enterBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            enterBtn.TabIndex = 21;
            enterBtn.Tag = "Cyber";
            enterBtn.TextButton = "Enter";
            enterBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            enterBtn.Timer_Effect_1 = 5;
            enterBtn.Timer_RGB = 300;
            enterBtn.Click += enterBtn_Click;
            // 
            // formCalDefCalculator
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1545, 1217);
            Controls.Add(enterBtn);
            Controls.Add(btnCalculate);
            Controls.Add(pnTop);
            Controls.Add(calGoalInputLbl);
            Controls.Add(calorieGoalInput);
            Controls.Add(genderInput);
            Controls.Add(heightInput);
            Controls.Add(ageInput);
            Controls.Add(weightInput);
            Controls.Add(genderLbl);
            Controls.Add(ageLbl);
            Controls.Add(activityComboBox1);
            Controls.Add(activityLbl);
            Controls.Add(heightLbl);
            Controls.Add(weightLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "formCalDefCalculator";
            Text = "Caloric Deficit Calculator";
            ((System.ComponentModel.ISupportInitialize)weightInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)ageInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)calorieGoalInput).EndInit();
            pnTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label activityLbl;
        private System.Windows.Forms.ComboBox activityComboBox1;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label genderLbl;
        private NumericUpDown weightInput;
        private NumericUpDown ageInput;
        private TextBox heightInput;
        private ComboBox genderInput;
        private NumericUpDown calorieGoalInput;
        private Label calGoalInputLbl;
        private Panel pnTop;
        private ReaLTaiizor.Controls.Button extLogButton;
        private ReaLTaiizor.Controls.CyberButton btnCalculate;
        private ReaLTaiizor.Controls.CyberButton enterBtn;
    }
}

