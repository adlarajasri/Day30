using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySMJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a single-dimensional array
            int[] singleArray = new int[5];
            Console.WriteLine("Single-dimensional array:");
            for (int i = 0; i < singleArray.Length; i++)
            {
                singleArray[i] = i + 1;
                Console.Write(singleArray[i] + " ");
            }
            Console.WriteLine();

            // Creating a two-dimensional array
            int[,] multiArray = new int[3, 3];
            Console.WriteLine("Multidimensional array:");
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    multiArray[i, j] = i + j;
                    Console.Write(multiArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Creating a jagged array
            int[][] jaggedArray = new int[3][];
            Console.WriteLine("Jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i + j;
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
