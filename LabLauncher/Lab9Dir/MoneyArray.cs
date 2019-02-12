using System;

namespace LabLauncher.Lab9Dir
{
    public class MoneyArray
    {
        //публичный get позволит вытаскивать данные из обёртки для отображения
        public Money[] array { get; protected set; }
        public int size { get; protected set; }
        protected string name;

        public static int count { get; protected set; }

        //возвращает индекс элемента с минимальным значением
        public int minIndex
        {
            get
            {
                Money min = null;
                int minIndex = -1;

                int length = array.Length;

                if (length > 0)
                {
                    min = array[0];
                    if (length > 1)
                        for (int i = 1; i < length; i++)
                            if (array[i] < min)
                            {
                                min = array[i];
                                minIndex = i;
                            }
                }

                return minIndex;
            }
        }

        //конструктор без параметров
        public MoneyArray()
        {
            array = new Money[0];
            size = 0;
            count++;
            name = $"Счёт №{count}";
        }

        //конструктор, заполняющий массив случайными значениями
        public MoneyArray(int _size)
        {
            Random rnd = new Random();
            int tmp;

            array = new Money[_size];
            size = _size;

            for (int i = 0; i < _size; i++)
            {
                tmp = rnd.Next(0, 10000);
                array[i] = new Money(tmp / 100, tmp % 100);
            }

            count++;
            name = $"Счёт №{count}";
        }

        //конструктор, позволяющий заполнить массив элементами, заданными пользователем (в отдельной форме)
        public MoneyArray(Money[] input)
        {
            array = input;
            size = input.Length;
            count++;
            name = $"Счёт №{count}";
        }

        //индексатор
		public Money ValueOf(int i)
		{
			return array[i];
		}

        public override string ToString()
        {
            return name;
        }
    }
}
