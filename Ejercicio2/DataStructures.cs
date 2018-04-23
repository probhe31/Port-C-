using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio2
{
    class DataStructures
    {
        private const int SIZE_LOG_LINES = 100000;
        private const int SIZE_UNIQUE_IPS = 90001;
        private static LogReader logReader = new LogReader(SIZE_LOG_LINES, SIZE_UNIQUE_IPS, CollectionType.Hash);


        static void Main(string[] args)
        {
            Console.WriteLine("Reading all log entries...");
            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            int sizeLogLines = logReader.ReadAllLogs();
            Console.WriteLine("Number of lines: " + sizeLogLines);
            watch1.Stop();
            var elapsedMs1 = watch1.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: " + elapsedMs1 + " miliseconds");


            Console.WriteLine("\nProcessing unique IPs...");
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            int sizeUniqueIps = logReader.GetSizeUniqueIps();
            watch2.Stop();
            var elapsedMs2 = watch2.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: " + elapsedMs2 + " miliseconds");
            Console.WriteLine("Number of unique IPs: " + sizeUniqueIps);


            Console.ReadKey();
        }

        
        
    }
}
