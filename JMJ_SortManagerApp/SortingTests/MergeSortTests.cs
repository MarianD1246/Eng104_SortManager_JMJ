using NUnit.Framework;
using SortManager;
using System;
using System.Collections.Generic;

namespace SortTests;

public class MergeSortTests
{
    [TestCaseSource(typeof(UnsortedData), "Arrays")]
    public void GivenTestCaseSourceObjects_MergeSortWillSortCorrectly(int[] oArr)
    {
        int[] result = new BubbleSort().Sort(oArr);
        int[] expected = oArr;
        Array.Sort(expected);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Empty Array Test")]
    [TestCase(new int[] { }, new int[] { })]

    public void GivenEmptyArray_Merge_ReturnEmptyArray(int[] input, int[] expected)
    {
        int[] result = new MergeSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Single Digit Array Test")]
    [TestCase(new int[] { 2 }, new int[] { 2 })]

    public void GivenSingleDigitArray_Merge_ReturnSingleDigitArray(int[] input, int[] expected)
    {
        int[] result = new MergeSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }
}

