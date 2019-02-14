using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    /// <summary>
    /// Тип системы проведения турнира
    /// </summary>
    public enum TournamentType
    {
        /// <summary>
        /// Олимпийская
        /// </summary>
        Olimpic,

        /// <summary>
        /// Швейцарская
        /// </summary>
        Swiss,

        /// <summary>
        /// Круговая
        /// </summary>
        Circle,

        /// <summary>
        /// Нокаут
        /// </summary>
        KnockOut
    }
}
