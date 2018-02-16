using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.StringManupulation
{
    public static class AnagramChecker
    {
        static int NO_OF_CHARS = 256;
        //Time Complexity: O(n)
        public static bool IsAnagram(this string firstString, string secondstring)
        {
            var result = areAnagram(firstString.ToCharArray(), secondstring.ToCharArray());
            return result;
        }

        static bool areAnagram(char[] str1, char[] str2)
        {
            // Create 2 count arrays and initialize
            // all values as 0
            int[] count1 = new int[NO_OF_CHARS];
            int[] count2 = new int[NO_OF_CHARS];
            int i;

            // For each character in input strings,
            // increment count in the corresponding
            // count array
            for (i = 0; i < str1.Length && i < str2.Length; i++)
            {
                count1[str1[i]]++;
                count2[str2[i]]++;
            }

            // If both strings are of different length.
            // Removing this condition will make the program 
            // fail for strings like "aaca" and "aca"
            if (str1.Length != str2.Length)
                return false;

            // Compare count arrays
            for (i = 0; i < NO_OF_CHARS; i++)
                if (count1[i] != count2[i])
                    return false;

            return true;
        }
    }
}
