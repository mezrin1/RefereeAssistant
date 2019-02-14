using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.Domain.TourType
{
    public class CircleTourType : ITournamentType
    {
        public string Name => "Круговая система"; // вместо return

        public Round GetNextRound(IEnumerable<Player> players, IEnumerable<Round> rounds) //IEnumerable( в метод передается самое простое)
        {

            return null;
        }
    }
}
