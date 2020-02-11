using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;

namespace PassControl.test
{
    [TestClass]
    public class EventControlerTests
    {
        [TestMethod]
        public void DarbuotojasTurintisTeisePraejo()
        {
            //Assign
            HumanRepository humanRepository = new HumanRepository();
            EventControler eventControler = new EventControler(humanRepository);

            //Act
            bool praejo = eventControler.TryPass(4, 1);
            bool nepraejo = eventControler.TryPass(4, 3);
            //Assert
            Assert.IsTrue(praejo);
            Assert.AreEqual(eventControler.events.Count, 2);
            Assert.IsFalse(nepraejo);
        }

    }
}
