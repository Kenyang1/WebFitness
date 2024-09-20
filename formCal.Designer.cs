namespace fitness
{
    partial class formCal
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
            lblCalHead = new ReaLTaiizor.Controls.NightLabel();
            maxIntakeLabel = new ReaLTaiizor.Controls.FoxLabel();
            todayCalLabel = new ReaLTaiizor.Controls.FoxLabel();
            calIntakeProgressBar = new ReaLTaiizor.Controls.CircleProgressBar();
            lblImport = new ReaLTaiizor.Controls.FoxLabel();
            lblPreset = new ReaLTaiizor.Controls.FoxLabel();
            btn100Cal = new ReaLTaiizor.Controls.CyberButton();
            btn200Cal = new ReaLTaiizor.Controls.CyberButton();
            btn500Cal = new ReaLTaiizor.Controls.CyberButton();
            btn1000Cal = new ReaLTaiizor.Controls.CyberButton();
            btn300Cal = new ReaLTaiizor.Controls.CyberButton();
            btn600Cal = new ReaLTaiizor.Controls.CyberButton();
            calInput = new ReaLTaiizor.Controls.CyberTextBox();
            goalCalIntake = new ReaLTaiizor.Controls.NightLabel();
            totalCalIntake = new ReaLTaiizor.Controls.NightLabel();
            calInputTextBox = new NumericUpDown();
            enterCalButton = new ReaLTaiizor.Controls.CyberButton();
            calIntakeProgressLabelTop = new Label();
            calIntakeProgressLabelBottom = new Label();
            fractionLine = new Label();
            calDefButton = new ReaLTaiizor.Controls.CyberButton();
            endDayBtn = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)calInputTextBox).BeginInit();
            SuspendLayout();
            // 
            // lblCalHead
            // 
            lblCalHead.AutoSize = true;
            lblCalHead.BackColor = Color.Transparent;
            lblCalHead.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalHead.ForeColor = Color.WhiteSmoke;
            lblCalHead.Location = new Point(73, 79);
            lblCalHead.Margin = new Padding(7, 0, 7, 0);
            lblCalHead.Name = "lblCalHead";
            lblCalHead.Size = new Size(424, 81);
            lblCalHead.TabIndex = 0;
            lblCalHead.Text = "Calorie Tracker";
            // 
            // maxIntakeLabel
            // 
            maxIntakeLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maxIntakeLabel.ForeColor = Color.FromArgb(0, 192, 192);
            maxIntakeLabel.Location = new Point(656, 279);
            maxIntakeLabel.Margin = new Padding(7, 8, 7, 8);
            maxIntakeLabel.Name = "maxIntakeLabel";
            maxIntakeLabel.Size = new Size(510, 90);
            maxIntakeLabel.TabIndex = 1;
            maxIntakeLabel.Text = "Daily calorie goal:";
            // 
            // todayCalLabel
            // 
            todayCalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            todayCalLabel.ForeColor = Color.FromArgb(0, 192, 192);
            todayCalLabel.Location = new Point(656, 497);
            todayCalLabel.Margin = new Padding(7, 8, 7, 8);
            todayCalLabel.Name = "todayCalLabel";
            todayCalLabel.Size = new Size(510, 90);
            todayCalLabel.TabIndex = 3;
            todayCalLabel.Text = "Today's calorie intake:";
            // 
            // calIntakeProgressBar
            // 
            calIntakeProgressBar.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calIntakeProgressBar.Location = new Point(29, 200);
            calIntakeProgressBar.Margin = new Padding(7, 8, 7, 8);
            calIntakeProgressBar.Maximum = 100L;
            calIntakeProgressBar.MinimumSize = new Size(243, 273);
            calIntakeProgressBar.Name = "calIntakeProgressBar";
            calIntakeProgressBar.PercentColor = Color.White;
            calIntakeProgressBar.ProgressColor1 = Color.FromArgb(92, 92, 92);
            calIntakeProgressBar.ProgressColor2 = Color.Teal;
            calIntakeProgressBar.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            calIntakeProgressBar.Size = new Size(582, 582);
            calIntakeProgressBar.TabIndex = 4;
            calIntakeProgressBar.Value = 0L;
            // 
            // lblImport
            // 
            lblImport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImport.ForeColor = Color.FromArgb(0, 192, 192);
            lblImport.Location = new Point(29, 763);
            lblImport.Margin = new Padding(7, 8, 7, 8);
            lblImport.Name = "lblImport";
            lblImport.Size = new Size(182, 90);
            lblImport.TabIndex = 5;
            lblImport.Text = "Input:";
            // 
            // lblPreset
            // 
            lblPreset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreset.ForeColor = Color.FromArgb(0, 192, 192);
            lblPreset.Location = new Point(510, 763);
            lblPreset.Margin = new Padding(7, 8, 7, 8);
            lblPreset.Name = "lblPreset";
            lblPreset.Size = new Size(420, 90);
            lblPreset.TabIndex = 6;
            lblPreset.Text = "Presets:";
            // 
            // btn100Cal
            // 
            btn100Cal.Alpha = 20;
            btn100Cal.BackColor = Color.Transparent;
            btn100Cal.Background = true;
            btn100Cal.Background_WidthPen = 4F;
            btn100Cal.BackgroundPen = true;
            btn100Cal.ColorBackground = Color.FromArgb(37, 52, 68);
            btn100Cal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn100Cal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn100Cal.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn100Cal.ColorLighting = Color.FromArgb(29, 200, 238);
            btn100Cal.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn100Cal.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn100Cal.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn100Cal.Effect_1 = true;
            btn100Cal.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn100Cal.Effect_1_Transparency = 25;
            btn100Cal.Effect_2 = true;
            btn100Cal.Effect_2_ColorBackground = Color.White;
            btn100Cal.Effect_2_Transparency = 20;
            btn100Cal.Font = new Font("Arial", 11F);
            btn100Cal.ForeColor = Color.FromArgb(245, 245, 245);
            btn100Cal.Lighting = false;
            btn100Cal.LinearGradient_Background = false;
            btn100Cal.LinearGradientPen = false;
            btn100Cal.Location = new Point(510, 907);
            btn100Cal.Margin = new Padding(7, 8, 7, 8);
            btn100Cal.Name = "btn100Cal";
            btn100Cal.PenWidth = 15;
            btn100Cal.Rounding = true;
            btn100Cal.RoundingInt = 70;
            btn100Cal.Size = new Size(153, 137);
            btn100Cal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn100Cal.TabIndex = 12;
            btn100Cal.Tag = "Cyber";
            btn100Cal.TextButton = "100";
            btn100Cal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn100Cal.Timer_Effect_1 = 5;
            btn100Cal.Timer_RGB = 300;
            btn100Cal.Click += presetBtn_Click;
            // 
            // btn200Cal
            // 
            btn200Cal.Alpha = 20;
            btn200Cal.BackColor = Color.Transparent;
            btn200Cal.Background = true;
            btn200Cal.Background_WidthPen = 4F;
            btn200Cal.BackgroundPen = true;
            btn200Cal.ColorBackground = Color.FromArgb(37, 52, 68);
            btn200Cal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn200Cal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn200Cal.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn200Cal.ColorLighting = Color.FromArgb(29, 200, 238);
            btn200Cal.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn200Cal.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn200Cal.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn200Cal.Effect_1 = true;
            btn200Cal.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn200Cal.Effect_1_Transparency = 25;
            btn200Cal.Effect_2 = true;
            btn200Cal.Effect_2_ColorBackground = Color.White;
            btn200Cal.Effect_2_Transparency = 20;
            btn200Cal.Font = new Font("Arial", 11F);
            btn200Cal.ForeColor = Color.FromArgb(245, 245, 245);
            btn200Cal.Lighting = false;
            btn200Cal.LinearGradient_Background = false;
            btn200Cal.LinearGradientPen = false;
            btn200Cal.Location = new Point(712, 907);
            btn200Cal.Margin = new Padding(7, 8, 7, 8);
            btn200Cal.Name = "btn200Cal";
            btn200Cal.PenWidth = 15;
            btn200Cal.Rounding = true;
            btn200Cal.RoundingInt = 70;
            btn200Cal.Size = new Size(153, 137);
            btn200Cal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn200Cal.TabIndex = 13;
            btn200Cal.Tag = "Cyber";
            btn200Cal.TextButton = "200";
            btn200Cal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn200Cal.Timer_Effect_1 = 5;
            btn200Cal.Timer_RGB = 300;
            btn200Cal.Click += presetBtn_Click;
            // 
            // btn500Cal
            // 
            btn500Cal.Alpha = 20;
            btn500Cal.BackColor = Color.Transparent;
            btn500Cal.Background = true;
            btn500Cal.Background_WidthPen = 4F;
            btn500Cal.BackgroundPen = true;
            btn500Cal.ColorBackground = Color.FromArgb(37, 52, 68);
            btn500Cal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn500Cal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn500Cal.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn500Cal.ColorLighting = Color.FromArgb(29, 200, 238);
            btn500Cal.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn500Cal.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn500Cal.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn500Cal.Effect_1 = true;
            btn500Cal.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn500Cal.Effect_1_Transparency = 25;
            btn500Cal.Effect_2 = true;
            btn500Cal.Effect_2_ColorBackground = Color.White;
            btn500Cal.Effect_2_Transparency = 20;
            btn500Cal.Font = new Font("Arial", 11F);
            btn500Cal.ForeColor = Color.FromArgb(245, 245, 245);
            btn500Cal.Lighting = false;
            btn500Cal.LinearGradient_Background = false;
            btn500Cal.LinearGradientPen = false;
            btn500Cal.Location = new Point(510, 1061);
            btn500Cal.Margin = new Padding(7, 8, 7, 8);
            btn500Cal.Name = "btn500Cal";
            btn500Cal.PenWidth = 15;
            btn500Cal.Rounding = true;
            btn500Cal.RoundingInt = 70;
            btn500Cal.Size = new Size(153, 137);
            btn500Cal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn500Cal.TabIndex = 14;
            btn500Cal.Tag = "Cyber";
            btn500Cal.TextButton = "500";
            btn500Cal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn500Cal.Timer_Effect_1 = 5;
            btn500Cal.Timer_RGB = 300;
            btn500Cal.Click += presetBtn_Click;
            // 
            // btn1000Cal
            // 
            btn1000Cal.Alpha = 20;
            btn1000Cal.BackColor = Color.Transparent;
            btn1000Cal.Background = true;
            btn1000Cal.Background_WidthPen = 4F;
            btn1000Cal.BackgroundPen = true;
            btn1000Cal.ColorBackground = Color.FromArgb(37, 52, 68);
            btn1000Cal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn1000Cal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn1000Cal.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn1000Cal.ColorLighting = Color.FromArgb(29, 200, 238);
            btn1000Cal.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn1000Cal.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn1000Cal.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn1000Cal.Effect_1 = true;
            btn1000Cal.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn1000Cal.Effect_1_Transparency = 25;
            btn1000Cal.Effect_2 = true;
            btn1000Cal.Effect_2_ColorBackground = Color.White;
            btn1000Cal.Effect_2_Transparency = 20;
            btn1000Cal.Font = new Font("Arial", 11F);
            btn1000Cal.ForeColor = Color.FromArgb(245, 245, 245);
            btn1000Cal.Lighting = false;
            btn1000Cal.LinearGradient_Background = false;
            btn1000Cal.LinearGradientPen = false;
            btn1000Cal.Location = new Point(906, 1061);
            btn1000Cal.Margin = new Padding(7, 8, 7, 8);
            btn1000Cal.Name = "btn1000Cal";
            btn1000Cal.PenWidth = 15;
            btn1000Cal.Rounding = true;
            btn1000Cal.RoundingInt = 70;
            btn1000Cal.Size = new Size(148, 137);
            btn1000Cal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn1000Cal.TabIndex = 15;
            btn1000Cal.Tag = "Cyber";
            btn1000Cal.TextButton = "1000";
            btn1000Cal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn1000Cal.Timer_Effect_1 = 5;
            btn1000Cal.Timer_RGB = 300;
            btn1000Cal.Click += presetBtn_Click;
            // 
            // btn300Cal
            // 
            btn300Cal.Alpha = 20;
            btn300Cal.BackColor = Color.Transparent;
            btn300Cal.Background = true;
            btn300Cal.Background_WidthPen = 4F;
            btn300Cal.BackgroundPen = true;
            btn300Cal.ColorBackground = Color.FromArgb(37, 52, 68);
            btn300Cal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn300Cal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn300Cal.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn300Cal.ColorLighting = Color.FromArgb(29, 200, 238);
            btn300Cal.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn300Cal.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn300Cal.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn300Cal.Effect_1 = true;
            btn300Cal.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn300Cal.Effect_1_Transparency = 25;
            btn300Cal.Effect_2 = true;
            btn300Cal.Effect_2_ColorBackground = Color.White;
            btn300Cal.Effect_2_Transparency = 20;
            btn300Cal.Font = new Font("Arial", 11F);
            btn300Cal.ForeColor = Color.FromArgb(245, 245, 245);
            btn300Cal.Lighting = false;
            btn300Cal.LinearGradient_Background = false;
            btn300Cal.LinearGradientPen = false;
            btn300Cal.Location = new Point(906, 907);
            btn300Cal.Margin = new Padding(7, 8, 7, 8);
            btn300Cal.Name = "btn300Cal";
            btn300Cal.PenWidth = 15;
            btn300Cal.Rounding = true;
            btn300Cal.RoundingInt = 70;
            btn300Cal.Size = new Size(148, 137);
            btn300Cal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn300Cal.TabIndex = 16;
            btn300Cal.Tag = "Cyber";
            btn300Cal.TextButton = "300";
            btn300Cal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn300Cal.Timer_Effect_1 = 5;
            btn300Cal.Timer_RGB = 300;
            btn300Cal.Click += presetBtn_Click;
            // 
            // btn600Cal
            // 
            btn600Cal.Alpha = 20;
            btn600Cal.BackColor = Color.Transparent;
            btn600Cal.Background = true;
            btn600Cal.Background_WidthPen = 4F;
            btn600Cal.BackgroundPen = true;
            btn600Cal.ColorBackground = Color.FromArgb(37, 52, 68);
            btn600Cal.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btn600Cal.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btn600Cal.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btn600Cal.ColorLighting = Color.FromArgb(29, 200, 238);
            btn600Cal.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btn600Cal.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btn600Cal.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btn600Cal.Effect_1 = true;
            btn600Cal.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btn600Cal.Effect_1_Transparency = 25;
            btn600Cal.Effect_2 = true;
            btn600Cal.Effect_2_ColorBackground = Color.White;
            btn600Cal.Effect_2_Transparency = 20;
            btn600Cal.Font = new Font("Arial", 11F);
            btn600Cal.ForeColor = Color.FromArgb(245, 245, 245);
            btn600Cal.Lighting = false;
            btn600Cal.LinearGradient_Background = false;
            btn600Cal.LinearGradientPen = false;
            btn600Cal.Location = new Point(712, 1061);
            btn600Cal.Margin = new Padding(7, 8, 7, 8);
            btn600Cal.Name = "btn600Cal";
            btn600Cal.PenWidth = 15;
            btn600Cal.Rounding = true;
            btn600Cal.RoundingInt = 70;
            btn600Cal.Size = new Size(153, 137);
            btn600Cal.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btn600Cal.TabIndex = 17;
            btn600Cal.Tag = "Cyber";
            btn600Cal.TextButton = "600";
            btn600Cal.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btn600Cal.Timer_Effect_1 = 5;
            btn600Cal.Timer_RGB = 300;
            btn600Cal.Click += presetBtn_Click;
            // 
            // calInput
            // 
            calInput.Alpha = 20;
            calInput.BackColor = Color.Transparent;
            calInput.Background_WidthPen = 3F;
            calInput.BackgroundPen = true;
            calInput.ColorBackground = Color.FromArgb(37, 52, 68);
            calInput.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            calInput.ColorLighting = Color.FromArgb(29, 200, 238);
            calInput.ColorPen_1 = Color.FromArgb(29, 200, 238);
            calInput.ColorPen_2 = Color.FromArgb(37, 52, 68);
            calInput.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            calInput.Font = new Font("Arial", 27F);
            calInput.ForeColor = Color.FromArgb(245, 245, 245);
            calInput.Lighting = false;
            calInput.LinearGradientPen = false;
            calInput.Location = new Point(70, 2375);
            calInput.Margin = new Padding(17, 22, 17, 22);
            calInput.Name = "calInput";
            calInput.PenWidth = 15;
            calInput.RGB = false;
            calInput.Rounding = true;
            calInput.RoundingInt = 60;
            calInput.Size = new Size(821, 298);
            calInput.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            calInput.TabIndex = 18;
            calInput.Tag = "Cyber";
            calInput.TextButton = "";
            calInput.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            calInput.Timer_RGB = 300;
            // 
            // goalCalIntake
            // 
            goalCalIntake.AutoSize = true;
            goalCalIntake.BackColor = Color.Transparent;
            goalCalIntake.Font = new Font("Segoe UI", 18F);
            goalCalIntake.ForeColor = Color.WhiteSmoke;
            goalCalIntake.Location = new Point(656, 383);
            goalCalIntake.Margin = new Padding(7, 0, 7, 0);
            goalCalIntake.Name = "goalCalIntake";
            goalCalIntake.Size = new Size(266, 81);
            goalCalIntake.TabIndex = 19;
            goalCalIntake.Text = "MAXCAL";
            // 
            // totalCalIntake
            // 
            totalCalIntake.AutoSize = true;
            totalCalIntake.BackColor = Color.Transparent;
            totalCalIntake.Font = new Font("Segoe UI", 18F);
            totalCalIntake.ForeColor = Color.WhiteSmoke;
            totalCalIntake.Location = new Point(656, 596);
            totalCalIntake.Margin = new Padding(7, 0, 7, 0);
            totalCalIntake.Name = "totalCalIntake";
            totalCalIntake.Size = new Size(301, 81);
            totalCalIntake.TabIndex = 20;
            totalCalIntake.Text = "TOTALCAL";
            // 
            // calInputTextBox
            // 
            calInputTextBox.BackColor = Color.FromArgb(32, 33, 36);
            calInputTextBox.BorderStyle = BorderStyle.None;
            calInputTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calInputTextBox.ForeColor = SystemColors.Info;
            calInputTextBox.Location = new Point(49, 861);
            calInputTextBox.Margin = new Padding(0);
            calInputTextBox.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            calInputTextBox.Name = "calInputTextBox";
            calInputTextBox.Size = new Size(308, 57);
            calInputTextBox.TabIndex = 21;
            // 
            // enterCalButton
            // 
            enterCalButton.Alpha = 20;
            enterCalButton.BackColor = Color.Transparent;
            enterCalButton.Background = true;
            enterCalButton.Background_WidthPen = 4F;
            enterCalButton.BackgroundPen = true;
            enterCalButton.ColorBackground = Color.FromArgb(37, 52, 68);
            enterCalButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            enterCalButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            enterCalButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            enterCalButton.ColorLighting = Color.FromArgb(29, 200, 238);
            enterCalButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            enterCalButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            enterCalButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            enterCalButton.Effect_1 = true;
            enterCalButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            enterCalButton.Effect_1_Transparency = 25;
            enterCalButton.Effect_2 = true;
            enterCalButton.Effect_2_ColorBackground = Color.White;
            enterCalButton.Effect_2_Transparency = 20;
            enterCalButton.Font = new Font("Arial", 11F);
            enterCalButton.ForeColor = Color.FromArgb(245, 245, 245);
            enterCalButton.Lighting = false;
            enterCalButton.LinearGradient_Background = false;
            enterCalButton.LinearGradientPen = false;
            enterCalButton.Location = new Point(73, 987);
            enterCalButton.Margin = new Padding(2, 3, 2, 3);
            enterCalButton.Name = "enterCalButton";
            enterCalButton.PenWidth = 15;
            enterCalButton.Rounding = true;
            enterCalButton.RoundingInt = 70;
            enterCalButton.Size = new Size(216, 131);
            enterCalButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            enterCalButton.TabIndex = 22;
            enterCalButton.Tag = "Cyber";
            enterCalButton.TextButton = "Enter";
            enterCalButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            enterCalButton.Timer_Effect_1 = 5;
            enterCalButton.Timer_RGB = 300;
            enterCalButton.Click += enterCalButton_Click;
            // 
            // calIntakeProgressLabelTop
            // 
            calIntakeProgressLabelTop.AutoSize = true;
            calIntakeProgressLabelTop.BackColor = Color.FromArgb(53, 53, 53);
            calIntakeProgressLabelTop.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calIntakeProgressLabelTop.ForeColor = Color.MediumTurquoise;
            calIntakeProgressLabelTop.Location = new Point(237, 404);
            calIntakeProgressLabelTop.Margin = new Padding(2, 0, 2, 0);
            calIntakeProgressLabelTop.Name = "calIntakeProgressLabelTop";
            calIntakeProgressLabelTop.Size = new Size(167, 81);
            calIntakeProgressLabelTop.TabIndex = 23;
            calIntakeProgressLabelTop.Text = "0000";
            calIntakeProgressLabelTop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calIntakeProgressLabelBottom
            // 
            calIntakeProgressLabelBottom.AutoSize = true;
            calIntakeProgressLabelBottom.BackColor = Color.FromArgb(53, 53, 53);
            calIntakeProgressLabelBottom.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calIntakeProgressLabelBottom.ForeColor = Color.MediumTurquoise;
            calIntakeProgressLabelBottom.Location = new Point(237, 490);
            calIntakeProgressLabelBottom.Margin = new Padding(2, 0, 2, 0);
            calIntakeProgressLabelBottom.Name = "calIntakeProgressLabelBottom";
            calIntakeProgressLabelBottom.Size = new Size(167, 81);
            calIntakeProgressLabelBottom.TabIndex = 24;
            calIntakeProgressLabelBottom.Text = "0000";
            calIntakeProgressLabelBottom.TextAlign = ContentAlignment.MiddleRight;
            // 
            // fractionLine
            // 
            fractionLine.BackColor = Color.MediumTurquoise;
            fractionLine.BorderStyle = BorderStyle.FixedSingle;
            fractionLine.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fractionLine.ForeColor = Color.MediumTurquoise;
            fractionLine.Location = new Point(218, 485);
            fractionLine.Margin = new Padding(2, 0, 2, 0);
            fractionLine.Name = "fractionLine";
            fractionLine.Size = new Size(201, 5);
            fractionLine.TabIndex = 25;
            fractionLine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calDefButton
            // 
            calDefButton.Alpha = 20;
            calDefButton.BackColor = Color.Transparent;
            calDefButton.Background = true;
            calDefButton.Background_WidthPen = 4F;
            calDefButton.BackgroundPen = true;
            calDefButton.ColorBackground = Color.FromArgb(37, 52, 68);
            calDefButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            calDefButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            calDefButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            calDefButton.ColorLighting = Color.FromArgb(29, 200, 238);
            calDefButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            calDefButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            calDefButton.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            calDefButton.Effect_1 = true;
            calDefButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            calDefButton.Effect_1_Transparency = 25;
            calDefButton.Effect_2 = true;
            calDefButton.Effect_2_ColorBackground = Color.White;
            calDefButton.Effect_2_Transparency = 20;
            calDefButton.Font = new Font("Arial", 11F);
            calDefButton.ForeColor = Color.FromArgb(245, 245, 245);
            calDefButton.Lighting = false;
            calDefButton.LinearGradient_Background = false;
            calDefButton.LinearGradientPen = false;
            calDefButton.Location = new Point(1326, 279);
            calDefButton.Margin = new Padding(2, 3, 2, 3);
            calDefButton.Name = "calDefButton";
            calDefButton.PenWidth = 15;
            calDefButton.Rounding = true;
            calDefButton.RoundingInt = 70;
            calDefButton.Size = new Size(291, 142);
            calDefButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            calDefButton.TabIndex = 26;
            calDefButton.Tag = "Cyber";
            calDefButton.TextButton = "Calculate Calorie Deficit";
            calDefButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            calDefButton.Timer_Effect_1 = 5;
            calDefButton.Timer_RGB = 300;
            calDefButton.Click += calDefButton_Click;
            // 
            // endDayBtn
            // 
            endDayBtn.Alpha = 20;
            endDayBtn.BackColor = Color.Transparent;
            endDayBtn.Background = true;
            endDayBtn.Background_WidthPen = 4F;
            endDayBtn.BackgroundPen = true;
            endDayBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            endDayBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            endDayBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            endDayBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            endDayBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            endDayBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            endDayBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            endDayBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            endDayBtn.Effect_1 = true;
            endDayBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            endDayBtn.Effect_1_Transparency = 25;
            endDayBtn.Effect_2 = true;
            endDayBtn.Effect_2_ColorBackground = Color.White;
            endDayBtn.Effect_2_Transparency = 20;
            endDayBtn.Font = new Font("Arial", 11F);
            endDayBtn.ForeColor = Color.FromArgb(245, 245, 245);
            endDayBtn.Lighting = false;
            endDayBtn.LinearGradient_Background = false;
            endDayBtn.LinearGradientPen = false;
            endDayBtn.Location = new Point(1304, 811);
            endDayBtn.Margin = new Padding(2, 3, 2, 3);
            endDayBtn.Name = "endDayBtn";
            endDayBtn.PenWidth = 15;
            endDayBtn.Rounding = true;
            endDayBtn.RoundingInt = 70;
            endDayBtn.Size = new Size(291, 142);
            endDayBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            endDayBtn.TabIndex = 27;
            endDayBtn.Tag = "Cyber";
            endDayBtn.TextButton = "End Day";
            endDayBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            endDayBtn.Timer_Effect_1 = 5;
            endDayBtn.Timer_RGB = 300;
            endDayBtn.Click += endDayBtn_Click;
            // 
            // formCal
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1940, 1099);
            Controls.Add(endDayBtn);
            Controls.Add(calDefButton);
            Controls.Add(fractionLine);
            Controls.Add(calIntakeProgressLabelBottom);
            Controls.Add(calIntakeProgressLabelTop);
            Controls.Add(enterCalButton);
            Controls.Add(calInputTextBox);
            Controls.Add(totalCalIntake);
            Controls.Add(goalCalIntake);
            Controls.Add(calInput);
            Controls.Add(btn600Cal);
            Controls.Add(btn300Cal);
            Controls.Add(btn1000Cal);
            Controls.Add(btn500Cal);
            Controls.Add(btn200Cal);
            Controls.Add(btn100Cal);
            Controls.Add(lblPreset);
            Controls.Add(lblImport);
            Controls.Add(calIntakeProgressBar);
            Controls.Add(todayCalLabel);
            Controls.Add(maxIntakeLabel);
            Controls.Add(lblCalHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "formCal";
            Text = "formCal";
            Load += formCal_Load;
            ((System.ComponentModel.ISupportInitialize)calInputTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.NightLabel lblCalHead;
        private ReaLTaiizor.Controls.FoxLabel maxIntakeLabel;
        private ReaLTaiizor.Controls.FoxLabel todayCalLabel;
        private ReaLTaiizor.Controls.CircleProgressBar calIntakeProgressBar;
        private ReaLTaiizor.Controls.FoxLabel lblImport;
        private ReaLTaiizor.Controls.FoxLabel lblPreset;
        private ReaLTaiizor.Controls.CyberButton btn100Cal;
        private ReaLTaiizor.Controls.CyberButton btn200Cal;
        private ReaLTaiizor.Controls.CyberButton btn500Cal;
        private ReaLTaiizor.Controls.CyberButton btn1000Cal;
        private ReaLTaiizor.Controls.CyberButton btn300Cal;
        private ReaLTaiizor.Controls.CyberButton btn600Cal;
        private ReaLTaiizor.Controls.CyberTextBox calInput;
        private ReaLTaiizor.Controls.NightLabel goalCalIntake;
        private ReaLTaiizor.Controls.NightLabel totalCalIntake;
        private NumericUpDown calInputTextBox;
        private ReaLTaiizor.Controls.CyberButton enterCalButton;
        private Label calIntakeProgressLabelTop;
        private Label calIntakeProgressLabelBottom;
        private Label fractionLine;
        private ReaLTaiizor.Controls.CyberButton calDefButton;
        private ReaLTaiizor.Controls.CyberButton endDayBtn;
    }
}