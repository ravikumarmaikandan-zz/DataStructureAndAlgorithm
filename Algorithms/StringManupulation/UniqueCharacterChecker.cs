using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.StringManupulation
{
    public static class UniqueCharacterChecker
    {
        public static bool IsUniqueCharacterChecker(this string str)
        {
            return isUniqueChar(str);
        }

        public static bool IsUniqueCharacterCheckerUsingBitShifter(this string str)
        {
            return IsUniqueCharacterUsingBitShifter(str);
        }
        public static bool isUniqueChar(string str)
        {
            if (str.Length > 128)
            {
                return false;
            }
            var char_set = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i];

                if (char_set[val])
                {
                    return false;
                }
                char_set[val] = true;
            }
            return true;
        }

        /// <summary>
        /// using bit shifter
        /// </summary>
        public static bool IsUniqueCharacterUsingBitShifter(string str)
        {
            int checker = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }

                checker |= (i << val);
            }
            return true;
        }
    }
}
