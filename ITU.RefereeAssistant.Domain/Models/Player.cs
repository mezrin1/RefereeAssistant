using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    public class Player
    {
        public string Name { get; set; }
        
        public override string ToString()//
        {
            return Name;
        }
    }
}
