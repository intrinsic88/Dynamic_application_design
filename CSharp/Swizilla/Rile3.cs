using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class Rules3:IRule
    {
        public decimal rules(int units) {
            return ((units - 300) * 6.75M);
        }
    }
}
