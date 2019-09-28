using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class KeyCode
    {
        public static string GetKeyMap(int keycode)
        {
            string code="";
            switch (keycode)
            {
                case 37:
                    code = "{left}";
                    break;

                case 38:
                    code = "{up}";
                    break;

                case 39:
                    code = "{right}";
                    break;

                case 40:
                    code = "{down}";
                    break;
            }
            return code;
        }
    }
}
