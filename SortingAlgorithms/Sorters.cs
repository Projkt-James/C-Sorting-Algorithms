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

        public enum MergeType
        {
            TopDown,
            BottomUp
        }

        public static List<int> MergeSort(List<int> inputList, MergeType type = MergeType.TopDown)
        {

            int n = inputList.Count;

            if (type == MergeType.TopDown)
            {
                if (inputList.Count <= 1)
                {
                    return inputList;
                }

                List<int> left = new List<int>();
                List<int> right = new List<int>();

                for (int i = 0; i < n; i++)
                {
                    if (i < n / 2)
                    {
                        left.Add(inputList[i]);
                    }
                    else
                    {
                        right.Add(inputList[i]);
                    }
                }

                left = MergeSort(left, type);
                right = MergeSort(right, type);

                //Merge both lists
                left.AddRange(right);

                return left;

            } else if (type == MergeType.BottomUp)
            {

                // TODO Write Code For BottomUp Merge Sort
                return inputList;

            } else
            {
                throw new Exception("Invalid Merge Type Provided");
            }
        }
    }
}
