namespace LabLauncher.Lab9Dir
{
    public class Money
    {
		public int roubles { get; protected set; }
		public int copeeks { get; protected set; }

        public static int count { get; protected set; }

        public Money()
        {
            roubles = 0;
            copeeks = 0;
            count++;
        }

		public Money(int roubles, int copeeks)
        {
            if (roubles >= 0 && copeeks >= 0 && copeeks < 100)
            {
                this.roubles = roubles;
                this.copeeks = copeeks;
                count++;
            }
        }

		public void addCopeeks(int add)
        {
            int buf = copeeks;
            buf += add;

            while (buf > 99)
            {
                roubles++;
                buf -= 100;
            }

            copeeks = buf;
        }

        public static void addCopeeks(Money m, int add)
        {
            int buf = m.copeeks;
            buf += add;

            while (buf > 99)
            {
                m.roubles++;
                buf -= 100;
            }

            m.copeeks = (int)buf;
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
            int cop = m1.copeeks + m2.copeeks;

            if (cop > 99)
            {
                rub++;
                cop -= 100;
            }

            return new Money(rub, (int)cop);
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

                m = new Money(rub, (int)cop);
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
            return money.copeeks;
        }

        public override string ToString()
        {
            return $"{roubles} руб. {copeeks} коп.";
        }
    }
}