using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class Event
    {
        public Guid Id { get; private set; }
        public int HumanId { get; private set; }
        public int GateId { get; private set; }
        public DateTime Date;
        public bool Pass { get; private set; }

        public Event(Guid id, int humanId, int gateId, DateTime date, bool pass)
        {
            Id = id;
            HumanId = humanId;
            GateId = gateId;
            Date = date;
            Pass = pass;
        }
    }
}
