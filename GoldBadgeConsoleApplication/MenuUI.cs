using GoldBadgeApplicationRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeConsoleApplication
{
    class MenuUI
    {
        private MenuRepo _menuRepo = new MenuRepo();

        // Method that starts or runs the application
        public void Run()
        {
            Menu();
        }

        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {


                // Display our options to the user
                Console.WriteLine("Select menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By MealName\n" +
                    "4. Delete Existing Content\n" +
                    "5. Exit");

                // Get the user's input
                string input = Console.ReadLine();

                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        // Create New Content
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        // View Content By MealName
                        DisplayContentByMealName();
                        break;
                    case "4":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "5":
                        // Exit
                        Console.WriteLine("Toodles!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
          



            
        }

        // Create new MenuContent
        private void CreateNewContent()
        {
            MenuContent newContent = new MenuContent();

            //Meal Name
            Console.WriteLine("Enter the meal name for the content:");
            newContent.MealName = Console.ReadLine();

            //Meal Number
            Console.WriteLine("Enter the meal number for the content (1, 2, 3, 10 etc):");
            string MealNumberAsString = Console.ReadLine();
            newContent.MealNumber = int.Parse(MealNumberAsString);

            //Meal Price
            Console.WriteLine("Enter the meal price for the content (1.10d, 2.30d etc):");
            string MealPriceAsString = Console.ReadLine();
            newContent.MealPrice = double.Parse(MealPriceAsString);

            //Comes With Sides
            Console.WriteLine("Does this come with sides? (y/n)");
            string comesWithSidesAsString = Console.ReadLine().ToLower();

            if(comesWithSidesAsString == "y") 
            {
                newContent.ComesWithSides = true;
            }
            else 
            {
                newContent.ComesWithSides = false;
            }

            _menuRepo.AddContentToList(newContent);

        }

        //View Current MenuContent that is saved
        private void DisplayAllContent() 
        {
            
        }

        //View existing Content by MealName
        private void DisplayContentByMealName() 
        {
            
        }

        //Delete Existing Content
        private void DeleteExistingContent() 
        {
        
        }

    }

    
}
