using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Rules4:IRule
    {
        public decimal rules(int units) {
            return ((units - 500) * 8.0M);
        }
    }
}
