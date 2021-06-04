using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class Faviorites
    {
        public List<Post> FavPostList { get; set; }

        public Faviorites()
        {
            FavPostList = new List<Post>();
        }
        public bool AddToFavorite(Post pos)
        {
            for (int i = 0; i < FavPostList.Count; i++)
            {
                if (SearchFavorite(pos) == -1)
                {
                    FavPostList.Add(pos);
                    return true;
                }
            }
            return false;
        }
        public bool RemoveFromFavorite(Post pos)
        {
            for (int i = 0; i < FavPostList.Count; i++)
            {
                if (FavPostList[i] == pos)
                {
                    FavPostList.Remove(pos);
                    return true;
                }
            }
            return true;
        }
        public int SearchFavorite(Post pos)
        {
            for (int i = 0; i < FavPostList.Count; i++)
            {
                if (FavPostList[i] == pos)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}