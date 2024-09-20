namespace fitness
{
    partial class formExercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formExercise));
            lblExerciseHead = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            lblCardio = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel2 = new ReaLTaiizor.Controls.SkyLabel();
            skyLabel3 = new ReaLTaiizor.Controls.SkyLabel();
            exerciseTypeText = new TextBox();
            durationText = new TextBox();
            additionalInfoText = new TextBox();
            listView1 = new ListView();
            addBtn = new ReaLTaiizor.Controls.CyberButton();
            newBtn = new ReaLTaiizor.Controls.CyberButton();
            updateBtn = new ReaLTaiizor.Controls.CyberButton();
            removeBtn = new ReaLTaiizor.Controls.CyberButton();
            removeAllBtn = new ReaLTaiizor.Controls.CyberButton();
            dateTimePicker1 = new DateTimePicker();
            workoutResourcesBtn = new ReaLTaiizor.Controls.CyberButton();
            workoutResourcesBtn2 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            hopePictureBox3 = new ReaLTaiizor.Controls.HopePictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblExerciseHead
            // 
            lblExerciseHead.AutoSize = true;
            lblExerciseHead.BackColor = Color.Transparent;
            lblExerciseHead.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExerciseHead.ForeColor = Color.LightGray;
            lblExerciseHead.Location = new Point(28, 19);
            lblExerciseHead.Name = "lblExerciseHead";
            lblExerciseHead.Size = new Size(186, 32);
            lblExerciseHead.TabIndex = 0;
            lblExerciseHead.Text = "Exercise Tracker";
            // 
            // lblCardio
            // 
            lblCardio.AutoSize = true;
            lblCardio.Font = new Font("Verdana", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardio.ForeColor = Color.FromArgb(27, 94, 137);
            lblCardio.Location = new Point(28, 87);
            lblCardio.Name = "lblCardio";
            lblCardio.Size = new Size(99, 13);
            lblCardio.TabIndex = 1;
            lblCardio.Text = "Exercise Type";
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(28, 135);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(213, 13);
            skyLabel1.TabIndex = 2;
            skyLabel1.Text = "Time Duration (ex: 1 hr 10 min)";
            // 
            // skyLabel2
            // 
            skyLabel2.AutoSize = true;
            skyLabel2.Font = new Font("Verdana", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel2.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel2.Location = new Point(28, 181);
            skyLabel2.Name = "skyLabel2";
            skyLabel2.Size = new Size(37, 13);
            skyLabel2.TabIndex = 3;
            skyLabel2.Text = "Date";
            // 
            // skyLabel3
            // 
            skyLabel3.AutoSize = true;
            skyLabel3.Font = new Font("Verdana", 8.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel3.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel3.Location = new Point(28, 227);
            skyLabel3.Name = "skyLabel3";
            skyLabel3.Size = new Size(52, 13);
            skyLabel3.TabIndex = 4;
            skyLabel3.Text = "Details";
            // 
            // exerciseTypeText
            // 
            exerciseTypeText.BackColor = Color.FromArgb(32, 33, 36);
            exerciseTypeText.BorderStyle = BorderStyle.None;
            exerciseTypeText.ForeColor = SystemColors.Info;
            exerciseTypeText.Location = new Point(28, 111);
            exerciseTypeText.Margin = new Padding(1);
            exerciseTypeText.Name = "exerciseTypeText";
            exerciseTypeText.Size = new Size(167, 16);
            exerciseTypeText.TabIndex = 5;
            // 
            // durationText
            // 
            durationText.BackColor = Color.FromArgb(32, 33, 36);
            durationText.BorderStyle = BorderStyle.None;
            durationText.ForeColor = SystemColors.Info;
            durationText.Location = new Point(30, 158);
            durationText.Margin = new Padding(1);
            durationText.Name = "durationText";
            durationText.Size = new Size(165, 16);
            durationText.TabIndex = 6;
            // 
            // additionalInfoText
            // 
            additionalInfoText.BackColor = Color.FromArgb(32, 33, 36);
            additionalInfoText.BorderStyle = BorderStyle.None;
            additionalInfoText.ForeColor = SystemColors.Info;
            additionalInfoText.Location = new Point(28, 247);
            additionalInfoText.Margin = new Padding(1);
            additionalInfoText.Name = "additionalInfoText";
            additionalInfoText.Size = new Size(186, 16);
            additionalInfoText.TabIndex = 8;
            // 
            // listView1
            // 
            listView1.Font = new Font("Segoe UI", 12F);
            listView1.GridLines = true;
            listView1.Location = new Point(252, 74);
            listView1.Margin = new Padding(1);
            listView1.Name = "listView1";
            listView1.Size = new Size(422, 151);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // addBtn
            // 
            addBtn.Alpha = 20;
            addBtn.BackColor = Color.Transparent;
            addBtn.Background = true;
            addBtn.Background_WidthPen = 4F;
            addBtn.BackgroundPen = true;
            addBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            addBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            addBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            addBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            addBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            addBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            addBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            addBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            addBtn.Effect_1 = true;
            addBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            addBtn.Effect_1_Transparency = 25;
            addBtn.Effect_2 = true;
            addBtn.Effect_2_ColorBackground = Color.White;
            addBtn.Effect_2_Transparency = 20;
            addBtn.Font = new Font("Arial", 11F);
            addBtn.ForeColor = Color.FromArgb(245, 245, 245);
            addBtn.Lighting = false;
            addBtn.LinearGradient_Background = false;
            addBtn.LinearGradientPen = false;
            addBtn.Location = new Point(49, 281);
            addBtn.Margin = new Padding(1);
            addBtn.Name = "addBtn";
            addBtn.PenWidth = 15;
            addBtn.Rounding = true;
            addBtn.RoundingInt = 70;
            addBtn.Size = new Size(92, 27);
            addBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addBtn.TabIndex = 0;
            addBtn.Tag = "Cyber";
            addBtn.TextButton = "Add";
            addBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            addBtn.Timer_Effect_1 = 5;
            addBtn.Timer_RGB = 300;
            addBtn.Click += addBtn_Click;
            // 
            // newBtn
            // 
            newBtn.Alpha = 20;
            newBtn.BackColor = Color.Transparent;
            newBtn.Background = true;
            newBtn.Background_WidthPen = 4F;
            newBtn.BackgroundPen = true;
            newBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            newBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            newBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            newBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            newBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            newBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            newBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            newBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            newBtn.Effect_1 = true;
            newBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            newBtn.Effect_1_Transparency = 25;
            newBtn.Effect_2 = true;
            newBtn.Effect_2_ColorBackground = Color.White;
            newBtn.Effect_2_Transparency = 20;
            newBtn.Font = new Font("Arial", 11F);
            newBtn.ForeColor = Color.FromArgb(245, 245, 245);
            newBtn.Lighting = false;
            newBtn.LinearGradient_Background = false;
            newBtn.LinearGradientPen = false;
            newBtn.Location = new Point(156, 281);
            newBtn.Margin = new Padding(1);
            newBtn.Name = "newBtn";
            newBtn.PenWidth = 15;
            newBtn.Rounding = true;
            newBtn.RoundingInt = 70;
            newBtn.Size = new Size(92, 27);
            newBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            newBtn.TabIndex = 10;
            newBtn.Tag = "Cyber";
            newBtn.TextButton = "New";
            newBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            newBtn.Timer_Effect_1 = 5;
            newBtn.Timer_RGB = 300;
            newBtn.Click += newBtn_Click_1;
            // 
            // updateBtn
            // 
            updateBtn.Alpha = 20;
            updateBtn.BackColor = Color.Transparent;
            updateBtn.Background = true;
            updateBtn.Background_WidthPen = 4F;
            updateBtn.BackgroundPen = true;
            updateBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            updateBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            updateBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            updateBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            updateBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            updateBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            updateBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            updateBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            updateBtn.Effect_1 = true;
            updateBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            updateBtn.Effect_1_Transparency = 25;
            updateBtn.Effect_2 = true;
            updateBtn.Effect_2_ColorBackground = Color.White;
            updateBtn.Effect_2_Transparency = 20;
            updateBtn.Font = new Font("Arial", 11F);
            updateBtn.ForeColor = Color.FromArgb(245, 245, 245);
            updateBtn.Lighting = false;
            updateBtn.LinearGradient_Background = false;
            updateBtn.LinearGradientPen = false;
            updateBtn.Location = new Point(275, 281);
            updateBtn.Margin = new Padding(1);
            updateBtn.Name = "updateBtn";
            updateBtn.PenWidth = 15;
            updateBtn.Rounding = true;
            updateBtn.RoundingInt = 70;
            updateBtn.Size = new Size(92, 27);
            updateBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            updateBtn.TabIndex = 11;
            updateBtn.Tag = "Cyber";
            updateBtn.TextButton = "Update";
            updateBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            updateBtn.Timer_Effect_1 = 5;
            updateBtn.Timer_RGB = 300;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Alpha = 20;
            removeBtn.BackColor = Color.Transparent;
            removeBtn.Background = true;
            removeBtn.Background_WidthPen = 4F;
            removeBtn.BackgroundPen = true;
            removeBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            removeBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            removeBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            removeBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            removeBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            removeBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            removeBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            removeBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            removeBtn.Effect_1 = true;
            removeBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            removeBtn.Effect_1_Transparency = 25;
            removeBtn.Effect_2 = true;
            removeBtn.Effect_2_ColorBackground = Color.White;
            removeBtn.Effect_2_Transparency = 20;
            removeBtn.Font = new Font("Arial", 11F);
            removeBtn.ForeColor = Color.FromArgb(245, 245, 245);
            removeBtn.Lighting = false;
            removeBtn.LinearGradient_Background = false;
            removeBtn.LinearGradientPen = false;
            removeBtn.Location = new Point(395, 281);
            removeBtn.Margin = new Padding(1);
            removeBtn.Name = "removeBtn";
            removeBtn.PenWidth = 15;
            removeBtn.Rounding = true;
            removeBtn.RoundingInt = 70;
            removeBtn.Size = new Size(92, 27);
            removeBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            removeBtn.TabIndex = 12;
            removeBtn.Tag = "Cyber";
            removeBtn.TextButton = "Remove";
            removeBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            removeBtn.Timer_Effect_1 = 5;
            removeBtn.Timer_RGB = 300;
            removeBtn.Click += removeBtn_Click;
            // 
            // removeAllBtn
            // 
            removeAllBtn.Alpha = 20;
            removeAllBtn.BackColor = Color.Transparent;
            removeAllBtn.Background = true;
            removeAllBtn.Background_WidthPen = 4F;
            removeAllBtn.BackgroundPen = true;
            removeAllBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            removeAllBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            removeAllBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            removeAllBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            removeAllBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            removeAllBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            removeAllBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            removeAllBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            removeAllBtn.Effect_1 = true;
            removeAllBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            removeAllBtn.Effect_1_Transparency = 25;
            removeAllBtn.Effect_2 = true;
            removeAllBtn.Effect_2_ColorBackground = Color.White;
            removeAllBtn.Effect_2_Transparency = 20;
            removeAllBtn.Font = new Font("Arial", 11F);
            removeAllBtn.ForeColor = Color.FromArgb(245, 245, 245);
            removeAllBtn.Lighting = false;
            removeAllBtn.LinearGradient_Background = false;
            removeAllBtn.LinearGradientPen = false;
            removeAllBtn.Location = new Point(513, 281);
            removeAllBtn.Margin = new Padding(1);
            removeAllBtn.Name = "removeAllBtn";
            removeAllBtn.PenWidth = 15;
            removeAllBtn.Rounding = true;
            removeAllBtn.RoundingInt = 70;
            removeAllBtn.Size = new Size(92, 27);
            removeAllBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            removeAllBtn.TabIndex = 13;
            removeAllBtn.Tag = "Cyber";
            removeAllBtn.TextButton = "Remove All";
            removeAllBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            removeAllBtn.Timer_Effect_1 = 5;
            removeAllBtn.Timer_RGB = 300;
            removeAllBtn.Click += removeAllBtn_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(28, 202);
            dateTimePicker1.Margin = new Padding(1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // workoutResourcesBtn
            // 
            workoutResourcesBtn.Alpha = 20;
            workoutResourcesBtn.BackColor = Color.Transparent;
            workoutResourcesBtn.Background = true;
            workoutResourcesBtn.Background_WidthPen = 4F;
            workoutResourcesBtn.BackgroundPen = true;
            workoutResourcesBtn.ColorBackground = Color.FromArgb(37, 52, 68);
            workoutResourcesBtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            workoutResourcesBtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            workoutResourcesBtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            workoutResourcesBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            workoutResourcesBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            workoutResourcesBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            workoutResourcesBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            workoutResourcesBtn.Effect_1 = true;
            workoutResourcesBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            workoutResourcesBtn.Effect_1_Transparency = 25;
            workoutResourcesBtn.Effect_2 = true;
            workoutResourcesBtn.Effect_2_ColorBackground = Color.White;
            workoutResourcesBtn.Effect_2_Transparency = 20;
            workoutResourcesBtn.Font = new Font("Arial", 11F);
            workoutResourcesBtn.ForeColor = Color.FromArgb(245, 245, 245);
            workoutResourcesBtn.Lighting = false;
            workoutResourcesBtn.LinearGradient_Background = false;
            workoutResourcesBtn.LinearGradientPen = false;
            workoutResourcesBtn.Location = new Point(156, 334);
            workoutResourcesBtn.Margin = new Padding(1);
            workoutResourcesBtn.Name = "workoutResourcesBtn";
            workoutResourcesBtn.PenWidth = 15;
            workoutResourcesBtn.Rounding = true;
            workoutResourcesBtn.RoundingInt = 70;
            workoutResourcesBtn.Size = new Size(163, 51);
            workoutResourcesBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            workoutResourcesBtn.TabIndex = 15;
            workoutResourcesBtn.Tag = "Cyber";
            workoutResourcesBtn.TextButton = "Workout Plans";
            workoutResourcesBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            workoutResourcesBtn.Timer_Effect_1 = 5;
            workoutResourcesBtn.Timer_RGB = 300;
            workoutResourcesBtn.Click += workoutResourcesBtn_Click;
            // 
            // workoutResourcesBtn2
            // 
            workoutResourcesBtn2.Alpha = 20;
            workoutResourcesBtn2.BackColor = Color.Transparent;
            workoutResourcesBtn2.Background = true;
            workoutResourcesBtn2.Background_WidthPen = 4F;
            workoutResourcesBtn2.BackgroundPen = true;
            workoutResourcesBtn2.ColorBackground = Color.FromArgb(37, 52, 68);
            workoutResourcesBtn2.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            workoutResourcesBtn2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            workoutResourcesBtn2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            workoutResourcesBtn2.ColorLighting = Color.FromArgb(29, 200, 238);
            workoutResourcesBtn2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            workoutResourcesBtn2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            workoutResourcesBtn2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            workoutResourcesBtn2.Effect_1 = true;
            workoutResourcesBtn2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            workoutResourcesBtn2.Effect_1_Transparency = 25;
            workoutResourcesBtn2.Effect_2 = true;
            workoutResourcesBtn2.Effect_2_ColorBackground = Color.White;
            workoutResourcesBtn2.Effect_2_Transparency = 20;
            workoutResourcesBtn2.Font = new Font("Arial", 11F);
            workoutResourcesBtn2.ForeColor = Color.FromArgb(245, 245, 245);
            workoutResourcesBtn2.Lighting = false;
            workoutResourcesBtn2.LinearGradient_Background = false;
            workoutResourcesBtn2.LinearGradientPen = false;
            workoutResourcesBtn2.Location = new Point(342, 334);
            workoutResourcesBtn2.Margin = new Padding(1);
            workoutResourcesBtn2.Name = "workoutResourcesBtn2";
            workoutResourcesBtn2.PenWidth = 15;
            workoutResourcesBtn2.Rounding = true;
            workoutResourcesBtn2.RoundingInt = 70;
            workoutResourcesBtn2.Size = new Size(163, 51);
            workoutResourcesBtn2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            workoutResourcesBtn2.TabIndex = 16;
            workoutResourcesBtn2.Tag = "Cyber";
            workoutResourcesBtn2.TextButton = "Workout Videos";
            workoutResourcesBtn2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            workoutResourcesBtn2.Timer_Effect_1 = 5;
            workoutResourcesBtn2.Timer_RGB = 300;
            workoutResourcesBtn2.Click += workoutResourcesBtn2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 325);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(516, 325);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(89, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.Location = new Point(622, 400);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(52, 37);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 34;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox2
            // 
            hopePictureBox2.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox2.Image = (Image)resources.GetObject("hopePictureBox2.Image");
            hopePictureBox2.Location = new Point(13, 400);
            hopePictureBox2.Name = "hopePictureBox2";
            hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox2.Size = new Size(75, 50);
            hopePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox2.TabIndex = 35;
            hopePictureBox2.TabStop = false;
            hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox3
            // 
            hopePictureBox3.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox3.Image = (Image)resources.GetObject("hopePictureBox3.Image");
            hopePictureBox3.Location = new Point(609, 16);
            hopePictureBox3.Name = "hopePictureBox3";
            hopePictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox3.Size = new Size(56, 40);
            hopePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox3.TabIndex = 36;
            hopePictureBox3.TabStop = false;
            hopePictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(27, 94, 137);
            panel1.Location = new Point(28, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 1);
            panel1.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(27, 94, 137);
            panel2.Location = new Point(28, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 1);
            panel2.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(27, 94, 137);
            panel3.Location = new Point(28, 267);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 1);
            panel3.TabIndex = 39;
            // 
            // formExercise
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(799, 402);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(hopePictureBox3);
            Controls.Add(hopePictureBox2);
            Controls.Add(hopePictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(workoutResourcesBtn2);
            Controls.Add(workoutResourcesBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(removeAllBtn);
            Controls.Add(removeBtn);
            Controls.Add(updateBtn);
            Controls.Add(newBtn);
            Controls.Add(addBtn);
            Controls.Add(listView1);
            Controls.Add(additionalInfoText);
            Controls.Add(durationText);
            Controls.Add(exerciseTypeText);
            Controls.Add(skyLabel3);
            Controls.Add(skyLabel2);
            Controls.Add(skyLabel1);
            Controls.Add(lblCardio);
            Controls.Add(lblExerciseHead);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formExercise";
            Text = "formExercise";
            Load += formExercise_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel lblExerciseHead;
        private ReaLTaiizor.Controls.SkyLabel lblCardio;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel2;
        private ReaLTaiizor.Controls.SkyLabel skyLabel3;
        private TextBox exerciseTypeText;
        private TextBox durationText;
        private TextBox additionalInfoText;
        private ListView listView1;
        private ReaLTaiizor.Controls.CyberButton addBtn;
        private ReaLTaiizor.Controls.CyberButton newBtn;
        private ReaLTaiizor.Controls.CyberButton updateBtn;
        private ReaLTaiizor.Controls.CyberButton removeBtn;
        private ReaLTaiizor.Controls.CyberButton removeAllBtn;
        private DateTimePicker dateTimePicker1;
        private ReaLTaiizor.Controls.CyberButton workoutResourcesBtn;
        private ReaLTaiizor.Controls.CyberButton workoutResourcesBtn2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}