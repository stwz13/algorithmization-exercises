using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class задача
    {
        static void Main(string[] args)
        {
            //Определить наибольшую длину подпоследовательности из символов abc (подпоследовательность может быть неполной и оканчиваться на a или ab)
            var s = Console.ReadLine();
            s = s.Replace("abc", "*") + "  ";
            int mx = 0;
            int curr = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    curr += 3;
                    if (s[i + 1] == 'a')
                    {
                        if (s[i + 2] == 'b') curr += 2;
                        else curr++;
                    }
                    mx = Math.Max(curr, mx);
                }
                else curr = 0;
            }
            Console.WriteLine(mx);
        }
    }
}
