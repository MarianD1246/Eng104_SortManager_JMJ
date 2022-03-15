using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SortManager;

public class Program2
{
    //------------------------CONTROLLER---------------------
    public static void Main(String[] args)
    {
        char getInput;
        int[] unsortedArray = GetInput(out getInput);
        int[] sortedArray;
        string timer;
        //switch case to determine the correct method
        Stopwatch methodTimer = new();
        switch (getInput){
            case 'a':
            case 'A':
                methodTimer.Start();
                sortedArray = MergeSortMethod(unsortedArray);
                methodTimer.Stop();
                timer = methodTimer.Elapsed.ToString(@"mm\:ss\:ffffff");
                PrintArray(sortedArray, getInput, timer);
                break;

            case 'b':
            case 'B':
                methodTimer.Start();
                sortedArray = BubbleSortMethod(unsortedArray);
                methodTimer.Stop();
                timer = methodTimer.Elapsed.ToString(@"mm\:ss\:ffffff");
                PrintArray(sortedArray, getInput, timer);
                break;
            case 'c':
            case 'C':
                methodTimer.Start();
                sortedArray = NetSortMethod(unsortedArray);
                methodTimer.Stop();
                timer = methodTimer.Elapsed.ToString(@"mm\:ss\:ffffff");
                PrintArray(sortedArray, getInput, timer);
                break;
            case 'd':
            case 'D':
                methodTimer.Start();
                sortedArray = MergeSortOldMethod(unsortedArray);
                methodTimer.Stop();
                timer = methodTimer.Elapsed.ToString(@"mm\:ss\:ffffff");
                PrintArray(sortedArray, getInput, timer);
                break;
        }
    }
    //method to print array 
    //stopwatch to be in sort methods
    //---------------------VIEW-----------------------------
    public static int[] GetInput(out char input)
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
        Random rand = new Random();;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 1001);;
        }
        
        Console.WriteLine("Choose a Sort Method: \nType A for Merge Sort\nType B for Bubble Sort\nType C for .Net Sort\nType D for Premium ULTRA PLUS MergeSort");
        ConsoleKeyInfo userInput;
        char key = ' ';
        bool getKey = false;
        while (!getKey)
        {
            userInput = Console.ReadKey();
            if (userInput.KeyChar == 'a' || userInput.KeyChar == 'A' || userInput.KeyChar == 'b' || userInput.KeyChar == 'B' || userInput.KeyChar == 'c' || userInput.KeyChar == 'C' || userInput.KeyChar == 'd' || userInput.KeyChar == 'D')
            {
                getKey = true;
                key = userInput.KeyChar;
            }
            else
                Console.WriteLine("Valid inputs are A(Merge Sort) or B(Bubble Sort) or C(.Net Sort) or D(old MergeSort)");

        }
        input = key;
        return arr;
    }

    public static void PrintArray(int[] sortedArray, char whichSortMethod, string timeElapsed)
    {
        StringBuilder sortedOutput = new();
        Console.WriteLine();
        if (sortedArray.Length <= 20)
        {
            foreach (int i in sortedArray)

            {
                sortedOutput.Append($"[{i}], ");
            }
            Console.WriteLine(sortedOutput.ToString().Trim(' ', ','));
        }
        else
        {
            Console.WriteLine("Array length is more than 20, so data is not displayed.");
        }
        Console.WriteLine($"Time Taken to sort: {timeElapsed}");
    }


    //-----------------------CALLING THE MODELS------------------------
    public static int[] MergeSortMethod(int[] arr)
    {
        int[] sorted = MergeSort.MergeArraySort(arr);
        return sorted;
    }
    public static int[] BubbleSortMethod(int[] arr)
    {
        int[] sorted = BubbleSort.BubbleArraySort(arr);
        return sorted;
    }

    public static int[] NetSortMethod(int[] arr)
    {
        Array.Sort(arr);
        return arr;
    }
    public static int[] MergeSortOldMethod(int[] arr)
    {
        int[] sorted = MergeSort.MergeArraySortOld(arr);
        return sorted;
    }
}
//Main(controller) calls upon getInput(view) which returns A, B, C which calls the correct sort
// merge, bubble or .net(different models) -- factory model 
