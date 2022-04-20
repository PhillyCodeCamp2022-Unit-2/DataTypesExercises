using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aliceInWonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a term to see if it is in the first sentence of Alice in Wonderland:");
            string term = Console.ReadLine();
            /*
             aliceInWonderland.includes(term)
             aliceInWonderland.toLowerCase().includes(term)
             console.log(aliceInWonderland.toLowerCase().includes(term))
            */
            bool isTermInAliceString = aliceInWonderland.ToLower().Contains(term);
            Console.WriteLine(isTermInAliceString);
        }
    }
}
