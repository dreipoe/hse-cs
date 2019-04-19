using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabLauncher.Lab8Dir
{
    public class Database
    {
        public string Name { get; }
        private BinaryFormatter bf { get; }

        public Database(string filename)
        {
            Name = filename;
            bf = new BinaryFormatter();
        }

        public bool Add(Record record, int pos = 0, bool edit = false)
        {
            FileStream file = new FileStream(Name, FileMode.Open);

            try
            {
                for (int i = 1; i < pos; i++) bf.Deserialize(file);
            }
            catch
            {
                file.Close();
                return false;
            }

            int posSeek = (int)file.Position;
            FileStream tmp = new FileStream($"data/tmp", FileMode.Create);
            file.CopyTo(tmp);
            file.Position = posSeek;
            bf.Serialize(file, record);
            if (!edit) tmp.Position = 0;
            tmp.CopyTo(file);
            file.Close();
            tmp.Close();

            return true;
        }

        //Удаляет элемент из базы данных
        public void Del(int pos)
        {
            int i = 0;
            FileStream reading = new FileStream(Name, FileMode.Open);
            FileStream tmp = new FileStream($"data/tmp", FileMode.Create);

            while (reading.Position < reading.Length)
            {
                Record row = (bf.Deserialize(reading) as Record);
                if (i != pos) bf.Serialize(tmp, row);
                i++;
            }

            reading.Position = tmp.Position = 0;
            reading.SetLength(tmp.Length);
            tmp.CopyTo(reading);
            reading.Close();
            tmp.Close();
        }

        //Добавление в конец файла
        public void Push(Record record)
        {
            FileStream file = new FileStream(Name, FileMode.Append);
            bf.Serialize(file, record);
            file.Close();
        }

        //Возвращает массив объектов, сохранённых в файле. Используется как источник данных для элементов управления
        public Record[] Show()
        {
            Record[] records = new Record[0];
            FileStream reading = new FileStream(Name, FileMode.Open);

            while (reading.Position < reading.Length)
            {
                int push = records.Length;
                Array.Resize(ref records, push + 1);
                records[push] = (bf.Deserialize(reading) as Record);
            }

            reading.Close();
            return records;
        }

        //Индексатор, позволяет работать с БД как с массивом
        public Record this[int pos]
        {
            get
            {
                Record result = null;
                FileStream file = new FileStream(Name, FileMode.Open);

                try
                {
                    for (int i = 0; i < pos; i++) bf.Deserialize(file);
                    result = bf.Deserialize(file) as Record;
                }
                catch {}

                file.Close();
                return result;
            }

            set
            {
                Add(value, pos, true);
            }
        }
    }
}
