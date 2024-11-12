using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int sm = 0;
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                string[] s = (Console.ReadLine()).Split(' ');

                if (s[0] == "+") 
                {
                    if (s[1] == "x") k += 1;
                    else sm += Convert.ToInt32(s[1]);
                }
                if (s[0] == "*")
                {
                    k *= Convert.ToInt32(s[1]);
                    sm *= Convert.ToInt32(s[1]);
                }
                if (s[0] =="-") 
                {
                    
                    if (s[1] == "x") k -= 1;
                    else sm -= Convert.ToInt32(s[1]);
                }
            }
            int r = int.Parse(Console.ReadLine());
            sm = r - sm;
            int ans = sm / k;
            Console.WriteLine(ans);

        }
    }
}
