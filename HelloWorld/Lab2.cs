using System;

namespace HelloWorld
{
    class Lab2
    {
        public static void Run()
        {
            string key = "0";

            do
            {
                Console.Write("Введите номер задачи для её запуска (0 - назад): ");
                key = Console.ReadLine();

                switch (key)
                {
                    case "0": break;
                    case "1": Lab2Task1(); break;
                    case "2": Lab2Task2(); break;
                    case "3": Lab2Task3(); break;
                    default:
                        Console.WriteLine("Извините, но такой задачи в этой лаб. работе нет.");
                        break;
                }
            } while (key != "0");
        }

        private static void Lab2Task1()
        {
            Console.Write("Длина последовательности: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = 0, a;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Введите следующее число последовательности: ");

                    while (!int.TryParse(Console.ReadLine(), out a))
                        Console.WriteLine("Число не опознано, повторите ввод.");

                    if (i % 2 == 0) sum += a;
                }

                Console.WriteLine($"Сумма чётных элементов последовательности: {sum}.");
            }
            else
            {
                Console.WriteLine("Это не целое число.");
            }
        }

        private static void Lab2Task2()
        {
            int a = 1;
            int i = 0;
            bool correct = true;

            Console.Write("k1: ");
            if (int.TryParse(Console.ReadLine(), out int k1))
                Console.Write("k2: ");
            else
                correct = false;

            if (correct && int.TryParse(Console.ReadLine(), out int k2))
            {
                while (a != 0)
                {
                    Console.Write("Введите следующее число последовательности (0 - выход): ");

                    if (int.TryParse(Console.ReadLine(), out a))
                    {
                        if ((a % k1 == 0) && (a % k2 != 0)) i++;
                    }

                    Console.WriteLine($"Во введённой последовательности уже {i} чис(ел), удовлетворяющих условию.");
                }
            }
            else
            {
                Console.WriteLine("Это не целое число.");
            }
        }

        private static void Lab2Task3()
        {
            Console.Write("Количество слагаемых: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = 0;
                int a = 1;
                do
                {
                    sum += a;
                    a += 2;
                    n--;
                } while (n > 0);
                Console.WriteLine($"Результат: {sum}");
            }
            else
            {
                Console.WriteLine("Это не целое число.");
            }
        }
    }
}
