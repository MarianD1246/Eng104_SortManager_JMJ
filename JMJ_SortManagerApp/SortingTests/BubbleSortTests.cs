using NUnit.Framework;
using SortManager;
using System;
using System.Collections.Generic;

namespace SortTests;

public class BubbleSortTests
{

    [TestCaseSource(typeof(UnsortedData), "Arrays")]
    public void GivenTestCaseSourceObjects_BubbleWillSortCorrectly(int[] oArr)
    {
        
        int[] result = new BubbleSort().Sort(oArr);
        int[] expected = oArr;
        Array.Sort(expected);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Empty Array Test")]
    [TestCase(new int[] { }, new int[] { })]

    public void GivenEmptyArray_Bubble_ReturnEmptyArray(int[] input, int[] expected)
    {
        int[] result = new BubbleSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Single Digit Array Test")]
    [TestCase(new int[] { 2 }, new int[] { 2 })]

    public void GivenSingleDigitArray_Bubble_ReturnSingleDigitArray(int[] input, int[] expected)
    {
        int[] result = new BubbleSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Bubble Sort")]
    [Description("1000 Bubble Array Test")]

    [Test]
    public void GivenThousandIntArray_Bubble_ReturnCorrectOrderArray()
    {
        int[] input = new int[1000];
        Random rand = new Random(1);
        for (int i = 0; i < 1000; i++)
        {
            input[i] = rand.Next(0, 1001);
        }
        int[] result = new BubbleSort().Sort(input);
        Array.Sort(input);
        Assert.That(result, Is.EqualTo(input));
    }
}

