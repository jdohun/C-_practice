using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Test {
    struct ACSetting {
        public double currentInCelsius; // 현재 온도(도C)
        public double target; // 희망 온도

        public readonly double GetFahrenheit() {
            /*target = currentInCelsius * 1.8 + 32; // 화씨 계산 결과를 target에 저장;
            return target; // target 반환*/
            return currentInCelsius * 1.8 + 32;
        }
    }
    class Class1 {
        public static void Main(string[] args ) {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;
            WriteLine($"{acs.GetFahrenheit()}");
            WriteLine($"{acs.target}");
        }
    }
}
