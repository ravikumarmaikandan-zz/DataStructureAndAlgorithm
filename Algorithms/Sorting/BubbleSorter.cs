using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class BubbleSorter
    {
        public static void DoBubbleSort(this int[] numbers)
        {
            var sortedNumbers = BubbleSort(numbers);

            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }
        /// <summary>
        /// Overview of Bubbble Sort
        /// Sorting takes place by stepping through all the data items one-by-one in pairs and 
        /// comparing adjacent data items and swapping each pair that is out of order.
        /// </summary>
        public static int[] BubbleSort(int[] numbers)
        {
            bool isSorted = false;
            while (!isSorted)
            {
                isSorted = BubbleSortArray(numbers);
            }

            return numbers;
        }

        private static bool BubbleSortArray(int[] numbers)
        {
            bool isSorted = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    SwapSmallerNumber(numbers, i);
                    isSorted = false;
                }
            }
            return isSorted;
        }

        private static void SwapSmallerNumber(int[] numbers, int j)
        {
            var tempHolder = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = tempHolder;
        }
    }
}
