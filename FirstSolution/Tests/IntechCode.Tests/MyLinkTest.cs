using System;
using IntechCode.IntechCollection;
using NUnit.Framework;

namespace IntechCode.Tests
{
    [TestFixture]
    public class MyLinkTests
    {
        public void MyLinq_supports_Where()
        {
            var list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(7);
            list.Add(10);

            int x = 98;
            bool isOdd = (x & 1) != 0;

            Func<int, bool> filter = num => (num & 1) != 0;

            var allOdds = list.Where(filter);
            var allPositiveOdds = list.Where(i => i >= 0);
        }






    }
    static class MyLinqDeFou
    {
        class En : IMyEnumerable<T>
        {
            readonly IMyEnumerable<T> _source;
            readonly Func<T, bool> _predicate;
            public En(IMyEnumerable<T> s, Func<T, bool> p)
            {
                _source = s;
                _predicate = p;
            }

            class E : IMyEnumerator<T>
            {
                readonly IMyEnumerator<T> _source;
                public E(En<T> e) => _spirce = e;
                public T Current => throw new NotImplementedException();

                public bool MoveNext()
                {
                    throw new NotImplementedException();
                }
            }
        }

        public static IMyEnumerable<T> Where<T>(this IMyEnumerable @this, Func<T, bool> predicate)
        {

        }

    }
}