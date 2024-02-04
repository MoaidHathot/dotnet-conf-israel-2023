using System;
using System.Buffers;
using System.Collections.Generic;
using System.Buffers;

namespace benchmarks
{
    public class SearchValuesDemo
    {
        public static void Demo()
        {
            Console.WriteLine(SearchValues.Create(""));
            Console.WriteLine(SearchValues.Create("a"));
            Console.WriteLine(SearchValues.Create("ac"));
            Console.WriteLine(SearchValues.Create("ace"));
            Console.WriteLine(SearchValues.Create("ab\u05D0\u05D1"));
            Console.WriteLine(SearchValues.Create("abc\u05D0\u05D1"));
            Console.WriteLine(SearchValues.Create("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(SearchValues.Create("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"));
            Console.WriteLine(SearchValues.Create("\u00A3\u00A5\u00A7\u00A9\u00AB\u00AD"));
            Console.WriteLine(SearchValues.Create("abc\u05D0\u05D1\u05D2"));
        }
    }
}
