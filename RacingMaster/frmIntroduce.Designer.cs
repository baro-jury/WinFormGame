namespace RacingMaster
{
    partial class frmIntroduce
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btLog = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbIntroduce = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Jokerman", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTitle.Location = new System.Drawing.Point(225, 155);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(350, 70);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Racing Master";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLogin
            // 
            this.pnLogin.BackgroundImage = global::RacingMaster.Properties.Resources.flame_bgr;
            this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogin.Controls.Add(this.btLog);
            this.pnLogin.Controls.Add(this.btAdd);
            this.pnLogin.Controls.Add(this.tbUsername);
            this.pnLogin.Controls.Add(this.lbUsername);
            this.pnLogin.Location = new System.Drawing.Point(270, 301);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(260, 120);
            this.pnLogin.TabIndex = 2;
            // 
            // btLog
            // 
            this.btLog.Location = new System.Drawing.Point(140, 78);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(100, 30);
            this.btLog.TabIndex = 3;
            this.btLog.Text = "Old Racer";
            this.btLog.UseVisualStyleBackColor = true;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(20, 78);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 30);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "New Racer";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(20, 41);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(220, 27);
            this.tbUsername.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Segoe Script", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(45, 12);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(170, 25);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Enter your name\r\n";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIntroduce
            // 
            this.lbIntroduce.BackColor = System.Drawing.Color.Transparent;
            this.lbIntroduce.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIntroduce.ForeColor = System.Drawing.Color.White;
            this.lbIntroduce.Location = new System.Drawing.Point(225, 229);
            this.lbIntroduce.Name = "lbIntroduce";
            this.lbIntroduce.Size = new System.Drawing.Size(350, 70);
            this.lbIntroduce.TabIndex = 3;
            this.lbIntroduce.Text = "Use arrows (← → ↑ ↓) to drive the car. Don\'t hit other cars, survive as long as y" +
    "ou can and collect coins.\r\n";
            this.lbIntroduce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIntroduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RacingMaster.Properties.Resources.raceIntro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lbIntroduce);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.lbTitle);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmIntroduce";
            this.Text = "NeedForSpeed";
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbIntroduce;
    }
}