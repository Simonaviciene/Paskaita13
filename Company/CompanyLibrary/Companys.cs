using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CompanyLibrary
{
    public class Companys
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public bool NeKomercinesPaskirtiesImone { get; private set; }
        public List<string> phoneNumbers;

        public Companys(int iD, string name, bool neKomercinesPaskirtiesImone, List<string> phoneNumbers)
        {
            ID = iD;
            Name = name;
            NeKomercinesPaskirtiesImone = neKomercinesPaskirtiesImone;
            this.phoneNumbers = phoneNumbers;
        }

        public int TelefonuNumeriuSkaiciavimas()
        {
            return phoneNumbers.Count;
        }
    }
}
