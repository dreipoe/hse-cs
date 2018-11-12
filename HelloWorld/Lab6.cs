using System;

namespace HelloWorld
{
    class Lab6
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
                    case "1": Lab6Task1(); break;
                    case "2": Lab6Task2(); break;
                    default:
                        Console.WriteLine("Извините, но такой задачи в этой лаб. работе нет.");
                        break;
                }
            } while (key != "0");
        }

        //Задача №1
        private static void Lab6Task1()
        {
            double[,] matrix = null;
            string key = "0";

            do
            {
                Console.WriteLine("1. Создать матрицу.");
                Console.WriteLine("2. Напечатать матрицу.");
                Console.WriteLine("3. Удалить первую строку с нулём.");
                Console.WriteLine("0. Назад");

                key = Console.ReadLine();

                switch (key)
                {
                    case "0": break;
                    case "1": MatrixFill(ref matrix); break;
                    case "2": Lib.PrintArray(ref matrix); break;
                    case "3": DeleteFirstRowWithZero(ref matrix); break;
                    default:
                        Console.WriteLine("Извините, но такой задачи в этой лаб. работе нет.");
                        break;
                }
            } while (key != "0");
        }

        private static void MatrixFill(ref double[,] arr)
        {
            if (arr == null)
            {
                byte rows = Lib.SecureInput("Введите количество строк в матрице: ");
                byte columns = Lib.SecureInput("Введите количество столбцов в матрице: ");
                arr = new double[rows, columns];

                string key2 = "Y";

                do
                {
                    Console.WriteLine("1. Создать массив вручную.");
                    Console.WriteLine("2. Создать массив с помощью ДСЧ.");

                    key2 = Console.ReadLine();

                    switch (key2)
                    {
                        case "1": Lib.ManualArrayFill(ref arr); break;
                        case "2": Lib.RandomArrayFill(ref arr); break;
                        default:
                            Console.WriteLine("Нет такого пункта.");
                            break;
                    }
                } while (key2 != "1" && key2 != "2");
            }
            else Console.WriteLine("Массив уже заполнен.");
        }

        private static void DeleteFirstRowWithZero(ref double[,] arr)
        {
            int iZero = -1;

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    if (arr[i, j] == 0)
                    {
                        iZero = i;
                        break;
                    }

            if (iZero != -1)
            {
                double[,] tmp = new double[arr.GetLength(0) - 1, arr.GetLength(1)];

                for (int i = 0; i < iZero; i++)
                    for (int j = 0; j < tmp.GetLength(1); j++)
                        tmp.SetValue(
                            arr.GetValue(i, j),
                            i, j
                        );

                for (int i = iZero; i < tmp.GetLength(0); i++)
                    for (int j = 0; j < tmp.GetLength(1); j++)
                        tmp.SetValue(
                            arr.GetValue(i + 1, j),
                            i, j
                        );

                arr = tmp;

                Console.WriteLine("Первая строка с нулём была удалена.");
            }
            else Console.WriteLine("Нет строк для удаления.");
        }

        //Задача №2
        private static void Lab6Task2()
        {
            string key = "Y";
            char[] str = null;

            do
            {
                Console.WriteLine("Работа со строкой:");
                Console.WriteLine("1. Создать строку");
                Console.WriteLine("2. Перевернуть чётные слова");
                Console.WriteLine("0. Назад");

                key = Console.ReadLine();

                switch (key)
                {
                    case "1":
                        Console.Write("Ваша строка: ");
                        str = Console.ReadLine().Trim().ToCharArray();
                        break;
                    case "2": SwapEvenWords(ref str); break;
                    case "0": break;
                    default:
                        Console.WriteLine("Нет такого пункта.");
                        break;
                }
            } while (key != "0");
        }

        private static void SwapEvenWords(ref char[] str)
        {
            if (str != null && str.Length > 0)
            {
                int words = 1, a = 0;
                bool space = false;

                for (int i = 0; i < str.Length; i++)
                {
                    if (!space && (str[i] == ' ' || str[i] == ','))
                    {
                        space = true;
                        if (words % 2 == 0)
                        {
                            for (int j = a; j < (a + i) / 2; j++)
                                Lib.Swap(ref str[j], ref str[i - 1 - j + a]);
                        }
                    }

                    if (space && str[i] != ' ' && str[i] != ',')
                    {
                        space = false;
                        if (++words % 2 == 0) a = i;
                    }
                }

                Console.Write("Результат: ");
                Console.WriteLine(str);
            }
            else Console.WriteLine("Строка ещё не заполнена!");
        }
    }
}