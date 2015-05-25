using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCowsChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string yournum = "";
            while (yournum == "")
            {
                Console.WriteLine("Input your number");
                yournum = Console.ReadLine();
                if (!StrCheck(yournum)) { Console.WriteLine("Your number has same characters"); yournum = ""; };
            }
            string anothernum = "";
            while (anothernum != "x")
            {
                Console.WriteLine("Print another number or print x to exit");
                anothernum = Console.ReadLine();
                if (anothernum == "x") return;
                if (!StrCheck(anothernum)) { Console.WriteLine("Number has same characters"); }
                int bulls = 0;
                int cows = 0;
                StrCompare(yournum, anothernum, out bulls, out cows);
                Console.WriteLine("There are {0} bulls and {1} cows", bulls, cows);
            }
        }

        static void StrCompare(string str1, string str2, out int bulls, out int cows)
        {
            bulls = 0;
            cows = 0;
            if (str1.Length != str2.Length) return;
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        if (i == j) { bulls++; } else { cows++; }
                    }
                }
            }
        }

        static bool StrCheck(string str)
        {
            if (str.Length == 1) return true;
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && (i != j)) return false;
                }
            }
            return true;
        }
    }
}
