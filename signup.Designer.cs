namespace fitness
{
    partial class signup
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
            signUpLbl = new ReaLTaiizor.Controls.BigLabel();
            signInLinkLabel = new LinkLabel();
            RememberMecheckBox2 = new CheckBox();
            lblGender = new Label();
            genderComboBox = new ComboBox();
            lblUser = new Label();
            lblPassword1 = new Label();
            lblPassword2 = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            Sign_Up = new ReaLTaiizor.Controls.NightButton();
            passwordTextBox = new TextBox();
            con_passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            weightTextBox = new TextBox();
            heightTextBox = new TextBox();
            ageTextBox = new TextBox();
            lblAge = new Label();
            SuspendLayout();
            // 
            // signUpLbl
            // 
            signUpLbl.AutoSize = true;
            signUpLbl.BackColor = Color.Transparent;
            signUpLbl.Font = new Font("Segoe UI", 25F);
            signUpLbl.ForeColor = SystemColors.ButtonFace;
            signUpLbl.Location = new Point(512, 25);
            signUpLbl.Margin = new Padding(7, 0, 7, 0);
            signUpLbl.Name = "signUpLbl";
            signUpLbl.Size = new Size(339, 112);
            signUpLbl.TabIndex = 0;
            signUpLbl.Text = "Sign Up";
            // 
            // signInLinkLabel
            // 
            signInLinkLabel.AutoSize = true;
            signInLinkLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInLinkLabel.LinkColor = Color.White;
            signInLinkLabel.Location = new Point(104, 1104);
            signInLinkLabel.Margin = new Padding(7, 0, 7, 0);
            signInLinkLabel.Name = "signInLinkLabel";
            signInLinkLabel.Size = new Size(270, 51);
            signInLinkLabel.TabIndex = 1;
            signInLinkLabel.TabStop = true;
            signInLinkLabel.Text = "Back to Sign In";
            signInLinkLabel.LinkClicked += signInLinkLabel_LinkClicked;
            // 
            // RememberMecheckBox2
            // 
            RememberMecheckBox2.AutoSize = true;
            RememberMecheckBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RememberMecheckBox2.ForeColor = SystemColors.ButtonFace;
            RememberMecheckBox2.Location = new Point(568, 1104);
            RememberMecheckBox2.Margin = new Padding(7, 8, 7, 8);
            RememberMecheckBox2.Name = "RememberMecheckBox2";
            RememberMecheckBox2.Size = new Size(270, 49);
            RememberMecheckBox2.TabIndex = 2;
            RememberMecheckBox2.Text = "Remember Me";
            RememberMecheckBox2.UseVisualStyleBackColor = true;
            RememberMecheckBox2.CheckedChanged += RememberMecheckBox2_CheckedChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.ForeColor = SystemColors.ButtonFace;
            lblGender.Location = new Point(51, 429);
            lblGender.Margin = new Padding(7, 0, 7, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(133, 45);
            lblGender.TabIndex = 7;
            lblGender.Text = "Gender:";
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Items.AddRange(new object[] { "male", "female" });
            genderComboBox.Location = new Point(51, 521);
            genderComboBox.Margin = new Padding(7, 8, 7, 8);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(215, 49);
            genderComboBox.TabIndex = 8;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.ButtonFace;
            lblUser.Location = new Point(51, 221);
            lblUser.Margin = new Padding(7, 0, 7, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(173, 45);
            lblUser.TabIndex = 10;
            lblUser.Text = "Username:";
            // 
            // lblPassword1
            // 
            lblPassword1.AutoSize = true;
            lblPassword1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword1.ForeColor = SystemColors.ButtonFace;
            lblPassword1.Location = new Point(466, 221);
            lblPassword1.Margin = new Padding(7, 0, 7, 0);
            lblPassword1.Name = "lblPassword1";
            lblPassword1.Size = new Size(162, 45);
            lblPassword1.TabIndex = 11;
            lblPassword1.Text = "Password:";
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword2.ForeColor = SystemColors.ButtonFace;
            lblPassword2.Location = new Point(918, 221);
            lblPassword2.Margin = new Padding(7, 0, 7, 0);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(286, 45);
            lblPassword2.TabIndex = 12;
            lblPassword2.Text = "Confirm Password:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeight.ForeColor = SystemColors.ButtonFace;
            lblHeight.Location = new Point(466, 429);
            lblHeight.Margin = new Padding(7, 0, 7, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(214, 45);
            lblHeight.TabIndex = 13;
            lblHeight.Text = "Height (ft-in):";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeight.ForeColor = SystemColors.ButtonFace;
            lblWeight.Location = new Point(918, 442);
            lblWeight.Margin = new Padding(7, 0, 7, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(201, 45);
            lblWeight.TabIndex = 14;
            lblWeight.Text = "Weight (lbs):";
            // 
            // Sign_Up
            // 
            Sign_Up.BackColor = Color.Transparent;
            Sign_Up.DialogResult = DialogResult.None;
            Sign_Up.Font = new Font("Segoe UI", 10F);
            Sign_Up.ForeColor = Color.FromArgb(242, 93, 89);
            Sign_Up.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            Sign_Up.HoverForeColor = Color.White;
            Sign_Up.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            Sign_Up.Location = new Point(979, 1033);
            Sign_Up.Margin = new Padding(7, 8, 7, 8);
            Sign_Up.MinimumSize = new Size(350, 128);
            Sign_Up.Name = "Sign_Up";
            Sign_Up.NormalBackColor = Color.FromArgb(242, 93, 89);
            Sign_Up.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            Sign_Up.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            Sign_Up.PressedForeColor = Color.White;
            Sign_Up.Radius = 20;
            Sign_Up.Size = new Size(350, 128);
            Sign_Up.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Sign_Up.TabIndex = 15;
            Sign_Up.Text = "Create Account";
            Sign_Up.Click += Sign_Up_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(466, 297);
            passwordTextBox.Margin = new Padding(7, 8, 7, 8);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(237, 47);
            passwordTextBox.TabIndex = 16;
            // 
            // con_passwordTextBox
            // 
            con_passwordTextBox.Location = new Point(934, 297);
            con_passwordTextBox.Margin = new Padding(7, 8, 7, 8);
            con_passwordTextBox.Name = "con_passwordTextBox";
            con_passwordTextBox.Size = new Size(237, 47);
            con_passwordTextBox.TabIndex = 17;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(51, 297);
            usernameTextBox.Margin = new Padding(7, 8, 7, 8);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(237, 47);
            usernameTextBox.TabIndex = 18;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(918, 539);
            weightTextBox.Margin = new Padding(7, 8, 7, 8);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(237, 47);
            weightTextBox.TabIndex = 23;
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(466, 523);
            heightTextBox.Margin = new Padding(7, 8, 7, 8);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(237, 47);
            heightTextBox.TabIndex = 24;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(466, 720);
            ageTextBox.Margin = new Padding(7, 8, 7, 8);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(237, 47);
            ageTextBox.TabIndex = 25;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.ForeColor = SystemColors.ButtonFace;
            lblAge.Location = new Point(466, 636);
            lblAge.Margin = new Padding(7, 0, 7, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(84, 45);
            lblAge.TabIndex = 26;
            lblAge.Text = "Age:";
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 25, 29);
            ClientSize = new Size(1399, 1230);
            Controls.Add(lblAge);
            Controls.Add(ageTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(con_passwordTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(Sign_Up);
            Controls.Add(lblWeight);
            Controls.Add(lblHeight);
            Controls.Add(lblPassword2);
            Controls.Add(lblPassword1);
            Controls.Add(lblUser);
            Controls.Add(genderComboBox);
            Controls.Add(lblGender);
            Controls.Add(RememberMecheckBox2);
            Controls.Add(signInLinkLabel);
            Controls.Add(signUpLbl);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 8, 7, 8);
            Name = "signup";
            Text = "signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel signUpLbl;
        private LinkLabel signInLinkLabel;
        private CheckBox RememberMecheckBox2;
        private Label lblGender;
        private ComboBox genderComboBox;
        private Label lblUser;
        private Label lblPassword1;
        private Label lblPassword2;
        private Label lblHeight;
        private Label lblWeight;
        private ReaLTaiizor.Controls.NightButton Sign_Up;
        private TextBox passwordTextBox;
        private TextBox con_passwordTextBox;
        private TextBox usernameTextBox;
        private TextBox weightTextBox;
        private TextBox heightTextBox;
        private TextBox ageTextBox;
        private Label lblAge;
    }
}