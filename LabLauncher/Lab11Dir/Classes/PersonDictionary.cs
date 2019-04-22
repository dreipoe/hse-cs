using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLauncher.Lab11Dir.Classes
{
    class PersonDictionary<S, T> : DictionaryBase
    {
        public void Add(S key, T value)
        {

        }

        public PersonDictionary<S, T> Clone()
        {
            var dictionary = new PersonDictionary<S, T>();
            return dictionary;
        }
    }
}
