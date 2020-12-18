using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree.Repository
{
    class BadgesRepo
    {
        private Dictionary<int, Badges>  _dictionaryOfBadges = new Dictionary<int, Badges>();
        int Count;

        //Create Badges
        public void AddContentToDictionary(Badges badges) 
        {
            Count++;
            _dictionaryOfBadges.Add(Count, badges);
        }
        //read method
        //return Dictionary<int,Badges>
        public Dictionary<int, Badges> GetKeyValuePairs() 
        {
            return _dictionaryOfBadges;
        }

        //update doors
        public bool UpdateDoors(int oldDictKey, Badges newBadge)
        {
            Badges oldBadges = GetBadgeByDictKey(oldDictKey);
            if (oldBadges !=null)
            {
                oldBadges.BadgeID = newBadge.BadgeID;
                oldBadges.ListOfDoorNames = newBadge.ListOfDoorNames;
                return true;
            }
            return false;
        }
        //helper method
        public Badges GetBadgeByDictKey(int dictKey)
        {
            foreach (var pair in _dictionaryOfBadges)
            {
                if (pair.Key == dictKey)
                {
                    return pair.Value;
                }
            }
            return null;
        }

        //remove a door 
        public bool RemoveDoor(int dictKey, string doorNameToRemove)
        {
            //find the Badge
            Badges badge = GetBadgeByDictKey(dictKey);
            if (badge!=null)
            {
                foreach (var door in badge.ListOfDoorNames)
                {
                    if (door==doorNameToRemove)
                    {
                        badge.ListOfDoorNames.Remove(door);
                    }
                }
            }
            return false;
        }
        public bool AddDoor(int dictKey, string doorNameToAdd)
        {
            Badges badge = GetBadgeByDictKey(dictKey);
            if (badge == null)
            {
                return false;
            }
            badge.ListOfDoorNames.Add(doorNameToAdd);
            return true;
        }
    }
}
