using NBench;
using ProjectManager.ServiceLayer.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.PerformanceTest
{
    public class PerformanceTesting
    {

        [PerfBenchmark(NumberOfIterations = 1, RunMode = RunMode.Throughput,
        TestMode = TestMode.Test, SkipWarmups = true)]
        [ElapsedTimeAssertion(MaxTimeMilliseconds = 5000)]
        public void Benchmark_Performance_ElaspedTime()
        {
            var controller = new TaskController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            controller.GetAllTasks();
        }

        [PerfBenchmark(Description = "MemoryTEST",
NumberOfIterations = 5, RunMode = RunMode.Throughput, RunTimeMilliseconds = 2500, TestMode = TestMode.Test)]
        [MemoryAssertion(MemoryMetric.TotalBytesAllocated, MustBe.LessThanOrEqualTo, ByteConstants.SixtyFourKb)]
        public void Benchmark_Performance_Memory()
        {
            using (var controller = new TaskController())
            {
                controller.Request = new HttpRequestMessage()
                {
                    RequestUri = new Uri("http://localhost")
                };
                controller.GetAllTasks();

            }
        }
    }
}
