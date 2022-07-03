using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MainApp {
    class _10_2 {
        static public int[,] MuxArr( int[,] arr1, int[,] arr2 ) {
            int[,] arr = new int[2, 2]{ { 0,0 }, { 0,0} };
            arr[0, 0] = arr1[0, 0] * arr2[0, 0] + arr1[0, 1] * arr2[1, 0];
            arr[0, 1] = arr1[0, 0] * arr2[0, 1] + arr1[0, 1] * arr2[1, 1];
            arr[1, 0] = arr1[1, 0] * arr2[0, 0] + arr1[1, 1] * arr2[1, 0];
            arr[1, 1] = arr1[1, 0] * arr2[0, 1] + arr1[1, 1] * arr2[1, 1];

            return arr;
        }

        static void Main( string[] args ) {
            int[,] arr1 = new int[2, 2]{ { 3, 2 }, { 1, 4 } };
            int[,] arr2 = new int[2, 2]{ { 9, 2 }, { 1, 7 } };

            int[,] arr = MuxArr(arr1, arr2);

            for (int i = 0; i < arr.GetLength(0); ++i ) {
                for ( int j = 0; j < arr.GetLength(1); ++j ) {
                    Write($"{arr[i, j]} ");
                }
                WriteLine();
            }
        }
    }
}
