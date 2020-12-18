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
        
        }

        //Edit Doors
        private void EditDoors() 
        {
            
        }

        //See Method
        private void SeedContentList() 
        {
            
        }
    }
}
