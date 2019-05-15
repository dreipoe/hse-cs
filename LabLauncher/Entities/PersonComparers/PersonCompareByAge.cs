using System.Collections.Generic;

namespace LabLauncher.Entities.PersonComparers
{
    public class PersonCompareByAge : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person a, Person b)
        {
            if (a.age < b.age) return -1;
            else if (a.age > b.age) return 1;
            else return 0;
        }
    }
}
