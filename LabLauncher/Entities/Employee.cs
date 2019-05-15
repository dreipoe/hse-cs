namespace LabLauncher.Entities
{
    public class Employee : Worker
    {
        public enum education { secondary, secondarySpecial, higherIncomplete, higher, postgraduate }
        public education edu { get; protected set; }

        public Employee(string FIO, string pos, byte c, int salary, int experience, education edu) : base(FIO, pos, c, salary, experience)
        {
            this.edu = edu;
        }

        public new string info()
        {
            string sAges = yearCase(age);
            string sExp = yearCase(experience);

            string result = $"{FIO}, {age} {sAges}\n";
            result += $"Зарплата: {salary} руб.\n";
            result += $"Опыт работы: {experience} {sExp}\n";
            result += $"Образование: {sEducation}\n";
            result += $"Должность: {position}";

            return result;
        }

        public override string virtualInfo()
        {
            return info();
        }

        protected string sEducation
        {
            get
            {
                switch (edu)
                {
                    case education.secondary: return "среднее общее";
                    case education.secondarySpecial: return "среднее специальное";
                    case education.higherIncomplete: return "неоконченное высшее";
                    case education.higher: return "высшее";
                    case education.postgraduate: return "второе высшее";
                    default: return null;
                }
            }
        }
    }
}
