using System;
using GoldBadgeApplicationRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoldBadgeApplicationUnitTest
{
    [TestClass]
    public class MenuRepositoryTests
    {
        private MenuRepo _repo;
        private MenuContent _content;

        [TestInitialize]
        public void Arrange() 
        {
            _repo = new MenuRepo();
            _content = new MenuContent();

            _repo.AddContentToList(_content);
        }


        // Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange --> Setting up the playing field
            MenuContent content = new MenuContent();
            content.MealName = "Hamburger";
            MenuRepo repo = new MenuRepo();

            // Act --> Get/run the code we want to test
            repo.AddContentToList(content);
            MenuContent contentFromList = repo.GetContentByMealName("Hamburger");

            // Assert --> Verify the expected outcome
            Assert.IsNotNull(contentFromList);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue() 
        {
            // Arrange
            MenuContent content = new MenuContent();
            content.MealName = "Hamburger";
            MenuRepo repo = new MenuRepo();

            //Act
            bool deleteResult = _repo.RemoveContentFromList(_content.MealName);

            // Assert
            Assert.IsTrue(deleteResult);

        }

    }
}
