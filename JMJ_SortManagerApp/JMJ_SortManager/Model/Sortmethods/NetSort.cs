using System;
namespace SortManager;

class NetSort : ISortable
{
    public int[] Sort(int[] arr)
    {   
        Array.Sort(arr);
        return arr;
    }
}