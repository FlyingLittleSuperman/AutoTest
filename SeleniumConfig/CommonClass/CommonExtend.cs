using System.Collections;
using System.Collections.Generic;

namespace SeleniumConfig.CommonClass
{
    public static class CommonExtend
    {
        public static List<T> ToList<T>(this IEnumerable list)
        {
            List<T> newList = new List<T>();
            foreach (object o in list)
            {
                newList.Add((T)o);
            }
            return newList;
        }

        public static bool HasItem(this IEnumerable list)
        {
            if (list == null) return false;
            var enumerable = list.GetEnumerator();
            return enumerable.MoveNext();
        }

    }
}