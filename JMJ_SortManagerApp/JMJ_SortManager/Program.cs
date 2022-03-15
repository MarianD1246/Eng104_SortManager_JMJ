using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SortManager;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("How many numbers would you like in your array?");

        bool getNumberOfArray = false;
        int lengthOfArray = 0;
        while (!getNumberOfArray)
        {
            string sizeOfArray = Console.ReadLine();
            getNumberOfArray = int.TryParse(sizeOfArray, out lengthOfArray);
            if (!getNumberOfArray)
                Console.WriteLine("Please enter a number for the array length.");
        }

        int[] arr = new int[lengthOfArray];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 101);
        }
        StringBuilder generatedArray = new();
        foreach (int i in arr)
        {
            generatedArray.Append($"[{i}], ");
        }
        Console.WriteLine(generatedArray.ToString().Trim(' ', ','));
        generatedArray.Clear();
        Console.WriteLine("Choose a Sort Method: \nType A for Merge Sort\nType B for Bubble Sort\nType C for .Net Sort");

        ConsoleKeyInfo chosenSort;
        Stopwatch methodTimer = new Stopwatch();
        do
        {
            chosenSort = Console.ReadKey();
            Console.WriteLine(" ");
            switch (chosenSort.KeyChar)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("You have chosen Merge Sort");
                    methodTimer.Start();
                    arr = MergeSort.MergeArraySort(arr);
                    methodTimer.Stop();
                    foreach (int i in arr)
                    {
                        generatedArray.Append($"[{i}], ");
                    }
                    Console.WriteLine(generatedArray.ToString().Trim(' ', ','));
                    Console.WriteLine($"Time Taken for MergeSort: {methodTimer.Elapsed}");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("You have chosen a Bubble Sort");
                    methodTimer.Start();
                    int[] sorted = BubbleSort.BubbleArraySort(arr);
                    methodTimer.Stop();
                    foreach (int i in arr)
                    {
                        generatedArray.Append($"[{i}], ");
                    }
                    Console.WriteLine(generatedArray.ToString().Trim(' ', ','));
                    Console.WriteLine($"Time Taken for BubbleSort: {methodTimer.Elapsed}");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("You have chosen a .Net Sort");
                    methodTimer.Start();
                    Array.Sort(arr);
                    methodTimer.Stop();
                    foreach (int i in arr)
                    {
                        generatedArray.Append($"[{i}], ");
                    }
                    Console.WriteLine(generatedArray.ToString().Trim(' ', ','));
                    Console.WriteLine($"Time Taken for .Net Sort: {methodTimer.Elapsed}");
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

        } while (chosenSort.KeyChar != 'a' && chosenSort.KeyChar != 'A' && chosenSort.KeyChar != 'b' && chosenSort.KeyChar != 'B' && chosenSort.KeyChar != 'c' && chosenSort.KeyChar != 'C');

    }
}
