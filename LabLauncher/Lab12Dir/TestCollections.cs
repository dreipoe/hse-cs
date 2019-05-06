using System;
using System.Collections;
using System.Collections.Generic;

using LabLauncher.Entities;

namespace LabLauncher.Lab12Dir
{
    class TestCollections
    {
        public LinkedList<Person> People { get; }
        public LinkedList<string> Names { get; }
        public SortedDictionary<Person, Worker> Couples { get; }
        public SortedDictionary<string, Worker> Book { get; }

        public int Max { get; }

        public TestCollections(int count)
        {
            if (count > 0)
            {
                Max = count;
                People = new LinkedList<Person>();
                Names = new LinkedList<string>();
                Couples = new SortedDictionary<Person, Worker>();
                Book = new SortedDictionary<string, Worker>();
            }
            else throw new TestCollectionsException("Объём коллекции не может быть отрицательной величиной");
        }

        public void InitTestCollections()
        {
            int limit = Math.Min(Max, 10);
            for (int i = 0; i < limit; i++) auto(i);
        }

        public static Worker auto(int index)
        {
            switch (index)
            {
                case 0: return new Worker("Джек Тайдер", "Токарный", "Токарь", 17, 22000, 3);
                case 1: return new Worker("Поливанова Ада Мефодиевна", "Посудный", "Бригадир", 43, 50000, 26);
                case 2: return new Worker("Аводков Всеволод Мирославович", "Оружейный", "Химик", 61, 50000, 40);
                case 3: return new Worker("Эдвард Кокс", "Оружейный", "Токарь", 50, 66000, 36);
                case 4: return new Worker("Ретюнскиха Стелла Федоровна", "Топ-менеджер", 44, 77000, 24);
                case 5: return new Worker("Остапчук Терентий Евгениевич", "Бухгалтер", 26, 38000, 10);
                case 6: return new Worker("Митькин Феофан Пахомович", "Ведущий программист", 40, 81000, 22);
                case 7: return new Worker("Роджер Стэнли", "Ведущий программист", 62, 186000, 29);
                case 8: return new Worker("Индик Игнатий Всеволодович", "Главный инженер", 38, 100000, 18);
                case 9: return new Worker("Сиянин Капитон Ираклиевич", "Инженер по производству", 20, 65000, 0);
                default: return null;
            }
        }

        public void Add(Worker worker)
        {
            if (People.Count < Max)
            {
                People.AddLast(worker.Base);
                Names.AddLast(worker.ToString());
                Couples[worker.Base] = worker;
                Book[worker.ToString()] = worker;
            }
            else throw new TestCollectionsException("Коллекция переполнена");
        }

        public void Remove(Person person)
        {
            string key = person.ToString();

            People.Remove(person);
            Names.Remove(key);
            Couples.Remove(person);
            Book.Remove(key);
        }

        // заполняет таблицу времени доступа элементов к коллекциям
        public double[,] SearchTime()
        {
            
            Worker[] team = getNodes();
            double[,] timeTable = new double[4, 4]; // строки - это элементы, столбцы - это коллекции
            DateTime now;

            for (int i = 0; i < 4; i++)
            {
                Worker worker = team[i];
                Person basis = worker.Base;
                string name = worker.ToString();

                for (int j = 0; j < 4; j++)
                {
                    now = DateTime.Now;

                    switch (j)
                    {
                        case 0: People.Contains(basis); break;
                        case 1: Names.Contains(name); break;
                        case 2: Couples.ContainsValue(worker); break;
                        case 3: Book.ContainsKey(name); break;
                    }

                    timeTable[i, j] = (DateTime.Now - now).TotalMilliseconds;
                }             
            }

            return timeTable;
        }

        // возвращает массив элементов, используемых при измерении времени доступа
        private Worker[] getNodes()
        {
            int n = 0, center = People.Count / 2;
            Worker[] team = new Worker[4];
            team[0] = Book[People.First.Value.ToString()];
            team[2] = Book[People.Last.Value.ToString()];
            team[3] = new Worker("", "", 0, 0, 0);
            foreach (Worker worker in People)
                if (n == center)
                {
                    team[1] = worker;
                    break;
                }
                else n++;

            return team;
        }
    }
}
