using System;
using System.Collections.Generic;

namespace PrefixesArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public bool IsAcronym(IList<string> words, string s)
        {
            if (words.Count != s.Length) { return false; }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != words[i][0]) 
                {
                    return false;
                }
            }
            return true;
        }

        public static IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices) 
        {
            List<int> result = new List<int>();
            if (tomatoSlices % 2 != 0)
            {
                return result;
            }
            if (tomatoSlices >= cheeseSlices * 2 && tomatoSlices <= cheeseSlices * 4)
            {
                int total_jumbo = (tomatoSlices - 2 * cheeseSlices) / 2;
                int total_small = cheeseSlices - total_jumbo;
                result.Add(total_jumbo);
                result.Add(total_small);
                return result;
            }
            return result;
        }
    }
}
