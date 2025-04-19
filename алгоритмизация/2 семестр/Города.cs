
using System;
using System.IO;

namespace ConsoleApp6
{
    class task4
    {
        static void Main(string[] args)
        {

            var reader = new StreamReader("input_s1_01.txt");

            var s = reader.ReadLine().Split();
            int n = int.Parse(s[0]);
            int m = int.Parse(s[1]);
            int ans = 1;
            int[,] graph = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) graph[i, j] = 0;
                    else graph[i, j] = 100001;
                }
            }

            for (int k = 0; k < m; k++)
            {
                var curr_s = reader.ReadLine().Split();
                int i = int.Parse(curr_s[0]) - 1;
                int j = int.Parse(curr_s[1]) - 1;
                int l = int.Parse(curr_s[2]);
                graph[i, j] = Math.Min(graph[i, j],l);
                graph[j,i] = graph[i, j];
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0;j < n; j++)
                    {
                        graph[i,j] = Math.Min(graph[i,j], graph[i,k] + graph[k,j]);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans = Math.Max(ans, graph[i,j]);
                }
            }
            Console.WriteLine(ans);

        }
    }
}


