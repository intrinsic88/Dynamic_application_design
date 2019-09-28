using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Rules2:IRule
    {
        public decimal rules(int units) {
            return ((units - 100) * 4.05M);
        }
    }
}
