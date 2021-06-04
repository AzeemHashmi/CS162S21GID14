using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class Comments
    {
        public string comment { get; set; }
        public AboutProfile RefProfile { get; set; }
        public Queue<Reply> ReplyQueue { get; set; }


        public bool AddReply(Reply rep)
        {
            bool flag = false;
            if (SearchReport(rep) != -1)
            {
                ReplyQueue.Enqueue(rep);
                flag = true;
            }
            return flag;
        }
        public bool DeleteReply(Reply rep)
        {
            Queue<Reply> updatedQueue = null;
            bool flag = false;
            if(ReplyQueue.Contains(rep)==true)
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