using System;

namespace HelloWorld
{
    class Lab4
    {
        public static void Run()
        {
            byte n;

            n = Lib.SecureInput("Кол-во элементов массива (0 - выход)? ");
            int[] arr = Lib.CreateArray(n);
            byte nd = n;
            string key = "Y";

            do
            {
                Lib.PrintArray(ref arr, nd); PrintMenu();

                key = Console.ReadLine();

                switch (key)
                {
                    case "1": deleteMinNumber(); break;
                    case "2": AddToEnd(); break;
                    case "3": MoveToRight(); break;
                    case "4": FindFirstNeg(); break;
                    case "5": SelectSorting(); break;
                    case "0": break;
                    default: Console.WriteLine("Команда не опознана"); break;
                }
            } while (key != "0");

            void deleteMinNumber()
            {
                if (nd > 0)
                {
                    byte iMin = 0;
                    int min = arr[0];

                    for (byte i = 1; i < nd; i++)
                    {
                        if (min > arr[i])
                        {
                            min = arr[i];
                            iMin = i;
                        }
                    }

                    for (byte i = iMin; i < (nd - 1); i++) arr[i] = arr[i + 1];
                    arr[nd - 1] = 0;
                    nd--;

                    Console.WriteLine("Элемент удалён.");
                }
                else Console.WriteLine("Массив пуст. Удалять нечего.");
            }

            void AddToEnd()
            {
                if (nd < n)
                {
                    byte k = Lib.SecureInput("Сколько элементов нужно добавить? ");

                    if ((nd + k) <= n)
                    {
                        Random random = new Random();
                        for (byte i = nd; i < (nd + k); i++) arr[i] = random.Next(-50, 50);
                        nd += k;
                    }
                    else
                        Console.WriteLine("В массиве недостаточно места.");
                }
                else Console.WriteLine("Массив уже содержит максимальное количество элементов.");
            }

            //могло бы 
            void MoveToRight()
            {
                Console.Write("На сколько элементов вправо нужно сдвинуть массив? ");

                if (uint.TryParse(Console.ReadLine(), out uint m))
                {
                    m %= nd;
                    uint border = nd - m;
                    uint rmid = m / 2;
                    uint lmid = border / 2;

                    for (uint i = 0; i < rmid; i++)
                        Lib.Swap(ref arr[border + i], ref arr[nd - 1 - i]);
                    for (uint i = 0; i < lmid; i++)
                        Lib.Swap(ref arr[i], ref arr[border - 1 - i]);
                    for (uint i = 0; i < (nd / 2); i++)
                        Lib.Swap(ref arr[i], ref arr[nd - 1 - i]);

                    Console.WriteLine("Массив сдвинут.");
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так. Повторите ввод.");
                }
            }

            void FindFirstNeg()
            {
                bool found = false;
                uint iNeg = 0;
                int fNeg = 0;

                for (uint i = 0; i < nd && !found; i++)
                    if (arr[i] < 0)
                    {
                        iNeg = i;
                        fNeg = arr[i];
                        found = true;
                    }

                if (found)
                {
                    Console.WriteLine("Первый отрициальный элемент");
                    Console.WriteLine($"Индекс: {iNeg}");
                    Console.WriteLine($"Значение: {fNeg}");
                }
                else Console.WriteLine("В этом массиве нет отрицательных значений");
            }

            void SelectSorting()
            {
                uint iMin; int min;

                for (uint i = 0; i < nd; i++)
                {
                    iMin = i;
                    min = int.MaxValue;

                    for (uint j = i; j < nd; j++)
                        if (arr[j] < min)
                        {
                            iMin = j;
                            min = arr[j];
                        }

                    if (i != iMin)
                        Lib.Swap(ref arr[i], ref arr[iMin]);
                }

                Console.WriteLine("Массив отсортирован");
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Что нужно сделать с ним?");
            Console.WriteLine("1. Удалить минимальный элемент");
            Console.WriteLine("2. Добавить элементы в конец массива");
            Console.WriteLine("3. Сдвинуть массив вправо");
            Console.WriteLine("4. Найти первый отрицательный элемент");
            Console.WriteLine("5. Выполнить сортировку");
            Console.WriteLine("0. Выход");
            Console.Write(">>> ");
        }
    }
}
