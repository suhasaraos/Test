using DSAlgos.Algorithms;
using DSAlgos.Puzzles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Puzzles

            new TowersOfHanoi().Run();

            #endregion

            #region Algorithms

            new QuickSort().RunIteratively();

            #endregion  

            Console.ReadLine();
        }

    }
}
