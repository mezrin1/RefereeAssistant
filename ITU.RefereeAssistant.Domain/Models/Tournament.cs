using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Tournament
    {
        string Name { get; set; }
        TournamentType Type { get; set; }
        Raiting[] StartSet { get; set; }
        Raiting[] Current { get; set; }
        Round[] Rounds { get; set; }
    }
}
