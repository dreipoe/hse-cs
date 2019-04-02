using System;

namespace HelloWorld
{
    class Lab7
    {
        private class Unidirectional
        {
            private class Item
            {
                public double field;
                public Item next;
            }

            private Item head;

            public void Born()
            {
                Console.Write("Количество элементов в списке: ");

                byte n;
                if (byte.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    Random random = new Random();

                    for (byte i = 0; i < n; i++)
                        head = new Item
                        {
                            field = random.NextDouble() * 200 - 100,
                            next = head
                        };
                }
                else Console.WriteLine("Введённое значение не является натуральным числом или значение слишком велико."); 
            }

            public void Print()
            {
                Item current = head;

                if (current != null)
                {
                    Console.WriteLine("Состав списка: ");
                    while (current != null)
                    {
                        Console.Write($"{current.field:f3} ");
                        current = current.next;
                    }
                    Console.WriteLine();
                } else Console.WriteLine("Список пуст.");
            }

            public void DelEvenItems()
            {
                Item current = head;

                if (current != null && current.next != null)
                {
                    while (current.next != null)
                    {
                        current.next = current.next.next;
                        if (current.next != null)
                            current = current.next;
                    }
                }
                else Console.WriteLine("Список пуст или содержит всего один элемент.");
            }
        }

        private class Bidirectional
        {
            private class Item
            {
                public string field;
                public Item next;
                public Item pred;
            }

            private Item head;

            public void Born()
            {
                Console.Write("Количество элементов в списке: ");

                byte n;
                if (byte.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    for (byte i = 1; i <= n; i++)
                    {
                        Console.Write($"Введите строку {i}: ");

                        head = new Item
                        {
                            field = Console.ReadLine(),
                            next = head
                        };

                        if (head.next != null) head.next.pred = head;
                    }
                }
                else Console.WriteLine("Введённое значение не является натуральным числом или значение слишком велико.");
            }

            public void Print()
            {
                Item current = head;

                if (current != null)
                {
                    Console.WriteLine("Состав списка: ");

                    do
                    {
                        Console.WriteLine($"{current.field:f3} ");
                        current = current.next;
                    } while (current != null);
                }
                else Console.WriteLine("Список пуст.");
            }

            public void AddOddStrings()
            {
                Item current = head, insert, tmp = null;

                while (current != null)
                {
                    Console.Write("Введите нечётную строку: ");

                    insert = new Item
                    {
                        field = Console.ReadLine(),
                        pred = current.pred,
                        next = current
                    };
                    if (tmp != null) tmp.next = insert;
                    current.pred = insert;
                    tmp = current;
                    current = current.next;

                    Console.WriteLine("Вставили.");
                }

                head = head.pred;
            }
        }

        private class BinaryTree
        {
            private class Item
            {
                public int field;
                public Item left;
                public Item right;
            }

            private Item root;

            public static Random random = new Random();

            public static BinaryTree BornIdealTree()
            {
                BinaryTree me = new BinaryTree();
                Console.Write("Высота дерева: ");

                byte deep;
                if (byte.TryParse(Console.ReadLine(), out deep))
                {
                    if (deep < 1)
                        Console.WriteLine("Введённое число не является натуральным.");
                    else if (deep > 24)
                        Console.WriteLine("На столь большое дерево не хватит оперативной памяти. Операция не выполнена.");
                    else
                        me.root = CreateIdealTree(deep);
                } else Console.WriteLine("Введённое значение не является натуральным числом либо число слишком большое.");

                return me;
            }

            public void Print()
            {
                ShowTree(root, 0);
            }

            public int FindMaxNumber()
            {
                return FindMaxNumber(root);
            }

            private static Item CreateIdealTree(int deep)
            {
                return new Item {
                    field = random.Next(-100, 100),
                    left = (deep > 1) ? CreateIdealTree(deep - 1) : null,
                    right = (deep > 1) ? CreateIdealTree(deep - 1) : null
                };
            }

            private void ShowTree(Item current, int l)
            {
                if (current != null)
                {
                    ShowTree(current.left, l + 3);
                    for (int i = 0; i < l; i++) Console.Write(' ');
                    Console.WriteLine(current.field);
                    ShowTree(current.right, l + 3);
                }
            }

            private int FindMaxNumber(Item current, int max = int.MinValue)
            {
                if (current != null) {
                    max = Math.Max(current.field, max);
                    max = (root.left != null) ? FindMaxNumber(current.left, max) : max;
                    max = (root.right != null) ? FindMaxNumber(current.right, max) : max;
                }

                return max;
            }

            /*
            public BinaryTree GetSortedTree()
            {
                BinaryTree sorted = new BinaryTree(field);
                FetchElement(sorted);
                return sorted;
            }

            private void FetchElement(BinaryTree root)
            {
                Add(root, field);
                if (left != null) left.FetchElement(root);
                if (right != null) right.FetchElement(root);
            }

            private static bool Add(BinaryTree root, int d)
            {
                BinaryTree p = root;
                BinaryTree r = null;
                bool ok = false;
                while (p != null && !ok)
                {
                    r = p;
                    if (d == p.field)
                        ok = true;
                    else if (d < p.field)
                        p = p.left;
                    else
                        p = p.right;
                }

                if (ok)
                    return false;

                BinaryTree NewPoint = new BinaryTree(d);

                if (d < r.field)
                    r.left = NewPoint;
                else
                    r.right = NewPoint;

                return true;
            }
            */
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
            Unidirectional list = new Unidirectional();

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
                        case "1": list.Born(); break;
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
            Bidirectional list = new Bidirectional();

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
                        case "1": list.Born(); break;
                        case "2": list.Print(); break;
                        case "3": list.AddOddStrings(); break;
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
            string key = "";
            BinaryTree tree = null;

            do
            {
                Console.WriteLine("Работа с бинарным деревом.");
                Console.WriteLine("1. Создать дерево.");
                Console.WriteLine("2. Распечатать дерево.");
                Console.WriteLine("3. Найти максимальное число.");
                Console.WriteLine("4. Преобразовать в дерево поиска.");
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
                        //case "4": tree = tree.GetSortedTree(); break;
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