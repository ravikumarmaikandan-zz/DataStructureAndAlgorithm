using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.StringManupulation
{
    public static class StringReverse
    {
        public static string StringReverser(this string str)
        {
            return Reverse(str);
        }

        private static string Reverse(string str)
        {
            var builder = new StringBuilder();
            for (int i = str.Length-1; i>=0; i --)
            {
                builder.Append(str[i]);
            }

            return builder.ToString();
        }
    }
}
