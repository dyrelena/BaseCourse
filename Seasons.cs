using System;

namespace Seasons
{
    class Seasons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца:");
            string month = Console.ReadLine();
            switch (month)
            {
                case "1":
                case "2":
                case "12":
                    Console.Clear();
                    Console.WriteLine("Зима");
                    Console.ReadLine();
                    break;
                case "3":
                case "4":
                case "5":
                    Console.Clear();
                    Console.WriteLine("Весна");
                    Console.ReadLine();
                    break;
                case "6":
                case "7":
                case "8":
                    Console.Clear();
                    Console.WriteLine("Лето");
                    Console.ReadLine();
                    break;
                case "9":
                case "10":
                case "11":
                    Console.Clear();
                    Console.WriteLine("Осень");
                    Console.ReadLine();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("На этой планете такого месяца нет");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
