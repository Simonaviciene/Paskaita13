using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyLibrary;

namespace Company
{
    public class Program
    {
        static void Main(string[] args)
        {
            Companys company = new Companys(1, "UAB Keldera", false, new List<string> { "+37064621141", "+3705562456" });
            Console.WriteLine("ID: {0} \nImones pavadinimas: {1}, \nTipas:{2}, \nKontaktai: {3}",
                company.ID, company.Name, company.NeKomercinesPaskirtiesImone, company.phoneNumbers);

            foreach (var phone in company.phoneNumbers)
            {
                Console.WriteLine("{0}", phone);
                Console.ReadLine();
            }
           
        }
        //CompanyRepository companyRepository = new CompanyRepository();
        //List<Companys> companies = companyRepository.Retrieve();


    }
}
