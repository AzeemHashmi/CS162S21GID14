using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class Timeline
    {
        public List<Post> PostList { get; set; }

        public Timeline()
        {
            PostList = new List<Post>();
        }

        public bool AddPost(Post post)
        {
            PostList.Add(post);
            return true;
        }
        public bool DeletePost(Post post)
        {
            if(PostList.Contains(post) == true)
            {
                PostList.Remove(post);
                return true;
            }
            return false;
        }
        public int SearchPost(Post post)
        {
            for(int i=0;i<PostList.Count;i++)
            {
                if(PostList[i] == post)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}