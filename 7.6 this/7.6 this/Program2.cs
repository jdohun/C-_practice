using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._6_this {
    class MyClass {
        int a, b, c;
        public MyClass() {
            this.a = 5425;
            WriteLine("MyClass()");
        }
        public MyClass(int b) : this() {
            this.b = b;
            WriteLine($"MyClass({b})");
        }
        public MyClass(int b, int c) : this(b) {
            this.c = c;
            WriteLine($"MyClass({b}, {c})");
        }

        public void PrintFields() {
            WriteLine("a:{0}, b:{1}, c:{2}", a, b, c);
        }
    }

    class Program2 {
        static void Main(string[] args) {
            MyClass a = new MyClass();
            a.PrintFields();
            WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}
