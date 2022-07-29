namespace Airplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlay));
            this.pbAirplane = new System.Windows.Forms.PictureBox();
            this.pbCloud = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.lbPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAirplane
            // 
            this.pbAirplane.Image = ((System.Drawing.Image)(resources.GetObject("pbAirplane.Image")));
            this.pbAirplane.Location = new System.Drawing.Point(248, 342);
            this.pbAirplane.Name = "pbAirplane";
            this.pbAirplane.Size = new System.Drawing.Size(80, 80);
            this.pbAirplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAirplane.TabIndex = 0;
            this.pbAirplane.TabStop = false;
            // 
            // pbCloud
            // 
            this.pbCloud.Image = ((System.Drawing.Image)(resources.GetObject("pbCloud.Image")));
            this.pbCloud.Location = new System.Drawing.Point(133, 60);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(100, 90);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud.TabIndex = 1;
            this.pbCloud.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = ((System.Drawing.Image)(resources.GetObject("pbBird.Image")));
            this.pbBird.Location = new System.Drawing.Point(325, 93);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(50, 50);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 2;
            this.pbBird.TabStop = false;
            // 
            // pbCoin
            // 
            this.pbCoin.Image = ((System.Drawing.Image)(resources.GetObject("pbCoin.Image")));
            this.pbCoin.Location = new System.Drawing.Point(133, 229);
            this.pbCoin.Name = "pbCoin";
            this.pbCoin.Size = new System.Drawing.Size(40, 40);
            this.pbCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoin.TabIndex = 3;
            this.pbCoin.TabStop = false;
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
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.pbCoin);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbCloud);
            this.Controls.Add(this.pbAirplane);
            this.Name = "frmPlay";
            this.Text = "Traveling...";
            ((System.ComponentModel.ISupportInitialize)(this.pbAirplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAirplane;
        private System.Windows.Forms.PictureBox pbCloud;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.Label lbPlayer;
    }
}
