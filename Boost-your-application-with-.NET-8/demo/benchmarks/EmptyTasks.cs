// dotnet run -c Release -f net7.0 --filter "*" --runtimes net7.0 net8.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

//BenchmarkSwitcher.FromAssembly(typeof(EmptyTasks).Assembly).Run(args);

[HideColumns("Error", "StdDev", "Median", "RatioSD")]
[MemoryDiagnoser(displayGenColumns: false)]
public class EmptyTasks
{
    [Benchmark] public async Task<TimeSpan> ZeroTimeSpan() => TimeSpan.Zero;
    [Benchmark] public async Task<DateTime> MinDateTime() => DateTime.MinValue;
    [Benchmark] public async Task<Guid> EmptyGuid() => Guid.Empty;
    [Benchmark] public async Task<DayOfWeek> Sunday() => DayOfWeek.Sunday;
    [Benchmark] public async Task<decimal> ZeroDecimal() => 0m;
    [Benchmark] public async Task<double> ZeroDouble() => 0;
    [Benchmark] public async Task<float> ZeroFloat() => 0;
    [Benchmark] public async Task<Half> ZeroHalf() => (Half)0f;
    [Benchmark] public async Task<(int, int)> ZeroZeroValueTuple() => (0, 0);
}