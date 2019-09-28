using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    interface IRule {
        decimal rules(int units);
    }
    class Rule1:IRule
    {
        public decimal rules(int units) {

            return (units>100?100:units * 1.35M);
        }
    }
}
