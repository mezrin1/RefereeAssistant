using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.BL
{
    /// <summary>
    /// Сервис для работы с турнирами
    /// </summary>
    /// <returns>Турнир</returns>
    public class TournamentService
    {
        /// <summary>
        /// ctor - автоматическое создание конструктора класса
        /// </summary>
        public TournamentService()
        {

        }

        public Tournament Create(Raiting[] raitings, TournamentType type)
        {
            var Tournament = new Tournament(raitings, type);
            return Tournament;
        }

        public Round GenerateRound(Tournament tournament)
        {
            var round = tournament.GetNextRound();
            return round;
        }
    }
}
