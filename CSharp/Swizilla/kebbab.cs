using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class kebbab:SwitchCase
    {
        public string convert(string[] words) {

            string outstring = "";
            outstring = words[0].ToLower();
            for (var i = 1; i < words.Length; i++)
            {
                outstring += "-" + words[i].ToLower();
            }

            return outstring;
        }

    }
}
