
using System;
using ChallengeTwo.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeTwo.UnitTest
{
    [TestClass]
    public class ClaimsRepositoryTests
    {
        private ClaimsRepo _repo;
        private Claims _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new ClaimsRepo();
            _content = new Claims();

            _repo.AddContentToQueue(_content);
        }


        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            Claims content = new Claims();
            content.ClaimType = "Car";
           ClaimsRepo repo = new ClaimsRepo();

            // Act --> Get/run the code we want to test
            repo.AddContentToQueue(content);
            Claims contentFromList = repo.GetContentByClaimType("Car");

            // Assert --> Verify the expected outcome
            Assert.IsNotNull(contentFromList);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            // Arrange
            Claims content = new Claims();
            content.ClaimType = "Car";
            ClaimsRepo repo = new ClaimsRepo();

            //Act
            bool deleteResult = _repo.RemoveContentFromQueue(_content.ClaimType);

            // Assert
            Assert.IsTrue(deleteResult);

        }
    }
}
