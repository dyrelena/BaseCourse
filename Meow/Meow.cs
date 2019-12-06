using System;

namespace Meow
{
    class Meow
    {
        static void Main(string[] args)
        {
            string M = "Meow";
            string W = "Woof";
            Console.WriteLine("\"Meow\" or \"Woof\"? ");
            string S = Console.ReadLine();
            if (M == S)
            {
                Console.WriteLine("Покорми кота!");
            }
            else if (W == S)
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else
            {
                Console.WriteLine("Wrong choice");
            }
			Console.ReadLine();
        }
    }
}
