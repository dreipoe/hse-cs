using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LabLauncher.Entities;

namespace LabLauncher.Lab13Dir
{
    delegate void ListHandler(object source, ListHandlerEventArgs args);

    class MyNewList : MyList
    {
        public event ListHandler ListCountChanged;
        public event ListHandler ListReferenceChanged;

        public string Name { get; protected set; }

        public MyNewList(string name) : base()
        {
            Name = name;
        }

        public virtual void OnListCountChanged(object source, ListHandlerEventArgs args)
        {
            ListCountChanged?.Invoke(source, args);
        }

        public virtual void OnListReferenceChanged(object source, ListHandlerEventArgs args)
        {
            ListReferenceChanged?.Invoke(source, args);
        }

        public override void AddDefaults()
        {
            OnListCountChanged(this, new ListHandlerEventArgs(Name, "add", null));
            base.AddDefaults();
        }

        public new void Add(Person person)
        {
            OnListCountChanged(this, new ListHandlerEventArgs(Name, "add", person));
            base.Add(person);
        }

        public bool Remove(int i)
        {
            bool result = ((i >= 0) && (i < Length)) ? true : false;
            if (result)
            {
                OnListCountChanged(this, new ListHandlerEventArgs(Name, "delete", this[i]));
                RemoveAt(i);
            }
            return result;
        }

        public new Person this[int index]
        {
            get
            {
                return base[index];
            }

            set
            {
                OnListReferenceChanged(this, new ListHandlerEventArgs(Name, "reference", value));
                this[index] = value;
            }
        }
    }
}