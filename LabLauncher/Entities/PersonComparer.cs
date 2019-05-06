using System;
using System.Collections;

namespace LabLauncher.Entities
{
    public class PersonComparer : IComparer
    {
        int IComparer.Compare(object a, object b)
        {
            if (a is Person && b is Person)
                return string.Compare(a.ToString(), b.ToString());
            else
                throw new Exception("Оба аргумента должны иметь тип Person");
        }
    }
}