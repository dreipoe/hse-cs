using System;
using System.Windows.Forms;

namespace LabLauncher.Lab10Dir
{
    using IPerson = Interfaces.Person;
    using IWorker = Interfaces.Worker;
    using IEmployee = Interfaces.Employee;
    using IEngineer = Interfaces.Engineer;
    using PersonComparer = Interfaces.PersonComparer;

    using education = Interfaces.Employee.education;
    using category = Interfaces.Engineer.category;

    public partial class Case2 : Form
    {
        IPerson[] persons;

        public Case2()
        {
            InitializeComponent();
            InitPersonList();
        }

        private void InitPersonList()
        {
            persons = new IPerson[]
            {
                new IWorker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3),
                new IWorker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26),
                new IWorker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40),
                new IWorker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36),
                new IEmployee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate),
                new IEmployee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary),
                new IEmployee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete),
                new IEmployee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate),
                new IEngineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first),
                new IEngineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third),
                new IEngineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second)
            };

            personList.DataSource = persons;
        }

        private void sortMe_Click(object sender, EventArgs e)
        {
            Array.Sort(persons, new PersonComparer());
            RefreshPersonList();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchMe.TextLength == 0) return;
            int a = Array.FindIndex(persons, p => p.ToString().Contains(searchMe.Text));
            if (a != -1) personList.SelectedIndex = a;
        }

        private void cloneMe_Click(object sender, EventArgs e)
        {
            if (personList.SelectedIndex == -1) return;

            IPerson selected = personList.SelectedItem as IPerson;
            IPerson addMe = selected.Clone() as IPerson;

            //обновляем массив
            int oldLength = persons.Length;
            IPerson[] people = new IPerson[oldLength + 1];
            for (int i = 0; i < oldLength; i++)
                people[i] = persons[i];
            people[oldLength] = addMe;
            persons = people;
            RefreshPersonList();
        }

        private void RefreshPersonList()
        {
            personList.DataSource = null;
            personList.DataSource = persons;
        }
    }
}
