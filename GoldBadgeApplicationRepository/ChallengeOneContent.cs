using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeApplicationRepository
{
    class ChallengeOneContent
    {
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public double MealPrice { get; set; }
        public bool ComesWithSides { get; set; }
       
        public menu(string mealName, int mealNumber, double mealPrice, bool comesWithSides) 
        {
            MealName = mealName;
            MealNumber = mealNumber;
            MealPrice = mealPrice;
            ComesWithSides = comesWithSides;
        }
       
    }
}
