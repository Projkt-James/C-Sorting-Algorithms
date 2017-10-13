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

        public static List<int> MergeSort(List<int> inputList)
        {
            return inputList;
        }
    }
}
