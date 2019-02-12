using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Match
    {
        long ID { get; set; }

        Player[] Players { get; set; }

        Raiting[] Raitings { get; set; }
        //Player[] Winner { get; set; }

        //Round[] Rounds { get; set; }
    }
}
