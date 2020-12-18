using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public List<string> Doors { get; set; } = new List<string>();

        public Badge(int badgeId, List<string> doors)
        {
            BadgeId = badgeId;
            Doors = doors;
        }

    }
}




