using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Extension.CollectionPlus
{
    using System.Linq;

    public static class LinqPlus
    {
        /// <summary>从 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 创建一个 <see cref="T:System.Collections.Generic.List`1" />,null返回new <see cref="T:System.Collections.Generic.List`1" /></summary>
        /// <returns>一个包含输入序列中元素的 <see cref="T:System.Collections.Generic.List`1" /></returns>
        /// <param name="source">要从其创建 <see cref="T:System.Collections.Generic.List`1" /> 的 <see cref="T:System.Collections.Generic.IEnumerable`1" /></param>
        /// <typeparam name="TSource">
        /// <paramref name="source" /> 中的元素的类型</typeparam>
        /// <returns><see cref="T:System.Collections.Generic.List`1" /></returns>
        public static List<TSource> ToListPlus<TSource>(this IEnumerable<TSource> source)
        {
            return source.ToList() ?? new List<TSource>();
        }

        /// <summary>对<see cref="T:System.Collections.Generic.IEnumerable`1" /> 的每个元素执行指定操作, null直接跳过</summary>
        /// <param name="source">要执行指定操作的 <see cref="T:System.Collections.Generic.IEnumerable`1" /></param>
        /// <param name="action">要对 <see cref="T:System.Collections.Generic.IEnumerable`1" /> 的每个元素执行的 <see cref="T:System.Action`1" /> 委托。</param>
        public static void ForEachPlus<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null || action == null) return;
            foreach (var item in source)
            {
                action(item);
            }
        }

        /// <summary>将序列中的每个元素投影到新表中, null返回new <see cref="T:System.Collections.Generic.List`1" /></summary>
        /// <returns>一个 <see cref="T:System.Collections.Generic.IEnumerable`1" />, 其元素为对 <paramref name="source" /> 的每个元素调用转换函数的结果</returns>
        /// <param name="source">一个值序列，要对该序列调用转换函数。</param>
        /// <param name="selector">应用于每个元素的转换函数。</param>
        /// <typeparam name="TSource">
        /// <paramref name="source" /> 中的元素的类型。</typeparam>
        /// <typeparam name="TResult">
        /// <paramref name="selector" /> 返回的值的类型。</typeparam>
        public static IEnumerable<TResult> SelectPlus<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            if (source == null || !source.Any()) return new List<TResult>();
            return source.Select(selector);
        }

        /// <summary>基于谓词筛选值序列, null返回new <see cref="T:System.Collections.Generic.List`1" /></summary>
        /// <returns>一个 <see cref="T:System.Collections.Generic.IEnumerable`1" />, 包含输入序列中满足条件的元素</returns>
        /// <param name="source">要筛选的 <see cref="T:System.Collections.Generic.IEnumerable`1" /></param>
        /// <param name="predicate">用于测试每个元素是否满足条件的函数</param>
        /// <typeparam name="TSource">
        /// <paramref name="source" /> 中的元素的类型</typeparam>
        public static IEnumerable<TSource> WherePlus<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null || !source.Any()) return new List<TSource>();
            return source.Where(predicate);
        }

        /// <summary>检索与指定谓词定义的条件匹配的所有元素, null返回new <see cref="T:System.Collections.Generic.List`1" /></summary>
        /// <returns>如果找到, 则为一个 <see cref="T:System.Collections.Generic.List`1" />, 其中包含与指定谓词所定义的条件相匹配的所有元素; null返回new<see cref="T:System.Collections.Generic.List`1" /></returns>
        /// <param name="match">
        /// <see cref="T:System.Predicate`1" /> 委托，用于定义要搜索的元素应满足的条件</param>
        public static List<T> FindAllPlus<T>(this IEnumerable<T> source, Predicate<T> match)
        {
            if (source == null || !source.Any()) return new List<T>();
            return source.Where(x => match(x)).ToList();
        }

        /// <summary>
        /// 按一定数量对序列中的元素进行分组, null返回新实例
        /// </summary>
        /// <typeparam name="T">泛型</typeparam>
        /// <param name="source">源</param>
        /// <param name="count">每组数量</param>
        /// <returns>结果</returns>
        public static IEnumerable<IEnumerable<T>> GroupByCount<T>(this IEnumerable<T> source, int count)
        {
            if (source == null || !source.Any() || count <= 0) return new List<IEnumerable<T>>();
            var allCount = source.Count();
            if (allCount <= count) return new List<IEnumerable<T>> { source };
            var result = new List<IEnumerable<T>>();
            var beginCount = 0;
            while (beginCount < allCount)
            {
                result.Add(source.Skip(beginCount).Take(count));
                beginCount = beginCount + count;
            }
            return result;
        }
    }
}
