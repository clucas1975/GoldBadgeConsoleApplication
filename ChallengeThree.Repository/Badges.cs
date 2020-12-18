using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree.Repository
{
    public class Badges
    {
        //Plain Old C# Object
        public int BadgeID { get; set; }

        public List<string> ListOfDoorNames { get; set; } = new List<string>();

        public Badges() {}

        public Badges(int badgeID, List<string> listOfDoorNames) 
        {
            BadgeID = badgeID;
            ListOfDoorNames = listOfDoorNames;
        }
       
    }
}
