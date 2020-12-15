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

            //Description
            Console.WriteLine("Enter the description of the Meal Name");
            newContent.Description = Console.ReadLine();

            //List of ingredients
            Console.WriteLine("Enter the list of ingredients");
            newContent.AListOfIngredients = Console.ReadLine();

            //Meal Price
            Console.WriteLine("Enter the meal price for the content (1.10m, 2.30m" +
                " etc):");
            string MealPriceAsString = Console.ReadLine();
            newContent.MealPrice = decimal.Parse(MealPriceAsString);

           

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
                    $"Description: {content.Description}\n" +
                    $"AListOfIngredients: {content.AListOfIngredients}" +
                    $"MealPrice: {content.MealPrice}");


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
                Console.WriteLine($"MealName: {content.MealName}\n" +
                    $"MealNumber: {content.MealNumber}\n" +
                    $"Description: {content.Description}\n" +
                    $"AListOfIngredients: {content.AListOfIngredients}" +
                    $"MealPrice: {content.MealPrice}");
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
            MenuContent hamburger = new MenuContent("Hamburger", 1, "sandwich with beef patty on bun", "Comes with ketchup, mustard and pickles and french fries",  1.10m);
            MenuContent chickenSandwich = new MenuContent("Chicken Sandwich", 2, "sandwich with fried or grilled chicken breast on bun", "comes with mayonaise and pickles and french fries", 1.50m);
            MenuContent tBoneSteak = new MenuContent("T-Bone Steak", 10, "steak grilled to perfection", "comes with scallions and peppers with your choice of baked potato, or french fries",  20.00m);
            MenuContent bbqChickenBreast = new MenuContent("BBQ Chicken Breast", 5, "grilled chicken breast on platter", "smothered with thick bbq sauce with your choice of baked potato, or french fries",  10.00m);

            _menuRepo.AddContentToList(hamburger);
            _menuRepo.AddContentToList(chickenSandwich);
            _menuRepo.AddContentToList(tBoneSteak);
            _menuRepo.AddContentToList(bbqChickenBreast);
        }

    }

    
}
