// dotnet run -c Release -f net7.0 --runtimes net7.0 net8.0

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Text.Json;
using System.Text.Json.Serialization;

//BenchmarkSwitcher.FromAssembly(typeof(JSON).Assembly).Run(args);

[HideColumns("Error", "StdDev", "Median", "RatioSD")]
[MemoryDiagnoser(displayGenColumns: false)]
public partial class JSON
{
    private readonly Rectangle _data = new()
    {
        X = 1,
        Y = 2,
        Width = 3,
        Height = 4,
        Color = new Color { R = 5, G = 6, B = 7, A = 8 }
    };

    [Benchmark]
    public void Serialize() => JsonSerializer.Serialize(Stream.Null, _data, JsonContext.Default.Rectangle);

    [Benchmark]
    public Task SerializeAsync() => JsonSerializer.SerializeAsync(Stream.Null, _data, JsonContext.Default.Rectangle);

    public class Rectangle
    {
        public int X, Y, Width, Height;
        public Color Color;
    }

    public struct Color
    {
        public byte R, G, B, A;
    }

    [JsonSerializable(typeof(Rectangle))]
    [JsonSourceGenerationOptions(IncludeFields = true)]
    private partial class JsonContext : JsonSerializerContext { }
}