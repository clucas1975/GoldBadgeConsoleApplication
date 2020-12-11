using System;
using GoldBadgeApplicationRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoldBadgeApplicationUnitTest
{
    [TestClass]
    public class MenuTests
    {
        [TestMethod]
        public void SetMealName_ShouldSetCorrectString()
        {
            MenuContent content = new MenuContent();
            content.MealName = "Hamburger";

            string expected = "Hamburger";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
