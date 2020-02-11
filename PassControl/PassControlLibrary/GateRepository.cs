using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class GateRepository
    {
        private List<Gate> gates;

        public GateRepository()
        {
            gates = new List<Gate>();
            gates.Add(new Gate(1, "pietinis"));
            gates.Add(new Gate(2, "siaurinis"));
            gates.Add(new Gate(3, "vakarinis"));
            gates.Add(new Gate(4, "rytinis"));

        }
        public List<Gate> Retrieve()
        {
            return gates;
        }
        public Gate Retrieve(int id)
        {
            foreach (var gate in gates)
            {
                if (gate.Id == id)
                    return gate;
            }
            return null;
        }
    }
}
