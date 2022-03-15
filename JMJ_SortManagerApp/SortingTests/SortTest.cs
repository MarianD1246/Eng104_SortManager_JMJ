using NUnit.Framework;
using SortManager;
using System;

namespace SortingTests;

public class SortTest
{

//------------------------------BUBBLE SORT-------------------------------------------------------------

    [Category("Bubble Sort")]
    [Description("Empty Bubble Array Test")]
    [TestCase(new int[] { }, new int[] {  })]

    public void GivenEmptyArray_Bubble_ReturnEmptyArray(int[] input, int[] expected)
    {
        int[] result = BubbleSort.BubbleArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Bubble Sort")]
    [Description("Single Digit Bubble Array Test")]
    [TestCase(new int[] {2}, new int[] {2})]

    public void GivenSingleDigitArray_Bubble_ReturnSingleDigitArray(int[] input, int[] expected)
    {
        int[] result = BubbleSort.BubbleArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Bubble Sort")]
    [Description("0-10 Bubble Array Test")]
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

    public void GivenOnetoTenIntArray_Bubble_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = BubbleSort.BubbleArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Bubble Sort")]
    [Description("1000 Bubble Array Test")]

    public void GivenOnetoTenIntArray_Bubble_ReturnCorrectOrderArray()
    {
        int[] input = new int[1000];
        Random rand = new Random(1);
        for (int i = 0; i<1000; i++)
        {
            input[i] = rand.Next(0, 1001);
        }
        int[] result = BubbleSort.BubbleArraySort(input);
        Array.Sort(input);
        Assert.That(result, Is.EqualTo(input));
    }

//------------------------------MERGE SORT-------------------------------------------------------------

[Category("Merge Sort")]
    [Description("Empty Merge Array Test")]
    [TestCase(new int[] { }, new int[] { })]

    public void GivenEmptyArray_Merge_ReturnEmptyArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Merge Sort")]
    [Description("Single Digit Merge Array Test")]
    [TestCase(new int[] {2}, new int[] {2})]

    public void GivenSingleDigitArray_Merge_ReturnSingleDigitArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Merge Sort")]
    [Description("0-10 Merge Array Test")]
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

    public void GivenOnetoTenIntArray_Merge_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    //------------------------------SLOW MERGE SORT--------------------------------------------------------

    [Category("Old Merge Sort")]
    [Description("Empty Old Merge Array Test")]
    [TestCase(new int[] {2}, new int[] {2})]

    public void GivenEmptyArray_OldMerge_ReturnEmptyArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySortOld(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Merge Sort")]
    [Description("Single Digit Old Merge Array Test")]
    [TestCase(new int[] { }, new int[] { })]

    public void GivenSingleDigitArray_OldMerge_ReturnSingleDigitArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySortOld(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [Category("Merge Sort")]
    [Description("0-10 Old Merge Array Test")]
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]

    public void GivenOnetoTenIntArray_OldMerge_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySortOld(input);
        Assert.That(expected, Is.EqualTo(result));
    }

}
