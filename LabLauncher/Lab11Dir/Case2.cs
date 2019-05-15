using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab11Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    public partial class Case2 : Form
    {
        private Stack<Person> people;

        public Case2()
        {
            InitializeComponent();
            InitPersonList();
        }

        // инициализация и автозаполнение
        private void InitPersonList()
        {
            people = new Stack<Person>();

            people.Push(new Person("Габриэль Мэйсон", 51));
            people.Push(new Person("Бойкова Нона Семеновна", 61));
            people.Push(new Person("Ванин Гарольд Иванович", 42));
            people.Push(new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3));
            people.Push(new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26));
            people.Push(new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40));
            people.Push(new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36));
            people.Push(new Employee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate));
            people.Push(new Employee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary));
            people.Push(new Employee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete));
            people.Push(new Employee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate));
            people.Push(new Engineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first));
            people.Push(new Engineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third));
            people.Push(new Engineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second));

            personList.DataSource = people.ToArray();
        }

        // открывает окно добавления объекта
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            if (addPerson.ShowDialog() == DialogResult.OK) people.Push(addPerson.retorn);
            personList.DataSource = people.ToArray();
        }

        // удаляет выделенный элемент с конца
        private void popButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show(
                "Вы действительно хотите удалить первый элемент?",
                "Лаб. работа №11",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (delete == DialogResult.Yes)
            {
                people.Pop();
                personList.DataSource = people.ToArray();
            }
        }

        // Обработка одного из трёх запросов. Используется оператор foreach
        private void queryButton_Click(object sender, EventArgs e)
        {
            if (q1.Checked)
            {
                int n = 0;
                foreach (Person person in people) if (person is Worker) n++;
                MessageBox.Show($"Кол-во рабочих в коллекции: {n}", "Лаб. №11", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (q2.Checked)
            {
                Stack<Person> engineers = new Stack<Person>();
                foreach (Person person in people) if (person is Engineer) engineers.Push(person);
                new Case1Print(engineers).Show();
            }
            else
            {
                // TODO: Придумать третий запрос
            }
        }

        //Клонирование коллекции
        private void cloneButton_Click(object sender, EventArgs e)
        {
            Stack<Person> clone = new Stack<Person>();
            Stack<Person> tmp = new Stack<Person>();
            foreach (Person person in people) tmp.Push(person);
            foreach (Person person in tmp) clone.Push(person);
            new Case1Print(clone).Show();
        }

        //Сортировка коллекции
        private void sortButton_Click(object sender, EventArgs e)
        {
            Person[] tmp = people.ToArray();           
            Array.Sort(tmp, new PersonComparer());
            Array.Reverse(tmp);
            people.Clear();
            foreach (Person person in tmp) people.Push(person);
            personList.DataSource = people.ToArray();
        }

        //Поиск нужного человека
        private void searchButton_Click(object sender, EventArgs e)
        {
            Person search = new Person(searchField.Text, 0);
            Person[] tmp = people.ToArray();
            Array.Sort(tmp, new PersonComparer());
            int pos = Array.BinarySearch(tmp, search, new PersonComparer()) + 1;

            if (pos > 0)
                MessageBox.Show($"Элемент найден на позиции {pos}", "Лаб. №11", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Элемент не найден", "Лаб. №11", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
