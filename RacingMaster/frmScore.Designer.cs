namespace RacingMaster
{
    partial class frmScore
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
            this.dgvScore = new System.Windows.Forms.DataGridView();
            this.usernameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScore
            // 
            this.dgvScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameCol,
            this.scoreCol,
            this.timeCol});
            this.dgvScore.Location = new System.Drawing.Point(12, 12);
            this.dgvScore.MultiSelect = false;
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            this.dgvScore.RowHeadersWidth = 51;
            this.dgvScore.RowTemplate.Height = 29;
            this.dgvScore.Size = new System.Drawing.Size(453, 320);
            this.dgvScore.TabIndex = 0;
            // 
            // usernameCol
            // 
            this.usernameCol.HeaderText = "Player";
            this.usernameCol.MinimumWidth = 6;
            this.usernameCol.Name = "usernameCol";
            this.usernameCol.ReadOnly = true;
            this.usernameCol.Width = 125;
            // 
            // scoreCol
            // 
            this.scoreCol.HeaderText = "Score";
            this.scoreCol.MinimumWidth = 6;
            this.scoreCol.Name = "scoreCol";
            this.scoreCol.ReadOnly = true;
            this.scoreCol.Width = 125;
            // 
            // timeCol
            // 
            this.timeCol.HeaderText = "Time";
            this.timeCol.MinimumWidth = 6;
            this.timeCol.Name = "timeCol";
            this.timeCol.ReadOnly = true;
            this.timeCol.Width = 150;
            // 
            // frmScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 344);
            this.Controls.Add(this.dgvScore);
            this.MaximumSize = new System.Drawing.Size(495, 391);
            this.MinimumSize = new System.Drawing.Size(495, 391);
            this.Name = "frmScore";
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.frmScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeCol;
    }
}