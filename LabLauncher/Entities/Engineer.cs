namespace LabLauncher.Entities
{
    public class Engineer : Employee
    {
        public enum category { third, second, first }
        protected category rang;

        public Engineer(
            string FIO,
            string pos,
            byte c,
            int salary,
            int experience,
            education edu,
            category rang
        ) : base(FIO, pos, c, salary, experience, edu)
        {
            //проверка требований к квалификации, необходимой для инженера, в зависимости от категории
            if (rang == category.third && ((edu < education.secondarySpecial) || (edu < education.higher) && (experience < 3))) return;
            if (rang == category.second && ((edu < education.higher) || (experience < 3))) return;
            if (rang == category.first && ((edu < education.higher) || (experience < 6))) return;

            this.rang = rang;
        }

        public new string info()
        {
            string sAges = yearCase(age);
            string sExp = yearCase(experience);

            string result = $"{FIO}, {age} {sAges}\n";
            result += $"Зарплата: {salary} руб.\n";           
            result += $"Опыт работы: {experience} {sExp}\n";
            result += $"Образование: {sEducation}\n";
            result += $"Категория: {sRang}\n";
            result += $"Должность: {position}";
            
            return result;
        }

        public override string virtualInfo()
        {
            return info();
        }

        protected string sRang
        {
            get
            {
                switch (rang)
                {
                    case category.third: return "третья";
                    case category.second: return "вторая";
                    case category.first: return "первая";
                    default: return null;
                }
            }
        }
    }
}
