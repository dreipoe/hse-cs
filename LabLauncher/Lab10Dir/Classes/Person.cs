

namespace LabLauncher.Lab10Dir
{
    public class Person
    {
        protected string firstname;
        protected string lastname;
        protected string patronym;
        protected byte age;

        //без отчества
        public Person(string a, string b, byte c)
        {
            firstname = a;
            lastname = b;
            patronym = null;
            age = c;
        }

        //с отчеством
        public Person(string a, string b, string c, byte d)
        {
            firstname = a;
            lastname = b;
            patronym = c;
            age = d;
        }

        public string row
        {
            get {
                string cas = string.Empty;
                int lastdigit = age % 10;

                if (age >= 5 || age / 10 % 10 == 1)
                    cas = "лет";
                else if (age == 1)
                    cas = "год";
                else if (age >= 2 && age <= 4)
                    cas = "года";

                string result = (patronym == null) ? $"{firstname} {lastname}, {age} {cas}" : $"{firstname} {lastname} {patronym}, {age} {cas}";
                return result;
            }
        }

        public override string ToString()
        {
            string result = $"{firstname} {lastname}";
            if (patronym != null) result += $" {patronym}";
            return result;
        }
    }
}
