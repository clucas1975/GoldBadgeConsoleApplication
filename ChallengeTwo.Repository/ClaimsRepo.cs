using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.Repository
{
   public class ClaimsRepo
    {
        private List<Claims> _listOfContent = new List<Claims>();

        //Create
        public void AddContentToList(Claims content)
        {
            _listOfContent.Add(content);
        }

        static void Main()
        {

        }

        //Read
        public List<Claims> GetClaims()
        {
            return _listOfContent;
        }

        //Update 
        public bool UpdateExistingContent(string originalClaimType, Claims newContent) 
        {
            //Find the content
            Claims oldContent = GetContentByClaimType(originalClaimType);

            //Update the content
            if(oldContent != null) 
            {
                oldContent.ClaimID = newContent.ClaimID;
                oldContent.ClaimType = newContent.ClaimType;
                oldContent.Description = newContent.Description;
                oldContent.ClaimAmount = newContent.ClaimAmount;
                oldContent.DateOfClaim = newContent.DateOfClaim;
                oldContent.DateOfAccident = newContent.DateOfAccident;
                oldContent.IsValid = newContent.IsValid;

                return true;
            }
            else 
            {
                return false;
            }
        }


        //Delete
        public bool RemoveContentFromList(string claimType)
        {
            Claims content = GetContentByClaimType(claimType);


            if (content == null)
            {
                return false;
            }

            int initialCount = _listOfContent.Count;
            _listOfContent.Remove(content);

            if (initialCount > _listOfContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public Claims GetContentByClaimType(string claimType)
        {
            foreach (Claims content in _listOfContent)
            {
                if (content.ClaimType == claimType)
                {
                    return content;
                }
                continue;
            }

            return null;
        }

    }
}
