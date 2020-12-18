using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChallengeThree.Repository;
using System.Collections.Generic;

namespace ChallengeThreeUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            void SetDoorName_ShouldSetCorrectString() 
            {
                Badges content = new Badges();
                content.ListOfDoorNames = new List<string>() { "A1" };

                string expected = "A1";
                string actual = "content.ListOfDoorNames";

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
