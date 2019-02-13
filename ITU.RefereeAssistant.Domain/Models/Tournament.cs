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
        public Tournament(Raiting[] start, TournamentType type) : this() //вызов конструктора public Tournament()
        {
            Start.AddRange(start);
            Type = type;//
        }

        #region MyRegion
        string Name { get; set; }
        TournamentType Type { get; set; }
        List<Raiting> Start { get; set; }
        List<Raiting> Current { get; set; }
        List<Round> Rounds { get; set; }
        #endregion

        /// <summary>
        /// Получить следующий раунд
        /// </summary>
        /// <returns></returns>
        public Round GetNextRound()
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
                        match.Players.Add(Start[i*2].Players);
                        match.Players.Add(Start[i*2 + 1].Players);
                        break;
                    case TournamentType.Swiss: //swiss
                        match.Players.Add(Start[i].Players);
                        match.Players.Add(Start[count - i - 1].Players);
                        break;
                }

                round.AddMatch(match);
            }

            Rounds.Add(round);

            return round;
        }
    }
}
