using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class GeneralSetting : Settings
    {
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public GeneralSetting()
        {
            User acc = new User();
            acc = acc.Instance;
            Username = acc.UserAccountList[acc.UserAccountList.Count - 1].Username;
            Email = acc.UserAccountList[acc.UserAccountList.Count - 1].Email;
        }
    }
}