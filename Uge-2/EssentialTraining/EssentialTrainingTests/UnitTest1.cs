﻿using System;
using EssentialTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EssentialTrainingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testInstance = new Class1();
            var testResult = testInstance.AddTwo(9, 5);
            Assert.AreEqual(14, testResult, "I expect 9 + 5 to be 14");
        }
    }
}
