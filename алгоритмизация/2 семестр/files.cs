using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class files
    {
        static bool isNumber(char s)
        {
            string numbers = "0123456789";
            return numbers.Contains(s);
        }
        static bool isGoodString(string s)
        {

            Queue<char> elements = new Queue<char>();
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) elements.Enqueue(charArray[i]);

            bool isGoodString = false;
            string currNumber = string.Empty;
            while (elements.Count != 0)
            {
                char currElement = elements.Dequeue();
                if (isNumber(currElement))
                {
                    currNumber += currElement;
                }

                else
                {
                    isGoodString = !(currNumber == string.Empty) && (Convert.ToInt16(currNumber[^1]) % 2 == 0);

                    currNumber = string.Empty;
                    if (isGoodString) return isGoodString;
                }
                
            }
            return !(currNumber == string.Empty) && (Convert.ToInt16(currNumber[^1]) % 2 == 0);
            

        }
        static void Main()
        {

            StreamReader reader = new StreamReader("test.txt");

            StreamWriter ansFile = new StreamWriter("ans.txt");

            string currS = null;

            while ((currS = reader.ReadLine()) != null)
            {
                Console.WriteLine(isGoodString(currS));
                if (isGoodString(currS)) ansFile.WriteLine(currS);
            }

            ansFile.Close();
        }
    }
}
