using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ITU.RefereeAssistant.Domain.Models;

namespace ITU.RefereeAssistant.Domain
{
    /// <summary>
    /// Система проведения турнира
    /// </summary>
    public interface ITournamentType
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; }

        /// <summary>
        /// получить следующий раунд
        /// </summary>
        /// <param name="players">Участники</param>
        /// <returns></returns>
        Round GetNextRound(IEnumerable<Player> players, IEnumerable<Round> rounds);
    }
}
