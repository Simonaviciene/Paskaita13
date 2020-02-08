using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;

namespace PassControl.test
{
    [TestClass]
    public class HumanRepositoryTests
    {
        [TestMethod]
        public void HumonRepositoryRetrievesExistingUserWithGateRightId1()
        {
            //Assign
            HumanRepository humanRepository = new HumanRepository();
            //Act 
            Human human = humanRepository.Retrieve(5);
            bool hasRight = human.HasRight(3);
            //Assert
            Assert.IsNotNull(human);
            Assert.IsTrue(hasRight);
            
        }
    }
}
