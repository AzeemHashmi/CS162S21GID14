using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class PostPrivacy : PrivacySetting
    {
        public int PrivacyStatus { get; set; }     //  1:  Public,  2: Friends Only,   3:  Private
    }
}