namespace RacingMaster
{
    partial class frmPlay
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
            this.components = new System.ComponentModel.Container();
            this.pbCloud1 = new System.Windows.Forms.PictureBox();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnScreen = new System.Windows.Forms.Panel();
            this.pbAirplane = new System.Windows.Forms.PictureBox();
            this.pbCoin2 = new System.Windows.Forms.PictureBox();
            this.pbCoin3 = new System.Windows.Forms.PictureBox();
            this.pnGameOver = new System.Windows.Forms.Panel();
            this.btViewScore = new System.Windows.Forms.Button();
            this.btReplay = new System.Windows.Forms.Button();
            this.lbEnd = new System.Windows.Forms.Label();
            this.pbCoin1 = new System.Windows.Forms.PictureBox();
            this.pbBird3 = new System.Windows.Forms.PictureBox();
            this.pbBird1 = new System.Windows.Forms.PictureBox();
            this.pbBird2 = new System.Windows.Forms.PictureBox();
            this.pbCloud3 = new System.Windows.Forms.PictureBox();
            this.pbCloud2 = new System.Windows.Forms.PictureBox();
            this.pbScore = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud1)).BeginInit();
            this.pnScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin3)).BeginInit();
            this.pnGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScore)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCloud1
            // 
            this.pbCloud1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCloud1.Image = global::RacingMaster.Properties.Resources.clouds;
            this.pbCloud1.Location = new System.Drawing.Point(11, 429);
            this.pbCloud1.Name = "pbCloud1";
            this.pbCloud1.Size = new System.Drawing.Size(100, 90);
            this.pbCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud1.TabIndex = 1;
            this.pbCloud1.TabStop = false;
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.Location = new System.Drawing.Point(3, 3);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(46, 20);
            this.lbPlayer.TabIndex = 4;
            this.lbPlayer.Text = "Pilot: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnScreen
            // 
            this.pnScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnScreen.Controls.Add(this.pbAirplane);
            this.pnScreen.Controls.Add(this.pbCoin2);
            this.pnScreen.Controls.Add(this.pbCoin3);
            this.pnScreen.Controls.Add(this.pnGameOver);
            this.pnScreen.Controls.Add(this.pbCoin1);
            this.pnScreen.Controls.Add(this.pbBird3);
            this.pnScreen.Controls.Add(this.pbBird1);
            this.pnScreen.Controls.Add(this.pbBird2);
            this.pnScreen.Controls.Add(this.pbCloud3);
            this.pnScreen.Controls.Add(this.pbCloud2);
            this.pnScreen.Controls.Add(this.pbCloud1);
            this.pnScreen.Location = new System.Drawing.Point(1, 26);
            this.pnScreen.Name = "pnScreen";
            this.pnScreen.Size = new System.Drawing.Size(479, 625);
            this.pnScreen.TabIndex = 6;
            // 
            // pbAirplane
            // 
            this.pbAirplane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAirplane.Image = global::RacingMaster.Properties.Resources.airplane;
            this.pbAirplane.Location = new System.Drawing.Point(210, 535);
            this.pbAirplane.Name = "pbAirplane";
            this.pbAirplane.Size = new System.Drawing.Size(80, 80);
            this.pbAirplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAirplane.TabIndex = 20;
            this.pbAirplane.TabStop = false;
            // 
            // pbCoin2
            // 
            this.pbCoin2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCoin2.Image = global::RacingMaster.Properties.Resources.dollar;
            this.pbCoin2.Location = new System.Drawing.Point(181, 370);
            this.pbCoin2.Name = "pbCoin2";
            this.pbCoin2.Size = new System.Drawing.Size(40, 40);
            this.pbCoin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin2.TabIndex = 19;
            this.pbCoin2.TabStop = false;
            // 
            // pbCoin3
            // 
            this.pbCoin3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCoin3.Image = global::RacingMaster.Properties.Resources.dollar;
            this.pbCoin3.Location = new System.Drawing.Point(416, 158);
            this.pbCoin3.Name = "pbCoin3";
            this.pbCoin3.Size = new System.Drawing.Size(40, 40);
            this.pbCoin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin3.TabIndex = 18;
            this.pbCoin3.TabStop = false;
            // 
            // pnGameOver
            // 
            this.pnGameOver.BackColor = System.Drawing.Color.Yellow;
            this.pnGameOver.Controls.Add(this.btViewScore);
            this.pnGameOver.Controls.Add(this.btReplay);
            this.pnGameOver.Controls.Add(this.lbEnd);
            this.pnGameOver.Location = new System.Drawing.Point(109, 205);
            this.pnGameOver.Name = "pnGameOver";
            this.pnGameOver.Size = new System.Drawing.Size(240, 110);
            this.pnGameOver.TabIndex = 17;
            // 
            // btViewScore
            // 
            this.btViewScore.Location = new System.Drawing.Point(143, 78);
            this.btViewScore.Name = "btViewScore";
            this.btViewScore.Size = new System.Drawing.Size(94, 29);
            this.btViewScore.TabIndex = 18;
            this.btViewScore.Text = "High Score";
            this.btViewScore.UseVisualStyleBackColor = true;
            this.btViewScore.Click += new System.EventHandler(this.btViewScore_Click);
            // 
            // btReplay
            // 
            this.btReplay.Location = new System.Drawing.Point(3, 78);
            this.btReplay.Name = "btReplay";
            this.btReplay.Size = new System.Drawing.Size(94, 29);
            this.btReplay.TabIndex = 17;
            this.btReplay.Text = "Replay";
            this.btReplay.UseVisualStyleBackColor = true;
            this.btReplay.Click += new System.EventHandler(this.btReplay_Click);
            // 
            // lbEnd
            // 
            this.lbEnd.BackColor = System.Drawing.Color.Yellow;
            this.lbEnd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEnd.ForeColor = System.Drawing.Color.Red;
            this.lbEnd.Location = new System.Drawing.Point(0, 0);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(240, 60);
            this.lbEnd.TabIndex = 16;
            this.lbEnd.Text = "Game Over";
            this.lbEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCoin1
            // 
            this.pbCoin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCoin1.Image = global::RacingMaster.Properties.Resources.dollar;
            this.pbCoin1.Location = new System.Drawing.Point(63, 303);
            this.pbCoin1.Name = "pbCoin1";
            this.pbCoin1.Size = new System.Drawing.Size(40, 40);
            this.pbCoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin1.TabIndex = 14;
            this.pbCoin1.TabStop = false;
            // 
            // pbBird3
            // 
            this.pbBird3.BackColor = System.Drawing.Color.Transparent;
            this.pbBird3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBird3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBird3.Image = global::RacingMaster.Properties.Resources.bird;
            this.pbBird3.Location = new System.Drawing.Point(343, 98);
            this.pbBird3.Name = "pbBird3";
            this.pbBird3.Size = new System.Drawing.Size(50, 50);
            this.pbBird3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird3.TabIndex = 13;
            this.pbBird3.TabStop = false;
            // 
            // pbBird1
            // 
            this.pbBird1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBird1.Image = global::RacingMaster.Properties.Resources.bird;
            this.pbBird1.Location = new System.Drawing.Point(39, 119);
            this.pbBird1.Name = "pbBird1";
            this.pbBird1.Size = new System.Drawing.Size(50, 50);
            this.pbBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird1.TabIndex = 12;
            this.pbBird1.TabStop = false;
            // 
            // pbBird2
            // 
            this.pbBird2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBird2.Image = global::RacingMaster.Properties.Resources.bird;
            this.pbBird2.Location = new System.Drawing.Point(299, 337);
            this.pbBird2.Name = "pbBird2";
            this.pbBird2.Size = new System.Drawing.Size(50, 50);
            this.pbBird2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird2.TabIndex = 11;
            this.pbBird2.TabStop = false;
            // 
            // pbCloud3
            // 
            this.pbCloud3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCloud3.Image = global::RacingMaster.Properties.Resources.clouds;
            this.pbCloud3.Location = new System.Drawing.Point(369, 265);
            this.pbCloud3.Name = "pbCloud3";
            this.pbCloud3.Size = new System.Drawing.Size(100, 90);
            this.pbCloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud3.TabIndex = 7;
            this.pbCloud3.TabStop = false;
            // 
            // pbCloud2
            // 
            this.pbCloud2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCloud2.Image = global::RacingMaster.Properties.Resources.clouds;
            this.pbCloud2.Location = new System.Drawing.Point(142, 108);
            this.pbCloud2.Name = "pbCloud2";
            this.pbCloud2.Size = new System.Drawing.Size(100, 90);
            this.pbCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud2.TabIndex = 6;
            this.pbCloud2.TabStop = false;
            // 
            // pbScore
            // 
            this.pbScore.Image = global::RacingMaster.Properties.Resources.dollar;
            this.pbScore.Image = global::RacingMaster.Properties.Resources.dollar;
            this.pbScore.Location = new System.Drawing.Point(397, 3);
            this.pbScore.Name = "pbScore";
            this.pbScore.Size = new System.Drawing.Size(20, 20);
            this.pbScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScore.TabIndex = 7;
            this.pbScore.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Location = new System.Drawing.Point(417, 3);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(31, 20);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "= 0";
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.pbScore);
            this.Controls.Add(this.pnScreen);
            this.Controls.Add(this.lbPlayer);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "frmPlay";
            this.Text = "Traveling...";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPlay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud1)).EndInit();
            this.pnScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin3)).EndInit();
            this.pnGameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCloud1;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnScreen;
        private System.Windows.Forms.PictureBox pbScore;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox pbCloud3;
        private System.Windows.Forms.PictureBox pbCloud2;
        private System.Windows.Forms.PictureBox pbBird3;
        private System.Windows.Forms.PictureBox pbBird1;
        private System.Windows.Forms.PictureBox pbBird2;
        private System.Windows.Forms.PictureBox pbCoin1;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Panel pnGameOver;
        private System.Windows.Forms.Button btViewScore;
        private System.Windows.Forms.Button btReplay;
        private System.Windows.Forms.PictureBox pbCoin2;
        private System.Windows.Forms.PictureBox pbCoin3;
        private System.Windows.Forms.PictureBox pbAirplane;
    }
}
