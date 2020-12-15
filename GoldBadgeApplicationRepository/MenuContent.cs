using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeApplicationRepository
{
  public  class MenuContent
    {
        // Plain Old C# Object -- POCO
        public string MealName { get; set; }
        public int MealNumber { get; set; }
        public string Description { get; set; }
        public string AListOfIngredients { get; set; }
        public decimal MealPrice { get; set; }
        


        public MenuContent() {}

        public MenuContent(string mealName, int mealNumber, string description, string aListOfIngredients,  decimal mealPrice) 

        {
            MealName = mealName;
            MealNumber = mealNumber;
            Description = description;
            AListOfIngredients = aListOfIngredients;

            MealPrice = mealPrice;
           
        }

        
       
    }
}
