namespace HelloWorld.Lab9Dir
{
    public class Money
    {
        protected int x_roubles;
		protected byte x_copeeks;

        public int roubles
        {
            get
            {
                return x_roubles;
            }
        }

        public int copeeks
        {
            get
            {
                return x_copeeks;
            }
        }

        protected static int count;

		public Money(int _roubles, byte _copeeks)
        {
            if (_roubles >= 0 && _copeeks >= 0 && _copeeks < 100)
            {
                x_roubles = _roubles;
                x_copeeks = _copeeks;
            }

			count++;
        }

		public static int Count()
		{
			return count;
		}

		public void addx_copeeks(byte add)
        {
            x_copeeks += add;

            while (x_copeeks > 99)
            {
                x_roubles++;
                x_copeeks = (byte)(x_copeeks - 100);
            }
        }

        public static void addx_copeeks(Money m, byte add)
        {
            m.x_copeeks += add;

            while (m.x_copeeks > 99)
            {
                m.x_roubles++;
                m.x_copeeks = (byte)(m.x_copeeks - 100);
            }
        }

        public static Money operator ++(Money money)
        {
            if (money.x_copeeks == 99)
            {
                money.x_roubles++;
                money.x_copeeks = 0;
            }
            else money.x_copeeks++;

            return money;
        }

        public static Money operator --(Money money)
        {
            if (money.x_copeeks == 0)
            {
                if (money.x_roubles != 0)
                {
                    money.x_roubles--;
                    money.x_copeeks = 99;
                }
            }
            else money.x_copeeks--;

            return money;
        }

        public static Money operator +(Money m1, Money m2)
        {
            int rub = m1.x_roubles + m2.x_roubles;
            byte cop = (byte)(m1.x_copeeks + m2.x_copeeks);

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
                int rub = m1.x_roubles - m2.x_roubles;
                char cop = (char)(m1.x_copeeks - m2.x_copeeks);

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

            result = ((m1.x_roubles < m2.x_roubles) || (m1.x_roubles == m2.x_roubles) && (m1.x_copeeks < m2.x_copeeks)) ? true : result;

            return result;
        }

        public static bool operator >(Money m1, Money m2)
        {
            bool result = false;

            result = ((m1.x_roubles > m2.x_roubles) || (m1.x_roubles == m2.x_roubles) && (m1.x_copeeks > m2.x_copeeks)) ? true : result;

            return result;
        }

        public static explicit operator int(Money money)
        {
            return money.x_roubles;
        }

        public static implicit operator double(Money money)
        {
            return money.x_copeeks / 100;
        }
    }
}