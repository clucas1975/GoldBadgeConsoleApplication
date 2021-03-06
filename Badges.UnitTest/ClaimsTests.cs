﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Badges.UnitTest
{
    [TestClass]
    public class ClaimsTests
    {
        [TestMethod]
        public void SetClaimType_ShouldSetCorrectString()
        {
            Claims content = new Claims();
            content.ClaimType = "Car";

            string expected = "Car";
            string actual = content.ClaimType;

            Assert.AreEqual(expected, actual);
        }
    }
}
