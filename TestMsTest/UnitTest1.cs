using BenchmarkDotNet.Attributes;
using TestLib;

namespace TestMsTest
{
    public class BenchmarkClass
    {
        [Benchmark(Description = "Рассчет с каждым числом")]
        public List<int> TestOne()
        {
            return Tasks.TaskOne();
        }
        [Benchmark(Description = "Составление чисел")]
        public List<int> TestTwo()
        {
            return Tasks.TaskTwo();
        }
    }
}