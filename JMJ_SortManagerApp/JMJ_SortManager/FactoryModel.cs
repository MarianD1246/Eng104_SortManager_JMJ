using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager
{
    public abstract class SortFactory
    {
        public abstract ISortable GetInstance();
    }
    public class BubbleFactory : SortFactory
    {
        public override ISortable GetInstance()
        {
            return new BubbleSort();
        }
    }
    public class MergeFactory : SortFactory
    {
        public override ISortable GetInstance()
        {
            return new MergeSort();
        }
    }
    public class NetFactory : SortFactory
    {
        public override ISortable GetInstance()
        {
            return new NetSort();
        }
    }

}
