using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static int Count(string s1, string s2)
        {
            int count = 0;
            for (int i = 0; i < s1.Length - s2.Length; i++)
            {
                if (s1.Substring(i, s2.Length) == s2) count++;
            }
            return count;
        }
        //Определить символ, наиболее часто встречающийся на месте * в комбинациях вида a*b/
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToLower();
            char c = s[0];
            int mx = 0;
            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i] == 'a' && s[i + 2] == 'b')
                {
                    var curr = s.Substring(i, 3);
                    if (Count(s, curr) > mx)
                    {
                        c = s[i + 1];
                        mx = Count(s, curr);

                    }
                }
            }
            Console.WriteLine(c);
        }
    }
}
