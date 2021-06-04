using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class Reply
    {
        public string ReplyText { get; set; }
        public AboutProfile RefProfile { get; set; }
        public Queue<Reply> ReplyQueue { get; set; }


        public Reply()
        {
            ReplyQueue = new Queue<Reply>();
        }
        public void AddReply(Reply rep)
        {
            ReplyQueue.Enqueue(rep);
        }


        public bool DeleteReply(Reply rep)
        {
            Queue<Reply> updatedQueue = null;
            bool flag = false;
            if (ReplyQueue.Contains(rep) == true)
            {
                updatedQueue = new Queue<Reply>(updatedQueue.Where(x => !ReplyQueue.Contains(x)));
                flag = true;
            }
            return flag;
        }
        public bool SearchReply(Reply rep)
        {
            if (ReplyQueue.Contains(rep) == true)
            {
                return true;
            }
            return false;
        }
    }
}