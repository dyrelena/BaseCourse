using System;

namespace Lottery
{
    class Lottery
    {
        static void Main(string[] args)
        {
            string oneMore, startOver;
            Double bet, prize;
            do //начать с начала
            {
                Console.WriteLine("Сделайте вашу ставку:");
                bet = Convert.ToDouble(Console.ReadLine());

                do //новый бросок кубика в текущей игре
                {                    
                    Random dice = new Random();
                    int value = dice.Next(1, 12);
                    switch (value)
                    {
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Выпало {0}. Вы сохранили свою ставку", value);
                            break;
                        case 9:
                        case 10:
                        case 11:
                            bet *= 2;
                            Console.WriteLine("Выпало {0}. Вы выиграли, сумма удваивается", value);
                            break;
                        case 12:
                            bet *= 10;
                            Console.WriteLine("Вы сорвали банк!");
                            break;
                        default:
                            bet *= 0;
                            Console.WriteLine("Выпало {0}. Ставка уходит на благотворительность", value);
                            break;
                    }
                    prize = bet;
                    if (prize == 0)
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Хотите забрать деньги и уйти? y/n");
                        oneMore = Console.ReadLine();
                    }
                } while (oneMore == "n");

                Console.WriteLine("Ваш выигрыш: {0}", prize);
                Console.WriteLine("\nНачать с начала? y/n");
                startOver = Console.ReadLine();

            } while (startOver == "y");            
        }
    }
}
