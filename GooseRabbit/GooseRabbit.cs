using System;

namespace GooseRabbit
{
    class GooseRabbit
    {
        static void Main(string[] args)
        {
            int paws = 64;
            for (int rabbit = paws / 4; rabbit >= 0; rabbit--)
            {
                Console.WriteLine("Кролики: {0}; Гуси: {1}", rabbit, (64-rabbit*4)/2);
            }
            Console.ReadLine();
        }
    }
}
