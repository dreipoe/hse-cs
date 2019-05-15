using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LabLauncher.Entities;

namespace LabLauncher.Lab13Dir
{
    class Journal
    {
        public class JournalEntry
        {
            string Name;
            string Changing;
            Person Item;

            public JournalEntry(string name, string changing, Person item)
            {
                Name = name;
                Changing = changing;
                Item = item;
            }
        }

        protected List<JournalEntry> journal;

        public void ListCountChanged(object sourse, ListHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.Name, e.Changing, e.Item);
            journal.Add(je);
        }

        public void ListReferenceChanged(object sourse, ListHandlerEventArgs e)
        {
            JournalEntry je = new JournalEntry(e.Name, e.Changing, e.Item);
            journal.Add(je);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
