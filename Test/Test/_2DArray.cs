using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2DArray {
    class MainApp {
        static void Main(string[] args ) {
            int[,] arr = new int[2, 3]{ {1, 2, 3}, {4, 5, 6}};

            for(int i = 0; i < arr.GetLength(0); ++i) {
                for(int j = 0; j < arr.GetLength(1); ++j) {
                    Write($"[{i}, {j}] : {arr[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();

            int[,] arr2 = new int[,]{ {1, 2, 3}, {4, 5, 6}};
            
            for (int i = 0; i < arr2.GetLength(0); ++i) {
                for (int j = 0; j < arr2.GetLength(1); ++j) {
                    Write($"[{i}, {j}] : {arr2[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();
            
            int[,] arr3 = { {1, 2, 3}, {4, 5, 6}};

            for (int i = 0; i < arr3.GetLength(0); ++i) {
                for (int j = 0; j < arr3.GetLength(1); ++j) {
                    Write($"[{i}, {j}] : {arr3[i, j]} ");
                }
                WriteLine();
            }
            WriteLine();
        }
    }
}
