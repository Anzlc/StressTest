using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StressTest.CPU
{
    public class CpuStressTest
    {

        public void Stress()
        {
            Console.WriteLine("Starting...");

            

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                 
                Console.WriteLine($"Thread {i + 1}# started!");
                Thread thread = new Thread(new ThreadStart(GeneratePrimeNumbers));
                thread.Start();
                
            }

            GeneratePrimeNumbers();
        }

        internal void GeneratePrimeNumbers() {
            int i = 1;
            int primeNumbersCount = 0;
            while (true)
            {
               
                int dividerCount = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    { 
                        dividerCount++;
                    }
                }
                if (dividerCount == 2)
                {
                    primeNumbersCount++;


                }
                i++;
            }


        }
    }
}
