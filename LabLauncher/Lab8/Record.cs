using System;

namespace LabLauncher.Lab8Dir
{
    [Serializable]
    public class Record
    {
        public enum month { jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec }

        public int number { get; }
        public month mm { get; }
        public int year { get; }
        public string unit { get; }
        public int profit { get; }

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

        public string id
        {
            get
            {
                return $"{mm}.{year}-{unit}";
            }
        }

        public string row
        {
            get
            {
                return $"{monthname} {year}, {unit}, €{profit}";
            }
        }

        public Record(month a, int b, string c, int prof)
        {
            mm = a;
            year = b;
            unit = c;
            profit = prof;
        }

        public static string getId(month a, int b, string c)
        {
            return $"{a}.{b}-{c}";
        }
    }
}
