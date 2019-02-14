using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.Domain.TourType
{
    public class OlympicTourType : ITournamentType
    {
        public string Name => "Олимпийская система"; // вместо return

        public Round GetNextRound(IEnumerable<Player> players, IEnumerable<Round> rounds) //IEnumerable( в метод передается самое простое)
        {

            var round = new Round();
            var playerCount = players.Count();
            var roundCount = rounds.Count();

            var roundLimit = Math.Log(playerCount, 2);

            if(roundCount >= roundLimit)
            {
                return null;
            }

            var winners = new List<Player>();
            var lastRound = rounds.LastOrDefault();

            if (lastRound != null)
            {
                foreach (var match in lastRound.Matches)
                {
                    foreach (var raiting in match.Raitings)
                    {
                        if (raiting.Score == 3)
                        {
                            winners.Add(raiting.Player);
                        }
                    }
                }
            }


            var currentPlayers = lastRound == null
                            ? players
                            : winners;


            var matchCount = currentPlayers.Count() / 2;

            for (int i = 0; i < matchCount; i++)
            {
                var match = new Match();

                var player1 = currentPlayers.ElementAt(i * 2);
                var player2 = currentPlayers.ElementAt(i * 2 + 1);

                match.Players.Add(player1);
                match.Players.Add(player2);

                match.Raitings.Add(new Raiting(player1));
                match.Raitings.Add(new Raiting(player2));

                round.AddMatch(match);
            }

            return round;
        }
    }
}
