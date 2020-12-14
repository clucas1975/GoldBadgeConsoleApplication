using System;
using ChallengeTwo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwo.UnitTest
{
    [TestClass]
    public class ClaimsTests
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
             Claims content = new Claims();
            content.ClaimType = "Car";

            string expected = "Car";
            string actual = content.ClaimType;

            Assert.AreEqual(expected, actual);
        }
    }
}
