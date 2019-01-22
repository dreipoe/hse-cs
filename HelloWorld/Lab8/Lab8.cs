using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                key = ReadLine();

                switch (key)
                {
                    case "1": Work(); break;
                    case "2": Open(); break;
                    case "0": break;
                    default:
                        WriteLine("Нет такого пункта в меню.");
                        break;
                }
            } while (key != "0");
        }

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
                WriteLine("0. Закрыть файл");
                Write("> ");

                key = ReadLine();

                switch (key)
                {
                    case "1": break;
                    case "2": break;
                    case "3": break;
                    case "0": break;
                    default:
                        WriteLine("Нет такого пункта в меню.");
                        break;
                }
            } while (key != "0");
        }

        private static void AddRecord()
        {
            string str, unit;
            uint month, year, profit;
            do
            {
                Write("Введите номер или название месяца на русском: ");
                str = ReadLine();
            } while (!uint.TryParse(str, out month) && !TryParseMonth(str, out month) && (month < 0) && (month >= 12));

            do
            {
                Write("Введите год: ");
            } while (!uint.TryParse(ReadLine(), out year));

            Write("Введите название подразделения: ");
            unit = ReadLine();

            do
            {
                Write("Сколько евро заработало это подразделение? ");
            } while (!uint.TryParse(ReadLine(), out profit));

            Record record = new Record((Record.month)month, year, unit, profit);
            db.Add(record);
        }

        private static bool TryParseMonth(string month, out uint code)
        {
            switch (month.ToLower())
            {
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

        private static void printDB()
        {
            if (db.Count != 0)
            {
                WriteLine();
                foreach (Record row in db)
                {
                    WriteLine(row.row);
                }
            }
            else WriteLine("пусто.");
        }

        private static void Open()
        {

        }
    }
}
