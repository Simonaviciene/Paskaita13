using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{

    public class ReportEvent
    {
        public string Human { get; private set; }
        public string Gate { get; private set; }
        public string Date { get; private set; }
        public string Pass { get; private set; }

        public ReportEvent(string human, string gate, DateTime date, bool pass)
        {
            Human = human;
            Gate = gate;
            Date = date.ToString();
           
           if(pass == true)
            {
                Pass = "Praejo";
            }
            else
            {
                Pass = "Nepraejo";
            }
        }

    }
}
