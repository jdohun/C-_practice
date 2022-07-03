using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._9_기반__파생_클래스_사이의_형식_변환 {
    class Mammal {
        public string name;

        public Mammal() {
            WriteLine("Mammal void Constructor");
        }

        public Mammal(string name) {
            this.name = name;
            WriteLine("Mammal string Constructor");
        }

        public void Nurse() {
            WriteLine("Nurse()");
        }
    }
    class Dog : Mammal {
        public Dog() {
            name = "default";
            WriteLine("Dog void Constructor");
        }
        public Dog(string name):base(name) { //base에서 name을 받는 생성자를 명시하지 않으면 void 즉, 디폴트 생성자가 호출됨
            this.name = name;
            WriteLine("Dog string Constructor");
        }

        public void Bark() {
            WriteLine("BarK()");
        }
    }
    class Cat : Mammal {
        public void Meow() {
            WriteLine("Meow()");
        }
    }

    class Program {
        static void Main(string[] args) {
            /*Mammal mammal = new Mammal();
            mammal.Nurse();*/

            //Mammal dog = new Dog("happy");
            //dog.bark(); // Mammal 클래스에는 Bark 메소드가 없기 때문에 사용불가
            //dog.Nurse();

            Mammal mammal = new Dog("happy");
            Dog dog;
            if (mammal is Dog) { // Dog 일 경우에만
                dog = (Dog)mammal; // 형변환
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;  // Cat이면 형변환 아니면 null
            if (cat != null) {
                cat.Meow();
            }
            Cat cat2 = mammal as Cat;
            if (cat2 != null) {
                cat2.Meow();
            }
            else {
                WriteLine("cat2 is not a cat");
            }
        }
    }
}
