using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ex9_1 {
    class NameCard {
        public int Age {
            get; set;
        }

        public string Name {
            get; set;
        }
    }

    class MainApp {
        static void Main( string[] args ) {
            NameCard MyCard = new NameCard();/*{
                Age = 24,
                Name = "상현"
            };*/    // 주석한거랑 밑에거 둘다 됨
            MyCard.Age = 24;
            MyCard.Name = "상현";

            WriteLine("나이 : {0}", MyCard.Age);
            WriteLine("이름 : {0}", MyCard.Name);
        }
    }
}