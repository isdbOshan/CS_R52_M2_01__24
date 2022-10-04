using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_18_Work_01
{
    public static class ExtensionContainer
    {
        public static string StripSpaces(this string s, string replaceString="")
        {
            return s.Trim().Replace(" ", replaceString);
        }
    }
}
