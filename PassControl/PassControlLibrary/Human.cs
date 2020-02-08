using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
  
    public class Human
    {
        public int Id { get;  private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<int> gateIdRights;


        public Human(int id, string name, string surname, List<int> gateIdRights)
        {
            Id = id;
            Name = name;
            Surname = surname;
            this.gateIdRights = gateIdRights;
        }

        public bool HasRight(int gateId)
        {
            foreach (var oneGate in gateIdRights)
            {
                if(oneGate == gateId)
                {
                    return true;
                }
               
            }
            return false;
            
        }
    }
}
