using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane
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
        Point coinInitialPos = new Point();
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
            coinInitialPos = pbCoin1.Location;

            pnGameOver.Visible = false;
        }

        #region Method

        int speed = 5;
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

        void moveCloud()
        {
            moveObject(pbCloud1, speed);
            moveObject(pbCloud2, speed);
            moveObject(pbCloud3, speed);
        }

        void moveBird()
        {
            moveObject(pbBird1, speed);
            moveObject(pbBird2, speed);
            moveObject(pbBird3, speed);
        }

        void moveCoin()
        {
            moveObject(pbCoin1, speed);
            moveObject(pbCoin2, speed);
            moveObject(pbCoin3, speed);
        }

        void getScore()
        {
            collectCoin(pbCoin1);
            collectCoin(pbCoin2);
            collectCoin(pbCoin3);
        }

        void gameover()
        {
            collideWithBird(pbBird1);
            collideWithBird(pbBird2);
            collideWithBird(pbBird3);
        }
        #endregion

        #region Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveCloud();
            moveBird();
            moveCoin();
            getScore();
            gameover();
        }

        private void frmPlay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (pbAirplane.Left > pnScreen.Left)
                {
                    pbAirplane.Left += -2*speed;
                }
            }
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (pbAirplane.Right < pnScreen.Width)
                {
                    pbAirplane.Left += 2 * speed;
                }
            }
            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (pbAirplane.Top > pnScreen.Top)
                {
                    pbAirplane.Top += -2 * speed;
                }
            }
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (pbAirplane.Bottom < pnScreen.Height)
                {
                    pbAirplane.Top += 2 * speed;
                }
            }
        }

        private void btReplay_Click(object sender, EventArgs e)
        {
            pnGameOver.Visible = false;
            pbAirplane.Location = airplaneInitialPos;
            pbBird1.Location = bird1InitialPos;
            pbBird2.Location = bird2InitialPos;
            pbBird3.Location = bird3InitialPos;
            pbCloud1.Location = cloud1InitialPos;
            pbCloud2.Location = cloud2InitialPos;
            pbCloud3.Location = cloud3InitialPos;
            pbCoin1.Location = coinInitialPos;
            timer1.Enabled = true;
        }

        private void btViewScore_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
