using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class Gate
    {
        public int Id { get; private set; }
        public string Code { get; private set; }

        public Gate(int id, string code)
        {
            Id = id;
            Code = code;
        }


    }
}
