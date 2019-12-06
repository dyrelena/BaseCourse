using System;

namespace NumberOfDigits
{
    class NumberOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");

            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                num /= 10;
                count++;
            }

            Console.WriteLine("Количество разрядов: {0}", count);
            Console.ReadLine();
        }
    }
}
