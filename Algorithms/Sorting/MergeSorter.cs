using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Algorithms.Sorting
{
    public static class MergeSorter
    {
        public static void DoMergeSort(this int[] numbers)
        {
            var sortedNumbers = MergeSort(numbers);

            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                numbers[i] = sortedNumbers[i];
            }
        }
        private static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1) return numbers; //Base case

            var left = new List<int>();
            var right = new List<int>();

            Divide(numbers, left, right);

            left = MergeSortList(left);
            right = MergeSortList(right);
            return Merge(left, right);
        }

        private static void Divide(int[] numbers, List<int> left, List<int> right)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i.IsOdd())
                    left.Add(numbers[i]);
                else
                    right.Add(numbers[i]);
            }
        }

        private static List<int>MergeSortList(List<int> list)
        {
            return MergeSort(list.ToArray()).ToList();
        }
        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while (NotEmpty(left) && NotEmpty(right))
            {
                MoveSmallerValueFromLeftOrRightResult(left, right, result);
            }

            MoveRemainingValuesFromSourceToResult(left, result);
            MoveRemainingValuesFromSourceToResult(right, result);

            return result.ToArray();
        }

        private static bool NotEmpty(List<int> list)
        {
            return list.Count() > 0;
        }
        private static void MoveSmallerValueFromLeftOrRightResult(List<int> left, List<int> right, List<int> result)
        {
            if (left.First() <= right.First())
                MoveValueFromSourceToResult(left, result);
            else
                MoveValueFromSourceToResult(right, result);
        }

        private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }

        private static void MoveRemainingValuesFromSourceToResult(List<int> list, List<int> result)
        {
            while (NotEmpty(list))
            {
                MoveValueFromSourceToResult(list, result);
            }
        }
    }
}
