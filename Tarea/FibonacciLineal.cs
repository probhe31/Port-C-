using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class FibonacciLineal
    {

        private const int N = 1000;
        private static long[] fibonacciCache = new long[N + 1];

        static void Main(string[] args)
        {                                   
            Console.WriteLine("1. Fibonacci lineal");
            Console.WriteLine("2. Programacion dinamica");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": 
                    DoFibonacciLineal(N);
                    break;

                case "2":
                    DoFibonacciProgramacionDinamica(N);
                    break;
            }

        
        }

        public static void DoFibonacciProgramacionDinamica(int N)
        {

            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i <= N; i++)
            {
                long res = FibonacciDinamico(i);
                Console.WriteLine(i + " -> " + res);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: " + elapsedMs + " miliseconds");
            Console.ReadKey();
        }


        public static void DoFibonacciLineal(int N)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i <= N; i++)
            {
                long res = Fibonacci(i);
             Console.WriteLine(i + " -> " + res);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: " + elapsedMs + " miliseconds");
            Console.ReadKey();
        }

        //O(N)
        public static long Fibonacci(int n)
        {
            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        //PROGRAMACION DINAMICA
        public static long FibonacciDinamico(int n)
        {
            if (n < 0)
            {
                throw new Exception("N can not be less than zero");
            }
            if (n <= 2)
            {
                fibonacciCache[n] = 1;
            }
            if (fibonacciCache[n] == 0)
            {
                fibonacciCache[n] = fibonacciCache[n - 1] + fibonacciCache[n - 2];
            }
            return fibonacciCache[n];
        }

    }
}
