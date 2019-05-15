using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LabLauncher.Entities;

namespace LabLauncher.Lab13Dir
{
    using education = Employee.education;
    using category = Engineer.category;

    class MyList : List<Person>
    {
        public int Length
        {
            get
            {
                return Count;
            }
        }

        public virtual void AddDefaults()
        {
            Add(new Person("Габриэль Мэйсон", 51));
            Add(new Person("Бойкова Нона Семеновна", 61));
            Add(new Person("Ванин Гарольд Иванович", 42));
            Add(new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3));
            Add(new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26));
            Add(new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40));
            Add(new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36));
            Add(new Employee("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24, education.postgraduate));
            Add(new Employee("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10, education.secondary));
            Add(new Employee("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22, education.higherIncomplete));
            Add(new Employee("Роджер Стэнли", "Ведущий программист", 62, 186000, 29, education.postgraduate));
            Add(new Engineer("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18, education.postgraduate, category.first));
            Add(new Engineer("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0, education.higher, category.third));
            Add(new Engineer("Чуканова Оксана Андрияновна", "Начальник цеха опытного произведства", 54, 88000, 34, education.postgraduate, category.second));
        }
    }
}
