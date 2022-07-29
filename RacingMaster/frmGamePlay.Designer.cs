namespace RacingMaster
{
    partial class frmGamePlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGamePlay));
            this.pnPlay = new System.Windows.Forms.Panel();
            this.pbExplosion = new System.Windows.Forms.PictureBox();
            this.pbGameover = new System.Windows.Forms.PictureBox();
            this.pbMyCar = new System.Windows.Forms.PictureBox();
            this.pbEnemy1 = new System.Windows.Forms.PictureBox();
            this.pbEnemy2 = new System.Windows.Forms.PictureBox();
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.pbRoad2 = new System.Windows.Forms.PictureBox();
            this.pbRoad1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbScore = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.btReplay = new System.Windows.Forms.Button();
            this.btViewScore = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPlay
            // 
            this.pnPlay.Controls.Add(this.pbExplosion);
            this.pnPlay.Controls.Add(this.pbGameover);
            this.pnPlay.Controls.Add(this.pbMyCar);
            this.pnPlay.Controls.Add(this.pbEnemy1);
            this.pnPlay.Controls.Add(this.pbEnemy2);
            this.pnPlay.Controls.Add(this.pbCoin);
            this.pnPlay.Controls.Add(this.pbRoad2);
            this.pnPlay.Controls.Add(this.pbRoad1);
            this.pnPlay.Location = new System.Drawing.Point(12, 12);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(458, 550);
            this.pnPlay.TabIndex = 0;
            // 
            // pbExplosion
            // 
            this.pbExplosion.Image = global::RacingMaster.Properties.Resources.explosion;
            this.pbExplosion.Location = new System.Drawing.Point(72, 395);
            this.pbExplosion.Name = "pbExplosion";
            this.pbExplosion.Size = new System.Drawing.Size(30, 30);
            this.pbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExplosion.TabIndex = 6;
            this.pbExplosion.TabStop = false;
            // 
            // pbGameover
            // 
            this.pbGameover.BackColor = System.Drawing.Color.Goldenrod;
            this.pbGameover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGameover.Image = ((System.Drawing.Image)(resources.GetObject("pbGameover.Image")));
            this.pbGameover.Location = new System.Drawing.Point(147, 207);
            this.pbGameover.Name = "pbGameover";
            this.pbGameover.Size = new System.Drawing.Size(160, 160);
            this.pbGameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameover.TabIndex = 6;
            this.pbGameover.TabStop = false;
            // 
            // pbMyCar
            // 
            this.pbMyCar.BackColor = System.Drawing.Color.Transparent;
            this.pbMyCar.BackgroundImage = global::RacingMaster.Properties.Resources.road;
            this.pbMyCar.Image = global::RacingMaster.Properties.Resources.car7;
            this.pbMyCar.Location = new System.Drawing.Point(205, 446);
            this.pbMyCar.Name = "pbMyCar";
            this.pbMyCar.Size = new System.Drawing.Size(50, 101);
            this.pbMyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMyCar.TabIndex = 1;
            this.pbMyCar.TabStop = false;
            // 
            // pbEnemy1
            // 
            this.pbEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy1.BackgroundImage = global::RacingMaster.Properties.Resources.road;
            this.pbEnemy1.Image = global::RacingMaster.Properties.Resources.car5;
            this.pbEnemy1.Location = new System.Drawing.Point(28, 103);
            this.pbEnemy1.Name = "pbEnemy1";
            this.pbEnemy1.Size = new System.Drawing.Size(50, 101);
            this.pbEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy1.TabIndex = 1;
            this.pbEnemy1.TabStop = false;
            // 
            // pbEnemy2
            // 
            this.pbEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy2.BackgroundImage = global::RacingMaster.Properties.Resources.road;
            this.pbEnemy2.Image = global::RacingMaster.Properties.Resources.car4;
            this.pbEnemy2.Location = new System.Drawing.Point(348, 207);
            this.pbEnemy2.Name = "pbEnemy2";
            this.pbEnemy2.Size = new System.Drawing.Size(50, 101);
            this.pbEnemy2.TabIndex = 1;
            this.pbEnemy2.TabStop = false;
            // 
            // pbCoin
            // 
            this.pbCoin.BackColor = System.Drawing.Color.Gold;
            this.pbCoin.Image = global::RacingMaster.Properties.Resources.dollar;
            this.pbCoin.Location = new System.Drawing.Point(147, 36);
            this.pbCoin.Name = "pbCoin";
            this.pbCoin.Size = new System.Drawing.Size(40, 40);
            this.pbCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin.TabIndex = 1;
            this.pbCoin.TabStop = false;
            // 
            // pbRoad2
            // 
            this.pbRoad2.Image = global::RacingMaster.Properties.Resources.road;
            this.pbRoad2.Location = new System.Drawing.Point(0, 0);
            this.pbRoad2.Name = "pbRoad2";
            this.pbRoad2.Size = new System.Drawing.Size(458, 560);
            this.pbRoad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad2.TabIndex = 1;
            this.pbRoad2.TabStop = false;
            // 
            // pbRoad1
            // 
            this.pbRoad1.Image = global::RacingMaster.Properties.Resources.road;
            this.pbRoad1.Location = new System.Drawing.Point(0, -550);
            this.pbRoad1.Name = "pbRoad1";
            this.pbRoad1.Size = new System.Drawing.Size(458, 550);
            this.pbRoad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoad1.TabIndex = 0;
            this.pbRoad1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Jokerman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbScore.Location = new System.Drawing.Point(12, 611);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(116, 33);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Coins = 0";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbPlayer.Location = new System.Drawing.Point(12, 565);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(132, 28);
            this.lbPlayer.TabIndex = 2;
            this.lbPlayer.Text = "Racer: Admin";
            // 
            // btReplay
            // 
            this.btReplay.Enabled = false;
            this.btReplay.Location = new System.Drawing.Point(307, 574);
            this.btReplay.Name = "btReplay";
            this.btReplay.Size = new System.Drawing.Size(70, 70);
            this.btReplay.TabIndex = 3;
            this.btReplay.Text = "Replay";
            this.btReplay.UseVisualStyleBackColor = true;
            this.btReplay.Click += new System.EventHandler(this.btReplay_Click);
            // 
            // btViewScore
            // 
            this.btViewScore.Enabled = false;
            this.btViewScore.Location = new System.Drawing.Point(400, 574);
            this.btViewScore.Name = "btViewScore";
            this.btViewScore.Size = new System.Drawing.Size(70, 70);
            this.btViewScore.TabIndex = 4;
            this.btViewScore.Text = "View Score";
            this.btViewScore.UseVisualStyleBackColor = true;
            this.btViewScore.Click += new System.EventHandler(this.btViewScore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 574);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmGamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btViewScore);
            this.Controls.Add(this.btReplay);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pnPlay);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "frmGamePlay";
            this.Text = "Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGamePlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGamePlay_KeyUp);
            this.pnPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnPlay;
        private System.Windows.Forms.PictureBox pbRoad2;
        private System.Windows.Forms.PictureBox pbRoad1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbMyCar;
        private System.Windows.Forms.PictureBox pbEnemy1;
        private System.Windows.Forms.PictureBox pbEnemy2;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Button btReplay;
        private System.Windows.Forms.Button btViewScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbGameover;
        private System.Windows.Forms.PictureBox pbExplosion;
    }
}