
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabLauncher.Lab8
{
    struct Record
    {
        private int id;

        private byte month {
            get { return month; }

            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }
                else
                {
                    throw new OverflowException();
                }
            }
        }

        private ushort year;
        private uint profit {
            get { return profit / 100; }
            set { profit = value; }
        }
    }
}
