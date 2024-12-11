using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice
{
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string str)
        {
            if (str.Length > 0)
            {
                char[] charArray = str.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);

            }

            return str;

        }
    }
}
