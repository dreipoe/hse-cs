using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab11Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    public partial class Case1 : Form
    {
        private ArrayList persons;

        public Case1()
        {
            InitializeComponent();
            InitPersonList();
        }

        // инициализация
        private void InitPersonList()
        {
            persons = new ArrayList();

            persons.Add(new Person("Габриэль Мэйсон", 51));
            persons.Add(new Person("Бойкова Нона Семеновна", 61));
            persons.Add(new Person("Ванин Гарольд Иванович", 42));
            persons.Add(new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3));
            persons.Add(new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26));
            persons.Add(new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40));
            persons.Add(new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36));
            persons.Add(new Employee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate));
            persons.Add(new Employee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary));
            persons.Add(new Employee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete));
            persons.Add(new Employee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate));
            persons.Add(new Engineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first));
            persons.Add(new Engineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third));
            persons.Add(new Engineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second));

            personList.DataSource = persons.ToArray();
        }

        // открывает окно добавления объекта
        private void addButton_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();

            if (addPerson.ShowDialog() == DialogResult.OK) persons.Add(addPerson.retorn);
        }

        // удаляет выделенный элемент
        private void delButton_Click(object sender, EventArgs e)
        {
            if (personList.SelectedItem == null) return;

            DialogResult delete = MessageBox.Show(
                "Вы действительно хотите удалить этот элемент?",
                "Лаб. работа №11",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (delete == DialogResult.Yes)
            {
                persons.RemoveAt(personList.SelectedIndex);
                personList.DataSource = persons.ToArray();
            }
        }

        // TODO: Придумать три запроса к коллекции

    }
}
