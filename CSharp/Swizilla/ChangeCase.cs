using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swizilla
{
    class ChangeCase
    {
        public enum Case { Lower, Upper, Pascal, Camel, Kebbab};

        public static string updateCase(Case @case, string[] words) {
            IDictionary<Case, Func<string[], string>> checkCase = new Dictionary<Case, Func<string[], string>>();

            checkCase.Add(Case.Lower,lowerCase);
            checkCase.Add(Case.Upper, upperCase);
            checkCase.Add(Case.Pascal, pascalCase);
            checkCase.Add(Case.Camel, camelCase);
            checkCase.Add(Case.Kebbab, kebbabCase);
            return checkCase[@case].Invoke(words);
        }
        public static string convert(Case @case, string []words)
        {
            string outstring="";
            switch (@case)
            {
                case Case.Lower: // lowercase
                    for (var i = 0; i < words.Length; i++)
                        outstring += words[i].ToLower();
                    break;

                case Case.Upper: // UPPERCASE
                    for (var i = 0; i < words.Length; i++)
                        outstring += words[i].ToUpper();
                    break;

                case Case.Pascal: //PascalCase
                    for (var i = 0; i < words.Length; i++)
                    {
                        outstring += Char.ToUpper(words[i][0]);
                        outstring += words[i].Substring(1).ToLower();
                    }
                    break;
                case Case.Camel: //CamelCase
                    outstring += words[0].ToLower();
                    for (var i = 1; i < words.Length; i++)
                    {
                        outstring += Char.ToUpper(words[i][0]);
                        outstring += words[i].Substring(1).ToLower();
                    }
                    break;
            }
            return outstring;
        }
        public static string lowerCase(string[] words)
        {
            string outstring = "";
            for (var i = 0; i < words.Length; i++)
                outstring += words[i].ToLower();
            return outstring;
        }

        public static string upperCase(string[] words) {
            string outstring = "";
            for (var i = 0; i < words.Length; i++)
                outstring += words[i].ToUpper();
            return outstring;
        }

        public static string pascalCase(string[] words) {

            string outstring = "";
            for (var i = 0; i < words.Length; i++)
            {
                outstring += Char.ToUpper(words[i][0]);
                outstring += words[i].Substring(1).ToLower();
            }
            return outstring;
        }
        public static string camelCase(string[] words) {
            string outstring = "";
                outstring += words[0].ToLower();
            for (var i = 1; i < words.Length; i++)
            {
                outstring += Char.ToUpper(words[i][0]);
                outstring += words[i].Substring(1).ToLower();
            }
            return outstring;
        }

        public static string kebbabCase(string[] words) {
            string outstring = "";
            outstring = words[0].ToLower();
            for (var i = 1; i < words.Length; i++) {
                outstring += "-"+ words[i].ToLower();
            }

            return outstring;
        }
    }
}
