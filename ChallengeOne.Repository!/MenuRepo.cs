using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Repository_
{
    public class MenuRepo
    {
        private List<MenuContent> _listOfContent = new List<MenuContent>();

        //Create
        public void AddContentToList(MenuContent content)
        {
            _listOfContent.Add(content);
        }

        //Read
        public List<MenuContent> GetMenuContents()
        {
            return _listOfContent;
        }


        //Update (not needed at this time)

        //Delete
        public bool RemoveContentFromList(string mealName)
        {
            MenuContent content = GetContentByMealName(mealName);

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
        private MenuContent GetContentByMealName(string mealName)
        {
            foreach (MenuContent content in _listOfContent)
            {
                if (content.MealName == mealName)
                {
                    return content;
                }
            }

            return null;
        }
    }
}

