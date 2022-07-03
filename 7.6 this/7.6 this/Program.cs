using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7._6_this {
    class Employee {
        private string Name;
        private string Position;

        public void SetName(string Name) {
            this.Name = Name;
        }
        public string GetName() {
            return Name;
        }
        public void SetPosition(string Position) {
            this.Position = Position;
        }
        public string GetPosition() {
            return Position;
        }
    }
    class Program {
        static void Main(string[] args) {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            WriteLine("{0} {1}", pooh.GetName(), pooh.GetPosition());

            Employee tigger = new Employee();
            tigger.SetName("tigger");
            tigger.SetPosition("Cleaner");
            WriteLine("{0} {1}", tigger.GetName(), tigger.GetPosition());
        }
    }
}
