using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Mail;
using System.Text;
using CS162S21GID14.Models;

namespace CS162S21GID14.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost]
        public bool SignIn(UserAccount obj)
        {
            AccountDBMSEntities dbms = new AccountDBMSEntities();
            var dbList = dbms.AccountCredentials.ToList();
            foreach (var dbObj in dbList)
            {
               if((dbObj.Email == obj.Email) && (dbObj.Password == obj.Password))
                {
                    return true;
                }
            }
            /*User user = new User();
            user = user.Instance;
            for(int i = 0;i<user.UserAccountList.Count;i++)
            {
                if(obj.Username == user.UserAccountList[i].Username && obj.Password == user.UserAccountList[i].Password)
                {
                    return true;
                }
            }
            return false;*/
            return false;
        }

    }
}
