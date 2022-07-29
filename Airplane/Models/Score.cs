using System;
using System.Collections.Generic;

#nullable disable

namespace Airplane.Models
{
    public partial class Score
    {
        public int ScoreId { get; set; }
        public string UserName { get; set; }
        public int Score1 { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual Account UserNameNavigation { get; set; }
    }
}
