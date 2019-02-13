using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Player
    {
        public string name { get; set; }
        
        public override string ToString()//
        {
            return name;
        }
    }
}
