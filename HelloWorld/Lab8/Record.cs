using System;

namespace HelloWorld
{
    [Serializable]
    public class Record
    {
        public enum month { jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec }

        public month mm { get; }
        public uint year { get; }
        public string unit { get; }
        public uint profit { get; }

        public string monthname
        {
            get
            {
                switch (mm) {
                    case month.jan: return "Январь";
                    case month.feb: return "Февраль";
                    case month.mar: return "Март";
                    case month.apr: return "Апрель";
                    case month.may: return "Май";
                    case month.jun: return "Июнь";
                    case month.jul: return "Июль";
                    case month.aug: return "Август";
                    case month.sep: return "Сентябрь";
                    case month.oct: return "Октябрь";
                    case month.nov: return "Ноябрь";
                    case month.dec: return "Декабрь";
                    default: return string.Empty;
                }
            }
        }

        public uint[] key
        {
            get
            {
                return new uint[]
                {
                    (uint)mm,
                    year
                };
            }
        }

        public string row
        {
            get
            {
                return $"{monthname} {year}, {unit}, €{profit}";
            }
        }

        public Record(month a, uint b, string c, uint prof)
        {
            mm = a;
            year = b;
            unit = c;
            profit = prof;
        }
    }
}
