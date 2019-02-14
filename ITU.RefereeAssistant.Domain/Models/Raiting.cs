using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ITU.RefereeAssistant.Domain.Models
{
    public class Raiting
    {
        public Raiting(Player player)
        {
            Player = player;
            Score = 0;
        }

        public Player Player { get; set; }
        
        public long Score { get; set; }
    }
}
