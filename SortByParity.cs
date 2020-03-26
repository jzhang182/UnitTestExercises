using System;
using System.Collections.Generic;
using System.Linq;
namespace XUnitTestSortByParity
{
    class ParitySortAlgorithm
    {
        public int[] SelectionIncreaseSort(int[] inputArray)
        {
            int temp = 0;
            for (int i = 0; i < inputArray.Length; i = i + 1)
            {
                int maxIndex = 0;
                for (int j = 0; j < inputArray.Length - i; j = j + 1)
                {
                    if (inputArray[j] > inputArray[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                temp = inputArray[inputArray.Length - i - 1];
                inputArray[inputArray.Length - i - 1] = inputArray[maxIndex];
                inputArray[maxIndex] = temp;
            }
            return inputArray;
        }
        public int[] SortByParity(int[] inputArray)
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            for (int i = 0; i < inputArray.Length; i = i + 1)
            {
                if (inputArray[i] % 2 == 0)
                {
                    evenList.Add(inputArray[i]);
                }
                else
                {
                    oddList.Add(inputArray[i]);
                }
            }
            int[] evenArray = SelectionIncreaseSort(evenList.ToArray());
            int[] oddArray = SelectionIncreaseSort(oddList.ToArray());
            int[] concatenatedArray = evenArray.Concat(oddArray).ToArray();
            return concatenatedArray;
        }
    }
}