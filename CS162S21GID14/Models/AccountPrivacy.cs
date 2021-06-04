using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class AccountPrivacy : PrivacySetting
    {
        public int AccountPrivacyStatus { get; set; }   //  1:  Public,  2: Friends Only,   3:  Private
        public int WhoCanSendMessages { get; set; }     //  1:  Public,  2: Friends Only,   3:  Private
        public int WhoCanSendRequest { get; set; }     //  1:  Public,  2: Friends Only,   3:  Private

    }
}