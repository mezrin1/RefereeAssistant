using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Match
    {
        /// <summary>
        /// ctor
        /// </summary>
        public Match()
        {
            Players = new List<Player>();
        }

        /// <summary>
        /// идентификатор
        /// </summary>
        long ID { get; set; }

        /// <summary>
        /// список участников
        /// </summary>
        public List<Player> Players { get; set; }

        Raiting[] Raitings { get; set; }

        public override string ToString()
        {
            return String.Join("  |  ", Players);
        }

    }
}
