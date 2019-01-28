using System;
using System.Collections.Generic;
using System.Text;

namespace LabLauncher.TestDir
{
    public class Person
    {
        string firstname = "Vasily";
        string lastname = "Pupkin";
        byte age = 30;
        int myhash;

        public int hash
        {
            get
            {
                return myhash;
            }
        }

        public string toString
        {
            get
            {
                return $"{firstname} {lastname}, {age} years";
            }
        }

        public Person() {
            myhash = GetHashCode();
        }

        public Person(string first, string last, byte age)
        {
            firstname = first;
            lastname = last;
            this.age = age;
            myhash = GetHashCode();
        }
    }
}
