using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager
{
    public class MergeSort
    {
        public static int[] MergeArraySort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpont
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = MergeArraySort(left);
            //Recursively sort the right array
            right = MergeArraySort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }

        public static int[] MergeArraySortOld(int[] arr, int compareNo = 1)
        {
            int noOfMergeGroups = arr.Length / compareNo;
            int leftOverInts = arr.Length % compareNo;
            int[] newOrder = new int[arr.Length];
            int lowLocation;

            if (arr == null || arr.Length == 0 || arr.Length == 1)
                return arr;


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
                return MergeArraySortOld(newOrder, compareNo * 2); //If the arrays aren't fully merged, merge them
        }
    }
}