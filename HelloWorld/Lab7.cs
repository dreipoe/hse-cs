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
                    Console.Write("Введите строку 1: ");
                    Bidirectional head = new Bidirectional(Console.ReadLine()), tmp = head, last = null;

                    for (byte i = 2; i <= n; i++)
                    {
                        Console.Write($"Введите строку {i}: ");
                        last = new Bidirectional(Console.ReadLine(), tmp);
                        tmp.next = last;

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
                        Console.WriteLine($"{handle.field:f3} ");
                        handle = handle.next;
                    } while (handle != null);
                }
                else Console.WriteLine("Список пуст.");
            }

            public Bidirectional AddOddStrings()
            {
                Bidirectional insert, cursor = this, tmp = null;

                while (cursor != null)
                {
                    Console.Write("Введите нечётную строку: ");

                    insert = new Bidirectional(Console.ReadLine(), tmp, cursor);
                    if (tmp != null) tmp.next = insert;
                    cursor.pred = insert;
                    tmp = cursor;
                    cursor = cursor.next;

                    Console.WriteLine("Вставили.");
                }

                return pred;
            }
        }

        private class BinaryTree
        {
            public int field;
            public BinaryTree left;
            public BinaryTree right;

            public static Random random = new Random();

            public BinaryTree(int d)
            {
                field = d;
            }

            public static BinaryTree BornIdealTree()
            {
                BinaryTree me = null;
                Console.Write("Высота дерева: ");

                if (byte.TryParse(Console.ReadLine(), out byte deep))
                {
                    if (deep < 1)
                        Console.WriteLine("Введённое число не является натуральным.");
                    else if (deep > 24)
                        Console.WriteLine("На столь большое дерево не хватит оперативной памяти. Операция не выполнена.");
                    else
                        me = CreateIdealTree(deep);
                } else Console.WriteLine("Введённое значение не является натуральным числом либо число слишком большое.");

                return me;
            }

            private static BinaryTree CreateIdealTree(int deep)
            {
                BinaryTree me = new BinaryTree(random.Next(-100, 100));
                me.left = (deep > 1) ? CreateIdealTree(deep - 1) : null;
                me.right = (deep > 1) ? CreateIdealTree(deep - 1) : null;

                return me;
            }

            public void Print(int l = 0)
            {
                if (left != null) left.Print(l + 3);
                Console.Write("\t");
                for (int i = 0; i < l; i++) Console.Write(" ");
                Console.WriteLine(field);
                if (right != null) right.Print(l + 3);
            }

            public int FindMaxNumber(int max = int.MinValue)
            {
                max = (field > max) ? field : max;
                max = (left != null) ? left.FindMaxNumber(max) : max;
                max = (right != null) ? right.FindMaxNumber(max) : max;

                return max;
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
                    Console.WriteLine("Ошибка. Скорее всего, список ещё не создан.");
                }
            } while (key != "0");
        }

        public static void Belist()
        {
            string key = string.Empty;
            Bidirectional list = null;

            do
            {
                Console.WriteLine("Работа с двунаправленным списком.");
                Console.WriteLine("1. Создать список.");
                Console.WriteLine("2. Распечатать список.");
                Console.WriteLine("3. Добавить нечётные элементы.");
                Console.WriteLine("0. Назад.");
                Console.Write(">>> ");

                key = Console.ReadLine();

                try
                {
                    switch (key)
                    {
                        case "1": list = Bidirectional.Born(); break;
                        case "2": list.Print(); break;
                        case "3": list = list.AddOddStrings(); break;
                        case "0": break;
                        default:
                            Console.WriteLine("Нет такого пункта в меню.");
                            break;
                    }
                } catch (NullReferenceException) {
                    Console.WriteLine("Ошибка. Скорее всего, список ещё не создан.");
                }
            } while (key != "0");
        }

        public static void Betree()
        {
            string key = string.Empty;
            BinaryTree tree = null;

            do
            {
                Console.WriteLine("Работа с бинарным деревом.");
                Console.WriteLine("1. Создать дерево.");
                Console.WriteLine("2. Распечатать дерево.");
                Console.WriteLine("3. Найти максимальное число.");
                Console.WriteLine("0. Назад.");
                Console.Write(">>> ");

                key = Console.ReadLine();

                try
                {
                    switch (key)
                    {
                        case "1": tree = BinaryTree.BornIdealTree(); break;
                        case "2": tree.Print(); break;
                        case "3": Console.WriteLine($"Маскимальное число в дереве: {tree.FindMaxNumber()}"); break;
                        case "0": break;
                        default:
                            Console.WriteLine("Нет такого пункта в меню.");
                            break;
                    }
                } catch (NullReferenceException) {
                    Console.WriteLine("Ошибка. Скорее всего, список ещё не создан.");
                }
            } while (key != "0");
        }
    }
}