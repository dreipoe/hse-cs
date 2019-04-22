namespace LabLauncher.Entities
{
    public class Worker : Person
    {
        protected int salary;
        public byte experience { get; protected set; }
        public string shop { get; protected set; }
        public string position { get; protected set; }

        public Worker(string FIO, string pos, byte c, int salary, int experience) : base(FIO, c)
        {
            if (!__construct(pos, salary, experience)) return;
        }

        public Worker(string FIO, string shop, string pos, byte c, int salary, int experience) : base(FIO, c)
        {
            if (__construct(pos, salary, experience))
                this.shop = shop;
            else return;
        }

        //используется конструкторами, создан для того, чтобы не дублировать один и тот же код
        protected bool __construct(string pos, int salary, int experience)
        {
            if (experience < 0 || experience > 255) return false;

            position = pos;
            this.salary = salary;
            this.experience = (byte)experience;
            return true;
        }

        public new string info()
        {
            string years = yearCase(age);
            string sExp = yearCase(experience);

            string result = $"{FIO}, {age} {years}\n";
            result += $"Зарплата: {salary} руб.\n";
            result += $"Опыт работы: {experience} {sExp}\n";
            result += $"Цех: {shop}\n";
            result += $"Должность: {position}";

            return result;
        }

        public override string virtualInfo()
        {
            return info();
        }
    }
}
