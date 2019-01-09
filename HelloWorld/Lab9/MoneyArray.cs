using System;
using static System.Console;

namespace HelloWorld
{
    class MoneyArray
    {
        Money[] array;
        int size;

        public MoneyArray()
        {
            array = null;
            size = 0;
        }

        public MoneyArray(int _size)
        {
            Random rnd = new Random();
            int tmp;

            array = new Money[_size];
            size = _size;
            for (int i = 0; i < _size; i++)
            {
                tmp = rnd.Next(-10000, 10000);
                array[i] = new Money(tmp / 100, tmp % 100);
            }
        }

        public MoneyArray(int _size, string message)
        {
            array = new Money[_size];
            size = _size;
            for (int i = 0; i < _size; i++)
            {
                Write(message);
                double tmp;
                if (double.TryParse(Console.ReadLine(), out tmp))
                {
                    //округление
                    int rub = (int) tmp;
                    int cop = (int)(tmp - rub) * 100;
                    array[i] = new Money(rub, cop);
                }
                else array[i] = new Money(0, 0);
            }
        }

		public Money IndexOf(int i)
		{
			return array[i];
		}

		public void View()
		{
			for (int i = 0; i < size; i++)
				WriteLine($"{array[i].getRoubles()} рубл(ей) {array[i].getCopeeks()} копе(ек)");
		}
    }
}
