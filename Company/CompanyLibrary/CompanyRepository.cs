using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibrary
{
    public class CompanyRepository
    {
        private List<Companys> companies;

        public CompanyRepository()
        {
            companies = new List<Companys>
            {
                new Companys(1, "UAB Mazmena", true, new List<string>{"4656352135","5576858"}),
                new Companys(2, "UAB Nezinau", false, new List<string>{"5655","46534575"}),
                new Companys(3, "UAB Pavargau", true, new List<string>{"456645686","5565458"}),
                new Companys(4, "UAB Noriu Atrostogu", true, new List<string>{"65963456","55645656"}),
                new Companys(5, "UAB Atostogu Birza", false, new List<string>{"36366666","56868886"}),
                new Companys(6, "UAB Bet Kas", false, new List<string>{"4656386535","55665464"}),
            };
        }

        public List<Companys> Retrieve()
        {
            return companies;
        }


        public Companys Retrieve(int id)
        {
            foreach(var company in companies)
            {
                if (id == company.ID)
                {
                    return company;
                }
            }
            return null;
        }


    }
}
