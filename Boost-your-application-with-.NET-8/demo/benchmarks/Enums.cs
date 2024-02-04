using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benchmarks
{
    // dotnet run -c Release -f net7.0 --runtimes net7.0 net8.0

    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Running;

    [HideColumns("Error", "StdDev", "Median", "RatioSD")]
    [MemoryDiagnoser(displayGenColumns: false)]
    public class Enums
    {
        private readonly DayOfWeek _dow = DayOfWeek.Saturday;

        [Benchmark] public bool IsDefined() => Enum.IsDefined(_dow);
        [Benchmark] public string GetName() => Enum.GetName(_dow);
        [Benchmark] public string[] GetNames() => Enum.GetNames<DayOfWeek>();
        [Benchmark] public DayOfWeek[] GetValues() => Enum.GetValues<DayOfWeek>();
        [Benchmark] public Array GetUnderlyingValues() => Enum.GetValuesAsUnderlyingType<DayOfWeek>();
        [Benchmark] public string EnumToString() => _dow.ToString();
        [Benchmark] public bool TryParse() => Enum.TryParse<DayOfWeek>("Saturday", out _);
    }
}
