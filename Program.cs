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
            int n, k, max = -50001, maxind = 0;
            string s = Console.ReadLine();
            n = int.Parse(s.Split()[0]);
            k = int.Parse(s.Split()[1]);
            int[] t = new int[k];
            for (int i = 0; i < k; i++)
            {
                t[i] = -50001;
            }
            for(int i = 0; i < n; i++)
            {
                t[i % k] = int.Parse(Console.ReadLine());
                if (maxind == (i % k))
                {
                    for (int j = 0; j < k; j++)
                    {
                        if (t[j] > max)
                        {
                            maxind = j;
                            max = t[j];
                        }
                    }
                }
                if(max < t[i % k])
                {
                    max = t[i % k];
                    maxind = i % k;
                }

                Console.WriteLine(max);
            }
        }
    }
}