using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex6_1 {
    class MainApp {
        static double Square( double arg ) {
            return arg * arg;
        }
        static void Main( string[] args ) {
            WriteLine("수를 입력하세요: ");
            string input = ReadLine();
            double arg = Convert.ToDouble(input);

            WriteLine("결과 : {0}", Square(arg));
        }
    }
}
