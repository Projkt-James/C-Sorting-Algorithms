using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class Sorters
    {

        public static (List<int>, int) BubbleSort(List<int> inputList)
        {
            int n = inputList.Count;
            bool swapped = true;
            int basicOperations = 0;

            while (swapped)
            {
                swapped = false;

                for(int i = 1; i <= n-1; i++)
                {
                    if(inputList[i-1] > inputList[i])
                    {
                        basicOperations++;

                        //Swap the list elements
                        int tmp = inputList[i-1];
                        inputList[i-1] = inputList[i];
                        inputList[i] = tmp;
                        swapped = true;
                    }
                }
            }

            return (inputList, basicOperations);
        }

        public static (List<int>, int) MergeSort(List<int> inputList)
        {
            int basicOperations = 0;

            int n = inputList.Count;

            if (inputList.Count <= 1)
            {
                return (inputList, 1);
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < n; i++)
            {
                basicOperations++;

                if (i < n / 2)
                {
                    left.Add(inputList[i]);
                }
                else
                {
                    right.Add(inputList[i]);
                }
            }

            //Recursively Merge Sort Both Sides
            (List<int> sortedLeft, int basicOperationsLeft) = MergeSort(left);
            (List<int> sortedRight, int basicOperationsRight) = MergeSort(right);

            //Merge Both Lists
            sortedLeft.AddRange(sortedRight);

            return (sortedLeft, basicOperations);
        }
    }
}
