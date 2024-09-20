namespace fitness
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            signInButton = new Button();
            pnTop = new Panel();
            extLogButton = new ReaLTaiizor.Controls.Button();
            pnlSignIn = new Panel();
            RememberMecheckBox1 = new CheckBox();
            signUpBtn = new Button();
            panel1 = new Panel();
            passwordTextBox = new TextBox();
            underlineUserPnl = new Panel();
            lblPass = new Label();
            lblSignIn = new Label();
            usernameTextBox = new TextBox();
            lblUser = new Label();
            loginBackground = new PictureBox();
            pnTop.SuspendLayout();
            pnlSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginBackground).BeginInit();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInButton.ForeColor = SystemColors.ButtonFace;
            signInButton.Location = new Point(100, 227);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(134, 38);
            signInButton.TabIndex = 0;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(24, 25, 29);
            pnTop.Controls.Add(extLogButton);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(799, 33);
            pnTop.TabIndex = 1;
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
            extLogButton.Location = new Point(758, 0);
            extLogButton.Name = "extLogButton";
            extLogButton.PressedBorderColor = Color.FromArgb(165, 37, 37);
            extLogButton.PressedColor = Color.FromArgb(165, 37, 37);
            extLogButton.Size = new Size(42, 33);
            extLogButton.TabIndex = 0;
            extLogButton.Text = "O";
            extLogButton.TextAlignment = StringAlignment.Center;
            extLogButton.Click += extLogButton_Click;
            // 
            // pnlSignIn
            // 
            pnlSignIn.BackColor = Color.FromArgb(24, 25, 29);
            pnlSignIn.Controls.Add(RememberMecheckBox1);
            pnlSignIn.Controls.Add(signUpBtn);
            pnlSignIn.Controls.Add(panel1);
            pnlSignIn.Controls.Add(passwordTextBox);
            pnlSignIn.Controls.Add(underlineUserPnl);
            pnlSignIn.Controls.Add(lblPass);
            pnlSignIn.Controls.Add(lblSignIn);
            pnlSignIn.Controls.Add(usernameTextBox);
            pnlSignIn.Controls.Add(lblUser);
            pnlSignIn.Controls.Add(signInButton);
            pnlSignIn.Location = new Point(231, 67);
            pnlSignIn.Name = "pnlSignIn";
            pnlSignIn.Size = new Size(327, 325);
            pnlSignIn.TabIndex = 2;
            // 
            // RememberMecheckBox1
            // 
            RememberMecheckBox1.AutoSize = true;
            RememberMecheckBox1.ForeColor = SystemColors.ButtonFace;
            RememberMecheckBox1.Location = new Point(197, 192);
            RememberMecheckBox1.Name = "RememberMecheckBox1";
            RememberMecheckBox1.Size = new Size(104, 19);
            RememberMecheckBox1.TabIndex = 9;
            RememberMecheckBox1.Text = "Remember Me";
            RememberMecheckBox1.UseVisualStyleBackColor = true;
            RememberMecheckBox1.CheckedChanged += RememberMecheckBox1_CheckedChanged;
            // 
            // signUpBtn
            // 
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            signUpBtn.ForeColor = SystemColors.ButtonFace;
            signUpBtn.Location = new Point(127, 280);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(75, 23);
            signUpBtn.TabIndex = 8;
            signUpBtn.Text = "Sign Up";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(113, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 1);
            panel1.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(24, 25, 29);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = Color.White;
            passwordTextBox.Location = new Point(113, 154);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(170, 20);
            passwordTextBox.TabIndex = 6;
            // 
            // underlineUserPnl
            // 
            underlineUserPnl.BackColor = Color.White;
            underlineUserPnl.Location = new Point(117, 117);
            underlineUserPnl.Name = "underlineUserPnl";
            underlineUserPnl.Size = new Size(170, 1);
            underlineUserPnl.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPass.ForeColor = SystemColors.ButtonFace;
            lblPass.Location = new Point(15, 153);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(80, 21);
            lblPass.TabIndex = 4;
            lblPass.Text = "password:";
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignIn.ForeColor = SystemColors.ButtonFace;
            lblSignIn.Location = new Point(100, 22);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(134, 32);
            lblSignIn.TabIndex = 3;
            lblSignIn.Text = "Get Started";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(24, 25, 29);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTextBox.ForeColor = SystemColors.Window;
            usernameTextBox.Location = new Point(117, 95);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(170, 20);
            usernameTextBox.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = SystemColors.ButtonFace;
            lblUser.Location = new Point(15, 94);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 21);
            lblUser.TabIndex = 1;
            lblUser.Text = "username:";
            // 
            // loginBackground
            // 
            loginBackground.Image = (Image)resources.GetObject("loginBackground.Image");
            loginBackground.Location = new Point(0, 0);
            loginBackground.Name = "loginBackground";
            loginBackground.Size = new Size(808, 485);
            loginBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            loginBackground.TabIndex = 3;
            loginBackground.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 402);
            Controls.Add(pnlSignIn);
            Controls.Add(pnTop);
            Controls.Add(loginBackground);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "login";
            pnTop.ResumeLayout(false);
            pnlSignIn.ResumeLayout(false);
            pnlSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button signInButton;
        private Panel pnTop;
        private Panel pnlSignIn;
        private ReaLTaiizor.Controls.Button extLogButton;
        private Panel underlineUserPnl;
        private Label lblPass;
        private Label lblSignIn;
        private TextBox usernameTextBox;
        private Label lblUser;
        private Panel panel1;
        private TextBox passwordTextBox;
        private PictureBox loginBackground;
        private Button signUpBtn;
        private CheckBox RememberMecheckBox1;
    }
}
