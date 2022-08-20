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

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sortedValues = Sort(values);
            return sortedValues[^1];
        }
        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }
        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            Console.WriteLine("Maximum Value is :" + max);

        }

        //public class FindMax
        //{
        //    public int FindMx(int First, int Second, int Third)
        //    {
        //        if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
        //        {
        //            return First;
        //        }
        //        if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
        //        {
        //            return Second;
        //        }
        //        if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
        //        {
        //            return Third;
        //        }
        //        return 0;
        //    }
        //    public float FindMx(float First, float Second, float Third)
        //    {
        //        if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
        //        {
        //            return First;
        //        }
        //        if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
        //        {
        //            return Second;
        //        }
        //        if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
        //        {
        //            return Third;
        //        }
        //        return 0;
        //    }
        //    public string FindMx(string firstString, string secondString, string thirdString)
        //    {
        //        if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
        //            firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
        //            firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
        //        {
        //            return firstString;
        //        }

        //        if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
        //            secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
        //            secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
        //        {
        //            return secondString;
        //        }

        //        if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
        //            thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
        //            thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
        //        {
        //            return thirdString;
        //        }
        //        return String.Empty;
        //    }
        //}
    }

}
