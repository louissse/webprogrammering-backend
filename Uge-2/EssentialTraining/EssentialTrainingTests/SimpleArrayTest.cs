using System;
using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTests
{
    [TestClass]
    public class SimpleArrayTest
    {
        [TestMethod]
        public void TestInstantiation()
        {
            var testInstance = new SimpleArray();
            Assert.AreEqual(testInstance.GroceryList.Length, 4);
            Assert.AreEqual(testInstance.GroceryList[2], "Milk");

        }

        [TestMethod]
        public void TestToString()
        {
            var testInstance = new SimpleArray();
            Assert.IsTrue(testInstance.ToString().StartsWith("There are"));
        }
    }
}
