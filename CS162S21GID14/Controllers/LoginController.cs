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
        [HttpGet]
        public bool SignIn(UserAccount obj)
        {
            User user = new User();
            user = user.Instance;
            for(int i = 0;i<user.UserAccountList.Count;i++)
            {
                if(obj.Username == user.UserAccountList[i].Username && obj.Password == user.UserAccountList[i].Password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
