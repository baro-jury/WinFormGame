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
    public partial class frmPlay : Form
    {
        Point airplaneInitialPos = new Point();
        Point bird1InitialPos = new Point();
        Point bird2InitialPos = new Point();
        Point bird3InitialPos = new Point();
        Point cloud1InitialPos = new Point();
        Point cloud2InitialPos = new Point();
        Point cloud3InitialPos = new Point();
        Point coin1InitialPos = new Point();
        Point coin2InitialPos = new Point();
        Point coin3InitialPos = new Point();
        public frmPlay()
        {
            InitializeComponent();

            airplaneInitialPos = pbAirplane.Location;
            bird1InitialPos = pbBird1.Location;
            bird2InitialPos = pbBird2.Location;
            bird3InitialPos = pbBird3.Location;
            cloud1InitialPos = pbCloud1.Location;
            cloud2InitialPos = pbCloud2.Location;
            cloud3InitialPos = pbCloud3.Location;
            coin1InitialPos = pbCoin1.Location;
            coin2InitialPos = pbCoin2.Location;
            coin3InitialPos = pbCoin3.Location;

            pbCoin2.Visible = false;
            pbCoin3.Visible = false;
            pnGameOver.Visible = false;
        }

        #region Method

        int speed = 5;
        bool goLeft = false, goRight = false, goUp = false, goDown = false;
        int collectedCoins = 0;
        Random random = new Random();

        void moveObject(PictureBox pb, int speed)
        {
            if (pb.Top > pnScreen.Height)
            {
                pb.Location = new Point
                    (random.Next(pnScreen.Left, pnScreen.Width - pb.Width), pnScreen.Top);
            }
            else
            {
                pb.Top += speed;
            }
        }

        void collideWithBird(PictureBox pb)
        {
            if (pbAirplane.Bounds.IntersectsWith(pb.Bounds))
            {
                timer1.Enabled = false;
                pnGameOver.Enabled = true;
                pnGameOver.Visible = true;
            }
        }

        void collectCoin(PictureBox pb)
        {
            if (pbAirplane.Bounds.IntersectsWith(pb.Bounds))
            {
                collectedCoins++;
                lbScore.Text = "= " + collectedCoins.ToString();
                pb.Location = new Point
                    (random.Next(pnScreen.Left, pnScreen.Width - pb.Width), pnScreen.Top);
            }
        }

        void moveAirplane()
        {
            if (goLeft)
            {
                if (pbAirplane.Left > pnScreen.Left)
                {
                    pbAirplane.Left += -speed;
                }
            }
            if (goRight)
            {
                if (pbAirplane.Right < pnScreen.Width)
                {
                    pbAirplane.Left += speed;
                }
            }
            if (goUp)
            {
                if (pbAirplane.Top > pnScreen.Top)
                {
                    pbAirplane.Top += -speed;
                }
            }
            if (goDown)
            {
                if (pbAirplane.Bottom < pnScreen.Height)
                {
                    pbAirplane.Top += speed;
                }
            }
        }

        void moveBird()
        {
            moveObject(pbBird1, speed);
            moveObject(pbBird2, speed);
            moveObject(pbBird3, speed);
        }

        void moveCloud()
        {
            moveObject(pbCloud1, speed);
            moveObject(pbCloud2, speed);
            moveObject(pbCloud3, speed);
        }

        void moveCoin()
        {
            moveObject(pbCoin1, speed);
            //moveObject(pbCoin2, speed);
            //moveObject(pbCoin3, speed);
        }

        void getScore()
        {
            collectCoin(pbCoin1);
            //collectCoin(pbCoin2);
            //collectCoin(pbCoin3);
        }

        void gameover()
        {
            collideWithBird(pbBird1);
            collideWithBird(pbBird2);
            collideWithBird(pbBird3);
            using (var context = new AirplaneContext())
            {

            }
        }
        #endregion

        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveAirplane();
            moveBird();
            moveCloud();
            moveCoin();
            getScore();
            gameover();
        }

        private void frmPlay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void frmPlay_KeyDown(object sender, KeyEventArgs e)
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
            moveAirplane();
        }

        private void btReplay_Click(object sender, EventArgs e)
        {
            pnGameOver.Visible = false;
            pnGameOver.Enabled = false;
            collectedCoins = 0;
            lbScore.Text = "= " + collectedCoins.ToString();
            pbAirplane.Location = airplaneInitialPos;
            pbBird1.Location = bird1InitialPos;
            pbBird2.Location = bird2InitialPos;
            pbBird3.Location = bird3InitialPos;
            pbCloud1.Location = cloud1InitialPos;
            pbCloud2.Location = cloud2InitialPos;
            pbCloud3.Location = cloud3InitialPos;
            pbCoin1.Location = coin1InitialPos;
            pbCoin2.Location = coin2InitialPos;
            pbCoin3.Location = coin3InitialPos;
            goLeft = false; goRight = false; goUp = false; goDown = false;
            timer1.Start();
        }

        private void btViewScore_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
