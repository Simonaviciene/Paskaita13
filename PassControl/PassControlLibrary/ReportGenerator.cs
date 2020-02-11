using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassControlLibrary
{
    public class ReportGenerator
    {
        private List<Event> bandymaiPraeiti;
        private HumanRepository humanRepository;
        private GateRepository gateRepository;

        public ReportGenerator(List<Event> bandymaiPraeiti, HumanRepository humanRepository, GateRepository gateRepository)
        {
            this.bandymaiPraeiti = bandymaiPraeiti;
            this.humanRepository = humanRepository;
            this.gateRepository = gateRepository;
        }
        public List<ReportEvent> GenerateTotalEvents()
        {
            List<ReportEvent> totalEventAtaskaita = new List<ReportEvent>();
            foreach (var item in bandymaiPraeiti)
            {
                Human human = humanRepository.Retrieve(item.HumanId);
                Gate gate = gateRepository.Retrieve(item.GateId);
                ReportEvent reportEvent = new ReportEvent(human.Name, gate.Code, item.Date, item.Pass);
                totalEventAtaskaita.Add(reportEvent);
            }
            return totalEventAtaskaita;
        }

    }
}
