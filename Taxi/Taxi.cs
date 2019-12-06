using System;

namespace Taxi
{
    class Taxi
    {
        static void Main(string[] args)
        {
            const decimal firstFive = 20;
            const decimal nextOne = 3;
            const decimal idleMin = 1;
            const int minWay = 5;
            decimal way, sum;
            int idle;
            string repead = "n";
            do
            {
                Console.WriteLine("Введите расстояние в км:");
                way = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Введите время простоя, мин.:");
                idle = Convert.ToInt32(Console.ReadLine());
                

                sum = firstFive + nextOne * Math.Max((way - minWay),0) + idle * idleMin;

                Console.WriteLine("К оплате " + sum + "грн.");                
                Console.WriteLine("\nХотите выполнить еще один просчет? (y/n)");
                repead = Console.ReadLine();
            }
            while (repead == "y");
        }
    }
}
