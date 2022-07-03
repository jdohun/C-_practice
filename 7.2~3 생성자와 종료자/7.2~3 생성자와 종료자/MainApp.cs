using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._2_3_생성자와_종료자 {

    class Global {
        public static int globalCount = 0; // 글로벌 클래스 공용 변수
    }

    class ClassA {
        public ClassA() {
            ++Global.globalCount; // 다른 클래스 생성자 호출시 글로벌 클래스 생성
        }
    }

    class ClassB {
        public ClassB() { // 다른 클래스 생성자 호출시 글로벌 클래스 생성
            ++Global.globalCount;
        }
    }

    class MainApp {
        static void Main(string[] args) {
            ClassA a = new ClassA();
            ClassA b = new ClassA();
            ClassB c = new ClassB();
            ClassB d = new ClassB();    // 클래스 ClassB의 객체 instance를 힙 영역에 생성하고, 그 참조형 변수로 d에 주소를 저장
                                        // 클래스 ClassB를 자료형으로 가지는 참조형 변수 d
            WriteLine("{0}", Global.globalCount);
        }
    }
}
