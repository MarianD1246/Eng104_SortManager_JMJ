using NUnit.Framework;
using SortManager;
using System;
using System.Collections.Generic;

namespace SortTests;

public static class UnsortedData
{
    public static object[] Arrays =
    {
        new int[] { 7},
        new int[] { 17, 12, 5},
        new int[] { 24, 1, 29, 16, 15, 22, 7, 14},
        new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 },
        new int[] { 47, 13, 39, 98, 70, 5, 18, 27, 24, 1, 75, 4, 9, 27, 11, 45, 8, 42, 1, 33, 29, 41, 51 },
        RandomArray(1000),
        RandomArray(10000)
    };

    public static int[] RandomArray(int length)
    {
        if (length > 0)
        {
            int[] output = new int[length];
            Random rand = new Random(1);
            for (int i = 0; i < length; i++)
            {
                output[i] = rand.Next(0, length + 1);
            }
        return output;
        }
        else return new int[] { 0 };
    }
}
