using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    class Event
    {
        public int Id { get; private set; }
        public int HumanId { get; private set; }
        public int GateId { get; private set; }
        public DateTime Date;
        public bool Pass { get; private set; }

        public Event(int id, int humanId, int gateId, DateTime date, bool pass)
        {
            Id = id;
            HumanId = humanId;
            GateId = gateId;
            Date = date;
            Pass = pass;
        }
    }
}
