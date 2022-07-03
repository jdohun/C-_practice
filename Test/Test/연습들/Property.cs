﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Property {

    class BirthdayInfo {
        private string name;
        private DateTime birthday;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        public DateTime Birthday {
            get {
                return birthday;
            }
            set {
                birthday = value;
            }
        }

        public int Age {
            get {
                return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
            }
        }
    }

    class MainApp {
        static void Main(string[] args ) {
            BirthdayInfo birth = new BirthdayInfo();
            birth.Name = "서현";
            birth.Birthday = new DateTime(1997, 6, 28);

            WriteLine($"Name: {birth.Name}");
            WriteLine($"Birthday: {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age: {birth.Age}");
        }
    }
}
