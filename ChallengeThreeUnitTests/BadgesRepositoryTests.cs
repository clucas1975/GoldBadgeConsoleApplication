using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeThree.Repository;

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
        }
    }
}
