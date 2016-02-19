using DSAlgos.Algorithms;
using DSAlgos.DataStructures;
using DSAlgos.Puzzles;
using System;

namespace DSAlgos
{
    class Program
    {



        // Define other methods and classes here



        static void Main(string[] args)
        {
            DemoPuzzles();

            //DemoAlgorithms();

            //DemoDataStructures();

            Console.ReadLine();
        }

        #region Puzzles
        static void DemoPuzzles()
        {
            //new TowersOfHanoi().Run();

            //new Anagrams().Run();

            //new ReduceWorkEquation().Run();

            //new CreateBSTUsingSortedArray().Run();

            //new CheckTreeIsBalanced().Run();
            //new RotatedArray().Run();

            new MergeSort().Run();
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
            //new Tree().Run();

            //new LinkedList().Run();

            new GraphDemo().Run();
        }

        #endregion


    }
}
