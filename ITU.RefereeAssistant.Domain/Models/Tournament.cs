using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{

    public class Tournament
    {
        public Tournament()
        {
            Start = new List<Raiting>();
            Current = new List<Raiting>();
            Rounds = new List<Round>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"> Стартовый набор команд</param>
        /// <param name="type"> Тип системы проведения турнира</param>
        public Tournament(Raiting[] start) : this() //вызов конструктора public Tournament()
        {
            Start.AddRange(start);
        }

        #region MyRegion
        string Name { get; set; }
        TournamentType Type { get; set; }
        public List<Raiting> Start { get; set; }
        public List<Raiting> Current { get; set; }
        public List<Round> Rounds { get; set; }
        #endregion

    }
}
