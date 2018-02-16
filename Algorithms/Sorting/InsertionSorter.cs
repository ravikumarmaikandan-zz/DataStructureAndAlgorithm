using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class InsertionSorter
    {
        public static void DoInsertionSort(this int[] numbers)
        {
            var sortedNumbers = InsertionSort(numbers);
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }

        /// <summary>
        /// Overview of Insertion Sort
        /// Pick the second element and compare the to the left. If small then swap the position. 
        /// pick the next elelemt and compare with all the elelments before that. if found anything smaller then swap position.
        /// </summary>
        public static int[] InsertionSort(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                //Compare the current element with all the element before that 
                //if small swap position
                var j = i - 1;
                int tempHolder = numbers[i];
                while (j >= 0 && (tempHolder < numbers[j]))
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = tempHolder;
            }

            return numbers;
        }
    }
}
