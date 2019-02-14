using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITU.RefereeAssistant.Domain;
using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.BL
{
    /// <summary>
    /// Сервис для работы с турнирами
    /// </summary>
    /// <returns>Турнир</returns>
    public class TournamentService
    {
        ITournamentType tourType { get; set;}

        /// <summary>
        /// ctor - автоматическое создание конструктора класса
        /// </summary>
        public TournamentService()
        {

        }

        

        public Tournament Create(Raiting[] raitings, ITournamentType type)
        {
            tourType = type;
            var Tournament = new Tournament(raitings);
            return Tournament;
        }

        public Round GenerateRound(Tournament tournament)
        {
            var players = tournament.Start.Select(raiting => raiting.Player);

            var round = tourType.GetNextRound(players, tournament.Rounds);

            tournament.Rounds.Add(round);

            return round;
        }
    }
}
