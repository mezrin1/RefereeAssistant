using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITU.RefereeAssistant.Domain.Models
{
    class Round
    {
        long ID { get; set; }

        Match[] Mathcse { get; set; }
    }
}
