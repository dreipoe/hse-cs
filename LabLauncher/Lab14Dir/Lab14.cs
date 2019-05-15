using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LabLauncher.Entities;

namespace LabLauncher.Lab14Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    public partial class Lab14 : Form
    {
        private ShopDictionary Enterprise;

        //Решение обходное, так как я не знаю более нормального способа привести типы элементов коллекции
        private List<Worker> Workers
        {
            get
            {
                List<Worker> selecting = new List<Worker>(), workers;

                foreach (List<Person> shop in Enterprise.Values)
                {
                    workers = shop.Where(p => p is Worker) as List<Worker>;
                    selecting.AddRange(workers);
                }

                return selecting;
            }
        }

        public Lab14()
        {
            InitializeComponent();
        }

        // инициализация и автозаполнение
        private void InitPersonList()
        {
            Enterprise = new ShopDictionary();

            Enterprise.Add(new Person("Габриэль Мэйсон", 51));
            Enterprise.Add(new Person("Бойкова Нона Семеновна", 61));
            Enterprise.Add(new Person("Ванин Гарольд Иванович", 42));
            Enterprise.Add(new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3));
            Enterprise.Add(new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26));
            Enterprise.Add(new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40));
            Enterprise.Add(new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36));
            Enterprise.Add(new Employee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate));
            Enterprise.Add(new Employee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary));
            Enterprise.Add(new Employee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete));
            Enterprise.Add(new Employee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate));
            Enterprise.Add(new Engineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first));
            Enterprise.Add(new Engineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third));
            Enterprise.Add(new Engineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second));


        }

        private void goButton_Click(object sender, EventArgs e)
        {

        }

        private List<Worker> getWorkersWithExpNotLessThan(int years, bool linq = false)
        {
            var result = (linq) ?
                from p in Workers where p.experience >= years select p:
                Workers.Where(p => p.experience >= years);

            return result as List<Worker>;
        }

        private List<Worker> getWorkersWithThePosition(string pos, bool linq = false)
        {
            var result = (linq) ?
                from p in Workers where p.position == pos select p :
                Workers.Where(p => p.position == pos);

            return result as List<Worker>;
        }

        private int howManyEngineers(bool linq = false)
        {
            int count = 0, addend;
            foreach (List<Person> shop in Enterprise.Values)
            {
                addend = (linq) ? 0 : shop.Where(p => p is Worker).Count();
                count += addend;
            }

            return count;
        }

        private int getTheRichestWorker(bool linq = false)
        {
            int result = (linq) ?
                (from p in Workers select p.salary).Max() :
                Workers.Select(p => p.salary).Max();

            return result;
        }
        
        private List<Worker> getSomething(bool linq = false)
        {
            List<Employee> withHigherEdu = new List<Employee>(), employers;

            foreach (List<Person> shop in Enterprise.Values)
            {
                employers = shop.Where(p => p is Employee) as List<Employee>;
                withHigherEdu.AddRange(employers);
            }

            withHigherEdu = withHigherEdu.Where(p => p.edu >= education.higherIncomplete) as List<Employee>;

            var result = (linq) ?
                (from p in Workers where p.salary >= 32000 select p).Intersect(from p in withHigherEdu select p) :
                Workers.Where(p => p.salary >= 32000).Intersect(withHigherEdu);

            return result as List<Worker>;
        }
    }
}
