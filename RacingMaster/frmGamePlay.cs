using RacingMaster.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingMaster
{
    public partial class frmGamePlay : Form
    {
        public Account CurrentAccount { get; }
        Score achievement = new Score();

        Point carInitialPos = new Point();
        Point enemy1InitialPos = new Point();
        Point enemy2InitialPos = new Point();
        Point coinInitialPos = new Point();
        Point road1InitialPos = new Point();
        Point road2InitialPos = new Point();

        public frmGamePlay()
        {
            InitializeComponent();

            carInitialPos = pbMyCar.Location;
            enemy1InitialPos = pbEnemy1.Location;
            enemy2InitialPos = pbEnemy2.Location;
            coinInitialPos = pbCoin.Location;
            road1InitialPos = pbRoad1.Location;
            road2InitialPos = pbRoad2.Location;

            pbGameover.Visible = false;
            pbExplosion.Visible = false;
        }

        public frmGamePlay(Account a)
        {
            InitializeComponent();

            carInitialPos = pbMyCar.Location;
            enemy1InitialPos = pbEnemy1.Location;
            enemy2InitialPos = pbEnemy2.Location;
            coinInitialPos = pbCoin.Location;

            pbGameover.Visible = false;
            pbExplosion.Visible = false;
            CurrentAccount = a;
            lbPlayer.Text = "Racer: " + a.UserName;
        }

        #region Method

        int speed = 5, collectedCoins = 0;
        bool goLeft = false, goRight = false, goUp = false, goDown = false;
        Random random = new Random();

        private void driveCar()
        {
            if (goLeft)
            {
                if (pbMyCar.Left > pnPlay.Left)
                {
                    pbMyCar.Left += -speed;
                }
            }
            if (goRight)
            {
                if (pbMyCar.Right < pnPlay.Width)
                {
                    pbMyCar.Left += speed;
                }
            }
            if (goUp)
            {
                if (pbMyCar.Top > pnPlay.Top)
                {
                    pbMyCar.Top += -speed;
                }
            }
            if (goDown)
            {
                if (pbMyCar.Bottom < pnPlay.Height)
                {
                    pbMyCar.Top += speed;
                }
            }
        }
        private void moveObject(PictureBox pb, int speed)
        {
            if (pb.Top > pnPlay.Height)
            {
                pb.Location = new Point
                    (random.Next(pnPlay.Left, pnPlay.Width - pb.Width), pnPlay.Top + 1);
                if (pb == pbEnemy1 || pb == pbEnemy2)
                {
                    changeEnemy(pb);
                }
            }
            else
            {
                pb.Top += speed;
            }
        }

        private void changeEnemy(PictureBox opponentCar)
        {
            int num = random.Next(1, 7);
            switch (num)
            {
                case 1:
                    opponentCar.Image = Properties.Resources.car1;
                    break;
                case 2:
                    opponentCar.Image = Properties.Resources.car2;
                    break;
                case 3:
                    opponentCar.Image = Properties.Resources.car3;
                    break;
                case 4:
                    opponentCar.Image = Properties.Resources.car4;
                    break;
                case 5:
                    opponentCar.Image = Properties.Resources.car5;
                    break;
                case 6:
                    opponentCar.Image = Properties.Resources.car6;
                    break;
                default:
                    break;
            }
        }

        private void moveTrack()
        {
            pbRoad1.Top += speed;
            pbRoad2.Top += speed;
            if (pbRoad1.Top > pnPlay.Height)
            {
                pbRoad1.Top = -pnPlay.Height;
            }
            if (pbRoad2.Top > pnPlay.Height)
            {
                pbRoad2.Top = -pnPlay.Height;
            }
        }

        private void moveEnemy()
        {
            moveObject(pbEnemy1, speed);
            moveObject(pbEnemy2, speed);
            if (pbEnemy1.Bounds.IntersectsWith(pbCoin.Bounds))
            {
                pbEnemy1.Location = new Point
                (random.Next(pnPlay.Left, pnPlay.Width - pbEnemy1.Width), pnPlay.Top + 1);
            }
            if (pbEnemy2.Bounds.IntersectsWith(pbCoin.Bounds))
            {
                pbEnemy2.Location = new Point
                (random.Next(pnPlay.Left, pnPlay.Width - pbEnemy2.Width), pnPlay.Top + 1);
            }
        }

        private void moveCoin()
        {
            moveObject(pbCoin, speed);
        }

        private void crashIntoEnemy(PictureBox enemy)
        {
            if (pbMyCar.Bounds.IntersectsWith(enemy.Bounds))
            {
                timer1.Enabled = false;
                pbGameover.Visible = true;
                pbExplosion.Visible = true;
                pbMyCar.Controls.Add(pbExplosion);
                pbExplosion.Location = new Point(10, 10);
                btReplay.Enabled = true;
                btViewScore.Enabled = true;
                using (var context = new RacingMasterContext())
                {
                    achievement.ScoreId = 0;
                    achievement.UserName = CurrentAccount.UserName;
                    achievement.Highscore = collectedCoins;
                    achievement.Time = DateTime.Now;
                    context.Scores.Add(achievement);
                    context.SaveChanges();
                }
            }
        }

        private void collectCoin(PictureBox coin)
        {
            if (pbMyCar.Bounds.IntersectsWith(coin.Bounds))
            {
                collectedCoins++;
                if (collectedCoins == 10 || collectedCoins == 30 || collectedCoins == 60 || collectedCoins == 100 || collectedCoins == 150)
                {
                    speed += 1;
                }

                lbScore.Text = "Coins = " + collectedCoins.ToString();

                coin.Location = new Point
                    (random.Next(pnPlay.Left, pnPlay.Width - coin.Width), pnPlay.Top + 1);

            }
        }

        private void getScore()
        {
            collectCoin(pbCoin);
        }

        private void gameover()
        {
            crashIntoEnemy(pbEnemy1);
            crashIntoEnemy(pbEnemy2);
        }
        #endregion

        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            driveCar();
            moveTrack();
            moveEnemy();
            moveCoin();
            getScore();
            gameover();
        }

        private void frmGamePlay_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.Up:
                    goUp = true;
                    break;
                case Keys.Down:
                    goDown = true;
                    break;
            }
            driveCar();
        }

        private void frmGamePlay_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.Down:
                    goDown = false;
                    break;
            }
        }

        private void btReplay_Click(object sender, EventArgs e)
        {
            pbGameover.Visible = false;
            pbExplosion.Visible = false;
            collectedCoins = 0;
            lbScore.Text = "Coins = 0";

            pbMyCar.Location = carInitialPos;
            pbEnemy1.Location = enemy1InitialPos;
            pbEnemy2.Location = enemy2InitialPos;
            pbCoin.Location = coinInitialPos;
            //pbRoad1.Location = road1InitialPos;
            //pbRoad2.Location = road2InitialPos;

            btReplay.Enabled = false;
            btViewScore.Enabled = false;
            goLeft = false; goRight = false; goUp = false; goDown = false;
            speed = 5;
            timer1.Start();
        }

        private void btViewScore_Click(object sender, EventArgs e)
        {
            frmScore newform = new frmScore();
            newform.Show();
        }
        #endregion
    }
}
