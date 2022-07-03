using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;

namespace Yeild {
    class MyEnumerator {
        int [] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator() {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;
            yield return numbers[3];
        }
    }
    class MainApp {
        static void Main(string[] args ) {
            var obj = new MyEnumerator();
            foreach(int i in obj ) {
                WriteLine(i);
            }
        }
    }
}
