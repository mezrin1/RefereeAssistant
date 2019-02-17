using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Round
    {
        public Round()
        {
            Matches = new List<Match>();
        }

        long ID { get; set; }

        public List<Match> Matches { get; set; }

        public void AddMatch(Match match)
        {
            Matches.Add(match);
        }
    }
}
