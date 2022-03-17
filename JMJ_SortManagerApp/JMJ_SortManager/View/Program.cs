using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager;

public enum SelectedSort
{
    MERGE,
    BUBBLE,
    NET
}
public class Program
{
    public static void Main(String[] args)
    {
        Timer timer = new();
        int[] unsortedArray = GetUserInputs(out SelectedSort selection);
        ISortable sortMethod = SortController.SelectSort(selection);
        timer.Start();
        int[] arr = sortMethod.Sort(unsortedArray);
        string timeElapsed = timer.Stop();
        PrintArray(arr, timeElapsed);
    }
    
    public static int[] GetUserInputs(out SelectedSort selection)
    {
        Console.WriteLine("How many numbers would you like in your array?");
        int lengthOfArray = 0;
        string sizeOfArray = Console.ReadLine();
       
        while (int.TryParse(sizeOfArray, out lengthOfArray) == false || lengthOfArray < 0)
        {
            Console.WriteLine("Invalid Input.\nPlease enter a number for the array length.");
            sizeOfArray = Console.ReadLine();
        }
        int[] arr = CreateArray(lengthOfArray);
        PrintArray(arr,"");

        Console.WriteLine("\nChoose a Sort Method: \nType A for Merge Sort\nType B for Bubble Sort\nType C for .Net Sort");// \nType D for Premium ULTRA PLUS MergeSort
        Char userInput = Char.ToUpper(Console.ReadKey().KeyChar);
        while (userInput != 'A' && userInput != 'B' && userInput != 'C') //&& userInput.KeyChar != 'd' && userInput.KeyChar != 'D'
        {
            Console.WriteLine("Valid inputs are A(Merge Sort) or B(Bubble Sort) or C(.Net Sort) "); //or D(Old MergeSort)
            userInput = Char.ToUpper(Console.ReadKey().KeyChar);
        }
        Console.WriteLine();
        

    switch (userInput)
    {
        case 'A':
            selection = SelectedSort.MERGE;
            return arr;
        case 'B':
            selection = SelectedSort.BUBBLE;
            return arr;
        case 'C':
            selection = SelectedSort.NET;
            return arr;
        default:
            selection = SelectedSort.MERGE;
            return arr;
        }      
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
        else Console.WriteLine("\nArray length is more than 20, so data is not displayed.");
       
        if(timeElapsed != "") Console.WriteLine($"Time Taken to sort: {timeElapsed}");
    }
}