using DSAlgos.Algorithms;
using DSAlgos.DataStructures;
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
            //DemoPuzzles();

            //DemoAlgorithms();

            DemoDataStructures();

            Console.ReadLine();
        }

        #region Puzzles
        static void DemoPuzzles()
        {
            new TowersOfHanoi().Run();

            new Anagrams().Run();

            new ReduceWorkEquation().Run();
        }
        #endregion


        #region Algorithms
        static void DemoAlgorithms()
        {
            new InsertionSort().Run();
        }

        #endregion

        #region DataStructures
        static void DemoDataStructures()
        {
            new Tree().Run();
        }

        #endregion


    }
}
