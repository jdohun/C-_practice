using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractClass {
    abstract class AbstarctBase {
        protected void ProtectedMethodA() {
            WriteLine("AbstractBase.PrivateMethod()A");
        }

        public void PubliceMethodA() {
            WriteLine("AbstractBase.PubliceMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    abstract class AbstarctBase2 : AbstarctBase {
        public abstract void AbstractMethodA2();
    }

    class Derived : AbstarctBase2 {
        public override void AbstractMethodA() {
            WriteLine("Derived.AbstractMethodA()");
            ProtectedMethodA();
        }

        public override void AbstractMethodA2() {
            WriteLine("Derived.AbstractMethodA2()");
        }
    }

    class MainApp {
        static void Main(string[] args ) {
            AbstarctBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PubliceMethodA();
        }
    }
}
