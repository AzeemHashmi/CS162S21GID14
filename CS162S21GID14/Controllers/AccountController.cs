using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CS162S21GID14.Models;

namespace CS162S21GID14.Controllers
{
    public class AccountController : ApiController
    {

        [HttpPost]
        public bool AddAccount(UserAccount acc)
        {
            AccountDBMSEntities dbms = new AccountDBMSEntities();
            AccountCredential cred = new AccountCredential();
            cred.Email = acc.Email;
            cred.Name = acc.Name;
            cred.Password = acc.Password;
            cred.Username = acc.Username;
            dbms.AccountCredentials.Add(cred);
            dbms.SaveChanges();
            return true;
        }
    }
}
