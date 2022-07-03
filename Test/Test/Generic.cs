using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Generic {
    class MyList<T> {
        private T[] array;

        public MyList() {
            array = new T[3];
        }

        public T this[int index] {
            get {
                return array[index];
            }
            set {
                if ( index >= array.Length ) {
                    Array.Resize<T>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Lenght {
            get { return array.Length; }
        }
    }

    class MainApp {
        static void Main(string[] args) {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mon";

            for (int i = 0; i < str_list.Lenght; ++i ) {
                WriteLine(str_list[i]);
            }
            WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            for(int i = 0; i < int_list.Lenght; ++i ) {
                WriteLine(int_list[i]);
            }
        }
    }
}
