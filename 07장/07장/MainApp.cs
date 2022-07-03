using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DeepCopy {
    class MyClass {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy() { // 클래스 MyClass 자료형을 반환하는 메서드
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;   // 새로 만든 객체 인스턴스 변수에 자기자신의 인스턴스 변수의 값 대입
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
    class MainApp {
        static void Main(string[] args) {
            WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;        // source가 참조하고 있는 곳을 같이 참조
                target.MyField2 = 30;           // 따라서 값이 공유됨

                WriteLine("{0} {1}", source.MyField1, source.MyField2);
                WriteLine("{0} {1}", target.MyField1, target.MyField2);
            }

            WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy(); // source가 참조하고 있는 곳의 값 자체를 복사함
                target.MyField2 = 30;               // 따라서 값이 다름

                WriteLine("{0} {1}", source.MyField1, source.MyField2);
                WriteLine("{0} {1}", target.MyField1, target.MyField2);
            }
        }
    }
}
