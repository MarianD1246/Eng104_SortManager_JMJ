using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSortManager;

public class BubbleSort
{
    public BubbleSort(int[] arr)
    {
        int[] array = arr;
    }
    public static int[] BubbleArraySort(int[] array)
    {
        bool isSorted = false;
        while (!isSorted)
        {
            bool isChanged = false;
            int bubble = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    int smaller = array[i];
                    int bigger = array[i - 1];
                    array[i] = bigger;
                    array[i - 1] = smaller;
                    isChanged = true;
                }
            }
            if (!isChanged)
                isSorted = true;
        }
        return array;
    }
}