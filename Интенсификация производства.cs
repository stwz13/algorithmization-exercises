
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Интенсификация_производства
    {
        static ulong allDays(string s)
        {
            ulong allDays = 0;
            string[] strings = s.Split('.');
            allDays += Convert.ToUInt16(strings[0]);
            ulong month = Convert.ToUInt16(strings[1]);
            ulong year = Convert.ToUInt16(strings[2]);
            allDays += 365 * (year - 1) + ((year - 1) / 4);

            if (year % 4 == 0) allDays++;
            switch (month)
            {
                case 1: allDays += 0; break;
                case 2: allDays += 31; break;
                case 3: allDays += 59; break;
                case 4: allDays += 90; break;
                case 5: allDays += 120; break;
                case 6: allDays += 151; break;
                case 7: allDays += 181; break;
                case 8: allDays += 212; break;
                case 9: allDays += 243; break;
                case 10: allDays += 273; break;
                case 11: allDays += 304; break;
                case 12: allDays += 334; break;
            }


            return allDays;

        }

        static void Main(string[] args)
        {


            string data1 = Console.ReadLine();
            string data2 = Console.ReadLine();
            ulong begin = Convert.ToUInt16((Console.ReadLine()));
            ulong workDays = allDays(data2) - allDays(data1) + 1;
            ulong result = ((2 * begin + workDays - 1) * workDays) / 2;
            Console.WriteLine(result);

        }
    }
}