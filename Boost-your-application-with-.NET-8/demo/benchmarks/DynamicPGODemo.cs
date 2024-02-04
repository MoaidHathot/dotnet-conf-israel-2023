using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace benchmarks
{
    internal class DynamicPGODemo
    {
        public static void Demo()
        {
            var list = new List<int>();
            Stopwatch sw = new Stopwatch();

            while (true)
            {
                sw.Restart();

                for (int i = 0; i < 1_000_000_000; i++)
                {
                    IsEmpty(list);
                }
                Console.WriteLine(sw.ElapsedMilliseconds.ToString());
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static bool IsEmpty(IList<int> list) => list.Count != 0;
    }
}
