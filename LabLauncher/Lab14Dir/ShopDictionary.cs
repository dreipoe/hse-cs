using System.Collections.Generic;

using LabLauncher.Entities;

namespace LabLauncher.Lab14Dir
{
    // Данные в этом словаре группируются по цехам. Элементы - коллекции работников конкретного цеха
    class ShopDictionary : Dictionary<string, List<Person>>
    {
        public ShopDictionary() : base()
        {
            Add(null, new List<Person>());
        }

        public void Add(Person person)
        {
            Worker worker = person as Worker;

            if (worker != null)
            {
                string shop = worker.shop;
                if (!ContainsKey(shop)) Add(shop, new List<Person>());
                this[shop].Add(worker);
            }
            else this[null].Add(person);
        }
    }
}
