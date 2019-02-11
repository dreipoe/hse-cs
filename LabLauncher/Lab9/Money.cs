namespace LabLauncher.Lab9Dir
{
    class Money
    {
		protected int x_roubles;
		protected byte x_copeeks;

		protected static int x_count;

        public int roubles
        {
            get
            {
                return x_roubles;
            }
        }

        public byte copeeks
        {
            get
            {
                return x_copeeks;
            }
        }

        public string row
        {
            get
            {
                return $"{x_roubles} руб. {x_copeeks} коп.";
            }           
        }

        public static int count
        {
            get
            {
                return x_count;
            }
        }

        public Money()
        {
            x_roubles = 0;
            x_copeeks = 0;
            x_count++;
        }

		public Money(int _roubles, byte _copeeks)
        {
            if (_roubles >= 0 && _copeeks >= 0 && _copeeks < 100)
            {
                x_roubles = _roubles;
                x_copeeks = _copeeks;
            }

			x_count++;
        }

		public static int Count()
		{
			return count;
		}

		public void addCopeeks(int add)
        {
            int buf = x_copeeks;
            buf += add;

            while (buf > 99)
            {
                x_roubles++;
                buf -= 100;
            }

            x_copeeks = (byte)buf;
        }

        public static void addCopeeks(Money m, int add)
        {
            int buf = m.x_copeeks;
            buf += add;

            while (buf > 99)
            {
                m.x_roubles++;
                buf -= 100;
            }

            m.x_copeeks = (byte)buf;
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
            if (money.copeeks == 0)
            {
                if (money.roubles != 0)
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
            int rub = m1.roubles + m2.roubles;
            int cop = m1.copeeks + m2.copeeks;

            if (cop > 99)
            {
                rub++;
                cop -= 100;
            }

            return new Money(rub, (byte)cop);
        }

        public static Money operator -(Money m1, Money m2)
        {
            Money m = null;

            if (m1 > m2)
            {
                int rub = m1.roubles - m2.roubles;
                int cop = m1.copeeks - m2.copeeks;

                if (cop < 0)
                {
                    rub--;
                    cop += 100;
                }

                m = new Money(rub, (byte)cop);
            }

            return m;
        }

        public static bool operator <(Money m1, Money m2)
        {
            bool result = ((m1.roubles < m2.roubles) || (m1.roubles == m2.roubles) && (m1.copeeks < m2.copeeks)) ? true : false;
            return result;
        }

        public static bool operator >(Money m1, Money m2)
        {
            bool result = ((m1.roubles > m2.roubles) || (m1.roubles == m2.roubles) && (m1.copeeks > m2.copeeks)) ? true : false;
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