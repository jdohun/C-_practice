using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test {
    class MainApp {
        private static double GetDiscountRate(Object client ) {
            switch (client) {
                case ("학생", int n) when n < 18:
                    return 0.2; // 학생 & 18세 미만
                case ("학생", _):
                    return 0.1; // 학생 & 18세 이상
                case ("일반", int n) when n < 18:
                    return 0.1; // 일반 & 18세 미만
                case ("일반", _):
                    return 0.05; // 일반 & 18세 이상
                default:
                    return 0;
            }

            /*return client switch {
                ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만
                ("학생", _) => 0.1, // 학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만
                ("일반", _) => 0.05, // 일반 & 18세 이상
                _ => 0,
            };*/
        }
        static void Main(string[] args) {
           WriteLine(GetDiscountRate(("", 7)));
        }
    }
}
