using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConstraintsOnTypeParameters {
    interface ITest {
        public void WhoamI();
    }
    class StructArray<T> where T : struct {
        public T[] Array { get; set; }
        public StructArray(int size ) {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class {
        public T[] Array { get; set; }
        public RefArray( int size ) {
            Array = new T[size];
        }
    }

    class Base {
        private static int totalNum = 0;
        private int privNum;
        public Base() {
            privNum = ++totalNum;
        }

        public void showNum() {
            WriteLine(privNum);
        }
    }
    class Derived : Base { 

    }
    class BaseArray<U> where U : Base {
        public U[] Array { get; set; }
        public BaseArray(int size ) {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U {
            Source.CopyTo(Array, 0);
        }
    }

    class Test : ITest {
        private static int totalNum = 0;
        private int privNum;

        public Test() {
            privNum = ++totalNum;
        }

        public void WhoamI() {
            WriteLine($"I am {privNum}");
        }
    }

    class InnerInterfaceArray<T> where T : ITest {
        public T[] Array { get; set; }
        public InnerInterfaceArray(int size ) {
            Array = new T[size];
        }
    }

    class MainApp {
        public static T CreateInstance<T>() where T : new() {
            return new T();
        }
        static void Main( string[] args ) {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            foreach(int element in a.Array ) {
                WriteLine(element);
            }
            WriteLine();

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            foreach ( StructArray<double> element in b.Array ) {
                WriteLine(element.Array.Length);
            }
            WriteLine();

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            foreach ( Base element in c.Array ) {
                element.showNum();
            }
            WriteLine();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            // d.Array[0] = new Base(); // Base 형식은 여기에 할당할 수 없다.
            d.Array[0] = new Derived();
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();
            
            foreach ( Derived element in d.Array ) {
                element.showNum();
            }
            WriteLine();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
            
            foreach ( Derived element in e.Array ) {
                element.showNum();
            }
            WriteLine();

            InnerInterfaceArray<Test> f = new InnerInterfaceArray<Test>(3);
            f.Array[0] = new Test();
            f.Array[1] = CreateInstance<Test>();
            f.Array[2] = CreateInstance<Test>();

            foreach(ITest element in f.Array ) {
                element.WhoamI();
            }
        }
    }
}