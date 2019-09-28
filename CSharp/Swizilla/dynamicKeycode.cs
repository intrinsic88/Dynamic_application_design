using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class dynamicKeycode
    {
        public static string KeyCode(int keycode) {

            string code = "";

            string content = File.ReadAllText("@D:\\Work\\Learning\\SWIZILA\\CSharp\\Swizilla\\keyCode.tx");

            Dictionary<int, string> newDict = new Dictionary<int, string> { };

            string [] temp = content.Split(',');
            foreach (var a in temp) {
                string[] temp2 = a.Split(':');
                newDict.Add(Convert.ToInt32(temp2[0]), temp2[1]);
            }

            return newDict[keycode];
        }
    }
}
