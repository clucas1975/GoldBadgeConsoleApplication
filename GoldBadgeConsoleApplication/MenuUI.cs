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
            SeedContentList();
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
            Console.Clear();
            MenuContent newContent = new MenuContent();

            //Meal Name
            Console.WriteLine("Enter the meal name for the content:");
            newContent.MealName = Console.ReadLine();

            //Meal Number
            Console.WriteLine("Enter the meal number for the content (1, 2, 3, 10 etc):");
            string MealNumberAsString = Console.ReadLine();
            newContent.MealNumber = int.Parse(MealNumberAsString);

            //Meal Price
            Console.WriteLine("Enter the meal price for the content (1.10m, 2.30m etc):");
            string MealPriceAsString = Console.ReadLine();
            newContent.MealPrice = decimal.Parse(MealPriceAsString);

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
            Console.Clear();

            List<MenuContent> listOfContent = _menuRepo.GetMenuContents();

            foreach (MenuContent content in listOfContent) 
            {
                Console.WriteLine($"MealName: {content.MealName}\n" +
                    $"MealNumber: {content.MealNumber}\n" +
                    $"MealPrice: {content.MealPrice}\n" +
                    $"ComesWithSides: {content.ComesWithSides}");
            }
        }

        //View existing Content by MealName
        private void DisplayContentByMealName() 
        {
            Console.Clear();
            // Prompt the user to give me a meal name
            Console.WriteLine("Enter the meal name that you would like to order:");


            // Get the customer's input
            string mealName = Console.ReadLine();

            // Find the content by that meal name
           MenuContent content = _menuRepo.GetContentByMealName(mealName);

            // Display said content if it isn't null
            if (content != null) 
            {
                Console.WriteLine($"Meal Name: {content.MealName}\n" +
                    $"Meal Number: {content.MealNumber}\n" +
                    $"Meal Price: {content.MealPrice}\n" +
                    $"Comes With Size: {content.ComesWithSides}");
            }
            else 
            {
                Console.WriteLine("No content by that meal name.");
            }
        }

        //Delete Existing Content
        private void DeleteExistingContent() 
        {
            DisplayAllContent();

            //Get the meal name they want to remove
            Console.WriteLine("\nEnter the meal name of the content (menu) you want to remove");

            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _menuRepo.RemoveContentFromList(input);

            // If the content was deleted, say so
            // Otherwise state it could not be deleted
            if (wasDeleted) 
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else 
            {
                Console.WriteLine("The content could not be deleted.");
            }
        }

        //See Method
        private void SeedContentList() 
        {
            MenuContent hamburger = new MenuContent("Hamburger", 1, 1.10m, false);
            MenuContent chickenSandwich = new MenuContent("Chicken Sandwich", 2, 1.50m, false);
            MenuContent tBoneSteak = new MenuContent("T-Bone Steak", 10, 20.00m, true);
            MenuContent bbqChickenBreast = new MenuContent("BBQ Chicken Breast", 5, 10.00m, true);

            _menuRepo.AddContentToList(hamburger);
            _menuRepo.AddContentToList(chickenSandwich);
            _menuRepo.AddContentToList(tBoneSteak);
            _menuRepo.AddContentToList(bbqChickenBreast);
        }

    }

    
}
