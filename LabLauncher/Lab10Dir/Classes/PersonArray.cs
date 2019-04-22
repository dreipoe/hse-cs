using LabLauncher.Entities;

namespace LabLauncher.Lab10Dir
{
    public class PersonArray
    {
        public Person[] array { get; protected set; }

        public PersonArray(Person[] persons)
        {
            array = persons;
        }

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
