namespace fitness
{
    partial class formProfile
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
            label1 = new Label();
            profilePictureBox = new ReaLTaiizor.Controls.ParrotPictureBox();
            importPhoto = new ReaLTaiizor.Controls.CrownButton();
            welcomeLbl = new ReaLTaiizor.Controls.SkyLabel();
            userLabel = new ReaLTaiizor.Controls.SkyLabel();
            genderLabel = new ReaLTaiizor.Controls.SkyLabel();
            weightLabel = new ReaLTaiizor.Controls.SkyLabel();
            heightLabel = new ReaLTaiizor.Controls.SkyLabel();
            ageLabel = new ReaLTaiizor.Controls.SkyLabel();
            updateSettingsButton = new ReaLTaiizor.Controls.CyberRadioButton();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            imageSavedLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(187, 57);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 65);
            label1.TabIndex = 0;
            label1.Text = "Your Profile";
            // 
            // profilePictureBox
            // 
            profilePictureBox.ColorLeft = Color.DodgerBlue;
            profilePictureBox.ColorRight = Color.DodgerBlue;
            profilePictureBox.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            profilePictureBox.FilterAlpha = 200;
            profilePictureBox.FilterEnabled = true;
            profilePictureBox.Image = null;
            profilePictureBox.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            profilePictureBox.IsElipse = false;
            profilePictureBox.IsParallax = false;
            profilePictureBox.Location = new Point(160, 189);
            profilePictureBox.Margin = new Padding(7, 8, 7, 8);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            profilePictureBox.Size = new Size(364, 410);
            profilePictureBox.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            profilePictureBox.TabIndex = 1;
            profilePictureBox.Text = "parrotPictureBox1";
            profilePictureBox.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // importPhoto
            // 
            importPhoto.Location = new Point(187, 615);
            importPhoto.Margin = new Padding(7, 8, 7, 8);
            importPhoto.Name = "importPhoto";
            importPhoto.Padding = new Padding(12, 14, 12, 14);
            importPhoto.Size = new Size(245, 63);
            importPhoto.TabIndex = 2;
            importPhoto.Text = "Import photo";
            importPhoto.Click += importPhoto_Click;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLbl.ForeColor = Color.FromArgb(27, 94, 137);
            welcomeLbl.Location = new Point(58, 760);
            welcomeLbl.Margin = new Padding(7, 0, 7, 0);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(226, 48);
            welcomeLbl.TabIndex = 3;
            welcomeLbl.Text = "Welcome";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userLabel.ForeColor = Color.Teal;
            userLabel.Location = new Point(291, 760);
            userLabel.Margin = new Padding(7, 0, 7, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(758, 48);
            userLabel.TabIndex = 4;
            userLabel.Text = "USERNAME HERE OR FIRSTNAME";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            genderLabel.ForeColor = Color.FromArgb(27, 94, 137);
            genderLabel.Location = new Point(136, 841);
            genderLabel.Margin = new Padding(7, 0, 7, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(154, 46);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "gender";
            genderLabel.Click += genderLabel_Click;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightLabel.ForeColor = Color.FromArgb(27, 94, 137);
            weightLabel.Location = new Point(136, 929);
            weightLabel.Margin = new Padding(7, 0, 7, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(285, 46);
            weightLabel.TabIndex = 6;
            weightLabel.Text = "currentweight";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heightLabel.ForeColor = Color.FromArgb(27, 94, 137);
            heightLabel.Location = new Point(136, 1020);
            heightLabel.Margin = new Padding(7, 0, 7, 0);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(278, 46);
            heightLabel.TabIndex = 7;
            heightLabel.Text = "currentheight";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ageLabel.ForeColor = Color.FromArgb(27, 94, 137);
            ageLabel.Location = new Point(486, 841);
            ageLabel.Margin = new Padding(7, 0, 7, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(90, 46);
            ageLabel.TabIndex = 8;
            ageLabel.Text = "age";
            // 
            // updateSettingsButton
            // 
            updateSettingsButton.BackColor = Color.Transparent;
            updateSettingsButton.Background = true;
            updateSettingsButton.Background_WidthPen = 2F;
            updateSettingsButton.BackgroundPen = true;
            updateSettingsButton.Checked = false;
            updateSettingsButton.Color_1_Background_value = Color.Empty;
            updateSettingsButton.Color_2_Background_value = Color.Empty;
            updateSettingsButton.ColorBackground = Color.FromArgb(37, 52, 68);
            updateSettingsButton.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            updateSettingsButton.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            updateSettingsButton.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            updateSettingsButton.ColorChecked = Color.FromArgb(29, 200, 238);
            updateSettingsButton.ColorPen_1 = Color.FromArgb(37, 52, 68);
            updateSettingsButton.ColorPen_2 = Color.FromArgb(41, 63, 86);
            updateSettingsButton.CyberRadioButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            updateSettingsButton.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            updateSettingsButton.Effect_1_Transparency = 25;
            updateSettingsButton.Effect_2 = true;
            updateSettingsButton.Effect_2_ColorBackground = Color.White;
            updateSettingsButton.Effect_2_Transparency = 15;
            updateSettingsButton.Font = new Font("Arial", 11F);
            updateSettingsButton.ForeColor = Color.FromArgb(245, 245, 245);
            updateSettingsButton.LinearGradient_Background = false;
            updateSettingsButton.LinearGradient_Value = false;
            updateSettingsButton.LinearGradientPen = false;
            updateSettingsButton.Location = new Point(588, 1020);
            updateSettingsButton.Margin = new Padding(7, 8, 7, 8);
            updateSettingsButton.Name = "updateSettingsButton";
            updateSettingsButton.RGB = false;
            updateSettingsButton.Rounding = true;
            updateSettingsButton.RoundingInt = 100;
            updateSettingsButton.Size = new Size(437, 45);
            updateSettingsButton.SizeChecked = 8;
            updateSettingsButton.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            updateSettingsButton.TabIndex = 9;
            updateSettingsButton.Tag = "Cyber";
            updateSettingsButton.TextButton = "Update Settings";
            updateSettingsButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            updateSettingsButton.Timer_Effect_1 = 1;
            updateSettingsButton.Timer_RGB = 300;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Location = new Point(113, 157);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(411, 426);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 10;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopePictureBox1.Click += hopePictureBox1_Click;
            // 
            // imageSavedLbl
            // 
            imageSavedLbl.AutoSize = true;
            imageSavedLbl.ForeColor = Color.CornflowerBlue;
            imageSavedLbl.Location = new Point(497, 626);
            imageSavedLbl.Name = "imageSavedLbl";
            imageSavedLbl.Size = new Size(194, 41);
            imageSavedLbl.TabIndex = 12;
            imageSavedLbl.Text = "Image saved!";
            // 
            // formProfile
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(1943, 1230);
            Controls.Add(imageSavedLbl);
            Controls.Add(hopePictureBox1);
            Controls.Add(updateSettingsButton);
            Controls.Add(ageLabel);
            Controls.Add(heightLabel);
            Controls.Add(weightLabel);
            Controls.Add(genderLabel);
            Controls.Add(userLabel);
            Controls.Add(welcomeLbl);
            Controls.Add(importPhoto);
            Controls.Add(profilePictureBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "formProfile";
            Text = "formProfile";
            Load += formProfile_Load;
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.ParrotPictureBox profilePictureBox;
        private ReaLTaiizor.Controls.CrownButton importPhoto;
        private ReaLTaiizor.Controls.SkyLabel welcomeLbl;
        private ReaLTaiizor.Controls.SkyLabel userLabel;
        private ReaLTaiizor.Controls.SkyLabel genderLabel;
        private ReaLTaiizor.Controls.SkyLabel weightLabel;
        private ReaLTaiizor.Controls.SkyLabel heightLabel;
        private ReaLTaiizor.Controls.SkyLabel ageLabel;
        private ReaLTaiizor.Controls.CyberRadioButton updateSettingsButton;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private Label imageSavedLbl;
    }
}