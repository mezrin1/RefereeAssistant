using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Match
    {
        public Match()
        {
            Players = new List<Player>();
            Raitings = new List<Raiting>();
        }

        /// <summary>
        /// идентификатор
        /// </summary>
        long ID { get; set; }

        /// <summary>
        /// список участников
        /// </summary>
        public IList<Player> Players { get; set; }

        public IList<Raiting> Raitings { get; set; }

        public override string ToString()
        {
            return String.Join("  |  ", Players);
        }

    }
}
