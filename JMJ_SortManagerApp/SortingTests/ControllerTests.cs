using NUnit.Framework;
using SortManager;
using System;
using System.Collections.Generic;

namespace SortTests;

public class ControllerTests
{

    [Category("Testing Controller Return Merge sort")]
    [TestCase(SelectedSort.MERGE)]

    public void GiveControllerMERGE_Enum_ReturnsMergeFactory(SelectedSort selected)
    {
        ISortable selectedSort = SortController.SelectSort(selected);
        var x = new MergeFactory().GetInstance();
        Assert.That(x, Is.TypeOf(selectedSort.GetType()));
        
    }

    [Category("Testing Controller Return Bubble sort")]
    [TestCase(SelectedSort.BUBBLE)]

    public void GiveControllerBUBBLE_Enum_ReturnsMergeFactory(SelectedSort selected)
    {
        ISortable selectedSort = SortController.SelectSort(selected);
        var x = new BubbleFactory().GetInstance();
        Assert.That(x, Is.TypeOf(selectedSort.GetType()));

    }

    [Category("Testing Controller Return NET sort")]
    [TestCase(SelectedSort.NET)]

    public void GiveControllerNET_Enum_ReturnsMergeFactory(SelectedSort selected)
    {
        ISortable selectedSort = SortController.SelectSort(selected);
        var x = new NetFactory().GetInstance();
        Assert.That(x, Is.TypeOf(selectedSort.GetType()));

    }
}

