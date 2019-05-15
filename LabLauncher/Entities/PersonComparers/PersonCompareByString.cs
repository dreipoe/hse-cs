using System.Collections.Generic;

namespace LabLauncher.Entities.PersonComparers
{
    public class PersonCompareByString : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person a, Person b)
        {
            return string.Compare(a.ToString(), b.ToString());
        }
    }
}