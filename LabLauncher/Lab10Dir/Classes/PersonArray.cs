using LabLauncher.Entities;

namespace LabLauncher.Lab10Dir
{
    public class PersonArray
    {
        protected Person[] array { get; set; }

        public PersonArray(Person[] persons)
        {
            array = persons;
        }

        public Person this[int i]
        {
            get
            {
                return array[i];
            }

            set
            {
                array[i] = value;
            }
        }

        //служащие со стажем не менее min лет
        public string selectEmpWithExpNotLessThan(int min)
        {
            string tmp = string.Empty;
            foreach (Person person in array)
            {
                Employee employee = person as Employee;
                if (employee != null && employee.experience >= min)
                    tmp += employee.ToString() + "\r\n";
            }

            return tmp;
        }

        //служащие с должностью pos
        public string selectEmpWithThePos(string pos)
        {
            string tmp = string.Empty;

            foreach (Person person in array)
            {
                Employee employee = person as Employee;
                if (employee != null && employee.position == pos)
                    tmp += employee.ToString() + "\r\n";
            }

            return tmp;
        }

        //рабочие из цеха shop
        public string workerFromThe(string shop)
        {
            string tmp = string.Empty;

            foreach (Person person in array)
            {
                Worker worker = person as Worker;
                if (worker != null && worker.shop == shop)
                    tmp += worker.ToString() + "\r\n";
            }

            return tmp;
        }
    }
}
