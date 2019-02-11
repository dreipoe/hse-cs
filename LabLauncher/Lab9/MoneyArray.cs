using System;

namespace LabLauncher.Lab9Dir
{
    class MoneyArray
    {
        protected Money[] array;
        protected int size;

        protected static int x_count;

        public Money[] arr
        {
            get
            {
                return array;
            }
        }

        public static int count
        {
            get
            {
                return x_count;
            }
        }

        public Money min
        {
            get
            {
                Money min = null;
                int length = array.Length;

                if (length > 0)
                {
                    min = array[0];
                    if (length > 1)
                        for (int i = 1; i < length; i++)
                            if (array[i] < min)
                                min = array[i];
                }

                return min;
            }
        }

        //конструктор без параметров
        public MoneyArray()
        {
            array = null;
            size = 0;
            x_count++;
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
                tmp = rnd.Next(-10000, 10000);
                array[i] = new Money(tmp / 100, (byte)(tmp % 100));
            }

            x_count++;
        }

        //конструктор, позволяющий заполнить массив элементы, заданными пользователем
        public MoneyArray(Money[] input)
        {
            array = input;
            size = input.Length;
            x_count++;
        }

		public Money ValueOf(int i)
		{
			return array[i];
		}
    }
}
