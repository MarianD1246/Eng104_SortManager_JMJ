using System.Text;
using System.Threading.Tasks;

namespace SortManager;

public class SortController
{
    public static ISortable SelectSort(SelectedSort Selection)
    {
        switch (Selection)
        {
            case SelectedSort.MERGE:
                return new MergeFactory().GetInstance();
            case SelectedSort.BUBBLE:
                return new BubbleFactory().GetInstance();
            case SelectedSort.NET:
                return new NetFactory().GetInstance();
            // case 'd':
            // case 'D':
            //     unsortedArray = MergeSort.MergeArraySortOld(unsortedArray);
            //     break;
            default:
                return null;
        }
    }
}