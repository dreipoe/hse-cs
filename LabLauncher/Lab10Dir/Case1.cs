using System;
using System.Windows.Forms;

namespace LabLauncher.Lab10Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    public partial class Case1 : Form
    {
        PersonArray personArray;

        public Case1()
        {
            InitializeComponent();
            InitPersonList();
        }

        private void InitPersonList()
        {
            Person[] personArray = new Person[]
            {
                new Person("Габриэль Мэйсон", 51),
                new Person("Бойкова Нона Семеновна", 61),
                new Person("Ванин Гарольд Иванович", 42),
                new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3),
                new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26),
                new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40),
                new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36),
                new Employee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate),
                new Employee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary),
                new Employee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete),
                new Employee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate),
                new Engineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first),
                new Engineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third),
                new Engineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second)
            };

            personList.DataSource = personArray;
            this.personArray = new PersonArray(personArray);
        }

        private void closeMe_Click(object sender, EventArgs e) { Close(); }

        private void more_Click(object sender, EventArgs e)
        {
            if (personList.SelectedIndex == -1) return;

            Person person = personList.SelectedItem as Person;
            string info = (virtualFlag.Checked) ? person.virtualInfo() : person.info();

            MessageBox.Show(
                info,
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string names = string.Empty;

            if (!expNoLessThan.Checked)
            {
                if (Field.TextLength == 0) return;

                if (empAs.Checked)
                    names = personArray.selectEmpWithThePos(Field.Text);
                else if (workerFrom.Checked)
                    names = personArray.workerFromThe(Field.Text);
                else return;
            }
            else names = personArray.selectEmpWithExpNotLessThan((int)years.Value);

            new Result(names).Show();
        }
    }
}
