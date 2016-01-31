using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos.Puzzles
{
    public class ReduceWorkEquation
    {
        /// <summary>
        /// Print all positive integer solutions to the equation a^2 + b^2 = c^2 + d^2 where a,b,c,d are less than 100. Print only non-trivial solutions
        /// A solution is considered trivial if its in the form x^2 + y^2 = x^2 + y^2 (same values on left and right) or if its a permutation of another 
        /// equivalent solution ex: 30^2 + 100^2 =98^2 + 36^2 can be presented eight ways by just rearranging the elements, you should print only one 
        /// of those 
        /// </summary>
        public void Run()
        {
            //Logic: Instead of brute forcing over all variables of a,b,c,d which leads to O(n^4), we can bring it down to O(n^2)

            //Create a list of solutions and store it in a dictionary;

            var n = 100;
            Dictionary<int, Tuple<int, int>> results = new Dictionary<int, Tuple<int, int>>();

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<= n; j++)
                {
                    if(i != j)
                    {
                        var result = Convert.ToInt32(Math.Pow(i, 2) + Math.Pow(j, 2));

                        if (results.ContainsKey(result))
                        {
                            var prevRes = results[result];
                            if (prevRes.Item1 != j)
                            {
                                Console.WriteLine(string.Format("{0}^2 + {1}^2 = {2}^2 + {3}^2 ", prevRes.Item1, prevRes.Item2, i, j));
                            }
                        }
                        else
                        {
                            results.Add(result, new Tuple<int, int>(i, j));
                        }
                    }
                }
            }
            
        }
    }
}
