using System.Collections.Generic;

namespace LabLauncher.Lab10Dir.Interfaces
{
    public class PersonComparer : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person a, Person b)
        {
            return string.Compare(a.ToString(), b.ToString());
        }
    }
}
