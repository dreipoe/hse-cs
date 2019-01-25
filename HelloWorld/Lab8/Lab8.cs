using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using static System.Console;

namespace HelloWorld
{
    static class Lab8
    {
        public static string filename = "Notname";
        public static List<Record> db;
        public static bool changed = false;

        public static void Run()
        {
            db = new List<Record>();

            string key;

            do
            {
                WriteLine("Добро пожаловать в Fenix!");
                WriteLine("1. Создать новый файл");
                WriteLine("2. Открыть существующий файл");
                WriteLine("0. Выход");
                Write("> ");

                key = ReadLine().ToLower();

                switch (key)
                {
                    case "1": Work(); break;
                    case "2": Open(); break;
                    case "generator": generator(); break;
                    case "0": break;
                    default:
                        WriteLine("Нет такого пункта в меню.");
                        break;
                }
            } while (key != "0");
        }

        //работа с файлом
        private static void Work()
        {
            string key;

            do
            {
                Write($"Содержимое файла {filename}: ");
                printDB();
                WriteLine("1. Добавить запись");
                WriteLine("2. Изменить запись");
                WriteLine("3. Удалить запись");
                WriteLine("4. Сохранить файл");
                WriteLine("5. Определить самый прибыльный год");
                WriteLine("6. Определить самый длинный период с доходами ниже среднего");
                WriteLine("0. Закрыть файл");
                Write("> ");

                key = ReadLine();

                switch (key)
                {
                    case "1": AddRecord(); break;
                    case "2": AddRecord(true); break;
                    case "3": deleteRecord(); break;
                    case "4": saveFile(); break;
                    case "5": mostProfitableYear(); break;
                    case "6": longest(); break;
                    case "0": if (changed) changedFile(); break;
                    default:
                        WriteLine("Нет такого пункта в меню.");
                        break;
                }
            } while (key != "0");

            filename = "Notname";
            db = new List<Record>();
        }

        //диалог добавления/изменения записи в файл
        private static void AddRecord(bool edit = false)
        {
            int id = 0, month, year, profit;
            string str, unit;

            if (edit)
                do {
                    id = SecureInput("Введите номер записи для редактирования: ");
                    if (id >= db.Count) WriteLine("Такого элемента в файле нет.");
                } while (id >= db.Count);

            do {
                Write("Введите номер или название месяца на русском: ");
                str = ReadLine();
            } while (!int.TryParse(str, out month) && !TryParseMonth(str, out month) && (month < 0) && (month >= 12));

            year = SecureInput("Введите год: ");

            Write("Введите название подразделения: ");
            unit = ReadLine();

            profit = SecureInput("Сколько евро заработало это подразделение? ");

            Record record = new Record((Record.month)month, year, unit, profit);

            if (edit) {
                db.RemoveAt(id);
                db.Insert(id, record);
            } else db.Add(record);

            changed = true;
        }

        //преобразует название месяца на русском в код месяца
        private static bool TryParseMonth(string month, out int code)
        {
            switch (month.ToLower()) {
                case "январь": code = 0; return true;
                case "февраль": code = 1; return true;
                case "март": code = 2; return true;
                case "апрель": code = 3; return true;
                case "май": code = 4; return true;
                case "июнь": code = 5; return true;
                case "июль": code = 6; return true;
                case "август": code = 7; return true;
                case "сентябрь": code = 8; return true;
                case "октябрь": code = 9; return true;
                case "ноябрь": code = 10; return true;
                case "декабрь": code = 11; return true;
                default: code = 0; return false;
            }
        }

        //Удаляет запись из файла
        private static void deleteRecord()
        {
            int id;
            id = SecureInput("Введите номер записи, чтобы удалить её: ");
            db.RemoveAt(id);
            changed = true;
        }

        private static void changedFile()
        {
            Write("Сохранить файл? (Y/N): ");
            string key = ReadLine().ToUpper();
            if (key == "Y") saveFile();
        }

        //Сохранение файла
        //TODO: Здесь не хватает обработки исключений, стоит добавить
        private static void saveFile()
        {
            Write("Под каким именем нужно сохранить файл? ");
            string file = ReadLine();

            FileInfo fileinfo = new FileInfo($"{file}.db");
            if (fileinfo.Exists) {
                Write("Такой файл уже существует. Перезаписать его? (Y/N): ");
                if (ReadLine().ToUpper() != "Y") return;
            }

            FileStream f1 = new FileStream($"{file}.db", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f1, db);
            f1.Close();

            filename = file;
        }

        //определяет самый прибыльный год для каждого подразделения
        private static void mostProfitableYear()
        {
            Write("Эта функция пока недоступна");
        }

        //определяет самый длинный период с доходом ниже среднего для каждого подразделения
        private static void longest()
        {
            Write("Эта функция пока недоступна");
        }

        //Печатает в консоли содержимое файла
        private static void printDB()
        {
            if (db.Count != 0)
            {
                WriteLine();
                for (int i = 0; i < db.Count; i++)
                    WriteLine($"Ячейка {i}: {db[i].row}");
            }
            else WriteLine("пусто.");
        }

        private static void Open()
        {
            bool exists;
            string file;
            FileInfo fileinfo;

            do
            {
                Write("Под каким именем нужно открыть файл? (0 - назад): ");
                file = ReadLine();
                fileinfo = new FileInfo($"{file}.db");
                exists = fileinfo.Exists;
            } while (file != "0" && !exists);

            if (file != "0")
            {
                FileStream f1 = new FileStream($"{file}.db", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                db = (List<Record>)bf.Deserialize(f1);
                filename = file;
                changed = false;
                f1.Close();
                Work();
            }   
        }

        //Чит-код, генерирует файл базы данных по умолчанию
        private static void generator()
        {
            Write("Внимание! Вы запустили чит-код, который сгенерирует файл по умолчанию. Вы действительно хотите этого? (Y/N): ");
            string key = ReadLine().ToUpper();

            if (key == "Y")
            {
                List<Record> dflt = new List<Record>();
                Random rnd = new Random();
                int profit1, profit2;

                for (int year = 2007; year <= 2009; year++)
                    for (int month = 0; month < 12; month++)
                    {
                        profit1 = (year == 2007) ? rnd.Next(500, 2000) : (int)(rnd.Next(500, 2000) * 1.32);
                        profit2 = rnd.Next(750, 3000);
                        dflt.Add(new Record((Record.month)month, year, "Эмо", profit1));
                        dflt.Add(new Record((Record.month)month, year, "Панк", profit2));
                    }

                FileStream f1 = new FileStream("default.db", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f1, dflt);
                f1.Close();
            }
        }

        private static int SecureInput(string message)
        {
            int num; bool check;

            do
            {
                Write(message);
                check = int.TryParse(ReadLine(), out num);

                if (!check)
                    WriteLine("Введённая строка не является натуральным числом или выходит за диапазон типа unit. Повторите ввод.");
            } while (!check);

            return num;
        }
    }
}
