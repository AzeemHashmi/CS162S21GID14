using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CS162S21GID14.Models;

namespace CS162S21GID14.Controllers
{
    public class HomePageDataController : ApiController
    {


        [HttpPost]
        public UserAccount LoadHomePage(UserAccount email)
        {
             AccountDBMSEntities dbms = new AccountDBMSEntities();
             var dbList = dbms.AccountCredentials.ToList();
             foreach (var dbobj in dbList)
             {
                 if(dbobj.Email == email.Email)
                 {
                     email.Email = dbobj.Email;
                     email.Name = dbobj.Name;
                     email.Password = dbobj.Password;
                     email.Username = dbobj.Username;
                     return email;
                 }
             }
            
            return email;

        }
    }
}
