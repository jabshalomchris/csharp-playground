using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public static class StringExtension
    {
        public static string Capitalize(this string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}
