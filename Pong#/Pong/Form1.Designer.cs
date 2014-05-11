namespace Pong
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RightPanel = new System.Windows.Forms.Panel();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.pbPowerUp = new System.Windows.Forms.PictureBox();
            this.Cdown = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ballPanel = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.lbWin = new System.Windows.Forms.Label();
            this.MeniPanel = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.Options = new System.Windows.Forms.Label();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbName1 = new System.Windows.Forms.Label();
            this.CheckReverse = new System.Windows.Forms.CheckBox();
            this.CheckPower = new System.Windows.Forms.CheckBox();
            this.OptionsBack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BallSpeed = new System.Windows.Forms.Label();
            this.BarSpeed = new System.Windows.Forms.TrackBar();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.ControlsBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbL1 = new System.Windows.Forms.Label();
            this.lbO1 = new System.Windows.Forms.Label();
            this.lbS1 = new System.Windows.Forms.Label();
            this.lbE1 = new System.Windows.Forms.Label();
            this.lbR1 = new System.Windows.Forms.Label();
            this.lbR2 = new System.Windows.Forms.Label();
            this.lbE2 = new System.Windows.Forms.Label();
            this.lbS2 = new System.Windows.Forms.Label();
            this.lbO2 = new System.Windows.Forms.Label();
            this.lbL2 = new System.Windows.Forms.Label();
            this.lbIme1 = new System.Windows.Forms.Label();
            this.lbIme2 = new System.Windows.Forms.Label();
            this.EndGame = new System.Windows.Forms.Label();
            this.PauseGame = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.PlayAgain = new System.Windows.Forms.Label();
            this.pbOn = new System.Windows.Forms.PictureBox();
            this.pbOff = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPowerUp)).BeginInit();
            this.MeniPanel.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).BeginInit();
            this.ControlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.LeftPanel.Location = new System.Drawing.Point(3, 100);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(10, 60);
            this.LeftPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.Gold;
            this.RightPanel.Location = new System.Drawing.Point(581, 100);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(10, 60);
            this.RightPanel.TabIndex = 1;
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.White;
            this.GamePanel.Controls.Add(this.pbPowerUp);
            this.GamePanel.Controls.Add(this.Cdown);
            this.GamePanel.Controls.Add(this.RightPanel);
            this.GamePanel.Controls.Add(this.LeftPanel);
            this.GamePanel.Controls.Add(this.shapeContainer1);
            this.GamePanel.Controls.Add(this.lbWin);
            this.GamePanel.Location = new System.Drawing.Point(81, 74);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(594, 257);
            this.GamePanel.TabIndex = 8;
            // 
            // pbPowerUp
            // 
            this.pbPowerUp.BackColor = System.Drawing.Color.Transparent;
            this.pbPowerUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPowerUp.Location = new System.Drawing.Point(487, 8);
            this.pbPowerUp.Name = "pbPowerUp";
            this.pbPowerUp.Size = new System.Drawing.Size(30, 30);
            this.pbPowerUp.TabIndex = 24;
            this.pbPowerUp.TabStop = false;
            this.pbPowerUp.Visible = false;
            // 
            // Cdown
            // 
            this.Cdown.AutoSize = true;
            this.Cdown.BackColor = System.Drawing.Color.Transparent;
            this.Cdown.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cdown.ForeColor = System.Drawing.Color.Black;
            this.Cdown.Location = new System.Drawing.Point(454, 41);
            this.Cdown.Name = "Cdown";
            this.Cdown.Size = new System.Drawing.Size(68, 80);
            this.Cdown.TabIndex = 23;
            this.Cdown.Text = "3";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ballPanel});
            this.shapeContainer1.Size = new System.Drawing.Size(594, 257);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // ballPanel
            // 
            this.ballPanel.BackColor = System.Drawing.Color.DarkGray;
            this.ballPanel.FillColor = System.Drawing.Color.Black;
            this.ballPanel.FillGradientColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ballPanel.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ballPanel.Location = new System.Drawing.Point(298, 106);
            this.ballPanel.Name = "ballPanel";
            this.ballPanel.Size = new System.Drawing.Size(14, 14);
            // 
            // lbWin
            // 
            this.lbWin.BackColor = System.Drawing.Color.White;
            this.lbWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbWin.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWin.Location = new System.Drawing.Point(0, 0);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(594, 257);
            this.lbWin.TabIndex = 12;
            this.lbWin.Text = "label2";
            this.lbWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeniPanel
            // 
            this.MeniPanel.BackColor = System.Drawing.Color.White;
            this.MeniPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MeniPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MeniPanel.Controls.Add(this.Start);
            this.MeniPanel.Controls.Add(this.Exit);
            this.MeniPanel.Controls.Add(this.Mode);
            this.MeniPanel.Controls.Add(this.Options);
            this.MeniPanel.Font = new System.Drawing.Font("Curlz MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniPanel.Location = new System.Drawing.Point(238, 27);
            this.MeniPanel.Name = "MeniPanel";
            this.MeniPanel.Size = new System.Drawing.Size(279, 351);
            this.MeniPanel.TabIndex = 9;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(29, 38);
            this.Start.Name = "Start";
            this.Start.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.Start.Size = new System.Drawing.Size(219, 58);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start Game";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Start.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(42, 262);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(58, 5, 58, 5);
            this.Exit.Size = new System.Drawing.Size(193, 58);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Exit";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Exit.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.BackColor = System.Drawing.Color.Transparent;
            this.Mode.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mode.ForeColor = System.Drawing.Color.Black;
            this.Mode.Location = new System.Drawing.Point(34, 111);
            this.Mode.Name = "Mode";
            this.Mode.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.Mode.Size = new System.Drawing.Size(209, 58);
            this.Mode.TabIndex = 0;
            this.Mode.Text = "Controls";
            this.Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mode.Click += new System.EventHandler(this.Mode_Click);
            this.Mode.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Mode.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // Options
            // 
            this.Options.AutoSize = true;
            this.Options.BackColor = System.Drawing.Color.Transparent;
            this.Options.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Options.ForeColor = System.Drawing.Color.Black;
            this.Options.Location = new System.Drawing.Point(35, 185);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(30, 5, 30, 5);
            this.Options.Size = new System.Drawing.Size(206, 58);
            this.Options.TabIndex = 0;
            this.Options.Text = "Options";
            this.Options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            this.Options.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Options.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.White;
            this.OptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptionsPanel.Controls.Add(this.tbPlayer2);
            this.OptionsPanel.Controls.Add(this.tbPlayer1);
            this.OptionsPanel.Controls.Add(this.label2);
            this.OptionsPanel.Controls.Add(this.lbName1);
            this.OptionsPanel.Controls.Add(this.CheckReverse);
            this.OptionsPanel.Controls.Add(this.CheckPower);
            this.OptionsPanel.Controls.Add(this.OptionsBack);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Controls.Add(this.BallSpeed);
            this.OptionsPanel.Controls.Add(this.BarSpeed);
            this.OptionsPanel.Location = new System.Drawing.Point(584, 3);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(279, 351);
            this.OptionsPanel.TabIndex = 10;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer2.ForeColor = System.Drawing.Color.Gold;
            this.tbPlayer2.Location = new System.Drawing.Point(123, 236);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(118, 26);
            this.tbPlayer2.TabIndex = 7;
            this.tbPlayer2.Text = "Player 2";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPlayer1.ForeColor = System.Drawing.Color.OrangeRed;
            this.tbPlayer1.Location = new System.Drawing.Point(123, 193);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(118, 26);
            this.tbPlayer1.TabIndex = 6;
            this.tbPlayer1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(32, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player2:";
            // 
            // lbName1
            // 
            this.lbName1.AutoSize = true;
            this.lbName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName1.Location = new System.Drawing.Point(32, 196);
            this.lbName1.Name = "lbName1";
            this.lbName1.Size = new System.Drawing.Size(73, 20);
            this.lbName1.TabIndex = 4;
            this.lbName1.Text = "Player1:";
            // 
            // CheckReverse
            // 
            this.CheckReverse.AutoSize = true;
            this.CheckReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckReverse.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CheckReverse.Location = new System.Drawing.Point(36, 151);
            this.CheckReverse.Name = "CheckReverse";
            this.CheckReverse.Size = new System.Drawing.Size(187, 28);
            this.CheckReverse.TabIndex = 3;
            this.CheckReverse.Text = "Reverse Controls";
            this.CheckReverse.UseVisualStyleBackColor = true;
            // 
            // CheckPower
            // 
            this.CheckPower.AutoSize = true;
            this.CheckPower.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckPower.FlatAppearance.BorderSize = 4;
            this.CheckPower.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CheckPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckPower.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CheckPower.Location = new System.Drawing.Point(36, 110);
            this.CheckPower.Name = "CheckPower";
            this.CheckPower.Size = new System.Drawing.Size(134, 28);
            this.CheckPower.TabIndex = 3;
            this.CheckPower.Text = "Power Ups!";
            this.CheckPower.UseVisualStyleBackColor = true;
            // 
            // OptionsBack
            // 
            this.OptionsBack.AutoSize = true;
            this.OptionsBack.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OptionsBack.Location = new System.Drawing.Point(96, 284);
            this.OptionsBack.Name = "OptionsBack";
            this.OptionsBack.Size = new System.Drawing.Size(82, 39);
            this.OptionsBack.TabIndex = 1;
            this.OptionsBack.Text = "Back";
            this.OptionsBack.Click += new System.EventHandler(this.OptionsBack_Click);
            this.OptionsBack.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.OptionsBack.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ball speed";
            // 
            // BallSpeed
            // 
            this.BallSpeed.AutoSize = true;
            this.BallSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BallSpeed.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BallSpeed.Location = new System.Drawing.Point(224, 56);
            this.BallSpeed.Name = "BallSpeed";
            this.BallSpeed.Size = new System.Drawing.Size(27, 29);
            this.BallSpeed.TabIndex = 1;
            this.BallSpeed.Text = "5";
            // 
            // BarSpeed
            // 
            this.BarSpeed.LargeChange = 1;
            this.BarSpeed.Location = new System.Drawing.Point(33, 61);
            this.BarSpeed.Minimum = 5;
            this.BarSpeed.Name = "BarSpeed";
            this.BarSpeed.Size = new System.Drawing.Size(184, 45);
            this.BarSpeed.TabIndex = 0;
            this.BarSpeed.TabStop = false;
            this.BarSpeed.Value = 5;
            this.BarSpeed.Scroll += new System.EventHandler(this.BarSpeed_Scroll);
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.White;
            this.ControlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlsPanel.Controls.Add(this.ControlsBack);
            this.ControlsPanel.Controls.Add(this.label4);
            this.ControlsPanel.Controls.Add(this.label8);
            this.ControlsPanel.Controls.Add(this.label7);
            this.ControlsPanel.Controls.Add(this.label6);
            this.ControlsPanel.Controls.Add(this.label12);
            this.ControlsPanel.Controls.Add(this.label10);
            this.ControlsPanel.Controls.Add(this.label11);
            this.ControlsPanel.Controls.Add(this.label9);
            this.ControlsPanel.Controls.Add(this.label5);
            this.ControlsPanel.Controls.Add(this.label3);
            this.ControlsPanel.Location = new System.Drawing.Point(-61, 35);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(279, 351);
            this.ControlsPanel.TabIndex = 10;
            this.ControlsPanel.Visible = false;
            // 
            // ControlsBack
            // 
            this.ControlsBack.AutoSize = true;
            this.ControlsBack.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlsBack.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ControlsBack.Location = new System.Drawing.Point(96, 284);
            this.ControlsBack.Name = "ControlsBack";
            this.ControlsBack.Size = new System.Drawing.Size(82, 39);
            this.ControlsBack.TabIndex = 1;
            this.ControlsBack.Text = "Back";
            this.ControlsBack.Click += new System.EventHandler(this.OptionsBack_Click);
            this.ControlsBack.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.ControlsBack.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Player 2 Controls";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(37, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Move down";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(34, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Move down";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(37, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Move up";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(183, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "S";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(163, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "↓ DOWN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(183, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "W";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(163, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "↑ UP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(34, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Move up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 1 Controls";
            // 
            // lbL1
            // 
            this.lbL1.AutoSize = true;
            this.lbL1.BackColor = System.Drawing.Color.OrangeRed;
            this.lbL1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL1.ForeColor = System.Drawing.Color.White;
            this.lbL1.Location = new System.Drawing.Point(20, 75);
            this.lbL1.Name = "lbL1";
            this.lbL1.Size = new System.Drawing.Size(41, 43);
            this.lbL1.TabIndex = 11;
            this.lbL1.Text = "L";
            // 
            // lbO1
            // 
            this.lbO1.AutoSize = true;
            this.lbO1.BackColor = System.Drawing.Color.OrangeRed;
            this.lbO1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbO1.ForeColor = System.Drawing.Color.White;
            this.lbO1.Location = new System.Drawing.Point(16, 130);
            this.lbO1.Name = "lbO1";
            this.lbO1.Size = new System.Drawing.Size(48, 43);
            this.lbO1.TabIndex = 12;
            this.lbO1.Text = "O";
            // 
            // lbS1
            // 
            this.lbS1.AutoSize = true;
            this.lbS1.BackColor = System.Drawing.Color.OrangeRed;
            this.lbS1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS1.ForeColor = System.Drawing.Color.White;
            this.lbS1.Location = new System.Drawing.Point(18, 185);
            this.lbS1.Name = "lbS1";
            this.lbS1.Size = new System.Drawing.Size(44, 43);
            this.lbS1.TabIndex = 13;
            this.lbS1.Text = "S";
            // 
            // lbE1
            // 
            this.lbE1.AutoSize = true;
            this.lbE1.BackColor = System.Drawing.Color.OrangeRed;
            this.lbE1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE1.ForeColor = System.Drawing.Color.White;
            this.lbE1.Location = new System.Drawing.Point(18, 238);
            this.lbE1.Name = "lbE1";
            this.lbE1.Size = new System.Drawing.Size(44, 43);
            this.lbE1.TabIndex = 14;
            this.lbE1.Text = "E";
            // 
            // lbR1
            // 
            this.lbR1.AutoSize = true;
            this.lbR1.BackColor = System.Drawing.Color.OrangeRed;
            this.lbR1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR1.ForeColor = System.Drawing.Color.White;
            this.lbR1.Location = new System.Drawing.Point(17, 289);
            this.lbR1.Name = "lbR1";
            this.lbR1.Size = new System.Drawing.Size(46, 43);
            this.lbR1.TabIndex = 15;
            this.lbR1.Text = "R";
            // 
            // lbR2
            // 
            this.lbR2.AutoSize = true;
            this.lbR2.BackColor = System.Drawing.Color.Gold;
            this.lbR2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR2.ForeColor = System.Drawing.Color.White;
            this.lbR2.Location = new System.Drawing.Point(697, 288);
            this.lbR2.Name = "lbR2";
            this.lbR2.Size = new System.Drawing.Size(46, 43);
            this.lbR2.TabIndex = 20;
            this.lbR2.Text = "R";
            // 
            // lbE2
            // 
            this.lbE2.AutoSize = true;
            this.lbE2.BackColor = System.Drawing.Color.Gold;
            this.lbE2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbE2.ForeColor = System.Drawing.Color.White;
            this.lbE2.Location = new System.Drawing.Point(698, 237);
            this.lbE2.Name = "lbE2";
            this.lbE2.Size = new System.Drawing.Size(44, 43);
            this.lbE2.TabIndex = 19;
            this.lbE2.Text = "E";
            // 
            // lbS2
            // 
            this.lbS2.AutoSize = true;
            this.lbS2.BackColor = System.Drawing.Color.Gold;
            this.lbS2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS2.ForeColor = System.Drawing.Color.White;
            this.lbS2.Location = new System.Drawing.Point(698, 185);
            this.lbS2.Name = "lbS2";
            this.lbS2.Size = new System.Drawing.Size(44, 43);
            this.lbS2.TabIndex = 18;
            this.lbS2.Text = "S";
            // 
            // lbO2
            // 
            this.lbO2.AutoSize = true;
            this.lbO2.BackColor = System.Drawing.Color.Gold;
            this.lbO2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbO2.ForeColor = System.Drawing.Color.White;
            this.lbO2.Location = new System.Drawing.Point(696, 129);
            this.lbO2.Name = "lbO2";
            this.lbO2.Size = new System.Drawing.Size(48, 43);
            this.lbO2.TabIndex = 17;
            this.lbO2.Text = "O";
            // 
            // lbL2
            // 
            this.lbL2.AutoSize = true;
            this.lbL2.BackColor = System.Drawing.Color.Gold;
            this.lbL2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbL2.ForeColor = System.Drawing.Color.White;
            this.lbL2.Location = new System.Drawing.Point(700, 74);
            this.lbL2.Name = "lbL2";
            this.lbL2.Size = new System.Drawing.Size(41, 43);
            this.lbL2.TabIndex = 16;
            this.lbL2.Text = "L";
            // 
            // lbIme1
            // 
            this.lbIme1.AutoSize = true;
            this.lbIme1.BackColor = System.Drawing.Color.Transparent;
            this.lbIme1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIme1.ForeColor = System.Drawing.Color.White;
            this.lbIme1.Location = new System.Drawing.Point(81, 19);
            this.lbIme1.Margin = new System.Windows.Forms.Padding(3);
            this.lbIme1.Name = "lbIme1";
            this.lbIme1.Padding = new System.Windows.Forms.Padding(5);
            this.lbIme1.Size = new System.Drawing.Size(37, 46);
            this.lbIme1.TabIndex = 21;
            this.lbIme1.Text = "1";
            this.lbIme1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbIme2
            // 
            this.lbIme2.AutoSize = true;
            this.lbIme2.BackColor = System.Drawing.Color.Transparent;
            this.lbIme2.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbIme2.ForeColor = System.Drawing.Color.White;
            this.lbIme2.Location = new System.Drawing.Point(625, 19);
            this.lbIme2.Margin = new System.Windows.Forms.Padding(0);
            this.lbIme2.Name = "lbIme2";
            this.lbIme2.Padding = new System.Windows.Forms.Padding(5);
            this.lbIme2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbIme2.Size = new System.Drawing.Size(41, 46);
            this.lbIme2.TabIndex = 22;
            this.lbIme2.Text = "2";
            this.lbIme2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndGame
            // 
            this.EndGame.AutoSize = true;
            this.EndGame.BackColor = System.Drawing.Color.Transparent;
            this.EndGame.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndGame.ForeColor = System.Drawing.Color.White;
            this.EndGame.Location = new System.Drawing.Point(530, 347);
            this.EndGame.Name = "EndGame";
            this.EndGame.Size = new System.Drawing.Size(145, 39);
            this.EndGame.TabIndex = 1;
            this.EndGame.Text = "End Game";
            this.EndGame.Visible = false;
            this.EndGame.Click += new System.EventHandler(this.EndGame_Click);
            this.EndGame.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.EndGame.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // PauseGame
            // 
            this.PauseGame.AutoSize = true;
            this.PauseGame.BackColor = System.Drawing.Color.Transparent;
            this.PauseGame.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseGame.ForeColor = System.Drawing.Color.White;
            this.PauseGame.Location = new System.Drawing.Point(85, 349);
            this.PauseGame.Name = "PauseGame";
            this.PauseGame.Size = new System.Drawing.Size(97, 39);
            this.PauseGame.TabIndex = 1;
            this.PauseGame.Text = "Pause";
            this.PauseGame.Visible = false;
            this.PauseGame.Click += new System.EventHandler(this.PauseGame_Click);
            this.PauseGame.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.PauseGame.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // PlayAgain
            // 
            this.PlayAgain.AutoSize = true;
            this.PlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.PlayAgain.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Orange;
            this.PlayAgain.Location = new System.Drawing.Point(510, 9);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(151, 39);
            this.PlayAgain.TabIndex = 1;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.Visible = false;
            this.PlayAgain.Click += new System.EventHandler(this.Start_Click);
            this.PlayAgain.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.PlayAgain.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // pbOn
            // 
            this.pbOn.BackColor = System.Drawing.Color.Transparent;
            this.pbOn.BackgroundImage = global::Pong.Properties.Resources.On;
            this.pbOn.Location = new System.Drawing.Point(707, -4);
            this.pbOn.Name = "pbOn";
            this.pbOn.Size = new System.Drawing.Size(46, 52);
            this.pbOn.TabIndex = 23;
            this.pbOn.TabStop = false;
            this.pbOn.Click += new System.EventHandler(this.pbOn_Click);
            // 
            // pbOff
            // 
            this.pbOff.BackColor = System.Drawing.Color.Transparent;
            this.pbOff.BackgroundImage = global::Pong.Properties.Resources.Off;
            this.pbOff.Location = new System.Drawing.Point(711, 66);
            this.pbOff.Name = "pbOff";
            this.pbOff.Size = new System.Drawing.Size(46, 52);
            this.pbOff.TabIndex = 23;
            this.pbOff.TabStop = false;
            this.pbOff.Visible = false;
            this.pbOff.Click += new System.EventHandler(this.pbOff_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 405);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.pbOff);
            this.Controls.Add(this.pbOn);
            this.Controls.Add(this.lbIme2);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.PauseGame);
            this.Controls.Add(this.EndGame);
            this.Controls.Add(this.lbIme1);
            this.Controls.Add(this.lbR2);
            this.Controls.Add(this.lbE2);
            this.Controls.Add(this.lbS2);
            this.Controls.Add(this.lbO2);
            this.Controls.Add(this.lbL2);
            this.Controls.Add(this.lbR1);
            this.Controls.Add(this.lbE1);
            this.Controls.Add(this.lbS1);
            this.Controls.Add(this.lbO1);
            this.Controls.Add(this.lbL1);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.MeniPanel);
            this.Controls.Add(this.GamePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong#";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GamePanel.ResumeLayout(false);
            this.GamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPowerUp)).EndInit();
            this.MeniPanel.ResumeLayout(false);
            this.MeniPanel.PerformLayout();
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarSpeed)).EndInit();
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Panel MeniPanel;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label Options;
        public System.Windows.Forms.Label Start;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ballPanel;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Label BallSpeed;
        private System.Windows.Forms.TrackBar BarSpeed;
        private System.Windows.Forms.Label OptionsBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckReverse;
        private System.Windows.Forms.CheckBox CheckPower;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.Label ControlsBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbL1;
        private System.Windows.Forms.Label lbO1;
        private System.Windows.Forms.Label lbS1;
        private System.Windows.Forms.Label lbE1;
        private System.Windows.Forms.Label lbR1;
        private System.Windows.Forms.Label lbR2;
        private System.Windows.Forms.Label lbE2;
        private System.Windows.Forms.Label lbS2;
        private System.Windows.Forms.Label lbO2;
        private System.Windows.Forms.Label lbL2;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName1;
        private System.Windows.Forms.Label lbIme1;
        private System.Windows.Forms.Label lbIme2;
        private System.Windows.Forms.Label EndGame;
        public System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.Label PauseGame;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Cdown;
        private System.Windows.Forms.Label PlayAgain;
        private System.Windows.Forms.PictureBox pbOn;
        private System.Windows.Forms.PictureBox pbOff;
        private System.Windows.Forms.PictureBox pbPowerUp;


    }
}