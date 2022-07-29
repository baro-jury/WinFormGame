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
        Point carInitialPos = new Point();
        Point enemy1InitialPos = new Point();
        Point enemy2InitialPos = new Point();
        Point coinInitialPos = new Point();

        public frmGamePlay()
        {
            InitializeComponent();

            carInitialPos = pbMyCar.Location;
            enemy1InitialPos = pbEnemy1.Location;
            enemy2InitialPos = pbEnemy2.Location;
            coinInitialPos = pbCoin.Location;

            pbGameover.Visible = false;
            pbExplosion.Visible = false;
        }

        #region Method

        int speed = 5;
        bool goLeft = false, goRight = false, goUp = false, goDown = false;
        int collectedCoins = 0;
        Random random = new Random();

        void moveObject(PictureBox pb, int speed)
        {
            if (pb.Top > pnPlay.Height)
            {
                pb.Location = new Point
                    (random.Next(pnPlay.Left, pnPlay.Width - pb.Width), pnPlay.Top);
            }
            else
            {
                pb.Top += speed;
            }
        }

        void crashIntoEnemy(PictureBox enemy)
        {
            if (pbMyCar.Bounds.IntersectsWith(enemy.Bounds))
            {
                timer1.Enabled = false;
                pbGameover.Visible = true;
                pbExplosion.Visible = true;
                pbMyCar.Controls.Add(pbExplosion);
                pbExplosion.Location = new Point(10,10);
                btReplay.Enabled = true;
                btViewScore.Enabled = true;
            }
        }

        void collectCoin(PictureBox coin)
        {
            if (pbMyCar.Bounds.IntersectsWith(coin.Bounds))
            {
                collectedCoins++;
                lbScore.Text = "Coins = " + collectedCoins.ToString();
                coin.Location = new Point
                    (random.Next(pnPlay.Left, pnPlay.Width - coin.Width), pnPlay.Top);
            }
        }

        void driveCar()
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

        void moveTrack()
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

        void moveEnemy()
        {
            moveObject(pbEnemy1, speed);
            moveObject(pbEnemy2, speed);
        }

        void moveCoin()
        {
            moveObject(pbCoin, speed);
        }

        void getScore()
        {
            collectCoin(pbCoin);
        }

        void gameover()
        {
            crashIntoEnemy(pbEnemy1);
            crashIntoEnemy(pbEnemy2);
            using (var context = new AirplaneContext())
            {

            }
        }
        #endregion


        #region Event
        private void btReplay_Click(object sender, EventArgs e)
        {
            pbGameover.Visible = false;
            collectedCoins = 0;
            lbScore.Text = "Coins = " + collectedCoins.ToString();
            pbMyCar.Location = carInitialPos;
            pbEnemy1.Location = enemy1InitialPos;
            pbEnemy2.Location = enemy2InitialPos;
            pbCoin.Location = coinInitialPos;
            btReplay.Enabled = false;
            btViewScore.Enabled = false;
            goLeft = false; goRight = false; goUp = false; goDown = false;
            timer1.Start();
        }

        private void btViewScore_Click(object sender, EventArgs e)
        {

        }
        
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

        

        
        #endregion
    }
}
