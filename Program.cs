using StressTest.CPU;

using System;

namespace StressTest 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CpuStressTest cpuStressTest = new CpuStressTest();

            cpuStressTest.Stress();
            
            



        }
    }
}