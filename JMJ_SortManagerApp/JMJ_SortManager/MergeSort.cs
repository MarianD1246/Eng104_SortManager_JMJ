using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager
{
    public class MergeSort
    {
        public static int[] MergeArraySort(int[] arr, int compareNo = 1)
        {
            int noOfMergeGroups = arr.Length / compareNo;
            int leftOverInts = arr.Length % compareNo;
            int[] newOrder = new int[arr.Length];
            int lowLocation;

            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Input Array is empty or Null");


            for (int x = 0; x < noOfMergeGroups; x++)   //Runs code on all standard subgroups of array
            {
                for (int i = 0; i < compareNo; i++)  //This orders a piece of array from min to max
                {
                    newOrder[i + (x * compareNo)] = arr.Skip(x * compareNo).Take(compareNo).Min();
                    lowLocation = Array.FindIndex(arr, item => item == arr.Skip(x * compareNo).Take(compareNo).Min());
                    arr[lowLocation] = int.MaxValue;
                }
            }
            if (leftOverInts > 0)    //This orders the numbers in the remainder
            {
                for (int i = 0; i < leftOverInts; i++)  //This orders a piece of array from min to max
                {
                    newOrder[i + (arr.Length - leftOverInts)] = arr.Skip(arr.Length - leftOverInts).Take(leftOverInts).Min();
                    lowLocation = Array.FindIndex(arr, item => item == arr.Skip(arr.Length - leftOverInts).Take(leftOverInts).Min());
                    arr[lowLocation] = int.MaxValue;
                }
            }

            if (compareNo >= arr.Length)    //If all the arrays have been merged return the array
                return newOrder;

            else
                return MergeArraySort(newOrder, compareNo * 2); //If the arrays aren't fully merged, merge them

        }
    }
}