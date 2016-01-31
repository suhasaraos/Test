using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Puzzles
{
    /// <summary>
    /// Given a string s generates all permutations - permutations of abc = abc, acb, bac, bca, cab, cba
    /// </summary>
    public class Anagrams
    {
        public void Run()
        {
            Permute("abcd");
        }

        string Permute(string s)
        {
            foreach(var charcter in s.ToCharArray())
            {
                return charcter + Permute(s.Replace(charcter.ToString(), ""));
            }

            return "";
        }

    }
}
