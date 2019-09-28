using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class FixedDow
    {
        static List<String> week = new List<string> { "Mon", "tue", "wed", "thur", "fri", "sat", "sun" };

        public static string DayOfWeek(int day)
        {
            //sanity check
            if (day < 0 || day > 6)
                return "Get Good";
          
        return week[day];
            }
    }
}
