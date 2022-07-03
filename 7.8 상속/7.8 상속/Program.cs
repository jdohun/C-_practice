using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._8_상속 {
    class Base {
        protected String Name;
        public Base(string Name) {
            this.Name = Name;
            WriteLine("{0}.Base()", this.Name);
        }

        ~Base() {
            WriteLine("{0}.~Base()", this.Name);
        }

        public void BaseMethod() {
            WriteLine("{0}.BaseMethod", Name);
        }
    }

    class Derived : Base {
        public Derived(String Name) : base(Name) {
            WriteLine("{0}.Derived()", this.Name);
        }

        ~Derived() {
            WriteLine("{0}.~Derived()", this.Name);
        }
        public void DerivedMethod() {
            WriteLine("{0}.Derived", Name);
        }
    }
    class Program {
        static void Main(string[] args) {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
