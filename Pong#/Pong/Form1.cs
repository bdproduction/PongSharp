using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Pong
{
    public partial class GameForm : Form
    {
        public Label pauselabel;

        public Panel left;
        public Panel right;
        public OvalShape ball;
        public bool[] movement = new bool[4];
        public int ballVel = 0;
        public bool game_start = false;
        public int ScorePlayer1 = 0;
        public int ScorePlayer2 = 0;
        public int speed = 6;
        public int speedinc = 0;
        public Random rand = new Random();
        public int maxspeed = 10;
        public int minspeed = 5;
        public bool Ongoing = false;
        public int Acount = 3;
        int StartHeight = 0;
        public bool[] PowerUp = new bool[4];
        public int hit = 0;
        System.Media.SoundPlayer player =
               new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 =
               new System.Media.SoundPlayer();


        public GameForm()
        {
            InitializeComponent();
            GamePanel.Visible = false;

            MeniPanel.Visible = true;
            left = this.LeftPanel;
            right = this.RightPanel;
            StartHeight = left.Height;
            lbIme1.Visible = false;
            lbIme2.Visible = false;
            ScoreClear();
            ball = this.ballPanel;
            pbOn.Visible = true;
            pbOn.BackgroundImage = Image.FromFile("On.png");
            pbOff.BackgroundImage = Image.FromFile("Off.png");
            player.SoundLocation = "BigBounce.wav";

            if (player.SoundLocation != null)
            {
                player.Load();
                player.PlayLooping();
            }
            OptionsPanel.Visible = false;
            KeyPreview = true;
            timer2.Interval = 1000;
            timer1.Interval = 1000 / 60;
            timer1.Start();
        }

        private void playSound(string path)
        {
            if (pbOn.Visible)
            {
                player1.SoundLocation = path;
                if (player1.SoundLocation != null)
                {
                    player1.Load();
                    player1.Play();
                }
            }
        }

        void Countdown()
        {
            Ongoing = false;
            Acount = 3;
            Cdown.Text = Acount.ToString();
            game_start = false;
            Cdown.Location = new Point(GamePanel.Width / 2 - 20, GamePanel.Height / 2 - 50);
            Cdown.Visible = true;
            timer2.Enabled = true;
            timer2.Start();

        }

        private void StopSound()
        {
            player.Stop();
            player1.Stop();
        }

        private void goaled()
        {
            int i = 0;
            while (PowerUp[i])
            {
                PowerUp[i] = false;
                i++;
            }
            hit = 0;
            right.Height = left.Height = StartHeight;
            pbPowerUp.Visible = false;
            if (ScorePlayer1 < 5 && ScorePlayer2 < 5)
                Countdown();
            ball.Location = new Point(297, 100);
            ballVel = rand.Next(0, 4);
            speed = BarSpeed.Value;

        }

        private void incSpeed()
        {
            speedinc += 1;
            if (speedinc > 3)
            {
                speedinc = 0;
                speed += 1;
                if (speed > maxspeed)
                {
                    speed = maxspeed;
                }
            }
        }

        void PowerUps()
        {
            if (hit == rand.Next(2, 5))
            {
                hit = 0;
                PowerUp[rand.Next(0, 4)] = true;

                if (PowerUp[0])
                {
                    pbPowerUp.Visible = true;
                    pbPowerUp.BackgroundImage = Image.FromFile("Reverse.png");
                    pbPowerUp.Location = new Point(rand.Next(GamePanel.Location.X + 130, GamePanel.Size.Width - 130), rand.Next(GamePanel.Location.Y + 50, GamePanel.Height - 50));
                }
                if (PowerUp[1])
                {
                    pbPowerUp.Visible = true;
                    pbPowerUp.BackgroundImage = Image.FromFile("SizeUp.png");
                    pbPowerUp.Location = new Point(rand.Next(GamePanel.Location.X + 130, GamePanel.Size.Width - 130), rand.Next(GamePanel.Location.Y + 50, GamePanel.Height - 50));
                }
                if (PowerUp[2])
                {
                    pbPowerUp.Visible = true;
                    pbPowerUp.BackgroundImage = Image.FromFile("SizeDown.png");
                    pbPowerUp.Location = new Point(rand.Next(GamePanel.Location.X + 130, GamePanel.Size.Width - 130), rand.Next(GamePanel.Location.Y + 50, GamePanel.Height - 50));
                }
                if (PowerUp[3])
                {
                    pbPowerUp.Visible = true;
                    pbPowerUp.BackgroundImage = Image.FromFile("LifePlus.png");
                    pbPowerUp.Location = new Point(rand.Next(GamePanel.Location.X + 130, GamePanel.Size.Width - 130), rand.Next(GamePanel.Location.Y + 50, GamePanel.Height - 50));

                }

            }


            if (PowerUp.Count(b => b == true) == 1)
            {
                if (PowerUp[0])
                {
                    if (((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height)))
                    {

                        playSound("powerUp.wav");
                        PowerUp[0] = false;
                        if (ballVel == 0)
                        {
                            ballVel = 3;
                        }
                        else if (ballVel == 1)
                        {
                            ballVel = 2;
                        }
                        else if (ballVel == 2)
                        {
                            ballVel = 1;
                        }
                        else if (ballVel == 3)
                        {
                            ballVel = 0;
                        }
                        pbPowerUp.Visible = false;
                    }
                }
                else if (PowerUp[1])
                {
                    if (((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height)))
                    {
                        playSound("powerUp.wav");
                        PowerUp[1] = false;
                        if (ballVel == 0)
                        {
                            left.Height += 20;
                        }
                        else if (ballVel == 1)
                        {
                            left.Height += 20;
                        }
                        else if (ballVel == 2)
                        {
                            right.Height += 20;
                        }
                        else if (ballVel == 3)
                        {
                            right.Height += 20;
                        }
                        pbPowerUp.Visible = false;
                    }
                }
                else if (PowerUp[2])
                {
                    if (((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height)))
                    {
                        playSound("powerUp.wav");
                        PowerUp[2] = false;
                        if (ballVel == 0)
                        {
                            left.Height -= 10;
                        }
                        else if (ballVel == 1)
                        {
                            left.Height -= 10;
                        }
                        else if (ballVel == 2)
                        {
                            right.Height -= 10;
                        }
                        else if (ballVel == 3)
                        {
                            right.Height -= 10;
                        }
                        pbPowerUp.Visible = false;
                    }
                }
                else if (PowerUp[3])
                {
                    if (((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X + ball.Size.Width >= pbPowerUp.Location.X && ball.Location.X + ball.Size.Width <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y + ball.Size.Height >= pbPowerUp.Location.Y && ball.Location.Y + ball.Size.Height <= pbPowerUp.Location.Y + pbPowerUp.Size.Height))
                        || ((ball.Location.X >= pbPowerUp.Location.X && ball.Location.X <= pbPowerUp.Location.X + pbPowerUp.Size.Width) && (ball.Location.Y >= pbPowerUp.Location.Y && ball.Location.Y <= pbPowerUp.Location.Y + pbPowerUp.Size.Height)))
                    {
                        playSound("powerUp.wav");
                        PowerUp[3] = false;
                        if (ballVel == 2 || ballVel == 3)
                        {
                            switch (ScorePlayer1)
                            {

                                case 0:
                                    break;
                                case 1:
                                    lbL2.Visible = false;
                                    ScorePlayer1--;
                                    break;
                                case 2:
                                    lbO2.Visible = false;
                                    ScorePlayer1--;
                                    break;
                                case 3:
                                    lbS2.Visible = false;
                                    ScorePlayer1--;
                                    break;
                                case 4:
                                    lbE2.Visible = false;
                                    ScorePlayer1--;
                                    break;
                                case 5:
                                    lbR2.Visible = false;
                                    ScorePlayer1--;
                                    break;
                            }
                        }
                        else
                        {
                            switch (ScorePlayer2)
                            {

                                case 0:
                                    break;
                                case 1:
                                    lbL1.Visible = false;
                                    ScorePlayer2--;
                                    break;
                                case 2:
                                    lbO1.Visible = false;
                                    ScorePlayer2--;
                                    break;
                                case 3:
                                    lbS1.Visible = false;
                                    ScorePlayer2--;
                                    break;
                                case 4:
                                    lbE1.Visible = false;
                                    ScorePlayer2--;
                                    break;
                                case 5:
                                    lbR1.Visible = false;
                                    ScorePlayer2--;
                                    break;
                            }

                        }
                        pbPowerUp.Visible = false;
                    }
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            Keys key = e.KeyCode;



            if (CheckReverse.Checked)
            {
                if (key == Keys.W)
                {
                    movement[0] = false;
                    movement[1] = true;
                }
                else if (key == Keys.S)
                {
                    movement[1] = false;
                    movement[0] = true;
                }
                if (key == Keys.Up)
                {
                    movement[2] = false;
                    movement[3] = true;
                }
                else if (key == Keys.Down)
                {
                    movement[3] = false;
                    movement[2] = true;
                }
            }
            else
            {

                if (key == Keys.W)
                {
                    movement[0] = true;
                    movement[1] = false;
                }
                else if (key == Keys.S)
                {
                    movement[1] = true;
                    movement[0] = false;
                }
                if (key == Keys.Up)
                {
                    movement[2] = true;
                    movement[3] = false;
                }
                else if (key == Keys.Down)
                {
                    movement[3] = true;
                    movement[2] = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            Keys key = e.KeyData;
            if (CheckReverse.Checked)
            {
                if (key == Keys.W)
                {
                    movement[1] = false;
                }
                else if (key == Keys.S)
                {
                    movement[0] = false;
                }
                if (key == Keys.Up)
                {
                    movement[3] = false;
                }
                else if (key == Keys.Down)
                {
                    movement[2] = false;
                }
            }
            else
            {

                if (key == Keys.W)
                {
                    movement[0] = false;
                }
                else if (key == Keys.S)
                {
                    movement[1] = false;
                }
                if (key == Keys.Up)
                {
                    movement[2] = false;
                }
                else if (key == Keys.Down)
                {
                    movement[3] = false;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (ScorePlayer1 == 5)
            {
                Ongoing = false;
                ScorePlayer1 = 0;
                ScorePlayer2 = 0;
                ball.Visible = false;
                PlayAgain.Visible = true;
                PlayAgain.Location = new Point(GamePanel.Width / 2 - 15, GamePanel.Height / 2 + 215);
                lbWin.Text = tbPlayer1.Text.ToUpper() + "\n WINS!";

                lbWin.ForeColor = Color.OrangeRed;
                lbWin.Visible = true;
                left.Location = new Point(left.Location.X, 100);
                right.Location = new Point(right.Location.X, 100);
                game_start = false;
            }
            else if (ScorePlayer2 == 5)
            {
                Ongoing = false;
                ScorePlayer1 = 0;
                ScorePlayer2 = 0;
                ball.Visible = false;
                PlayAgain.Visible = true;
                PlayAgain.Location = new Point(GamePanel.Width / 2 - 15, GamePanel.Height / 2 + 215);
                lbWin.Text = tbPlayer2.Text.ToUpper() + "\n WINS!";

                lbWin.ForeColor = Color.Gold;
                lbWin.Visible = true;
                left.Location = new Point(left.Location.X, 100);
                right.Location = new Point(right.Location.X, 100);
                game_start = false;
            }
            if (movement[0])
            {
                left.Location = new Point(left.Location.X, left.Location.Y - speed);
                if (left.Location.Y <= 0)
                {
                    left.Location = new Point(left.Location.X, 0);
                }
            }
            else if (movement[1])
            {
                left.Location = new Point(left.Location.X, left.Location.Y + speed);
                if (left.Location.Y + left.Size.Height >= GamePanel.Bounds.Height)
                {
                    left.Location = new Point(left.Location.X, GamePanel.Bounds.Height - left.Size.Height);
                }
            }
            if (movement[2])
            {
                right.Location = new Point(right.Location.X, right.Location.Y - speed);
                if (right.Location.Y < 0)
                {
                    right.Location = new Point(right.Location.X, 0);
                }
            }
            else if (movement[3])
            {
                right.Location = new Point(right.Location.X, right.Location.Y + speed);
                if (right.Location.Y + right.Size.Height >= GamePanel.Bounds.Height)
                {
                    right.Location = new Point(right.Location.X, GamePanel.Bounds.Height - right.Size.Height);
                }
            }
            if (game_start)
            {
                StartGame();
            }

        }
        private void StartGame()
        {
            int lx = ball.Location.X;
            int ly = ball.Location.Y;
            if (CheckPower.Checked)
            {
                PowerUps();
            }
            switch (ballVel)
            {
                case 0:
                    ball.Location = new Point(lx + speed, ly + speed);
                    break;
                case 1:
                    ball.Location = new Point(lx + speed, ly - speed);
                    break;
                case 2:
                    ball.Location = new Point(lx - speed, ly + speed);
                    break;
                case 3:
                    ball.Location = new Point(lx - speed, ly - speed);
                    break;
            }

            lx = ball.Location.X;
            ly = ball.Location.Y;
            if (ball.Location.X + ball.Size.Width > GamePanel.Bounds.Width + 5)
            {
                ScorePlayer1 += 1;
                if (ScorePlayer1 == 1)
                {
                    lbL2.Visible = true;
                }
                else
                    if (ScorePlayer1 == 2)
                    {
                        lbO2.Visible = true;
                    }
                    else
                        if (ScorePlayer1 == 3)
                        {
                            lbS2.Visible = true;
                        }
                        else
                            if (ScorePlayer1 == 4)
                            {
                                lbE2.Visible = true;
                            }
                            else
                                if (ScorePlayer1 == 5)
                                {
                                    lbR2.Visible = true;
                                }

                goaled();
            }
            else if (ball.Location.X + 2 < 0)
            {
                ScorePlayer2 += 1;
                if (ScorePlayer2 == 1)
                {
                    lbL1.Visible = true;
                }
                else
                    if (ScorePlayer2 == 2)
                    {
                        lbO1.Visible = true;
                    }
                    else
                        if (ScorePlayer2 == 3)
                        {
                            lbS1.Visible = true;
                        }
                        else
                            if (ScorePlayer2 == 4)
                            {
                                lbE1.Visible = true;
                            }
                            else
                                if (ScorePlayer2 == 5)
                                {
                                    lbR1.Visible = true;
                                }
                goaled();
            }
            else if (ball.Location.Y < 1)
            {
                ball.Location = new Point(ball.Location.X, 1);
                if (ballVel == 1)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarZid.wav");
                    }
                    ballVel = 0;
                }
                else if (ballVel == 3)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarZid.wav");
                    }
                    ballVel = 2;
                }
            }
            else if (ball.Location.Y + ball.Size.Height + 2 >= GamePanel.Bounds.Height - 2)
            {
                ball.Location = new Point(ball.Location.X, GamePanel.Bounds.Height - ball.Size.Height - 2);
                if (ballVel == 0)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarZid.wav");
                    }
                    ballVel = 1;
                }
                else if (ballVel == 2)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarZid.wav");
                    }
                    ballVel = 3;
                }
            }
            else if (((ball.Location.X + ball.Size.Width >= left.Location.X && ball.Location.X + ball.Size.Width <= left.Location.X + left.Size.Width) && (ball.Location.Y + ball.Size.Height >= left.Location.Y && ball.Location.Y + ball.Size.Height <= left.Location.Y + left.Size.Height))
                || ((ball.Location.X + ball.Size.Width >= left.Location.X && ball.Location.X + ball.Size.Width <= left.Location.X + left.Size.Width) && (ball.Location.Y >= left.Location.Y && ball.Location.Y <= left.Location.Y + left.Size.Height))
                || ((ball.Location.X >= left.Location.X && ball.Location.X <= left.Location.X + left.Size.Width) && (ball.Location.Y + ball.Size.Height >= left.Location.Y && ball.Location.Y + ball.Size.Height <= left.Location.Y + left.Size.Height))
                || ((ball.Location.X >= left.Location.X && ball.Location.X <= left.Location.X + left.Size.Width) && (ball.Location.Y >= left.Location.Y && ball.Location.Y <= left.Location.Y + left.Size.Height)))
            {
                ball.Location = new Point(ball.Location.X + speed + rand.Next(0, 3), ball.Location.Y + rand.Next(0, 3));
                if (ballVel == 2)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarPanela.wav");
                    }
                    if ((ball.Location.X + ball.Size.Width == left.Location.X && ball.Location.X + ball.Size.Width == left.Location.X + right.Size.Width) && (ball.Location.Y + ball.Size.Height == left.Location.Y && ball.Location.Y + ball.Size.Height == left.Location.Y + right.Size.Height))
                    {
                        ballVel = 1;
                    }
                    else
                        ballVel = 0;
                }
                else if (ballVel == 3)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarPanela.wav");
                    }
                    if ((ball.Location.X + ball.Size.Width == right.Location.X && ball.Location.X + ball.Size.Width == right.Location.X + right.Size.Width) && (ball.Location.Y == right.Location.Y && ball.Location.Y == right.Location.Y + right.Size.Height))
                        ballVel = 0;
                    else
                        ballVel = 1;
                }
                if (PowerUp.Count(b => b == true) < 1)
                {
                    hit++;
                }
                incSpeed();
            }
            else if (((ball.Location.X + ball.Size.Width >= right.Location.X && ball.Location.X + ball.Size.Width <= right.Location.X + right.Size.Width) && (ball.Location.Y + ball.Size.Height >= right.Location.Y && ball.Location.Y + ball.Size.Height <= right.Location.Y + right.Size.Height))
                || ((ball.Location.X + ball.Size.Width >= right.Location.X && ball.Location.X + ball.Size.Width <= right.Location.X + right.Size.Width) && (ball.Location.Y >= right.Location.Y && ball.Location.Y <= right.Location.Y + right.Size.Height))
                || ((ball.Location.X >= right.Location.X && ball.Location.X <= right.Location.X + right.Size.Width) && (ball.Location.Y + ball.Size.Height >= right.Location.Y && ball.Location.Y + ball.Size.Height <= right.Location.Y + right.Size.Height))
                || ((ball.Location.X >= right.Location.X && ball.Location.X <= right.Location.X + right.Size.Width) && (ball.Location.Y >= right.Location.Y && ball.Location.Y <= right.Location.Y + right.Size.Height)))
            {
                ball.Location = new Point(ball.Location.X - speed - rand.Next(0, 3), ball.Location.Y - rand.Next(0, 3));
                if (ballVel == 0)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarPanela.wav");
                    }
                    if ((ball.Location.X + ball.Size.Width == right.Location.X && ball.Location.X + ball.Size.Width == right.Location.X + right.Size.Width) && (ball.Location.Y + ball.Size.Height == right.Location.Y && ball.Location.Y + ball.Size.Height == right.Location.Y + right.Size.Height))
                    {
                        ballVel = 3;
                    }
                    else
                        ballVel = 2;
                }
                else if (ballVel == 1)
                {
                    if (pbOn.Visible)
                    {
                        playSound("udarPanela.wav");
                    }
                    if ((ball.Location.X + ball.Size.Width == right.Location.X && ball.Location.X + ball.Size.Width == right.Location.X + right.Size.Width) && (ball.Location.Y == right.Location.Y && ball.Location.Y == right.Location.Y + right.Size.Height))
                        ballVel = 2;
                    else
                        ballVel = 3;
                }
                if (PowerUp.Count(b => b == true) < 1)
                {
                    hit++;
                }
                incSpeed();
            }
        }

        private void PauseGame_Click(object sender, EventArgs e)
        {
            if (Ongoing)
            {
                if (game_start)
                    game_start = false;
                else
                    game_start = true;
            }
        }


        private void Start_Click(object sender, EventArgs e)
        {
            BarSpeed.Enabled = false;
            ball.Visible = true;
            this.BackgroundImage = Bitmap.FromFile("background1.png");
            this.BackColor = Color.Teal;
            speed = BarSpeed.Value;
            Countdown();
            ScoreClear();
            GamePanel.Visible = true;
            StopSound();
            MeniPanel.Visible = false;
            EndGame.Visible = true;
            PauseGame.Visible = true;
            PlayAgain.Visible = false;

            lbIme1.Text = tbPlayer1.Text.ToString();
            lbIme1.Visible = true;
            lbIme2.Text = tbPlayer2.Text.ToString();
            lbIme2.Visible = true;
            lbIme2.Location = new Point(GamePanel.Location.X + GamePanel.Size.Width - lbIme2.Size.Width, lbIme2.Location.Y);

            int i = 0;
            while (PowerUp[i])
            {
                PowerUp[i] = false;
                i++;
            }
            right.Height = left.Height = StartHeight;
            pbPowerUp.Visible = false;
        }



        private void Start_MouseHover(object sender, EventArgs e)
        {


            if (sender.Equals(Start))
                Start.ForeColor = Color.Gold;
            else if (sender.Equals(Mode))
                Mode.ForeColor = Color.Crimson;
            else if (sender.Equals(Options))
                Options.ForeColor = Color.Orange;
            else if (sender.Equals(Exit))
                Exit.ForeColor = Color.Green;
            else if (sender.Equals(OptionsBack))
                OptionsBack.ForeColor = Color.OrangeRed;
            else if (sender.Equals(ControlsBack))
                ControlsBack.ForeColor = Color.Crimson;
        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(Start))
                Start.ForeColor = Color.Black;
            else if (sender.Equals(Mode))
                Mode.ForeColor = Color.Black;
            else if (sender.Equals(Options))
                Options.ForeColor = Color.Black;
            else if (sender.Equals(Exit))
                Exit.ForeColor = Color.Black;
            else if (sender.Equals(OptionsBack))
                OptionsBack.ForeColor = SystemColors.ControlDarkDark;
            else if (sender.Equals(ControlsBack))
                ControlsBack.ForeColor = SystemColors.ControlDarkDark;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Options_Click(object sender, EventArgs e)
        {
            if (pbOn.Visible)
            {
                playSound("Meni.wav");
            }
            OptionsPanel.Location = new Point(MeniPanel.Location.X, MeniPanel.Location.Y);
            MeniPanel.Visible = false;
            OptionsPanel.Visible = true;

        }

        private void BarSpeed_Scroll(object sender, EventArgs e)
        {
            BallSpeed.Text = BarSpeed.Value.ToString();
            this.Invalidate();
        }

        private void OptionsBack_Click(object sender, EventArgs e)
        {

            OptionsPanel.Visible = false;
            ControlsPanel.Visible = false;
            MeniPanel.Visible = true;
            if (pbOn.Visible)
            {
                playSound("BigBounce.wav");

            }
            this.Invalidate();
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            if (pbOn.Visible)
            {
                playSound("Meni.wav");
            }
            ControlsPanel.Location = new Point(MeniPanel.Location.X, MeniPanel.Location.Y);
            MeniPanel.Visible = false;
            ControlsPanel.Visible = true;
        }
        void ScoreClear()
        {
            lbWin.Visible = false;
            lbL1.Visible = false;
            lbL2.Visible = false;
            lbO1.Visible = false;
            lbO2.Visible = false;
            lbS1.Visible = false;
            lbS2.Visible = false;
            lbE1.Visible = false;
            lbE2.Visible = false;
            lbR1.Visible = false;
            lbR2.Visible = false;

        }


        private void EndGame_Click(object sender, EventArgs e)
        {
            game_start = false;
            BarSpeed.Enabled = true;
            PlayAgain.Visible = false;
            if (pbOn.Visible)
            {
                player.Play();
            }
            EndGame.Visible = false;
            MeniPanel.Visible = true;
            GamePanel.Visible = false;
            lbIme1.Visible = false;
            lbIme2.Visible = false;
            ScoreClear();
            RestartGame();
            PauseGame.Visible = false;
            hit = 0;
            int i = 0;
            while (PowerUp[i])
            {
                PowerUp[i] = false;
                i++;
            }
            right.Height = left.Height = StartHeight;
            pbPowerUp.Visible = false;
        }


        void RestartGame()
        {
            timer2.Stop();
            int i = 0;
            while (PowerUp[i])
            {
                PowerUp[i] = false;
                i++;
            }
            right.Height = left.Height = StartHeight;
            pbPowerUp.Visible = false;
            ball.Location = new Point(242, 71);
            ballVel = rand.Next(0, 4);
            movement = new bool[4];
            ScorePlayer1 = 0;
            ScorePlayer2 = 0;
            ScoreClear();
            left.Location = new Point(left.Location.X, 100);
            right.Location = new Point(right.Location.X, 100);
            ball.Location = new Point(297, 128);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Acount--;
            Cdown.Text = Acount.ToString();
            Ongoing = false;
            if (Acount == 0)
            {
                Cdown.Text = "Go!";
                Cdown.Location = new Point(GamePanel.Width / 2 - 50, GamePanel.Height / 2 - 50);
                if (pbOn.Visible)
                {
                    playSound("Start.wav");
                }
            }
            if (Acount < 0)
            {
                Ongoing = true;
                game_start = true;
                Cdown.Visible = false;
                Acount = 3;
                Cdown.Text = Acount.ToString();
                timer2.Enabled = false;
                timer2.Stop();



            }



        }

        private void pbOn_Click(object sender, EventArgs e)
        {

            pbOn.Visible = false;
            pbOff.Location = new Point(pbOn.Location.X, pbOn.Location.Y);
            pbOff.Visible = true;
            StopSound();


        }

        private void pbOff_Click(object sender, EventArgs e)
        {
            pbOn.Visible = true;

            pbOff.Visible = false;
            if (MeniPanel.Visible)
            {
                playSound(player.SoundLocation);
            }

        }




    }
}