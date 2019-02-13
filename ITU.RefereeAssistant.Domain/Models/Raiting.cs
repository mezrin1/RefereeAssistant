using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ITU.RefereeAssistant.Domain.Models
{
    public class Raiting
    {
        public Raiting()
        {
            Players = new Player();
        }

        public Player Players { get; set; }
        
        long Score { get; set; }
    }
}
