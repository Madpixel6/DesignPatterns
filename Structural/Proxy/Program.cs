using System;
using System.Diagnostics;
using System.Threading;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Performing the benchmark using proxy to Heavy ***");
            var results = PerformBenchmark();
            Console.WriteLine("First, uncached occurence computation time:" + results.Item1);
            Console.WriteLine("Second, cached by proxy occurence computation time:" + results.Item2);
            Console.ReadKey();
        }

        private static ValueTuple<double, double> PerformBenchmark()
        {
            var watch = new Stopwatch();
            var heavyProxy = new HeavyProxy(new Heavy());
            var results = new ValueTuple<double, double>();

            BenchmarkWarmup();
            watch.Start();
            _ = heavyProxy.GetMagicNumber().Result;
            watch.Stop();
            results.Item1 = watch.Elapsed.TotalMilliseconds;

            BenchmarkWarmup();
            watch.Restart();
            _ = heavyProxy.GetMagicNumber().Result;
            watch.Stop();
            results.Item2 = watch.Elapsed.TotalMilliseconds;
            return results;
        }

        private static void BenchmarkWarmup()
        {
            //Run at highest priority to minimize fluctuations caused by other processes/threads
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
