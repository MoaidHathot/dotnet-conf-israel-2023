// dotnet run -c Release -f net8.0 --filter "*"

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Frozen;
using System.Collections.Immutable;

[HideColumns("Error", "StdDev", "Median", "RatioSD")]
public class FrozenDictionaries
{
    private const int Items = 10_000;

    private static readonly Dictionary<int, int> _dictionary = 
        new Dictionary<int, int>(Enumerable.Range(0, Items).
            ToDictionary(x => x, x => x));
    private static readonly ImmutableDictionary<int, int> _immutableDictionary = 
        ImmutableDictionary.CreateRange(Enumerable.Range(0, Items).
            ToDictionary(x => x, x => x));
    private static readonly FrozenDictionary<int, int> _frozenDictionary = 
        FrozenDictionary.ToFrozenDictionary(Enumerable.Range(0, Items).
            ToDictionary(x => x, x => x));

    [Benchmark]
    public int DictionaryGets()
    {
        int sum = 0;
        for (int i = 0; i < Items; i++)
        {
            sum += _dictionary[i];
        }
        return sum;
    }

    [Benchmark]
    public int ImmutableDictionaryGets()
    {
        int sum = 0;
        for (int i = 0; i < Items; i++)
        {
            sum += _immutableDictionary[i];
        }
        return sum;
    }

    [Benchmark(Baseline = true)]
    public int FrozenDictionaryGets()
    {
        int sum = 0;
        for (int i = 0; i < Items; i++)
        {
            sum += _frozenDictionary[i];
        }
        return sum;
    }
}