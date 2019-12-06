using System;

namespace Exchange
{
    class Exchange
    {
        static void Main(string[] args)
        {
            const decimal uahToUsd = 24;            
            const decimal uahToEur = 26;

            decimal sum, uah;
            string currency;

            Console.WriteLine("Введите сумму:");
            sum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите валюту (uah, usd, eur):");
            currency = Console.ReadLine();

            switch (currency)
            {
                case "uah":
                    Console.WriteLine("Доллар: {0}", Math.Round(sum / uahToUsd,2));
                    Console.WriteLine("Евро: {0}", Math.Round(sum / uahToEur, 2));
                    Console.ReadLine();
                    break;                
                case "usd":
                    uah = Math.Round(sum / uahToUsd);
                    Console.WriteLine("Гривна: {0}", uah);
                    Console.WriteLine("Евро: {0}", Math.Round(uah / uahToEur, 2));
                    Console.ReadLine();
                    break;
                case "eur":
                    uah = Math.Round(sum / uahToEur);
                    Console.WriteLine("Гривна: {0}", uah);
                    Console.WriteLine("Доллар: {0}", Math.Round(uah / uahToUsd, 2));
                    Console.ReadLine();
                    break;
            }
        }
    }
}
