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
    public partial class frmScore : Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        private void LoadScore()
        {
            using (var context = new RacingMasterContext())
            {
                //dgvScore.DataSource = context.Scores.
                //    Select(x => new { x.UserName, x.Highscore, x.Time }).
                //    OrderByDescending(x => x.Highscore).
                //    ThenByDescending(x => x.Time).
                //    ToList();


                List<Score> list = context.Scores.Select(x => x).
                    OrderByDescending(x => x.Highscore).
                    ThenByDescending(x => x.Time).
                    ToList();
                while (list.Count > 10)
                {
                    list.Remove(list[list.Count - 1]);
                }
                dgvScore.DataSource = list;
            }
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            dgvScore.AutoGenerateColumns = false;
            dgvScore.Columns["usernameCol"].DataPropertyName = "UserName";
            dgvScore.Columns["scoreCol"].DataPropertyName = "Highscore";
            dgvScore.Columns["timeCol"].DataPropertyName = "Time";
            LoadScore();
        }
    }
}
