using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabLauncher.TestDir
{
    class Person
    {
        string firstname = "Vasily";
        string lastname = "Pupkin";
        byte age = 30;

        string toString
        {
            get
            {
                return $"{firstname}, {lastname}, {age} years";
            }
        }

        Person() { }

        Person(string first, string last, byte age)
        {
            firstname = first;
            lastname = last;
            this.age = age;
        }
    }
}
