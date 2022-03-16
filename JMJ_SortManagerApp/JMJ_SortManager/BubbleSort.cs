using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager;

public class BubbleSort : ISortable
{
    public int[] Sort(int[] array)
    {
        if (array == null || array.Length == 0)
            return array;
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