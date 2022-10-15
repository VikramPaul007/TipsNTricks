using BenchmarkDotNet.Attributes;
using System.Text;

namespace OptimizationTechniques;

[MemoryDiagnoser]
public class StringBuilderBenchmark
{
    [Params(10, 100, 1000)]
    public int Length { get; set; }

    [Benchmark(Baseline = true)]
    public string Concatenate()
    {
        string value = string.Empty;

        for (int i = 0; i <= Length; i++)
        {
            value += i.ToString();
        }

        return value;
    }

    [Benchmark]
    public string ConcatenateWithStringBuilder()
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i <= Length; i++)
        {
            stringBuilder.Append(i);
        }

        return stringBuilder.ToString();
    }
}
