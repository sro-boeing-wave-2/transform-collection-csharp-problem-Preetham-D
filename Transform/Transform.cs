using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static int[] Map(this int[] x,Func<int,int>condition)
        {
            // throw new NotImplementedException();
            List<int> a = new List<int>();
            foreach(int y in x)
            {
                a.Add(condition(y));
            }
            return a.ToArray();
        }
    }
}
