using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeThree.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChallengeThreeUnitTests
{
    
   public class BadgesRepositoryTests
    {
        private BadgesRepo _repo;
        private Badges _content;

        
        public void Arrange()
        {
            _repo = new BadgesRepo();
            _content = new Badges();

            _repo.AddContentToDictionary(_content);
        }

        public void AddToList_ShouldGetNotNull() 
        {
            //Arrange
            Badges content = new Badges();
            content.ListOfDoorNames = new List<string> { "A1", "B1" };
            BadgesRepo repo = new BadgesRepo();

            //Act
            repo.AddContentToDictionary(content);
            Badges contentFromList = repo.GetBadgeByDictKey(1);

            //Assert
            Assert.IsNotNull(contentFromList);

        }
    }
}
