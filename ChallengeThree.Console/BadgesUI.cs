using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeThree.Repository;

namespace ChallengeThree_Console
{
    class BadgesUI
    {
        private static BadgesRepo _badgesRepo = new BadgesRepo();

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
                    "1. Create Badges\n" +
                    "2. Add Doors\n" +
                    "3. Delete Doors\n" +
                    "4. Edit Doors\n " +
                    "5. Exit");


                // Get the user's input
                string input = Console.ReadLine();
                // Evaluate the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Add Doors
                        AddDoors();
                        break;
                    case "2":
                        //Delete Doors
                        DeleteDoors();
                        break;
                    case "3":
                        //Edit Doors
                        EditDoors();
                        break;
                    case "4":
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

        //Add Doors
        private void AddDoors() 
        {
            Console.Clear();
            Badges newContent = new Badges();

            //Door Name
            Console.WriteLine("Enter the name for the door to access:");
           
                       
            


            //Badge ID
            Console.WriteLine("Enter the id for the badge (3000, 3007):");
            string BadgeIDAsString = Console.ReadLine();
            newContent.BadgeID = int.Parse(BadgeIDAsString);
        }


        //Delete Doors
        private void DeleteDoors() 
        {
            _badgesRepo.GetKeyValuePairs();

            Console.WriteLine("\nEnter the badge id you want to remove:");

            string input = Console.ReadLine();
            int BadgeID = int.Parse(input);
            bool wasDeleted = _badgesRepo.RemoveDoor(BadgeID,"A1");

            if (wasDeleted) 
            {
                Console.WriteLine("The content was successfully deleted.");
            }
            else 
            {
                Console.WriteLine("The content cannot be deleted.");
            }

        }

        //Edit Doors
        private void EditDoors() 
        {
            //Display all content
           
            Badges newContent = new Badges();

            // Badge ID
            Console.WriteLine("Please enter the badge ID:");
            string BadgeIDAsString = Console.ReadLine();
            newContent.BadgeID = int.Parse(BadgeIDAsString);


            //Ask for the type of door to update
            Console.WriteLine("Enter the type of the door that you want to update:");

            //Get that Type
            string doorsToOpen = Console.ReadLine();




            //We will build a new object
           

           
        }

        //See Method
        private void SeedContentList() 


        {
            Badges badge = new Badges(3000, new List<string> { "A1", "B1" });
            Badges badge1 = new Badges(3000, new List<string> { "A1", "B1", "C3" });
            Badges badge2 = new Badges(3007, new List<string> { "A1", "B1", "zoom317" });

            _badgesRepo.AddContentToDictionary(badge);
            _badgesRepo.AddContentToDictionary(badge1);
            _badgesRepo.AddContentToDictionary(badge2);
        }
    }
}
