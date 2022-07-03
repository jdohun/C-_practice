using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1 {
    class 연습_문제_5_1 {
        static void Main(string[] args) {
            WriteLine("반복 횟수를 입력하세요: ");

            int repeat = int.Parse(ReadLine());
            if(repeat <= 0) {
                WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                return;
            }

            int i = 0;
            while (i < repeat) {
                int j = i;
                while ( j < repeat) {
                    Write("*");
                    ++j;
                }
                WriteLine();
                ++i;
            }

            /*for (int i = 0; i < 5; ++i) {
                for(int j = -1; j < i;++j) {
                    Write("*");
                }
                WriteLine();
            }*/
        }
    }
}
