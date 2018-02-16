using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class SelectionSorter
    {
        public static void DoSelectionSort(this int[] numbers)
        {
            var sortedNumbers = SelectionSort(numbers);
            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }
        public static int[] SelectionSort(int[] numbers)
        {
            //Overview of Selection sort
            //1. Find the minimum value in an array
            //2. swap the minimum value with the value in the first position
            for (var i = 0; i < numbers.Length; i++)
            {
                //1. Find the minimum value in an array
                int minItem = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minItem])
                    {
                        minItem = j;
                    }
                }
                //2. swap the minimum value with the value in the first position
                var tempHolder = numbers[i];
                numbers[i] = numbers[minItem];
                numbers[minItem] = tempHolder;
            }

            return numbers;
        }
    }
}
