using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
                          
             
            string Alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string LowerAlice = Alice.ToLower();
            //Console.WriteLine(Alice);
            Console.WriteLine("What do you want to search for?");
            string Search = Console.ReadLine();
            string LowerSearch = Search.ToLower();
            bool s = LowerAlice.Contains(LowerSearch);

            if (s)
            {
                Console.WriteLine("Yes, " +Search+" is in the text");
            }

            else
            {
                Console.WriteLine("That does not seem to be part of the Alice text");
            }
            
            Console.ReadLine();

            }
        }
    }

