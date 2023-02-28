using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_Cas1
{
    public class TimeConventer : ITimeConvert
    {
        public double minutes = 1;
        public double seconds = 1;
        public double ConvertHours(double days)
        {
            return days * 24;
        }

        public double ConvertMinutes(double days)
        {
            minutes = days * 24 * 60;
            return minutes;
        }

        public double ConvertSeconds(double days)
        { 
            minutes *= ConvertMinutes(days);
            return minutes * 60;
        }
    }
}
