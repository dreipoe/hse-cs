using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LabLauncher.Entities;

namespace LabLauncher.Lab13Dir
{
    class ListHandlerEventArgs : EventArgs
    {
        public string Name { get; protected set; }
        public string Changing { get; protected set; }
        public Person Item { get; protected set; }

        public ListHandlerEventArgs(string name, string changing, Person item)
        {
            Name = name;
            Changing = changing;
            Item = item;
        }

        //TODO: Может работать неправильно
        public override string ToString()
        {
            string result =
                $"Name: {Name}\n" +
                $"Changing: {Changing}\n" +
                $"Item: {Item}";

            return result;
        }
    }
}
