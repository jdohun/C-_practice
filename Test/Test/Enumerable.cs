using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace Enumerable {
    class MyList : IEnumerable, IEnumerator {
        private int[] array;
        int position = -1;

        public MyList() {
            array = new int[3];
        }

        public int this[int index] {
            get { return array[index]; }
            set {
                if(index >= array.Length ) {
                    Array.Resize<int>(ref array, index + 1);
                    WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        // IEnumerator 멤버
        public object Current { // 현재 위치 반환하도록 오버라이딩
            get { return array[position]; }
        }

        // IEnumerator 멤버
        public bool MoveNext() { // 다음 위치로 이동
            if ( position == array.Length - 1 ) {
                Reset();
                return false;
            }

            position++;
            return ( position < array.Length );
        }

        // IEnumerator 멤버
        public void Reset() {
            position = -1;
        }

        // IEnumerable 멤버
        public IEnumerator GetEnumerator() {
            return this;
        }
    }
    class MainApp {
        static void Main(string[] args ) {
            MyList list = new MyList();
            for (int i = 0; i < 5; ++i ) {
                list[i] = i;
            }

            foreach(int e in list ) {
                WriteLine(e);
            }
        }
    }
}
