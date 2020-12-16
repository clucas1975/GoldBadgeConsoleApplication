using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.Repository
{
    public class Claims
    {
        
        // Plain Old C# Object
        public bool DoYouWantToDealWithThisClaim { get; set; }

        public int ClaimID { get; set; }

        public string ClaimType { get; set; }

        public string Description { get; set; }

        public decimal ClaimAmount { get; set; }

        public DateTime DateOfAccident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public bool IsValid { get; set; }

        public Claims() {}


        public Claims(int claimID, string claimType, string description, decimal claimAmount, DateTime dateOfAccident, DateTime dateOfClaim, bool isValid ) 
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }

       
    }
}
