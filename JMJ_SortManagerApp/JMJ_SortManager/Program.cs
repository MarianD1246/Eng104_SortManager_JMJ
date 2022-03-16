using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager;

public class Program
{
    //------------------------VIEW---------------------
    public static void Main(String[] args)
    {
        char getInput;
        Timer timer = new();
        int[] unsortedArray = GetInput(out getInput);
        ISortable sortMethod = SortController.SelectSort(getInput);
        timer.Start();
        int[] arr = sortMethod.Sort(unsortedArray);
        string timeElapsed = timer.Stop();
        PrintArray(arr, timeElapsed);
    }
    
    public static int[] GetInput(out char input)
    {
        Console.WriteLine("How many numbers would you like in your array?");
        int lengthOfArray = 0;
        string sizeOfArray = Console.ReadLine();
       
        while (int.TryParse(sizeOfArray, out lengthOfArray) == false)
        {
            Console.WriteLine("Please enter a number for the array length.");
            sizeOfArray = Console.ReadLine();
        }
        int[] arr = CreateArray(lengthOfArray);
        PrintArray(arr,"");

        Console.WriteLine("Choose a Sort Method: \nType A for Merge Sort\nType B for Bubble Sort\nType C for .Net Sort");// \nType D for Premium ULTRA PLUS MergeSort
        ConsoleKeyInfo userInput = Console.ReadKey();
        while (userInput.KeyChar != 'a' && userInput.KeyChar != 'A' && userInput.KeyChar != 'b' && userInput.KeyChar != 'B' && userInput.KeyChar != 'c' && userInput.KeyChar != 'C') //&& userInput.KeyChar != 'd' && userInput.KeyChar != 'D'
        {
            Console.WriteLine("Valid inputs are A(Merge Sort) or B(Bubble Sort) or C(.Net Sort) "); //or D(Old MergeSort)
            userInput = Console.ReadKey(); 
        }
        
        input = userInput.KeyChar;
        return arr;
    }

    public static int[] CreateArray(int lengthOfArray)
    {
        int[] arr = new int[lengthOfArray];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 1001);
        }
        return arr;
    }

    public static void PrintArray(int[] sortedArray, string timeElapsed)
    {
        if (sortedArray.Length <= 20)
        {
            StringBuilder sortedOutput = new();
            foreach (int i in sortedArray)
            {
                sortedOutput.Append($"[{i}], ");
            }
            Console.WriteLine($"\n{sortedOutput.ToString().Trim(' ', ',')}");
        }
        else Console.WriteLine("\n Array length is more than 20, so data is not displayed.");
       
        if(timeElapsed != "") Console.WriteLine($"Time Taken to sort: {timeElapsed}");

        Console.WriteLine();
    }
}