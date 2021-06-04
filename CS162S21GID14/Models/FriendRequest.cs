using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    abstract public class FriendRequest
    {
        public AboutProfile RefProfile { get; set; }
    }
}