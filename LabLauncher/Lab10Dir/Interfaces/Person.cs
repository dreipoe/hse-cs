using System;

namespace LabLauncher.Lab10Dir.Interfaces
{
    public abstract class Person : PersonInterface, IComparable, ICloneable
    {
        protected string FIO;
        protected byte age;

        public Person(string FIO, byte c)
        {
            this.FIO = FIO;
            age = c;
        }

        public virtual object Clone()
        {
            return null;
        }

        public string info()
        {
            string years = yearCase(age);
            return $"{FIO}, {age} {years}";
        }

        public virtual string virtualInfo()
        {
            string years = yearCase(age);
            return $"{FIO}, {age} {years}";
        }

        public override string ToString()
        {
            return FIO;
        }

        public int CompareTo(object a)
        {
            Person tmp = (Person)a;
            if (string.Compare(FIO, tmp.FIO) > 0) return 1;
            if (string.Compare(FIO, tmp.FIO) < 0) return -1;
            return 0;
        }

        protected string yearCase(int years)
        {
            int lastdigit = years % 10;

            if (lastdigit >= 5 || lastdigit == 0 || years / 10 % 10 == 1)
                return "лет";
            else if (lastdigit == 1)
                return "год";
            else if (lastdigit >= 2 && lastdigit <= 4)
                return "года";
            else
                return null;
        }
    }
}
