using System;

namespace HelloWorld
{
    class Lab7
    {
        private class Unidirectional
        {
            public double field;
            public Unidirectional next;

            public Unidirectional(double _field, Unidirectional _next = null)
            {
                field = _field;
                next = _next;
            }

            public static Unidirectional Born()
            {
                Console.Write("Количество элементов в списке: ");

                if (byte.TryParse(Console.ReadLine(), out byte n) && n > 0)
                {
                    Random random = new Random();

                    Unidirectional head = new Unidirectional(random.NextDouble() * 200 - 100), tmp = head;

                    for (byte i = 1; i < n; i++)
                    {
                        head = new Unidirectional(random.NextDouble() * 200 - 100, tmp);
                        tmp = head;
                    }

                    return head;
                }
                else
                {
                    Console.WriteLine("Введённое значение не является натуральным числом или значение слишком велико.");
                    return null;
                }    
            }

            public void Print()
            {
                if (this != null)
                {
                    Unidirectional handle = this;
                    Console.WriteLine("Состав списка: ");
                    while (handle != null)
                    {
                        Console.Write($"{handle.field:f3} ");
                        handle = handle.next;
                    }
                    Console.WriteLine();
                } else Console.WriteLine("Список пуст.");
            }

            public void DelEvenItems()
            {
                if (this != null && next != null)
                {
                    Unidirectional handle = this;
                    while (handle.next != null)
                    {
                        handle.next = handle.next.next;

                        if (handle.next != null)
                            handle = handle.next;
                    }
                }
                else Console.WriteLine("Список пуст или содержит всего один элемент.");
            }
        }

        private class Bidirectional
        {
            public string field;
            public Bidirectional next;
            public Bidirectional pred;

            public Bidirectional(string _field, Bidirectional _pred = null, Bidirectional _next = null)
            {
                field = _field;
                next = _next;
                pred = _pred;
            }

            public static Bidirectional Born()
            {
                Console.Write("Количество элементов в списке: ");

                if (byte.TryParse(Console.ReadLine(), out byte n) && n > 0)
                {
                    Console.WriteLine("Введите строку 1.");
                    Bidirectional head = new Bidirectional(Console.ReadLine()), tmp = head, last = null;

                    for (byte i = 2; i <= n; i++)
                    {
                        Console.WriteLine($"Введите строку {i}.");
                        last = new Bidirectional(Console.ReadLine(), tmp);
                        tmp = last;
                    }

                    return head;
                }
                else
                {
                    Console.WriteLine("Введённое значение не является натуральным числом или значение слишком велико.");
                    return null;
                }
            }

            public void Print()
            {
                if (this != null)
                {
                    Bidirectional handle = this, head = this;
                    Console.WriteLine("Состав списка: ");

                    do
                    {
                        Console.Write($"{handle.field:f3} ");
                        handle = handle.next;
                    } while (handle != head);

                    Console.WriteLine();
                }
                else Console.WriteLine("Список пуст.");
            }

            public void AddOddStrings()
            {
                Bidirectional handle, header = this;

                while (false)
                {
                    handle = null;
                }
            }
        }

        public static void Run()
        {
            string key = string.Empty;

            do
            {
                Console.WriteLine("Лабораторная работа №7");
                Console.WriteLine("1. Работа с однонаправленным списком.");
                Console.WriteLine("2. Работа с двунаправленным списком.");
                Console.WriteLine("3. Работа с бинарным деревом.");
                Console.WriteLine("0. Назад.");
                Console.Write(">>> ");

                key = Console.ReadLine();

                switch (key)
                {
                    case "1": Unilist(); break;
                    case "2": Belist(); break;
                    case "3": Betree(); break;
                    case "0": break;
                    default:
                        Console.WriteLine("Нет такого пункта в меню.");
                        break;
                }
            } while (key != "0");
        }

        public static void Unilist()
        {
            string key = string.Empty;
            Unidirectional list = null;

            do
            {
                Console.WriteLine("Работа с однонаправленным списком.");
                Console.WriteLine("1. Создать список.");
                Console.WriteLine("2. Распечатать список.");
                Console.WriteLine("3. Удалить чётные элементы.");
                Console.WriteLine("0. Назад.");
                Console.Write(">>> ");

                key = Console.ReadLine();

                try
                {
                    switch (key)
                    {
                        case "1": list = Unidirectional.Born(); break;
                        case "2": list.Print(); break;
                        case "3": list.DelEvenItems(); break;
                        case "0": break;
                        default:
                            Console.WriteLine("Нет такого пункта в меню.");
                            break;
                    }
                } catch (NullReferenceException) {
                    Console.WriteLine("Список ещё не создан.");
                }
            } while (key != "0");
        }

        public static void Belist()
        {
            Console.WriteLine("Ещё не готово.");
        }

        public static void Betree()
        {
            Console.WriteLine("Ещё не готово.");
        }
    }
}
