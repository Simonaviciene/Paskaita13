using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassControlLibrary;




namespace PassControl
{
    class Program
    {
        static void Main(string[] args)
        {
            GateRepository gateRepository = new GateRepository();
            HumanRepository humanRepository = new HumanRepository();
            EventControler eventControler = new EventControler(humanRepository);
            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Pasirinkite veiksmas: [1] - Bandyti praeiti, [2] - Rodyti ataskaitas, [0] = iseiti");

                int veiksmas = Convert.ToInt32(Console.ReadLine());
                if (veiksmas == 0)
                {
                    Environment.Exit(0);
                }
                else if (veiksmas == 1)
                {
                    Console.WriteLine("Iveskite zmogaus Id: ");
                    int zmogausId = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("Iveskite vartu Id: ");
                    int vartuId = Convert.ToInt32(Console.ReadLine());
                    bool praejo = eventControler.TryPass(zmogausId, vartuId);

                    Console.WriteLine("Praejimas {0}", praejo);



                }
                else if (veiksmas == 2)
                {
                    Console.WriteLine("Ataskaitos: ");
                    ReportGenerator reportGenerator = new ReportGenerator(eventControler.events, humanRepository, gateRepository);

                   List<ReportEvent> visiPraejimai = reportGenerator.GenerateTotalEvents();

                    foreach (var item in visiPraejimai)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}", item.Human, item.Gate, item.Date, item.Pass);
                    }
                }
                else
                {
                    Console.WriteLine("Ivestas nezinomas skaicius {0}", veiksmas);
                }
                Console.WriteLine("Spauskite ENTER norint testi");
                Console.ReadLine();
            }
            


        }
    }
}
