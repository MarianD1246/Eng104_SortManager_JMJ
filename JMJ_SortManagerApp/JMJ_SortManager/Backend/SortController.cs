using System.Text;
using System.Threading.Tasks;

namespace SortManager;

public class SortController
{
    public static ISortable SelectSort(char c)
    {
        switch (c)
        {
            case 'A':
                return new MergeFactory().GetInstance();
            case 'B':
                return new BubbleFactory().GetInstance();
            case 'C':
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