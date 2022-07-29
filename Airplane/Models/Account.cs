using System;
using System.Collections.Generic;

#nullable disable

namespace Airplane.Models
{
    public partial class Account
    {
        public Account()
        {
            Scores = new HashSet<Score>();
        }

        public string UserName { get; set; }

        public virtual ICollection<Score> Scores { get; set; }
    }
}
