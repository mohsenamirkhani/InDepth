using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extentions
{
    public static class CollectionInitializerAddList
    {
        public static void Add<T>(this List<T> list, IEnumerable<T> collection, int value = 1)
        {
            foreach (var c in collection)
            {
                list.Add(c);
            }
            //list.AddRange(collection);
        }

        public static void Add(this List<string> list, int value, int count = 1)
        {
            list.AddRange(Enumerable.Repeat(value.ToString(), count));
        }

       
    }
}
