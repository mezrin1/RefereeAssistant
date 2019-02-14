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

        /// <summary>
        /// Получить следующий раунд
        /// </summary>
        /// <returns></returns>
       /* public Round GetNextRound()
        {
            var round = new Round();
            var count = Start.Count;
            var matchCount = count / 2;

            for (int i = 0; i < matchCount; i++)
            {
                var match = new Match();

                switch(Type)
                {
                    case TournamentType.Olimpic: //olympic
                        match.Players.Add(Start[i*2].Player);
                        match.Players.Add(Start[i*2 + 1].Player);
                        break;
                    case TournamentType.Swiss: //swiss
                        match.Players.Add(Start[i].Player);
                        match.Players.Add(Start[count - i - 1].Player);
                        break;
                }

                round.AddMatch(match);
            }

            Rounds.Add(round);

            return round;
        }*/
    }
}
