using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Repository_
{
    public class MenuContent
    {
        // Plain Old C# Object -- POCO
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public double MealPrice { get; set; }
        public bool ComesWithSides { get; set; }

        public MenuContent() { }

        public MenuContent(string mealName, int mealNumber, double mealPrice, bool comesWithSides)

        {
            MealName = mealName;
            MealNumber = mealNumber;
            MealPrice = mealPrice;
            ComesWithSides = comesWithSides;
        }

    }
}

