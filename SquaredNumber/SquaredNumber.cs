using System;

namespace SquaredNumber
{
    class SquaredNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());            
            int x = 1;

                for (int square = 1; square < num;)
                {
                    Console.WriteLine("Квадрат числа {0} = {1}", x, square);
                    x++;    
                    square = x * x;
                }
            Console.ReadLine();
        }
    }
}
