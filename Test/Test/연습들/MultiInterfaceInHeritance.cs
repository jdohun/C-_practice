using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultiInterfaceInHeritance {
    interface IRunnable {
        void Run();
    }

    interface IFlyable {
        void Fly();
    }

    class Plane : IFlyable {
        public void Fly() {
            WriteLine("Fly!");
        }
    }

    class Car : IRunnable {
        public void Run() {
            WriteLine("Run!");
        }
    }


    class FlyingCar : IRunnable, IFlyable {
        public void Run() {
            WriteLine("Run!");
        }
        
        public void Fly() {
            WriteLine("Fly!");
        }
    }

    class MainApp {
        static void Main(string [] args) {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
