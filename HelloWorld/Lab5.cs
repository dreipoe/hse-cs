using System;
using static System.Console;
using static HelloWorld.Lib;

namespace HelloWorld
{
	static class Lab5
    {
        public static void Run()
        {
            string key = "Y";

            do
            {
                WriteLine("1. Работа с одномерными массивами");
                WriteLine("2. Работа с матрицами");
                WriteLine("3. Работа с \"рваными\" массивами");
                WriteLine("0. Выход");
                Write(">>> ");

                key = ReadLine();

                switch (key)
                {
                    case "1": Vector(); break;
                    case "2": Matrix(); break;
                    case "3": Ragged(); break;
                    case "0": break;
                    default:
                        WriteLine("Такой команды нет.");
                        break;
                }
            } while (key != "0");
        }

        //Работа с одномерным массивом
        private static void Vector()
        {
            string key1 = "Y";
            int[] vector = null;
            byte vectorlen = 0;

            do
            {
                WriteLine("1. Создать массив.");
                WriteLine("2. Напечатать массив.");
                WriteLine("3. Удалить первый отрицательный элемент.");
                WriteLine("0. Назад");

                key1 = ReadLine();
                vectorlen = (byte)((vector != null) ? vector.Length : 0);

                switch (key1)
                {
                    case "1": VectorFill(ref vector); break;
                    case "2": PrintArray(ref vector, vectorlen); break;
                    case "3": DeleteFirstNeg(ref vector); break;
                    case "0": break;
                    default:
                        WriteLine("Нет такого пункта.");
                        break;
                }
            } while (key1 != "0");
        }

        private static void DeleteFirstNeg(ref int[] arr)
        {
            bool neg = false;

            if (arr != null && arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (neg)
                        arr[i - 1] = arr[i];
                    else if (arr[i] < 0)
                        neg = true;

                if (neg)
                {
                    WriteLine("Первый отрицательный элемент удалён.");
                    Array.Resize(ref arr, arr.Length - 1);
                } else WriteLine("В массиве нет отрицательных значений. Удалять нечего.");
            }
            else
                WriteLine("Массив ещё не заполнен!");
        }

        //Заполняет одномерный массив
        private static void VectorFill(ref int[] arr)
        {
            if (arr == null)
            {
                byte n = SecureInput("Введите количество элементов в массиве: ");
                arr = new int[n];

                string key2 = "Y";

                do
                {
                    WriteLine("1. Создать массив вручную.");
                    WriteLine("2. Создать массив с помощью ДСЧ.");

                    key2 = ReadLine();

                    switch (key2)
                    {
                        case "1": ManualArrayFill(ref arr); break;
                        case "2": RandomArrayFill(ref arr); break;
                        default:
                            WriteLine("Нет такого пункта.");
                            break;
                    }
                } while (key2 != "1" && key2 != "2");
            }
            else WriteLine("Массив уже заполнен.");
        }

        //Работа с матрицей
        private static void Matrix()
        {
            string key1 = "Y";
            int[,] matrix = null;

            do
            {
                WriteLine("1. Создать массив.");
                WriteLine("2. Напечатать массив.");
                WriteLine("3. Добавить столбец с заданным номером.");
                WriteLine("0. Назад");

                key1 = ReadLine();

                switch (key1)
                {
                    case "1": MatrixFill(ref matrix); break;
                    case "2": PrintArray(ref matrix); break;
                    case "3": AddColumn(ref matrix); break;
                    case "0": break;
                    default:
                        WriteLine("Такой команды нет.");
                        break;
                }
            } while (key1 != "0");
        }

        private static void AddColumn(ref int[,] arr)
        {
            if (arr != null)
            {
                byte n = SecureInput("С каким номером добавим столбец? ");

                if (n <= arr.GetLength(1))
                {
                    int[,] tmp = new int[arr.GetLength(0), arr.GetLength(1) + 1];

                    Random random = new Random();

                    for (int row = 0; row < tmp.GetLength(0); row++)
                        tmp[row, n] = random.Next(-999, 999);

                    for (int column = 0; column < n; column++)
                        for (int row = 0; row < arr.GetLength(0); row++)
                            tmp[row, column] = arr[row, column];

                    for (int column = n; column < arr.GetLength(1); column++)
                        for (int row = 0; row < arr.GetLength(0); row++)
                            tmp[row, column + 1] = arr[row, column];

                    arr = tmp;
                }
                else
                    WriteLine("Номер столбца выходит за пределы матрицы.");
            }
            else WriteLine("Матрица ещё не создана!");
        }

        //Заполнение матрицы
        private static void MatrixFill(ref int[,] arr)
        {
            if (arr == null)
            {
                byte rows = SecureInput("Введите количество строк в матрице: ");
                byte columns = SecureInput("Введите количество столбцов в матрице: ");
                arr = new int[rows, columns];

                string key2 = "Y";

                do
                {
                    WriteLine("1. Создать массив вручную.");
                    WriteLine("2. Создать массив с помощью ДСЧ.");

                    key2 = ReadLine();

                    switch (key2)
                    {
                        case "1": ManualArrayFill(ref arr); break;
                        case "2": RandomArrayFill(ref arr); break;
                        default:
                            WriteLine("Нет такого пункта.");
                            break;
                    }
                } while (key2 != "1" && key2 != "2");
            }
            else WriteLine("Массив уже заполнен.");
        }

        private static void Ragged()
        {
            string key1 = "Y";
            int[][] ragged = null;

            do
            {
                WriteLine("1. Создать массив.");
                WriteLine("2. Напечатать массив.");
                WriteLine("3. Удалить самую короткую строку.");
                WriteLine("0. Назад");

                key1 = ReadLine();

                switch (key1)
                {
                    case "1": RaggedFill(ref ragged); break;
                    case "2": PrintArray(ref ragged); break;
                    case "3": DeleteShortestRow(ref ragged); break;
                    case "0": break;
                    default:
                        WriteLine("Такой команды нет.");
                        break;
                }
            } while (key1 != "0");
        }

        private static void DeleteShortestRow(ref int[][] arr)
        {
            if (arr != null && arr.Length > 0)
            {
                byte shortest = byte.MaxValue, iShortest = 0;

                for (byte i = 0; i < arr.Length; i++)
                    if (arr[i].Length < shortest)
                    {
                        iShortest = i;
                        shortest = (byte)arr[i].Length;
                    }

                for (byte i = iShortest; i < arr.Length - 1; i++) arr[i] = arr[i + 1];
                Array.Resize(ref arr, arr.Length - 1);
            }
            else WriteLine("Массив пуст.");
        }

        private static void RaggedFill(ref int[][] arr)
        {
            if (arr == null)
            {
                ArrayInit(ref arr);

                string key2 = "Y";

                do
                {
                    WriteLine("1. Создать массив вручную.");
                    WriteLine("2. Создать массив с помощью ДСЧ.");

                    key2 = ReadLine();

                    switch (key2)
                    {
                        case "1": ManualArrayFill(ref arr); break;
                        case "2": RandomArrayFill(ref arr); break;
                        default:
                            WriteLine("Нет такого пункта.");
                            break;
                    }
                } while (key2 != "1" && key2 != "2");
            }
            else WriteLine("Массив уже заполнен.");
        }

        private static void ArrayInit(ref int[][] arr2)
        {
            byte rows = SecureInput("Введите количество строк в рваном массиве: ");
            arr2 = new int[rows][];

            byte rowlen = 0;
            for (int i = 0; i < rows; i++)
            {
                rowlen = SecureInput($"Введите длину строки {i}: ");
                arr2[i] = new int[rowlen];
            }
        }
    }
}