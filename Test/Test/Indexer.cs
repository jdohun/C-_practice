using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Indexer {
    class MyList {
        private int[] array;

        public MyList() {
            array = new int[3];
        }

        public int this[int index] {
            get { return array[index]; }
            set {
                if(index >= array.Length) {
                    Array.Resize<int>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length {
            get { return array.Length; }
        }
    }

    class MainApp {
        static void Main(string[] args ) {
            MyList list = new MyList();
            for(int i = 0; i < 5; ++i) {
                list[i] = i;
            }

            for(int i = 0; i < list.Length; ++i) {
                WriteLine(list[i]);
            }
        }
    }
}
