using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class User
    {
        private static User instance = null;
        private  List<UserAccount>  userAccountList = null;


        public User()
        {
            userAccountList = new List<UserAccount>();
        }
        public User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }

        public List<UserAccount> UserAccountList
        {
            set { userAccountList = value; }
            get { return userAccountList; }
        }
        public bool AddAccount(UserAccount acc)
        {
            bool flag = false;
            if(SearchAccount(acc) ==-1)
            {
                userAccountList.Add(acc);
                flag = true;
            }
            return flag;
        }
        public bool DeleteAccount(UserAccount acc)
        {
            bool flag = true;
            userAccountList.Remove(acc);
            return flag;
        }
        public int SearchAccount(UserAccount acc)
        {
            for (int i = 0; i < userAccountList.Count; i++)
            {
               if(acc.Username == userAccountList[i].Username)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}