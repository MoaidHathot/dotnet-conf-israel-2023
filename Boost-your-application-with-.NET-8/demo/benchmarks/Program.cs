// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using benchmarks;

//BenchmarkSwitcher.FromAssembly(typeof(Enums).Assembly).Run(args);

//DynamicPGODemo.Demo();
await DemoAsync();

#region DemoAsync
static async Task DemoAsync()
{
    for (int i = 0; i < 1_000; i++)
    {
        await YieldAsync();
    }

    static async Task<int> YieldAsync()
    {
        await Task.Yield();
        return 42;
    }
}
#endregion




