using NUnit.Framework;
using SortManager;
using System;
using System.Collections.Generic;

namespace SortTests;

public class BubbleSortTest
{

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

    [Category("0-10 Simple Array Test")]
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

    public void GivenTenIntArray_Bubble_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = new BubbleSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Bubble Sort")]
    [Description("1000 Bubble Array Test")]

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
public class MergeSortTest
{
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

    [Category("0-10 Simple Array Test")]
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

    public void GivenTenIntArray_Merge_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = new MergeSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

}
/*
public class OldMergeSortTest
{
    [Category("Empty Array Test")]
    [TestCase(new int[] {2}, new int[] {2})]

    public void GivenEmptyArray_OldMerge_ReturnEmptyArray(int[] input, int[] expected)
    {
        int[] result = new RecursiveSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Single Digit Array Test")]
    [TestCase(new int[] { }, new int[] { })]

    public void GivenSingleDigitArray_OldMerge_ReturnSingleDigitArray(int[] input, int[] expected)
    {
        int[] result = new RecursiveSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("0-10 Simple Array Test")]
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

    public void GivenTenIntArray_OldMerge_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = new RecursiveSort().Sort(input);
        Assert.That(expected, Is.EqualTo(result));
    }
}
    */
