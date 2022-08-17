using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericProblem
{
    internal class FindMax
    {
        public int FindMx(int First,int Second,int Third)
        {
            if(First.CompareTo(Second)>0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if(Second.CompareTo(First)>0 && Second.CompareTo(Third) > 0){
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            return 0;
        }
        public float FindMx(float First, float Second,float Third)
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                return First;
            }
            if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                return Second;
            }
            if (Third.CompareTo(First) > 0 && Third.CompareTo(Second) > 0)
            {
                return Third;
            }
            return 0;
        }
    }
}
