using NUnit.Framework;
using SortManager;

namespace SortingTests;

public class SortTest
{
    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [Description("1-10 Order test")]
    public void GivenOnetoTenIntArray_Bubble_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = BubbleSort.BubbleArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

    [TestCase(new int[] { 10, 7, 8, 4, 2, 6, 9, 3, 5, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [Description("1-10 Order test using MergeArray")]
    public void GivenOnetoTenIntArray_Merge_ReturnCorrectOrderArray(int[] input, int[] expected)
    {
        int[] result = MergeSort.MergeArraySort(input);
        Assert.That(expected, Is.EqualTo(result));
    }

}
