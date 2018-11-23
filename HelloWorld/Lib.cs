using System;
using static System.Console;

namespace HelloWorld
{
	static class Lib
    {
        public static int[] CreateArray(uint n = 0)
        {
            if (n > 0)
            {
                int[] ar = new int[n];
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    ar[i] = random.Next(-999, 999);
                    if (ar[i] == 0) ar[i]++;
                }

                return ar;
            }
            else
            {
                return null;
            }
        }

        public static void ManualArrayFill(ref int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                WriteLine($"Введите элемент {i}");
                if (!int.TryParse(ReadLine(), out arr2[i]))
                {
                    arr2[i] = 0;
                    WriteLine("Не удалось распознать целое число. Элементу присвоено значение 0.");
                }
            }
        }

        public static void ManualArrayFill(ref int[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    WriteLine($"Введите элемент [{i}, {j}]");
                    if (!int.TryParse(ReadLine(), out arr2[i, j]))
                    {
                        arr2[i, j] = 0;
                        WriteLine("Не удалось распознать целое число. Элементу присвоено значение 0.");
                    }
                }
        }

        public static void ManualArrayFill(ref double[,] arr2)
        {
            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    WriteLine($"Введите элемент [{i}, {j}]");
                    if (!double.TryParse(ReadLine(), out arr2[i, j]))
                    {
                        arr2[i, j] = 0;
                        WriteLine("Не удалось распознать число. Элементу присвоено значение 0.");
                    }
                }
        }

        public static void ManualArrayFill(ref int[][] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    WriteLine($"Введите элемент [{i}][{j}]");
                    if (!int.TryParse(ReadLine(), out arr2[i][j]))
                    {
                        arr2[i][j] = 0;
                        WriteLine("Не удалось распознать целое число. Элементу присвоено значение 0.");
                    }
                }
        }

        public static void PrintArray(ref int[] arr, byte factlen = 0)
        {
            Write("Состав массива: ");
            if (arr != null && factlen > 0)
                for (byte i = 0; i < factlen; i++) Write($"{arr[i]} ");
            else
                Write("пусто.");
            WriteLine();
        }

        public static void PrintArray(ref int[,] arr)
        {
            Write("Состав массива: ");
            if (arr != null)
            {
                WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Write($"{arr[i, j]}\t");
                    WriteLine();
                }
            }
            else Write("пусто.");

            WriteLine();
        }

        public static void PrintArray(ref double[,] arr)
        {
            Write("Состав массива: ");
            if (arr != null)
            {
                WriteLine();
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                        Write($"{arr[i, j]:f5}\t");
                    WriteLine();
                }
            }
            else Write("пусто.");

            WriteLine();
        }

        public static void PrintArray(ref int[][] arr)
        {
            Write("Состав массива: ");
            if (arr != null)
            {
                WriteLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                        Write($"{arr[i][j]}\t");
                    WriteLine();
                }
            }
            else Write("пусто.");

            WriteLine();
        }

        public static void RandomArrayFill(ref int[] arr2)
        {
            Random random = new Random();

            for (int i = 0; i < arr2.Length; i++) arr2[i] = random.Next(-999, 999);
            WriteLine("Массив был заполнен случайными числами");
        }

        public static void RandomArrayFill(ref int[,] arr2)
        {
            Random random = new Random();

            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                    arr2[i, j] = random.Next(-999, 999);
            WriteLine("Массив был заполнен случайными числами");
        }

        public static void RandomArrayFill(ref double[,] arr2)
        {
            Random random = new Random();

            for (int i = 0; i < arr2.GetLength(0); i++)
                for (int j = 0; j < arr2.GetLength(1); j++)
                    arr2[i, j] = (random.NextDouble() - 0.5) * 2000;
            WriteLine("Массив был заполнен случайными числами");
        }

        public static void RandomArrayFill(ref int[][] arr2)
        {
            Random random = new Random();

            for (int i = 0; i < arr2.Length; i++)
                for (int j = 0; j < arr2[i].Length; j++)
                    arr2[i][j] = random.Next(-999, 999);
            WriteLine("Массив был заполнен случайными числами");
        }

        public static byte SecureInput(string message)
        {
            byte num; bool check;

            do
            {
                Write(message);
                check = byte.TryParse(ReadLine(), out num);

                if (!check)
                    WriteLine("Введённая строка не является целым числом или выходит за диапазон (0 - 255). Повторите ввод.");
            } while (!check);

            return num;
        }

        public static void Swap(ref int a, ref int b)
        {
            int buff = a;
            a = b;
            b = buff;
        }

        public static void Swap(ref char a, ref char b)
        {
            char buff = a;
            a = b;
            b = buff;
        }
    }
}
