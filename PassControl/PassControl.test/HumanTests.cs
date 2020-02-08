using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PassControlLibrary;
using System.Collections.Generic;

namespace PassControl.test
{
    [TestClass]
    public class HumanTests
    {
        [TestMethod]
        public void HasRightReturnsTrueWhenHumanHasRightToGateId1()
        {
            //Assign
            Human human = new Human(1, "Martynas", "Auksine", new List<int> { 1, 2, 3 });
            //Act
            bool hasRight = human.HasRight(1);
            //Assert
            Assert.IsTrue(hasRight);
        }
        [TestMethod]
        public void HasRightReturnsTrueWhenHumanHasRightToGateId2()
        {
            //Assign
            Human human = new Human(1, "Martynas", "Auksine", new List<int> { 1, 2, 3 });
            //Act
            bool hasRight = human.HasRight(-1);
            //Assert
            Assert.IsFalse(hasRight);
        }
    }
}
