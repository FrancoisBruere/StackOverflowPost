using System;

namespace StackOverflowPost
{
    public class Post
    {
        public string postTitle { get; set; }
        public string postDescription { get; set; }
        public DateTime postDateTime { get; set; }

        public int _vote { get; private set; }

        public void VoteUp(int voteup)
        {
            _vote += voteup;
            Console.WriteLine("Vote added! Vote count: " + _vote);
            

        }


        public void VoteDown(int votedown)
        {

            _vote -= votedown;
            Console.WriteLine("Vote removed! Vote count: " + _vote);
            

        }


    }
}
