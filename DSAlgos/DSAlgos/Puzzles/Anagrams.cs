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
            Permute("abcd", "");
        }

        void Permute(string toPermute, string permuted)
        {
            if (toPermute.Length <= 1)
            {
                Console.WriteLine(permuted + toPermute);                
            }
            else
            {
                foreach (var charcter in toPermute.ToCharArray())
                {
                    Permute(toPermute.Replace(charcter.ToString(), string.Empty), permuted + charcter.ToString());
                }
            }
        }
    }
}
