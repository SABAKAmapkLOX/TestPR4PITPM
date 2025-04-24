using BenchmarkDotNet.Attributes;
using TestLib;

namespace TestMsTest
{
    public class BenchmarkClass
    {
        [Benchmark(Description = "������� � ������ ������")]
        public List<int> TestOne()
        {
            return Tasks.TaskOne();
        }
        [Benchmark(Description = "����������� �����")]
        public List<int> TestTwo()
        {
            return Tasks.TaskTwo();
        }
    }
}