using System.Collections.Generic;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        ///1-misol
        public static string ReturnLastFourWord(string word)
        {
        
            word = word.Substring((word.Length - 1) - 3);
            return word;
        }
        ///2-misol
        public static int OddCounter(List<int> number)
        {
            var counter = 0;
            foreach (var item in number)
            {
                while (item / 2 != 0)
                {
                    counter++;
                }
            }
            return counter;


        }
        ///3-misol
        public static bool EndWith_g_10(string text)
        {
            if (text.EndsWith("g_10"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ///4-misol
        public static bool LengthGreaterThanThree(List<string> text)
        {
            var check = false;
            foreach (string lists in text)
            {
                if (text.Count > 3)
                {
                    check = true;
                }
                else
                {
                    return false;
                }
            }
            return check;

        }

    }
}
