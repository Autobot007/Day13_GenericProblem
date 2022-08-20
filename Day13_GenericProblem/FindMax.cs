using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericProblem
{
    public class FindMax<T> where T : IComparable
    {
        public T[] value;
        public FindMax(T[] value)
        {
            this.value = value;
        }
        //        public T first,second,third;    
        //        public FindMax(T first, T second, T third)
        //        {
        //            this.first = first;
        //            this.second = second;
        //            this.third = third;
        //        }

        //        public T FindMx(T First,T Second,T Third)
        //        {
        //            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
        //            {
        //                return First;
        //            }
        //            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
        //            {
        //                return Second;
        //            }
        //            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
        //            {
        //                return Third;
        //            }
        //            return default;
        //        }

        //    }
        //}
    }
}