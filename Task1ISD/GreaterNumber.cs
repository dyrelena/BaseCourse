using System;

namespace Task1ISD
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Введите целое число:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите еще одно целое число");
            b = Convert.ToInt32(Console.ReadLine());
            if ((a - b) == 0)
            { 
                Console.WriteLine("Числа a и b равны "); }
            else if ((a - b) > 0)
            { 
                Console.WriteLine("Большее число: " + a); }
            else
            {
                Console.WriteLine("Большее число: " + b);
            }

            Console.ReadLine();
        }
    }
}
