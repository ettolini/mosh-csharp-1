using System;
using System.Collections.Generic;

namespace FriendLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            var notifications = true;
            var likes = 0;
            string firstFriend = "";
            string secondFriend = "";

            while (notifications)
            {
                System.Console.WriteLine("Please, enter a name.");
                var input = Console.ReadLine();
                
                if (!string.IsNullOrWhiteSpace(input))
                {
                    likes++;
                    if (likes == 1)
                        firstFriend = input;
                    else
                        if (likes == 2)
                            secondFriend = input;
                }
                else
                    notifications = false;
            }

            switch (likes)
            {
                case 0:
                    System.Console.WriteLine("You don't have unread notifications.");
                break;

                case 1:
                    System.Console.WriteLine("{0} likes your post.", firstFriend);
                break;

                case 2:
                    System.Console.WriteLine("{0} and {1} like your post.", firstFriend, secondFriend);
                break;

                default:
                    System.Console.WriteLine("{0}, {1}, and {2} others like your post.", firstFriend, secondFriend, (likes - 2));
                break;
            }
        }
    }
}
