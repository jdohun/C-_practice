using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex9_2 {
    class MainApp {
        static void Main(string[] args ) {
            var NameCard = new { Name = "박상현", Age = 17};
            WriteLine("이름: {0}, 나이: {1}", NameCard.Name, NameCard.Age);

            var Complex = new { Real= 3, Imaginary = -12};
            WriteLine("Real: {0}, Imaginary: {1}", Complex.Real, Complex.Imaginary);

        }
    }
}
