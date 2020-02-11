using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class EventControler
    {
        public List<Event> events;
        private HumanRepository humanRepository;

        public EventControler(HumanRepository humanRepository)
        {
            this.humanRepository = humanRepository;
            events = new List<Event>();

        }
        public bool TryPass( int humanId, int gateId)
        {

            Human human = humanRepository.Retrieve(humanId);
            bool hasRight = human.HasRight(gateId);
            
            events.Add(new Event(Guid.NewGuid(), humanId, gateId, DateTime.Now, hasRight));

            return hasRight;


        }

    }
}
