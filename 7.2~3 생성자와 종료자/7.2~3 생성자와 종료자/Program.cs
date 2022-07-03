using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._2_3_생성자와_종료자 {

    class Cat {
        public string Name;         // 클래스 인스턴스 변수
        public string Color;
        public static int catCount = 0; // 클래스 공용 변수
        public Cat() { // 디폴트 생성자
            Name = "default";
            Color = "default";
            ++catCount;
        }
        ~Cat() { // 종료자 == 소멸자, 가비지 컬렉터가 처리시에 호출함
            WriteLine("잘가");
        }

        public Cat(string _Name, string _Color) { // 생성자 오버로딩
            Name = _Name;
            Color = _Color;
            ++catCount;
        }

        public void Meow() { // 메서드
            WriteLine("{0} : 야옹", Name);
        }

        public static void PrintCount() { // 공용 메서드
            WriteLine("{0}", catCount);
        }
    }

    class Program {
        static void Main(string[] args) {
            Cat kitty = new Cat("nabi", "Brown");
            kitty.Meow();
            kitty.Name = "KITTY";
            kitty.Color = "White";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Name = "NERO";
            nero.Color = "Black";
            //nero.Meow();
            //WriteLine("{0}", Cat.catCount);
            Cat.PrintCount();
        }
    }
}
