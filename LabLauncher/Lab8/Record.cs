using System;

namespace LabLauncher
{
    public class Record
    {
        protected int id;

        protected byte month {
            get { return month; }

            set
            {
                if (value >= 1 && value <= 12)
                    month = value;
                else
                    throw new OverflowException();
            }
        }

        protected ushort year;
        protected uint profit;
    }
}
