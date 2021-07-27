using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post();

            Console.Write("Enter your post title: ");
            post.postTitle = Console.ReadLine();
           
            Console.Write("Enter post description: ");
            post.postDescription = Console.ReadLine();
            post.postDateTime = DateTime.Now;

            
            while (true)
            {
                Console.Write("Vote up press (U) vote down press (D) to quit press (Q)");
                var input = Console.ReadLine();
                if (input.ToLower() == "u")
                {
                    post.VoteUp(1);
                    
                }
                if (input.ToLower() == "d")
                {
                    post.VoteDown(1);
                    
                }
                if (input.ToLower() == "q")
                {
                    break;
                }
               
            }
            



        }
    }
}
