namespace LabLauncher.Entities
{
    public class Person
    {
        protected string FIO;
        protected byte age;

        public Person(string FIO, byte c)
        {
            this.FIO = FIO;
            age = c;
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
