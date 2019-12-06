using System;

namespace MultiTable
{
    class MultiTable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            for (int i = 1, j = 11; i <= 10 && j <= 20; i++, j++)
            {                
                Console.WriteLine("{0} x {1} = {2}\t {0} x {3} = {4}", num, i, num * i, j, num*j);   
            }

            Console.ReadLine();
        }
    }
}
