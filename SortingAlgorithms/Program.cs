using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> i = new InputGenerator(0, 100).GenerateRandomList(10);

            Helpers.ConsoleNewLine(1);
            Helpers.PrintList(i, "============ Random List ============");
            Helpers.ConsoleNewLine(2);

            
            //BUBBLE SORT
            Stopwatch bubbleWatch = new Stopwatch();
            bubbleWatch.Start();
            (List<int>bubbleSort, int bubbleOperations) = Sorters.BubbleSort(new List<int>(i));
            bubbleWatch.Stop();

            Helpers.ConsoleNewLine(1);
            Helpers.PrintList(bubbleSort, "============ BUBBLE Sorted List ============ \n" +
                "=> Basic Operations: " + bubbleOperations + "\n" +
                "=> Time Taken: " + bubbleWatch.Elapsed.TotalMilliseconds + " ms \n"
                );
            Helpers.ConsoleNewLine(1);

            // MERGE SORT
            Stopwatch mergeWatch = new Stopwatch();
            mergeWatch.Start();
            (List<int> mergeSort, int mergeOperations) = Sorters.MergeSort(new List<int>(i));
            mergeWatch.Stop();

            Helpers.ConsoleNewLine(1);
            Helpers.PrintList(mergeSort, "============ MERGE Sorted List ============ \n" +
                "=> Basic Operations: " + mergeOperations + "\n" + 
                "=> Time Taken: " + mergeWatch.Elapsed.TotalMilliseconds + " ms \n"
                );
            Helpers.ConsoleNewLine(1);

            //INSERTION SORT
            Stopwatch insertionWatch = new Stopwatch();
            insertionWatch.Start();
            (List<int> insertionSort, int insertionOperations) = Sorters.InsertionSort(new List<int>(i), i.Count - 1);
            insertionWatch.Stop();

            Helpers.ConsoleNewLine(1);
            Helpers.PrintList(mergeSort, "============ INSERTION Sorted List ============ \n" +
                "=> Basic Operations: " + insertionOperations + "\n" +
                "=> Time Taken: " + insertionWatch.Elapsed.TotalMilliseconds + " ms \n"
                );
            Helpers.ConsoleNewLine(2);
           

            Helpers.ConsoleNewLine(1);
            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }
    }

    class InputGenerator
    {
        int min;
        int max;
        Random rand;

        public InputGenerator(int listMin = 0, int listMax = 100)
        {
            this.min = listMin;
            this.max = listMax;
            rand = new Random();
        }

        public List<int> GenerateRandomList(int listLength)
        {
            List<int> input = new List<int>();

            for(int i = 0; i < listLength; i++)
            {
                input.Add(rand.Next(min, max));
            }

            return input;
        }

    }

    public static class Helpers
    {
        public static void PrintList(List<int> inputList, string stringBefore = "")
        {

            if(stringBefore.Length > 0)
            {
                Console.WriteLine(stringBefore);
            }
            
            for(int i = 0; i < inputList.Count; i++)
            {
                Console.Write(inputList[i]);
                if((i+1) != inputList.Count)
                {
                    Console.Write(", ");
                }
            }
        }

        public static void ConsoleNewLine(int numberBreaks)
        {
            for (int i = 0; i < numberBreaks; i++) Console.WriteLine();
        }
    }

}




