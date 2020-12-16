using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.Repository
{
   public class ClaimsRepo
    {
        private Queue<Claims> _queueOfContent = new Queue<Claims>();

        //Create
        public void AddContentToQueue(Claims content)
        {
            _queueOfContent.Enqueue(content);
        }

        static void Main()
        {

        }

        //Read
        public Queue<Claims> GetClaims()
        {
            return _queueOfContent;
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
        public bool RemoveContentFromQueue(string claimType)
        {
            Claims content = GetContentByClaimType(claimType);


            if (content == null)
            {
                return false;
            }

            int initialCount = _queueOfContent.Count;
            _queueOfContent.Dequeue();

            if (initialCount > _queueOfContent.Count)
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
            foreach (Claims content in _queueOfContent)
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
