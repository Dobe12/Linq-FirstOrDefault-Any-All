using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LINQextensions
{
    public static class EnumerableExtension
    {
        public static TSource FirstOrDefaultMy<TSource>(this IEnumerable<TSource> source)
        {
            IEnumerator enumerator = source.GetEnumerator();

            return (enumerator.MoveNext()) ? (TSource)enumerator.Current : default(TSource);
        }

        public static TSource FirstOrDefaultMy<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
           foreach(TSource el in source)
            {
                if (predicate(el))
                    return el;
            }

            return default(TSource);
        }

        public static bool AnyMy<TSourse>(this IEnumerable<TSourse> source)
        {
            IEnumerator enumerator = source.GetEnumerator();
          
            return (enumerator.MoveNext()) ? true : false;
        }

        public static bool AnyMy<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource el in source)
            {
                if (predicate(el))
                    return true;
            }

            return false;
        }


        public static bool AllMy<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            foreach (TSource el in source)
            {
                if (!predicate(el))
                    return false;
            }

            return true;
        }
    }
}
