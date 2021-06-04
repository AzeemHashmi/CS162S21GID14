using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS162S21GID14.Models
{
    public class Post
    {
        public int ShareCount { get; set; }
        public AboutProfile RefProfile { get; set; }
        public PostPrivacy PrivacyType { get; set; }
        public List<Comments> CommentsList { get; set; }
        public List<Reactions> ReactionsList { get; set; }
        public List<Tags> TagsList { get; set; }

        public Post()
        {
            CommentsList = new List<Comments>();
            ReactionsList = new List<Reactions>();
            CommentsList = new List<Comments>();
        }
        public void AddReaction(Reactions react)
        {
            ReactionsList.Add(react);
        }


        public bool DeleteReaction(Reactions react)
        {
            if (ReactionsList.Contains(react) == true)
            {
                ReactionsList.Remove(react);
                return true;
            }
            return false;
        }
        public int SearchReaction(Reactions react)
        {
            for (int i = 0; i < ReactionsList.Count; i++)
            {
                if (ReactionsList[i] == react)
                {
                    return i;
                }
            }
            return -1;
        }

        //////////  For Comment List
        public void AddComment(Comments com)
        {
            CommentsList.Add(com);
        }


        public bool DeleteComment(Comments com)
        {
            if (CommentsList.Contains(com) == true)
            {
                CommentsList.Remove(com);
                return true;
            }
            return false;
        }
        public int SearchReaction(Comments com)
        {
            for (int i = 0; i < CommentsList.Count; i++)
            {
                if (CommentsList[i] == com)
                {
                    return i;
                }
            }
            return -1;
        }


        //////////  For Tag List
        public void AddTag(Tags tag)
        {
            TagsList.Add(tag);
        }


        public bool DeleteComment(Tags tag)
        {
            if (TagsList.Contains(tag) == true)
            {
                TagsList.Remove(tag);
                return true;
            }
            return false;
        }
        public int SearchReaction(Tags tag)
        {
            for (int i = 0; i < TagsList.Count; i++)
            {
                if (TagsList[i] == tag)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}