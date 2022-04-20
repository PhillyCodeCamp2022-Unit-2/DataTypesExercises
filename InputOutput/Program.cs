using System;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            // let name: string = input.question("What is your name?");
            string name = Console.ReadLine();
            // console.log(`Hello ${name}!`);
            Console.WriteLine($"Hello {name}! :)");
        }
    }
}
