using System;
using System.Collections;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab11Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    public partial class Case1 : Form
    {
        private ArrayList people;
        private bool sorted = false;

        public Case1()
        {
            InitializeComponent();
            InitPersonList();
        }

        // инициализация и автозаполнение
        private void InitPersonList()
        {
            people = new ArrayList();

            people.Add(new Person("Габриэль Мэйсон", 51));
            people.Add(new Person("Бойкова Нона Семеновна", 61));
            people.Add(new Person("Ванин Гарольд Иванович", 42));
            people.Add(new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3));
            people.Add(new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26));
            people.Add(new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40));
            people.Add(new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36));
            people.Add(new Employee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate));
            people.Add(new Employee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary));
            people.Add(new Employee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete));
            people.Add(new Employee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate));
            people.Add(new Engineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first));
            people.Add(new Engineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third));
            people.Add(new Engineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second));

            personList.DataSource = people.ToArray();
        }

        // открывает окно добавления объекта
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            if (addPerson.ShowDialog() == DialogResult.OK) people.Add(addPerson.retorn);
            personList.DataSource = people.ToArray();
            sorted = false;
        }

        // удаляет выделенный элемент
        private void delButton_Click(object sender, EventArgs e)
        {
            if (personList.SelectedItem == null) return;

            DialogResult delete = MessageBox.Show("Вы действительно хотите удалить этот элемент?", "Лаб. работа №11", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (delete == DialogResult.Yes)
            {
                people.RemoveAt(personList.SelectedIndex);
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
                ArrayList engineers = new ArrayList();
                foreach (Person person in people) if (person is Engineer) engineers.Add(person);
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
            ArrayList clone = people.Clone() as ArrayList;
            new Case1Print(clone).Show();
        }

        //Сортировка коллекции
        private void sortButton_Click(object sender, EventArgs e)
        {
            people.Sort(new PersonComparer());
            personList.DataSource = people.ToArray();
            sorted = true;
        }

        //Поиск нужного человека
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!sorted)
            {
                DialogResult yes = MessageBox.Show(
                    "Коллекция будет отсортирована в алфавитном порядке, после чего отобразится позиция объекта в отсортированном массиве.\nПродолжить?",
                    "Лаб. №11",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );
                if (yes != DialogResult.Yes) return;
                sortButton_Click(sender, e);
            }

            Person search = new Person(searchField.Text, 0);
            int pos = people.BinarySearch(search, new PersonComparer()) + 1;

            if (pos > 0)
                MessageBox.Show($"Элемент найден на позиции {pos}", "Лаб. №11", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Элемент не найден", "Лаб. №11", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
