using System;
using static System.Console;

namespace HelloWorld
{
    static class Lab9
    {
        public static void Run()
        {
			string key;

			do
			{
				Write("Введите номер задачи для её запуска: ");

				key = ReadLine();

				switch (key)
				{
					case "1": Task1(); break;
					case "2": Task2(); break;
					case "0": break;
					default:
						WriteLine("Такой задачи нет в этой лабе.");
						break;
				}
			} while (key != "0");
		}

		private static void Task1()
		{
			Money a = new Money(0, 0);
			Money b = new Money(2, 20);
			Money c = new Money(202, 50);

			WriteLine($"Создано {Money.Count()} счет(ов), имеющих следующие средства:");
			WriteLine($"Счёт А содержит {a.getRoubles()} рубл(ей) {a.getCopeeks()}");
			WriteLine($"Счёт B содержит {b.getRoubles()} рубл(ей) {b.getCopeeks()}");
			WriteLine($"Счёт C содержит {c.getRoubles()} рубл(ей) {c.getCopeeks()}");

			WriteLine("Зачислим на них немного средств.");

			a.addCopeeks(220);
			b.addCopeeks(30);
			Money.addCopeeks(c, 50);

			WriteLine("Теперь на счетах стало больше денег.");
			WriteLine($"Счёт А содержит {a.getRoubles()} рубл(ей) {a.getCopeeks()}");
			WriteLine($"Счёт B содержит {b.getRoubles()} рубл(ей) {b.getCopeeks()}");
			WriteLine($"Счёт C содержит {c.getRoubles()} рубл(ей) {c.getCopeeks()}");
		}

		private static void Task2()
		{
			WriteLine("NYEHT!");
		}
	}
}
