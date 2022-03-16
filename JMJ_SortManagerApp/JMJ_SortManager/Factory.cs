using System;


namespace SortManager;

public class Factory
{
    public static int[] SelectSort(int[] unsortedArray, char c)
    {
        switch (c)
        {
            case 'a':
            case 'A':
                unsortedArray = MergeSort.MergeArraySort(unsortedArray);
                break;
            case 'b':
            case 'B':
                unsortedArray = BubbleSort.BubbleArraySort(unsortedArray);
                break;
            case 'c':
            case 'C':
                unsortedArray = NetSort.NetSortMethod(unsortedArray);
                break;
            case 'd':
            case 'D':
                unsortedArray = MergeSort.MergeArraySortOld(unsortedArray);
                break;
        }
        return unsortedArray;
    }
}