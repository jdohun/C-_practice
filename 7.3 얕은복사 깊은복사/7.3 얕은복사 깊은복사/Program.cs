using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._3_얕은복사_깊은복사 {
    class MyClass {
        
        public int num1, num2;
        private static int count = 0;   // 정적변수, 클래스 변수

        public MyClass() {
            ++count;
        }

        public MyClass(int x, int y) {
            num1 = x;
            num2 = y;
            ++count;
        }
        public void PrintMyClass() {
            WriteLine("{0}, {1}", num1, num2);
        }
        public static void PrintCount() {
            WriteLine("{0}", count);
        }

        public MyClass DeepCopy() {
            return new MyClass(num1, num2); // 생성자 오버로딩을 이용한 같은 값 새로운 객체 생성
        }
        public void DeepCopy(MyClass dest) {
            dest = new MyClass(num1, num2);
        }
    }

    class Program {
        static void Main(string[] args) {
            MyClass source;
            MyClass.PrintCount();
            source = new MyClass(10, 20);
            source.PrintMyClass();
            MyClass.PrintCount();

            /* MyClass target = source; // 얕은 복사
             target.PrintMyClass();
             target.num1 = 100;
             target.PrintMyClass();
             source.PrintMyClass();  // 얕은 복사로 인해서 값이 같이 변함
             MyClass.PrintCount();*/


            MyClass target = source.DeepCopy(); // 깊은 복사
            target.PrintMyClass();
            target.num1 = 100;
            target.PrintMyClass();
            source.PrintMyClass();  // 깊은 복사로 인해서 값이 유지
            MyClass.PrintCount();

            source.DeepCopy(target);
        }
    }
}
