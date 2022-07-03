using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class 메소드_오버로딩_vs_선택적_매개변수 {
        static void MyMethod( string arg0 = "", string arg1 = "" ) {
            Console.WriteLine("A");
        }
        static void MyMethod() {
            Console.WriteLine("B");
        }

        static void Main(string []args) {
            MyMethod();
        }
    }
}
