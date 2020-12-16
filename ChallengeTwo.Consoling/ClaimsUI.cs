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
        private static ClaimsRepo _claimsRepo = new ClaimsRepo();

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
                    "4. Update Existing Content\n" +
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
                        // View Content By Claim Type
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

            //Do you want to deal with this claim? Yes, or no
            Console.WriteLine("Do you want to deal with this claim now?(y/n)");
            string DoYouWantToDealWithThisClaimAsString = Console.ReadLine().ToLower();
            if(DoYouWantToDealWithThisClaimAsString == "y") 
            {
                newContent.DoYouWantToDealWithThisClaim = true;
            }
            else if(DoYouWantToDealWithThisClaimAsString == "n") 
            {
                newContent.DoYouWantToDealWithThisClaim = false;
                Console.WriteLine("Thank you, have a nice day! Please close by clicking on the X on the upper right corner.");
                string input = Console.ReadLine();
            }

             

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
            //Create date time 
            DateTime date = new DateTime(25/04/2018);
            //Converting to string format
            string date_str = date.ToString("dd/MM/yyyy");
            Console.WriteLine(date_str);

            //Date of Claim
            //Create date time 2018-27-04
            DateTime date1 = DateTime.Parse("dd / MM / yyyy");
            //Converting to string format
            string date1_str = date.ToString("dd/MM/yyyy");
            Console.WriteLine(date_str);

            //Is it valid?
            Console.WriteLine("The claim is valid?(t/f)");
            string isValidAsString = Console.ReadLine().ToLower();
          newContent.IsValid = false;
            if (isValidAsString == "y")
            {
                newContent.IsValid = true;
            }
            else 
            {
                newContent.IsValid = false;
            }

           _claimsRepo.AddContentToQueue(newContent);
        }

        //View current claims that are saved
        private void DisplayAllContent() 
        {
            Console.Clear();
            Queue<Claims> queueOfContent = _claimsRepo.GetClaims();

            foreach (Claims content in queueOfContent) 
            {
                Console.WriteLine($"ClaimID: {content.ClaimID}\n" +
                    $"ClaimType: {content.ClaimType}\n" +
                    $"Description: {content.Description}\n" +
                    $"ClaimAmount: {content.ClaimAmount}\n" +
                    $"DateOfAccident: {content.DateOfAccident}\n" +
                    $"DateOfClaim: {content.DateOfClaim}\n" +
                    $"IsValid: {content.IsValid} ");
            }
        }

        //View existing content by claim type
        private void DisplayContentByClaimType() 
        {
            Console.Clear();
            // Prompt the user to give me a claim type
            Console.WriteLine("Please enter the type of this claim:");

            // Get the customer's input
            string claimType = Console.ReadLine();

            // Find the content by that claim type
            Claims content = _claimsRepo.GetContentByClaimType(claimType);

            // Display said content if it isn't null
            if (content != null)
            {
                Console.WriteLine($"ClaimID: {content.ClaimID}\n" +
                    $"ClaimType: {content.ClaimType}\n" +
                    $"Description: {content.Description}\n" +
                    $"ClaimAmount: {content.ClaimAmount}\n" +
                    $"DateOfAccident: {content.DateOfAccident}\n" +
                    $"DateOfClaim: {content.DateOfClaim}\n" +
                    $"IsValid: {content.IsValid} ");
            }
            else
            {
                Console.WriteLine("No content by that claim type.");
            }

        }

        //Update Existing Content
        private void UpdateExistingContent() 
        {
            //Display all content
            DisplayAllContent();

            //Ask for the type of claim to update
            Console.WriteLine("Enter the type of the claim that you want to update:");

            //Get that Type
           string oldClaimType = Console.ReadLine();



            //We will build a new object
            Claims newContent = new Claims();

            // Claim ID
            Console.WriteLine("Please enter the claim ID:");
            string ClaimIDAsString = Console.ReadLine();
            newContent.ClaimID = int.Parse(ClaimIDAsString);

            //Claim Type
            Console.WriteLine("Please enter the claim type:");
            newContent.ClaimType = Console.ReadLine();

            //Description
            Console.WriteLine("Please enter claim description:");
            newContent.Description = Console.ReadLine();

            //Claim Amount
            Console.WriteLine("Please enter the amount of damage:");
            string ClaimAmountAsString = Console.ReadLine();
            newContent.ClaimAmount = decimal.Parse(ClaimAmountAsString);

            //Date of Accident
            //Create date time 2018-25-04
            DateTime date = new DateTime(2018, 04, 25);
            //Converting to string format
            string date_str = date.ToString("2018/04/25");
            Console.WriteLine("2018/04/25");

            //Date of Claim
            //Create date time 2018-27-04
            DateTime date1 = new DateTime(2018, 04, 27);
            //Converting to string format
            string date1_str = date.ToString("2018/04/27");
            Console.WriteLine(date_str);

            //Is it valid?
            Console.WriteLine("The claim is valid?(t/f)");
            string isValidAsString = Console.ReadLine().ToLower();

            if (isValidAsString == "y")
            {
                newContent.IsValid = true;
            }
            else
            {
                newContent.IsValid = false;
            }

            //Verify the update worked
            bool wasUpdated = _claimsRepo.UpdateExistingContent(oldClaimType, newContent);

            if (wasUpdated) 
            {
                Console.WriteLine("Claims successfully updated!");
            }
            else 
            {
                Console.WriteLine("Could not update claims.");
            }
        }

        //Delete Existing Content
        private void DeleteExistingContent() 
        {
            DisplayAllContent();

            //Get the claim type they want to remove
            Console.WriteLine("\nEnter the claim type of the content (claim) you want to remove");

            string input = Console.ReadLine();

            // Call the delete method
            bool wasDeleted = _claimsRepo.RemoveContentFromQueue(input);

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
            Claims car = new Claims(1, "Car", "Car accident on 465", 400.00m, new DateTime (2018, 04, 25), new DateTime (2018, 04, 27), true);
            Claims home = new Claims(2, "Home", "House fire in kitchen", 4000.00m, new DateTime (2018, 04, 11), new DateTime (2018, 04, 12), true);
            Claims theft = new Claims(3, "Theft", "Stolen pancakes", 4.00m, new DateTime (2018, 04, 27), new DateTime (2018, 06, 01), false);



            _claimsRepo.AddContentToQueue(car);
            _claimsRepo.AddContentToQueue(home);
            _claimsRepo.AddContentToQueue(theft);
         
        }
    }

}
