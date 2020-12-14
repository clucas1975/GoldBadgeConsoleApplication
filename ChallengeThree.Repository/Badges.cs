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

        public string ListOfDoorNames { get; set; }

        public Badges() {}

        public Badges(int BadgeID, string ListOfDoorNames) 
        {
            BadgeID = BadgeID;
            ListOfDoorNames = ListOfDoorNames;
        }
       
    }
}
