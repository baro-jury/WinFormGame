using System;
using System.Collections.Generic;

#nullable disable

namespace RacingMaster.Models
{
    public partial class Score
    {
        public int ScoreId { get; set; }
        public string UserName { get; set; }
        public int Highscore { get; set; }
        public DateTime Time { get; set; }

        public virtual Account UserNameNavigation { get; set; }
    }
}
