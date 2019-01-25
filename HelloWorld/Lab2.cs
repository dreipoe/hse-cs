using static System.Console;

namespace HelloWorld
{
    class Lab2
    {
        public static void Run()
        {
            string key = "0";

            do
            {
                Write("Введите номер задачи для её запуска (0 - назад): ");
                key = ReadLine();

                switch (key)
                {
                    case "0": break;
                    case "1": Lab2Task1(); break;
                    case "2": Lab2Task2(); break;
                    case "3": Lab2Task3(); break;
                    default:
                        WriteLine("Извините, но такой задачи в этой лаб. работе нет.");
                        break;
                }
            } while (key != "0");
        }

        private static void Lab2Task1()
        {
            Write("Длина последовательности: ");

            int n;
            if (int.TryParse(ReadLine(), out n))
            {
                int sum = 0, a;

                for (int i = 1; i <= n; i++)
                {
                    Write("Введите следующее число последовательности: ");

                    while (!int.TryParse(ReadLine(), out a))
                        WriteLine("Число не опознано, повторите ввод.");

                    if (i % 2 == 0) sum += a;
                }

                WriteLine($"Сумма чётных элементов последовательности: {sum}.");
            }
            else
            {
                WriteLine("Это не целое число.");
            }
        }

        private static void Lab2Task2()
        {
            int a = 1;
            int i = 0;
            bool correct = true;

            Write("k1: ");
            int k1;
            if (int.TryParse(ReadLine(), out k1))
                Write("k2: ");
            else
                correct = false;

            int k2;
            if (correct && int.TryParse(ReadLine(), out k2))
            {
                while (a != 0)
                {
                    Write("Введите следующее число последовательности (0 - выход): ");

                    if (int.TryParse(ReadLine(), out a))
                    {
                        if ((a % k1 == 0) && (a % k2 != 0)) i++;
                    }

                    WriteLine($"Во введённой последовательности уже {i} чис(ел), удовлетворяющих условию.");
                }
            }
            else
            {
                WriteLine("Это не целое число.");
            }
        }

        private static void Lab2Task3()
        {
            Write("Количество слагаемых: ");

            int n;
            if (int.TryParse(ReadLine(), out n))
            {
                int sum = 0;
                int a = 1;
                do
                {
                    sum += a;
                    a += 2;
                    n--;
                } while (n > 0);
                WriteLine($"Результат: {sum}");
            }
            else
            {
                WriteLine("Это не целое число.");
            }
        }
    }
}
