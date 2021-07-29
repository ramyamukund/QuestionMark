using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QMproject.Helpers
{
    public class DateInput
    {
        public DateInput(string[] dateSegments)
        {
            this.Day = int.Parse(dateSegments[0]);
            this.Month = int.Parse(dateSegments[1]);
            this.Year = int.Parse(dateSegments[2]);

        }
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }
    }
}
