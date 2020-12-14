using ChallengeTwo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.Consoling
{
    class ClaimsUI
    {
        private ClaimsRepo _menuRepo = new ClaimsRepo();

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
                    "3. View Content By ClaimType\n" +
                    "4. Update Existing Content" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

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
                        DisplayContentByClaimType();
                        break;
                    case "4":
                        // Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
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

        private static void CreateNewContent()
        {
            Console.Clear();
            Claims newContent = new Claims();

            // Claim ID
            Console.WriteLine("Please enter the ID for the claim:");
            string ClaimIDAsString = Console.ReadLine();
            newContent.ClaimID = int.Parse(ClaimIDAsString);

            //Claim Type
            Console.WriteLine("Please enter the claim type:");
            newContent.ClaimType = Console.ReadLine();

            //Description
            Console.WriteLine("Please describe the incident and/or accident:");
            newContent.Description = Console.ReadLine();

            //Claim Amount
            Console.WriteLine("Please enter the claim amount:");
            string ClaimAmountAsString = Console.ReadLine();
            newContent.ClaimAmount = decimal.Parse(ClaimAmountAsString);

            //Date of Accident
            //Create date time 2018-25-04
            DateTime date = new DateTime(25/04/2018);
            //Converting to string format
            string date_str = date.ToString("dd/MM/yyyy");
            Console.WriteLine(date_str);

            //Date of Claim
            //Create date time 2018-27-04
            DateTime date = DateTime.Parse("dd / MM / yyyy");
            //Converting to string format
            string date_str = date.ToString("dd/MM/yyyy");
            Console.WriteLine(date_str);


        }
    }

}
