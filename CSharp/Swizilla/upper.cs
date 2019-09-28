using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    interface SwitchCase {
        string convert(string[] words);
    }
    class upper: SwitchCase 
    {
        public string convert(string[] words) {
            string outstring = "";
            for (var i = 0; i < words.Length; i++)
                outstring += words[i].ToUpper();
            return outstring;
        }

        //public static string caseUpper(string[] words) {
        //    changeCaseInt cc = new changeCaseInt();

        //    return cc.convert(words);
        //}
    }
}
