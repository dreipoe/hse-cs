using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "0";
            Console.WriteLine("В этом проекте находятся все лаб. работы студента ПИ-18У Орешкина А. А.");

            do
            {
                Console.Write("Введите номер лаб. работы для его запуска (0 - выход): ");
                key = Console.ReadLine();

                switch (key)
                {
                    case "0": break;
                    case "1": Lab1.Run(); break;
                    case "2": Lab2.Run(); break;
                    case "3": Lab3.Run(); break;
                    case "4": Lab4.Run(); break;
                    case "5": Lab5.Run(); break;
                    case "6": Lab6.Run(); break;
                    case "7": Lab7.Run(); break;
                    case "9": Lab9.Run(); break;
                    default:
                        Console.WriteLine("Извините, но такой лабы в этом проекте нет.");
                        break;
                }
            } while (key != "0");
        }
    }
}
