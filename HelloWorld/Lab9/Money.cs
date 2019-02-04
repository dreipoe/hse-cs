﻿namespace HelloWorld.Lab9Dir
{
    class Money
    {
		protected int roubles;
		protected byte copeeks;

		protected static int count;

		public Money(int _roubles, byte _copeeks)
        {
            if (_roubles >= 0 && _copeeks >= 0 && _copeeks < 100)
            {
                roubles = _roubles;
                copeeks = _copeeks;
            }

			count++;
        }

		public int getRoubles()
		{
			return roubles;
		}

		public int getCopeeks()
		{
			return copeeks;
		}

		public static int Count()
		{
			return count;
		}

		public void addCopeeks(byte add)
        {
            copeeks += add;

            while (copeeks > 99)
            {
                roubles++;
                copeeks = (byte)(copeeks - 100);
            }
        }

        public static void addCopeeks(Money m, byte add)
        {
            m.copeeks += add;

            while (m.copeeks > 99)
            {
                m.roubles++;
                m.copeeks = (byte)(m.copeeks - 100);
            }
        }

        public static Money operator ++(Money money)
        {
            if (money.copeeks == 99)
            {
                money.roubles++;
                money.copeeks = 0;
            }
            else money.copeeks++;

            return money;
        }

        public static Money operator --(Money money)
        {
            if (money.copeeks == 0)
            {
                if (money.roubles != 0)
                {
                    money.roubles--;
                    money.copeeks = 99;
                }
            }
            else money.copeeks--;

            return money;
        }

        public static Money operator +(Money m1, Money m2)
        {
            int rub = m1.roubles + m2.roubles;
            byte cop = (byte)(m1.copeeks + m2.copeeks);

            if (cop > 99)
            {
                rub++;
                cop = (byte)(cop - 100);
            }

            return new Money(rub, cop);
        }

        public static Money operator -(Money m1, Money m2)
        {
            Money m = null;

            if (m1 > m2)
            {
                int rub = m1.roubles - m2.roubles;
                char cop = (char)(m1.copeeks - m2.copeeks);

                if (cop < 0)
                {
                    rub--;
                    cop = (char)(cop + 100);
                }

                m = new Money(rub, (byte)cop);
            }

            return m;
        }

        public static bool operator <(Money m1, Money m2)
        {
            bool result = false;

            result = ((m1.roubles < m2.roubles) || (m1.roubles == m2.roubles) && (m1.copeeks < m2.copeeks)) ? true : result;

            return result;
        }

        public static bool operator >(Money m1, Money m2)
        {
            bool result = false;

            result = ((m1.roubles > m2.roubles) || (m1.roubles == m2.roubles) && (m1.copeeks > m2.copeeks)) ? true : result;

            return result;
        }

        public static explicit operator int(Money money)
        {
            return money.roubles;
        }

        public static implicit operator double(Money money)
        {
            return money.copeeks / 100;
        }
    }
}