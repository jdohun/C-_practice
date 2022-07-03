using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MoreOnArray {
    class MainApp {
        private static bool CheckPassed( int score ) {
            return score >= 60;
        }
        private static void Print(int value ) {
            Write($"{value} ");
        }
        static void Main(string[] args) {
            int[] scores = new int[]{80, 74, 81 ,90, 34};

            foreach (int score in scores) {
                Write($"{score} ");
            }
            WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            WriteLine($"Number of dimensions : {scores.Rank}");

            WriteLine($"Binary Search : 81 is at " +
                $"{Array.BinarySearch<int>(scores, 81)}");

            WriteLine($"Linear Search : 90 is at " +
                $"{Array.IndexOf<int>(scores, 90)}");

            WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            WriteLine($"Everyone passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            WriteLine("Old length of scores : " +
                $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);
            WriteLine($"New length of socres : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));
            WriteLine();
        }
    }
}
