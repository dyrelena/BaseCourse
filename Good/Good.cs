using System;

namespace Good
{
    class Good
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("1 or 0?");
            char num = Convert.ToChar( Console.ReadLine());            
            Console.WriteLine(num == '1' ? "Good!" : num == '0' ? "Bad!" : "Only 1 or 0!");
            Console.ReadLine();

        }
    }
}
