using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> i = new InputGenerator().GenerateRandomList(10);

            Helpers.ConsoleNewLine(1);
            Helpers.PrintList(i, "============ Random List ============");
            Helpers.ConsoleNewLine(2);

            (List<int>temp, int basicOperations) = Sorters.BubbleSort(i);
            i = temp;

            Helpers.ConsoleNewLine(1);
            Helpers.PrintList(i, "============ Bubble Sorted List ============ \n=> Basic Operations: " + basicOperations + "\n");
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
            this.min = listMin - 1;
            this.max = listMax + 1;
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




