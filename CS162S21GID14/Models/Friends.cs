using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class Friends
    {
        public List<AboutProfile> FriendsProfileList { get; set; }

        public bool AddFriend(AboutProfile frnd)
        {
            if(SearchFriend(frnd) == -1)
            {
                FriendsProfileList.Add(frnd);
                return true;
            }
            return false;
        }
        public bool RemoveFriend(AboutProfile frnd)
        {
            if (SearchFriend(frnd) == -1)
            {
                FriendsProfileList.Remove(frnd);
                return true;
            }
            return false;
        }
        public int SearchFriend(AboutProfile frnd)
        {
            for(int i = 0; i<FriendsProfileList.Count;i++)
            {
                if (FriendsProfileList[i] == frnd)
                {
                    return i;
                }
            }
            return -1;
           
        }
        
    }
}