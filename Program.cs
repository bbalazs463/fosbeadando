using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace beadando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int n, k;
            string s = Console.ReadLine();
            n = int.Parse(s.Split()[0]);
            k = int.Parse(s.Split()[1]);
            int[] t = new int[k];
            for (int i = 0; i < k; i++)
            {
                t[i] = -50001;
            }
            sw.Start();
            for(int i = 0; i < n; i++)
            {
                t[i % k] = int.Parse(Console.ReadLine());
                Console.WriteLine(t.Max());
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}