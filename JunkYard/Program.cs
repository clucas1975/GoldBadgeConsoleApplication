using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JunkYard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Badge> badgesINDatabase = new Dictionary<int, Badge>();

            Badge badge = new Badge(3000, new List<string> { "A1", "B1" });
            Badge badge1 = new Badge(3000, new List<string> { "A1", "B1", "C3" });
            Badge badge2 = new Badge(3007, new List<string> { "A1", "B1", "zoom317" });

            badgesINDatabase.Add(1, badge);
            badgesINDatabase.Add(2, badge1);
            badgesINDatabase.Add(3, badge2);


            //I have access to the key and the value
            foreach (var pair in badgesINDatabase)
            {
                Console.WriteLine($"Dictionary Key: {pair.Key}");
                Console.WriteLine($"Badge Id: {pair.Value.BadgeId}");
                foreach (var door in pair.Value.Doors)
                {
                    Console.WriteLine($"Door Access: {door}");
                }
                Console.WriteLine("**************************");
            }

            Console.WriteLine("***********Only using the badgesINDatabase.Keys*************");

            //Ill only have access to the key in badgesINDatabase.Keys
            foreach (var key in badgesINDatabase.Keys)
            {
                if (key == 2)
                {
                    Console.WriteLine(key);
                }
            }

            Console.WriteLine("***********Only using the badgesINDatabase.Values***************");
            //Ill only have access to the value badgesINDatabase.Keys
            foreach (var value in badgesINDatabase.Values)
            {

                if (value.BadgeId == 3007)
                {
                    Console.WriteLine(value.BadgeId);
                    foreach (var door in value.Doors)
                    {
                        Console.WriteLine(door);
                    }
                }
            }

            Console.ReadKey();



        }
    }
}
