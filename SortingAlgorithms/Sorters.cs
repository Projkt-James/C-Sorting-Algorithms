using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class Sorters
    {

        /**********************************
         BUBBLE SORT
        **********************************/
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

        /**********************************
         MERGE SORT
        **********************************/
        public static (List<int>, int) MergeSort(List<int> inputList)
        {
            int n = inputList.Count;
            int basicOperations = 0;

            //If list less than or equal to 1 return list
            if (n <= 1)
            {
                return (inputList, 1);
            }

            //Intiate left and right lists
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
            (List<int> recursiveLeft, int basicOperationsLeft) = MergeSort(left);
            (List<int> recursiveRight, int basicOperationsRight) = MergeSort(right);

            //Merge Both Lists
            List<int> result = Merge(recursiveLeft, recursiveRight);

            basicOperations += basicOperationsLeft + basicOperationsRight;

            return (result, basicOperations);
        }

        static List<int> Merge(List<int> left, List<int>right)
        {
            var result = new List<int>();

            while(left.Count > 0 && right.Count > 0)
            {
                if(left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while(left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result;
        }

        public static (List<int>, int) InsertionSort(List<int> inputList, int n)
        {
            int basicOperations = 0;

            if (n > 0)
            {
                //Call recursively until n is zero
                (List<int> a, int recursiveOperations) = InsertionSort(inputList, n - 1);
                basicOperations += recursiveOperations;

                int x = inputList[n];
                int j = n-1;

                while(j >= 0 && inputList[j] > x)
                {
                    basicOperations++;

                    inputList[j + 1] = inputList[j];
                    j = j - 1;
                }

                inputList[j + 1] = x;
            }

            return (inputList, basicOperations);
        }
 
    }
}
